Imports System
Imports System.IO
Imports System.Text
Imports System.Threading

Public Class RuntimeEngine
    Const ParityEven As Byte = 101  ' 'e'
    Const ParityOdd As Byte = 111   ' 'o'
    Const ParityNone As Byte = 110  ' 'n'

    Dim thisServerInfo As ThreadComm
    Dim thisAddressTextbox As TextBox
    Dim thisValueTextbox As TextBox
    Dim thisLoopDelayTextbox As TextBox
    Dim thisLoopingCheckbox As CheckBox
    Dim thisButton As Button
    Dim thisResultRichTextbox As RichTextBox
    Dim thisSlaveID As String
    Dim thisComPort As String
    Dim thisDataReturned As TextBox
    Dim mbClass As New ModbusXfce

    Dim thisStatus As String

    Public Sub New(ByRef ServerInfo As ThreadComm, ByRef AddressTextbox As TextBox, ByRef ValueTextbox As TextBox, ByRef LoopDelayTextbox As TextBox, _
                   ByRef LoopingCheckbox As CheckBox, ByRef GetButton As Button, ByVal ResultRichTextbox As RichTextBox, ByRef modbus As Object, ByRef DataReturned As TextBox)
        thisServerInfo = ServerInfo
        thisAddressTextbox = AddressTextbox
        thisValueTextbox = ValueTextbox
        thisLoopDelayTextbox = LoopDelayTextbox
        thisLoopingCheckbox = LoopingCheckbox
        thisButton = GetButton                      'Determins if we are getting or setting a Word, DWord, or Float.
        thisResultRichTextbox = ResultRichTextbox
        mbClass = modbus
        thisDataReturned = DataReturned
    End Sub

    Delegate Sub UpdateRichTextBoxCallBack()
    Private Sub UpdateRichTextBox()
        If thisResultRichTextbox.InvokeRequired Then
            thisResultRichTextbox.Invoke(New UpdateRichTextBoxCallBack(AddressOf UpdateRichTextBox))
        Else
            thisResultRichTextbox.Text = thisResultRichTextbox.Text & thisStatus & vbNewLine
            thisResultRichTextbox.SelectionStart = thisResultRichTextbox.TextLength
            thisResultRichTextbox.ScrollToCaret()
            thisResultRichTextbox.Refresh()
        End If
    End Sub
    Delegate Sub UpdateDataReturnedCallBack()
    Private Sub UpdateDataReturned()
        If thisDataReturned.InvokeRequired Then
            thisDataReturned.Invoke(New UpdateDataReturnedCallBack(AddressOf UpdateDataReturned))
        Else
            thisDataReturned.Text = thisStatus
            thisResultRichTextbox.Refresh()
        End If
    End Sub

    Sub ProcessThread()
        Dim thread As Thread = thread.CurrentThread

        Dim loopCount As Integer = 0
        Dim errorCount As Integer = 0
        'Top of the main process loop
TOP:
        If thisServerInfo.ExitCommand = 1 Then
            GoTo DONE
        End If

        Select Case thisButton.Text
            Case "Get Word"
                Dim Address As UInteger
                Dim MBValue As UShort
                Dim retval As Integer
                Dim i As Integer = 0

                Try
                    Address = CUInt(thisAddressTextbox.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    GoTo DONE
                End Try

                retval = mbClass.GetWord(Address, MBValue)
                If 0 = retval Then
                    thisStatus = MBValue.ToString() & " (0x" & Hex(MBValue) & ")"
                    UpdateDataReturned()
                Else
                    errorCount += 1
                    thisStatus = "GetWord Failed (" & retval.ToString() & ") LoopCount: " & loopCount & " ErrorCount: " & errorCount
                    UpdateRichTextBox()
                    UpdateDataReturned()
                End If

            Case "Set Word"
                Dim Address As UInteger
                Dim MBValue As UShort
                Dim retval As Integer
                Try
                    Address = CUInt(thisAddressTextbox.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    GoTo DONE
                End Try

                MBValue = CUShort(thisValueTextbox.Text)
                retval = mbClass.SetWord(Address, MBValue)
                If 0 <> retval Then
                    errorCount += 1
                    thisStatus = "SetWord Failed (" & retval.ToString() & ")"
                    UpdateRichTextBox()
                    UpdateDataReturned()
                Else
                    thisStatus = "SetWord Success: " & Address & " = " & MBValue.ToString()
                    UpdateDataReturned()
                End If

            Case "Get Dword"
                Dim Address As UInteger
                Dim MBValue As UInteger
                Dim retval As Integer
                Dim i As Integer = 0

                Try
                    Address = CUInt(thisAddressTextbox.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    GoTo DONE
                End Try

                retval = mbClass.GetDword(Address, MBValue)
                If 0 = retval Then
                    thisStatus = MBValue.ToString() & " (0x" & Hex(MBValue) & ")"
                    UpdateDataReturned()
                Else
                    errorCount += 1
                    thisStatus = "GetDWord Failed (" & retval.ToString() & ") LoopCount: " & loopCount & " ErrorCount: " & errorCount
                    UpdateRichTextBox()
                    UpdateDataReturned()
                End If

            Case "Set Dword"
                Dim Address As UInteger
                Dim MBValue As UInteger
                Dim retval As Integer

                Try
                    Address = CUInt(thisAddressTextbox.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    GoTo DONE
                End Try

                MBValue = CUInt(thisValueTextbox.Text)
                retval = mbClass.SetDword(Address, MBValue)
                If 0 <> retval Then
                    errorCount += 1
                    thisStatus = "SetWord Failed (" & retval.ToString() & ")"
                    UpdateRichTextBox()
                    UpdateDataReturned()
                Else
                    thisStatus = "SetWord Success: " & Address & " = " & MBValue.ToString()
                    UpdateDataReturned()
                End If

            Case "Get Float"
                Dim Address As UInteger
                Dim MBValue As Single
                Dim retval As Integer

                Try
                    Address = CUInt(thisAddressTextbox.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    GoTo DONE
                End Try

                retval = mbClass.GetFloat(Address, MBValue)
                If 0 = retval Then
                    thisStatus = MBValue.ToString() & " (0x" & Hex(MBValue) & ")"
                    UpdateDataReturned()
                Else
                    errorCount += 1
                    thisStatus = "GetFloat Failed (" & retval.ToString() & ") LoopCount: " & loopCount & " ErrorCount: " & errorCount
                    UpdateRichTextBox()
                    UpdateDataReturned()
                End If

            Case "Set Float"
                Dim Address As UInteger
                Dim MBValue As Single
                Dim retval As Integer

                Try
                    Address = CUInt(thisAddressTextbox.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    GoTo DONE
                End Try

                MBValue = CSng(thisValueTextbox.Text)
                retval = mbClass.SetSingle(Address, MBValue)
                If 0 = retval Then
                    thisStatus = "SetFloat Success: " & Address & " = " & MBValue.ToString()
                    UpdateDataReturned()
                Else
                    errorCount += 1
                    thisStatus = "SetFloat Failed (" & retval.ToString() & ")"
                    UpdateRichTextBox()
                    UpdateDataReturned()
                End If

        End Select

        If thisLoopingCheckbox.Checked = False Then
            GoTo DONE
        Else
            Try
                thread.Sleep(CInt(thisLoopDelayTextbox.Text))
            Catch ex As Exception
                'thread.Sleep(1)
            End Try
            loopCount += 1
            GoTo TOP
        End If
DONE:
    End Sub

End Class