Imports System.Threading

Public Class Form1
    Public Const MAX_THREADS As Integer = 3

    'Public ServerList(MAX_THREADS - 1) As String
    Public AddressArray() As TextBox
    Public ValueArray() As TextBox
    Public LoopDelayArray() As TextBox
    Public LoopingArray() As CheckBox
    Public GetButtons() As Button
    Public SetButtons() As Button
    Public KillButtons() As Button
    Public Results() As RichTextBox
    Public DataReturnedArray() As TextBox
    Public ServerExitCommand() As Integer = {0, 0, 0}  'Needs to have the same number as the MAX_THREADS.
    Public ActiveThreadNumber As Integer = -1
    Public ServerThreads(MAX_THREADS) As ThreadComm

    Dim clsThreads As New List(Of Thread)
	Dim LastThreadNumber As Integer = 0

    REM This is the main class used for this purpose
    Dim mbClass As New ModbusXfce()
    Const ParityEven As Byte = 101  ' 'e'
    Const ParityOdd As Byte = 111   ' 'o'
    Const ParityNone As Byte = 110  ' 'n'

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ConnectionStatus.Text = "Not Connected"

        AddressArray = New TextBox() {WordAddress, DwordAddress, FloatAddress}
        ValueArray = New TextBox() {WordValue, DwordValue, FloatValue}
        LoopDelayArray = New TextBox() {WordLoopDelay_TB, DWordLoopDelay, FloatLoopDelay}
        LoopingArray = New CheckBox() {WordLoop_CkB, DWordLoop_CB, FloatLoop_CB}
        GetButtons = New Button() {GetWordButton, GetDWordButton, GetFloatButton}
        SetButtons = New Button() {SetWordButton, SetDWordButton, SetFloatButton}
        KillButtons = New Button() {WordKill_B, DWordkill_B, FloatKill_B}
        DataReturnedArray = New TextBox() {WordReturned_TB, DWordReturned_TB, FloatReturned_TB}

        'Initialize the server array
        For i = 0 To MAX_THREADS - 1
            ServerThreads(i) = New ThreadComm
            ServerThreads(i).ExitCommand = 0
            ServerThreads(i).ServerName = ""
            ServerThreads(i).ThreadNumber = -1
            KillButtons(i).Enabled = False
        Next
    End Sub

    Private Sub WordKill_B_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WordKill_B.Click
        KillServer(0)
    End Sub

    Private Sub DWordKill_B_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DWordkill_B.Click
        KillServer(1)
    End Sub

    Private Sub Floatkill_B_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FloatKill_B.Click
        KillServer(2)
    End Sub

    Private Sub ConnectButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ConnectButton.Click
        mbClass.EnableLogging("c:\temp\mbclient.txt")           REM this should be disabled when happy
        mbClass.EnableMessageLogging()

        'attached to the 205 needs to be set to 3 or Byte and Word Swapping
        'attached to the ETS Slave port needs to be set to 2 or Word Swapping
        '1 => Byte Swaping
        '2 => Word Swaping

        Dim swapflag As Integer = 0

        If SwapBytes.Checked = True Then
            swapflag = swapflag Or ModbusXfce.SwapByteFlag
        End If

        If SwapWords.Checked = True Then
            swapflag = swapflag Or ModbusXfce.SwapWordFlag
        End If

        mbClass.SetSwapFlag(swapflag)

        If TCP_RB.Checked Then
            If (0 = mbClass.OpenTCP(IP_tb.Text, 502)) Then
                MsgBox("Could not connect: " + IP_tb.Text)
                ConnectionStatus.Text = "Not Connected"
                Return
            Else
                ConnectionStatus.Text = "TCP Connected"
            End If
        Else
            If SlaveId.Text.Length = 0 Then
                MsgBox("Please put in a Slave ID")
                Return
            End If
            Dim curItem As String = COMPortList.SelectedItem.ToString()
            Dim ComPort As Integer = CInt(Mid(curItem, 4))
            If (ComPort > 0) Then
                If (0 = mbClass.OpenRTU(CInt(SlaveId.Text), ComPort, 115200, 8, ParityNone, 1)) Then
                    MsgBox("Could not open Modbus/RTU port: " + curItem + "Slave Id: " + SlaveId.Text)
                    ConnectionStatus.Text = "Not Connected"
                    Return
                Else
                    ConnectionStatus.Text = "RTU Connected"
                End If
            End If
        End If

		DisconnectButton.Enabled = True
        TCP_RB.Enabled = False
        RTU_RB.Enabled = False
        COMPortList.Enabled = False
        SlaveId.Enabled = False
        IP_tb.Enabled = False
        SwapBytes.Enabled = False
        SwapWords.Enabled = False
        ConnectButton.Enabled = False
        GetWordButton.Enabled = True
        GetDWordButton.Enabled = True
        GetFloatButton.Enabled = True
        SetWordButton.Enabled = True
        SetDWordButton.Enabled = True
        SetFloatButton.Enabled = True
    End Sub

    Private Sub DisconnectButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisconnectButton.Click
        mbClass.CloseHandle()
        ConnectionStatus.Text = "Not Connected"

        TCP_RB.Enabled = True
        RTU_RB.Enabled = True
        COMPortList.Enabled = True
        SlaveId.Enabled = True
        IP_tb.Enabled = True
        SwapBytes.Enabled = True
        SwapWords.Enabled = True
        ConnectButton.Enabled = True
        GetWordButton.Enabled = False
        GetDWordButton.Enabled = False
        GetFloatButton.Enabled = False
        SetWordButton.Enabled = False
        SetDWordButton.Enabled = False
        SetFloatButton.Enabled = False
    End Sub

    Private Sub KillServer(ByVal ServerIndex As Integer)
        ServerThreads(ServerIndex).ExitCommand = 1
        KillButtons(ServerIndex).Enabled = False

        'Wait for the thread to really have seen it
        Threading.Thread.Sleep(3000)
        ServerThreads(ServerIndex).ServerName = ""
        ServerThreads(ServerIndex).ThreadNumber = -1
        GetButtons(ServerIndex).Enabled = True
        SetButtons(ServerIndex).Enabled = True
        'ServerList(ServerIndex) = ""
    End Sub

    Public Sub CreateThread(ByRef AddressName As String, ByRef ButtonClicked As Button, ByRef ServerNum As Integer)
        ServerThreads(ServerNum).ThreadNumber = 0
        ServerThreads(ServerNum).ExitCommand = 0
        ServerThreads(ServerNum).ServerName = AddressName
        Dim tws As New RuntimeEngine(ServerThreads(ServerNum), AddressArray(ServerNum), ValueArray(ServerNum), LoopDelayArray(ServerNum), _
                                     LoopingArray(ServerNum), ButtonClicked, Results_RTB, mbClass, DataReturnedArray(ServerNum))

        'If we are re-using an existing thread slot, don't add it again
        'If LastThreadNumber > MAX_THREADS - 1 Then
        'LastThreadNumber = 0
        'clsThreads(LastThreadNumber) = New Thread(New ThreadStart(AddressOf tws.ProcessThread))
        'Else
        'New thread slot, so add it
        clsThreads.Add(New Thread(New ThreadStart(AddressOf tws.ProcessThread)))
        'End If

        clsThreads(LastThreadNumber).Start()
        clsThreads(LastThreadNumber).Name = AddressName
        clsThreads(LastThreadNumber).IsBackground = True
        If LoopingArray(ServerNum).Checked = True Then
            KillButtons(ServerNum).Enabled = True
            GetButtons(ServerNum).Enabled = False
            SetButtons(ServerNum).Enabled = False
        End If
    End Sub

    Private Sub GetWordButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GetWordButton.Click
        If ConnectionStatus.Text = "Not Connected" Then
            MsgBox("Not Connected to a system")
            Return
        End If
        If WordAddress.Text.Length = 0 Then
            MsgBox("Please put in an address")
            Return
        End If

        If ActiveThreadNumber >= MAX_THREADS Then
            MsgBox("Cannot add more servers; at maximum")
            Return
        End If

        CreateThread(WordAddress.Text, GetWordButton, 0)
        LastThreadNumber += 1
    End Sub

    Private Sub GetDWordButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GetDWordButton.Click
        If ConnectionStatus.Text = "Not Connected" Then
            MsgBox("Not Connected to a system")
            Return
        End If
        If DwordAddress.Text.Length = 0 Then
            MsgBox("Please put in an address")
            Return
        End If

        If ActiveThreadNumber >= MAX_THREADS Then
            MsgBox("Cannot add more servers; at maximum")
            Return
        End If

        CreateThread(DwordAddress.Text, GetDWordButton, 1)
        LastThreadNumber += 1
    End Sub

    Private Sub GetFloatButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GetFloatButton.Click

        If ConnectionStatus.Text = "Not Connected" Then
            MsgBox("Not Connected to a system")
            Return
        End If
        If FloatAddress.Text.Length = 0 Then
            MsgBox("Please put in an address")
            Return
        End If

        If ActiveThreadNumber >= MAX_THREADS Then
            MsgBox("Cannot add more servers; at maximum")
            Return
        End If

        CreateThread(DwordAddress.Text, GetFloatButton, 2)
        LastThreadNumber += 1
    End Sub

    Private Sub SetWordButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetWordButton.Click
        If ConnectionStatus.Text = "Not Connected" Then
            MsgBox("Not Connected to a system")
            Return
        End If
        If WordAddress.Text.Length = 0 Then
            MsgBox("Please put in an Address")
            Return
        End If

        If WordValue.Text.Length = 0 Then
            MsgBox("Please put in a Value")
            Return
        End If

        If ActiveThreadNumber >= MAX_THREADS Then
            MsgBox("Cannot add more servers; at maximum")
            Return
        End If

        CreateThread(WordAddress.Text, SetWordButton, 0)
        LastThreadNumber += 1
    End Sub

    Private Sub SetDWordButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetDWordButton.Click
        If ConnectionStatus.Text = "Not Connected" Then
            MsgBox("Not Connected to a system")
            Return
        End If
        If DwordAddress.Text.Length = 0 Then
            MsgBox("Please put in an Address")
            Return
        End If

        If DwordValue.Text.Length = 0 Then
            MsgBox("Please put in a Value")
            Return
        End If

        If ActiveThreadNumber >= MAX_THREADS Then
            MsgBox("Cannot add more servers; at maximum")
            Return
        End If

        CreateThread(DwordAddress.Text, SetDWordButton, 1)
        LastThreadNumber += 1
    End Sub

    Private Sub SetFloatButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetFloatButton.Click
        If ConnectionStatus.Text = "Not Connected" Then
            MsgBox("Not Connected to a system")
            Return
        End If
        If FloatAddress.Text.Length = 0 Then
            MsgBox("Please put in an address")
            Return
        End If

        If ActiveThreadNumber >= MAX_THREADS Then
            MsgBox("Cannot add more servers; at maximum")
            Return
        End If

        CreateThread(DwordAddress.Text, SetFloatButton, 2)
        LastThreadNumber += 1
    End Sub

    Private Sub ClearResults_B_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClearResults_B.Click
        Results_RTB.Clear()
    End Sub
End Class

Public Class ThreadComm
    Public ExitCommand As Integer
    Public ServerName As String
    Public ThreadNumber As Integer
End Class