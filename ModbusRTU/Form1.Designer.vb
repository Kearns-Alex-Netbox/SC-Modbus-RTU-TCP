<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ConnectButton = New System.Windows.Forms.Button()
		Me.DisconnectButton = New System.Windows.Forms.Button()
		Me.GetWordButton = New System.Windows.Forms.Button()
		Me.WordAddress = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.WordValue = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.DwordAddress = New System.Windows.Forms.TextBox()
		Me.GetDWordButton = New System.Windows.Forms.Button()
		Me.DwordValue = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.ConnectionStatus = New System.Windows.Forms.TextBox()
		Me.COMPortList = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.FloatAddress = New System.Windows.Forms.TextBox()
		Me.GetFloatButton = New System.Windows.Forms.Button()
		Me.FloatValue = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.SwapWords = New System.Windows.Forms.CheckBox()
		Me.SwapBytes = New System.Windows.Forms.CheckBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.TCP_RB = New System.Windows.Forms.RadioButton()
		Me.RTU_RB = New System.Windows.Forms.RadioButton()
		Me.IP_tb = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.SlaveId = New System.Windows.Forms.TextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.SetWordButton = New System.Windows.Forms.Button()
		Me.SetDWordButton = New System.Windows.Forms.Button()
		Me.SetFloatButton = New System.Windows.Forms.Button()
		Me.WordLoop_CkB = New System.Windows.Forms.CheckBox()
		Me.DWordLoop_CB = New System.Windows.Forms.CheckBox()
		Me.FloatLoop_CB = New System.Windows.Forms.CheckBox()
		Me.WordLoopDelay_TB = New System.Windows.Forms.TextBox()
		Me.DWordLoopDelay = New System.Windows.Forms.TextBox()
		Me.FloatLoopDelay = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Results_RTB = New System.Windows.Forms.RichTextBox()
		Me.ClearResults_B = New System.Windows.Forms.Button()
		Me.WordKill_B = New System.Windows.Forms.Button()
		Me.WordReturned_TB = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.DWordkill_B = New System.Windows.Forms.Button()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.DWordReturned_TB = New System.Windows.Forms.TextBox()
		Me.FloatKill_B = New System.Windows.Forms.Button()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.FloatReturned_TB = New System.Windows.Forms.TextBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.GroupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'Label1
		'
		Me.Label1.AutoSize = true
		Me.Label1.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label1.Location = New System.Drawing.Point(23, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 14)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "COM Port"
		'
		'ConnectButton
		'
		Me.ConnectButton.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ConnectButton.Location = New System.Drawing.Point(26, 168)
		Me.ConnectButton.Name = "ConnectButton"
		Me.ConnectButton.Size = New System.Drawing.Size(78, 24)
		Me.ConnectButton.TabIndex = 3
		Me.ConnectButton.Text = "Connect"
		Me.ConnectButton.UseVisualStyleBackColor = true
		'
		'DisconnectButton
		'
		Me.DisconnectButton.Enabled = false
		Me.DisconnectButton.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.DisconnectButton.Location = New System.Drawing.Point(126, 168)
		Me.DisconnectButton.Name = "DisconnectButton"
		Me.DisconnectButton.Size = New System.Drawing.Size(78, 24)
		Me.DisconnectButton.TabIndex = 4
		Me.DisconnectButton.Text = "Disonnect"
		Me.DisconnectButton.UseVisualStyleBackColor = true
		'
		'GetWordButton
		'
		Me.GetWordButton.Enabled = false
		Me.GetWordButton.Location = New System.Drawing.Point(198, 296)
		Me.GetWordButton.Name = "GetWordButton"
		Me.GetWordButton.Size = New System.Drawing.Size(75, 23)
		Me.GetWordButton.TabIndex = 5
		Me.GetWordButton.Text = "Get Word"
		Me.GetWordButton.UseVisualStyleBackColor = true
		'
		'WordAddress
		'
		Me.WordAddress.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.WordAddress.Location = New System.Drawing.Point(142, 240)
		Me.WordAddress.Name = "WordAddress"
		Me.WordAddress.Size = New System.Drawing.Size(104, 22)
		Me.WordAddress.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label2.Location = New System.Drawing.Point(9, 242)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(115, 18)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Word Address"
		'
		'WordValue
		'
		Me.WordValue.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.WordValue.Location = New System.Drawing.Point(252, 240)
		Me.WordValue.Name = "WordValue"
		Me.WordValue.Size = New System.Drawing.Size(160, 22)
		Me.WordValue.TabIndex = 8
		'
		'Label3
		'
		Me.Label3.AutoSize = true
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label3.Location = New System.Drawing.Point(9, 341)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(127, 18)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "DWord Address"
		'
		'DwordAddress
		'
		Me.DwordAddress.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.DwordAddress.Location = New System.Drawing.Point(142, 339)
		Me.DwordAddress.Name = "DwordAddress"
		Me.DwordAddress.Size = New System.Drawing.Size(104, 22)
		Me.DwordAddress.TabIndex = 10
		'
		'GetDWordButton
		'
		Me.GetDWordButton.Enabled = false
		Me.GetDWordButton.Location = New System.Drawing.Point(198, 395)
		Me.GetDWordButton.Name = "GetDWordButton"
		Me.GetDWordButton.Size = New System.Drawing.Size(75, 23)
		Me.GetDWordButton.TabIndex = 11
		Me.GetDWordButton.Text = "Get Dword"
		Me.GetDWordButton.UseVisualStyleBackColor = true
		'
		'DwordValue
		'
		Me.DwordValue.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.DwordValue.Location = New System.Drawing.Point(252, 339)
		Me.DwordValue.Name = "DwordValue"
		Me.DwordValue.Size = New System.Drawing.Size(160, 22)
		Me.DwordValue.TabIndex = 12
		'
		'Label4
		'
		Me.Label4.AutoSize = true
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label4.Location = New System.Drawing.Point(282, 219)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(100, 18)
		Me.Label4.TabIndex = 13
		Me.Label4.Text = "Set Value(s)"
		'
		'Label5
		'
		Me.Label5.AutoSize = true
		Me.Label5.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label5.Location = New System.Drawing.Point(23, 123)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(49, 14)
		Me.Label5.TabIndex = 14
		Me.Label5.Text = "Status"
		'
		'ConnectionStatus
		'
		Me.ConnectionStatus.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ConnectionStatus.Location = New System.Drawing.Point(26, 140)
		Me.ConnectionStatus.Name = "ConnectionStatus"
		Me.ConnectionStatus.Size = New System.Drawing.Size(178, 22)
		Me.ConnectionStatus.TabIndex = 15
		'
		'COMPortList
		'
		Me.COMPortList.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.COMPortList.FormattingEnabled = true
		Me.COMPortList.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15"})
		Me.COMPortList.Location = New System.Drawing.Point(26, 32)
		Me.COMPortList.Name = "COMPortList"
		Me.COMPortList.Size = New System.Drawing.Size(81, 22)
		Me.COMPortList.TabIndex = 16
		'
		'Label6
		'
		Me.Label6.AutoSize = true
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label6.Location = New System.Drawing.Point(9, 440)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(112, 18)
		Me.Label6.TabIndex = 17
		Me.Label6.Text = "Float Address"
		'
		'FloatAddress
		'
		Me.FloatAddress.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FloatAddress.Location = New System.Drawing.Point(142, 438)
		Me.FloatAddress.Name = "FloatAddress"
		Me.FloatAddress.Size = New System.Drawing.Size(104, 22)
		Me.FloatAddress.TabIndex = 18
		'
		'GetFloatButton
		'
		Me.GetFloatButton.Enabled = false
		Me.GetFloatButton.Location = New System.Drawing.Point(198, 494)
		Me.GetFloatButton.Name = "GetFloatButton"
		Me.GetFloatButton.Size = New System.Drawing.Size(75, 23)
		Me.GetFloatButton.TabIndex = 19
		Me.GetFloatButton.Text = "Get Float"
		Me.GetFloatButton.UseVisualStyleBackColor = true
		'
		'FloatValue
		'
		Me.FloatValue.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FloatValue.Location = New System.Drawing.Point(252, 438)
		Me.FloatValue.Name = "FloatValue"
		Me.FloatValue.Size = New System.Drawing.Size(160, 22)
		Me.FloatValue.TabIndex = 20
		'
		'Label8
		'
		Me.Label8.AutoSize = true
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label8.Location = New System.Drawing.Point(160, 219)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(69, 18)
		Me.Label8.TabIndex = 25
		Me.Label8.Text = "Address"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.SwapWords)
		Me.GroupBox1.Controls.Add(Me.SwapBytes)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.TCP_RB)
		Me.GroupBox1.Controls.Add(Me.RTU_RB)
		Me.GroupBox1.Controls.Add(Me.IP_tb)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.SlaveId)
		Me.GroupBox1.Controls.Add(Me.COMPortList)
		Me.GroupBox1.Controls.Add(Me.ConnectionStatus)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.DisconnectButton)
		Me.GroupBox1.Controls.Add(Me.ConnectButton)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(510, 198)
		Me.GroupBox1.TabIndex = 27
		Me.GroupBox1.TabStop = false
		'
		'SwapWords
		'
		Me.SwapWords.AutoSize = true
		Me.SwapWords.Checked = true
		Me.SwapWords.CheckState = System.Windows.Forms.CheckState.Checked
		Me.SwapWords.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.SwapWords.Location = New System.Drawing.Point(108, 102)
		Me.SwapWords.Name = "SwapWords"
		Me.SwapWords.Size = New System.Drawing.Size(96, 18)
		Me.SwapWords.TabIndex = 55
		Me.SwapWords.Text = "Swap Words"
		Me.SwapWords.UseVisualStyleBackColor = true
		'
		'SwapBytes
		'
		Me.SwapBytes.AutoSize = true
		Me.SwapBytes.Checked = true
		Me.SwapBytes.CheckState = System.Windows.Forms.CheckState.Checked
		Me.SwapBytes.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.SwapBytes.Location = New System.Drawing.Point(6, 102)
		Me.SwapBytes.Name = "SwapBytes"
		Me.SwapBytes.Size = New System.Drawing.Size(96, 18)
		Me.SwapBytes.TabIndex = 54
		Me.SwapBytes.Text = "Swap Bytes"
		Me.SwapBytes.UseVisualStyleBackColor = true
		'
		'Label14
		'
		Me.Label14.AutoSize = true
		Me.Label14.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label14.Location = New System.Drawing.Point(365, 9)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(139, 182)
		Me.Label14.TabIndex = 51
		Me.Label14.Text = resources.GetString("Label14.Text")
		'
		'TCP_RB
		'
		Me.TCP_RB.AutoSize = true
		Me.TCP_RB.Location = New System.Drawing.Point(6, 79)
		Me.TCP_RB.Name = "TCP_RB"
		Me.TCP_RB.Size = New System.Drawing.Size(14, 13)
		Me.TCP_RB.TabIndex = 53
		Me.TCP_RB.UseVisualStyleBackColor = true
		'
		'RTU_RB
		'
		Me.RTU_RB.AutoSize = true
		Me.RTU_RB.Checked = true
		Me.RTU_RB.Location = New System.Drawing.Point(6, 37)
		Me.RTU_RB.Name = "RTU_RB"
		Me.RTU_RB.Size = New System.Drawing.Size(14, 13)
		Me.RTU_RB.TabIndex = 52
		Me.RTU_RB.TabStop = true
		Me.RTU_RB.UseVisualStyleBackColor = true
		'
		'IP_tb
		'
		Me.IP_tb.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.IP_tb.Location = New System.Drawing.Point(26, 74)
		Me.IP_tb.Name = "IP_tb"
		Me.IP_tb.Size = New System.Drawing.Size(178, 22)
		Me.IP_tb.TabIndex = 20
		Me.IP_tb.Text = "192.168.5."
		'
		'Label9
		'
		Me.Label9.AutoSize = true
		Me.Label9.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label9.Location = New System.Drawing.Point(110, 15)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(63, 14)
		Me.Label9.TabIndex = 18
		Me.Label9.Text = "Slave Id"
		'
		'Label13
		'
		Me.Label13.AutoSize = true
		Me.Label13.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label13.Location = New System.Drawing.Point(23, 57)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(21, 14)
		Me.Label13.TabIndex = 19
		Me.Label13.Text = "IP"
		'
		'SlaveId
		'
		Me.SlaveId.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.SlaveId.Location = New System.Drawing.Point(113, 32)
		Me.SlaveId.Name = "SlaveId"
		Me.SlaveId.Size = New System.Drawing.Size(91, 22)
		Me.SlaveId.TabIndex = 17
		'
		'GroupBox2
		'
		Me.GroupBox2.Location = New System.Drawing.Point(12, 206)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(510, 10)
		Me.GroupBox2.TabIndex = 28
		Me.GroupBox2.TabStop = false
		'
		'SetWordButton
		'
		Me.SetWordButton.Enabled = false
		Me.SetWordButton.Location = New System.Drawing.Point(279, 296)
		Me.SetWordButton.Name = "SetWordButton"
		Me.SetWordButton.Size = New System.Drawing.Size(75, 23)
		Me.SetWordButton.TabIndex = 29
		Me.SetWordButton.Text = "Set Word"
		Me.SetWordButton.UseVisualStyleBackColor = true
		'
		'SetDWordButton
		'
		Me.SetDWordButton.Enabled = false
		Me.SetDWordButton.Location = New System.Drawing.Point(279, 395)
		Me.SetDWordButton.Name = "SetDWordButton"
		Me.SetDWordButton.Size = New System.Drawing.Size(75, 23)
		Me.SetDWordButton.TabIndex = 30
		Me.SetDWordButton.Text = "Set Dword"
		Me.SetDWordButton.UseVisualStyleBackColor = true
		'
		'SetFloatButton
		'
		Me.SetFloatButton.Enabled = false
		Me.SetFloatButton.Location = New System.Drawing.Point(279, 494)
		Me.SetFloatButton.Name = "SetFloatButton"
		Me.SetFloatButton.Size = New System.Drawing.Size(75, 23)
		Me.SetFloatButton.TabIndex = 31
		Me.SetFloatButton.Text = "Set Float"
		Me.SetFloatButton.UseVisualStyleBackColor = true
		'
		'WordLoop_CkB
		'
		Me.WordLoop_CkB.AutoSize = true
		Me.WordLoop_CkB.Location = New System.Drawing.Point(142, 299)
		Me.WordLoop_CkB.Name = "WordLoop_CkB"
		Me.WordLoop_CkB.Size = New System.Drawing.Size(50, 17)
		Me.WordLoop_CkB.TabIndex = 32
		Me.WordLoop_CkB.Text = "Loop"
		Me.WordLoop_CkB.UseVisualStyleBackColor = true
		'
		'DWordLoop_CB
		'
		Me.DWordLoop_CB.AutoSize = true
		Me.DWordLoop_CB.Location = New System.Drawing.Point(142, 398)
		Me.DWordLoop_CB.Name = "DWordLoop_CB"
		Me.DWordLoop_CB.Size = New System.Drawing.Size(50, 17)
		Me.DWordLoop_CB.TabIndex = 33
		Me.DWordLoop_CB.Text = "Loop"
		Me.DWordLoop_CB.UseVisualStyleBackColor = true
		'
		'FloatLoop_CB
		'
		Me.FloatLoop_CB.AutoSize = true
		Me.FloatLoop_CB.Location = New System.Drawing.Point(142, 497)
		Me.FloatLoop_CB.Name = "FloatLoop_CB"
		Me.FloatLoop_CB.Size = New System.Drawing.Size(50, 17)
		Me.FloatLoop_CB.TabIndex = 34
		Me.FloatLoop_CB.Text = "Loop"
		Me.FloatLoop_CB.UseVisualStyleBackColor = true
		'
		'WordLoopDelay_TB
		'
		Me.WordLoopDelay_TB.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.WordLoopDelay_TB.Location = New System.Drawing.Point(418, 240)
		Me.WordLoopDelay_TB.Name = "WordLoopDelay_TB"
		Me.WordLoopDelay_TB.Size = New System.Drawing.Size(104, 22)
		Me.WordLoopDelay_TB.TabIndex = 35
		'
		'DWordLoopDelay
		'
		Me.DWordLoopDelay.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.DWordLoopDelay.Location = New System.Drawing.Point(418, 339)
		Me.DWordLoopDelay.Name = "DWordLoopDelay"
		Me.DWordLoopDelay.Size = New System.Drawing.Size(104, 22)
		Me.DWordLoopDelay.TabIndex = 36
		'
		'FloatLoopDelay
		'
		Me.FloatLoopDelay.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FloatLoopDelay.Location = New System.Drawing.Point(418, 438)
		Me.FloatLoopDelay.Name = "FloatLoopDelay"
		Me.FloatLoopDelay.Size = New System.Drawing.Size(104, 22)
		Me.FloatLoopDelay.TabIndex = 37
		'
		'Label7
		'
		Me.Label7.AutoSize = true
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label7.Location = New System.Drawing.Point(445, 217)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(50, 18)
		Me.Label7.TabIndex = 38
		Me.Label7.Text = "Delay"
		'
		'Results_RTB
		'
		Me.Results_RTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.Results_RTB.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Results_RTB.Location = New System.Drawing.Point(12, 523)
		Me.Results_RTB.Name = "Results_RTB"
		Me.Results_RTB.Size = New System.Drawing.Size(510, 52)
		Me.Results_RTB.TabIndex = 39
		Me.Results_RTB.Text = ""
		'
		'ClearResults_B
		'
		Me.ClearResults_B.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.ClearResults_B.Location = New System.Drawing.Point(360, 581)
		Me.ClearResults_B.Name = "ClearResults_B"
		Me.ClearResults_B.Size = New System.Drawing.Size(162, 23)
		Me.ClearResults_B.TabIndex = 40
		Me.ClearResults_B.Text = "Clear Results"
		Me.ClearResults_B.UseVisualStyleBackColor = true
		'
		'WordKill_B
		'
		Me.WordKill_B.Location = New System.Drawing.Point(447, 296)
		Me.WordKill_B.Name = "WordKill_B"
		Me.WordKill_B.Size = New System.Drawing.Size(75, 23)
		Me.WordKill_B.TabIndex = 41
		Me.WordKill_B.Text = "Kill"
		Me.WordKill_B.UseVisualStyleBackColor = true
		'
		'WordReturned_TB
		'
		Me.WordReturned_TB.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.WordReturned_TB.Location = New System.Drawing.Point(142, 268)
		Me.WordReturned_TB.Name = "WordReturned_TB"
		Me.WordReturned_TB.Size = New System.Drawing.Size(380, 22)
		Me.WordReturned_TB.TabIndex = 42
		'
		'Label10
		'
		Me.Label10.AutoSize = true
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label10.Location = New System.Drawing.Point(9, 270)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(116, 18)
		Me.Label10.TabIndex = 43
		Me.Label10.Text = "Data Returned"
		'
		'DWordkill_B
		'
		Me.DWordkill_B.Location = New System.Drawing.Point(447, 395)
		Me.DWordkill_B.Name = "DWordkill_B"
		Me.DWordkill_B.Size = New System.Drawing.Size(75, 23)
		Me.DWordkill_B.TabIndex = 44
		Me.DWordkill_B.Text = "Kill"
		Me.DWordkill_B.UseVisualStyleBackColor = true
		'
		'Label11
		'
		Me.Label11.AutoSize = true
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label11.Location = New System.Drawing.Point(9, 369)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(116, 18)
		Me.Label11.TabIndex = 46
		Me.Label11.Text = "Data Returned"
		'
		'DWordReturned_TB
		'
		Me.DWordReturned_TB.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.DWordReturned_TB.Location = New System.Drawing.Point(142, 367)
		Me.DWordReturned_TB.Name = "DWordReturned_TB"
		Me.DWordReturned_TB.Size = New System.Drawing.Size(380, 22)
		Me.DWordReturned_TB.TabIndex = 45
		'
		'FloatKill_B
		'
		Me.FloatKill_B.Location = New System.Drawing.Point(447, 494)
		Me.FloatKill_B.Name = "FloatKill_B"
		Me.FloatKill_B.Size = New System.Drawing.Size(75, 23)
		Me.FloatKill_B.TabIndex = 48
		Me.FloatKill_B.Text = "Kill"
		Me.FloatKill_B.UseVisualStyleBackColor = true
		'
		'Label12
		'
		Me.Label12.AutoSize = true
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label12.Location = New System.Drawing.Point(9, 468)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(116, 18)
		Me.Label12.TabIndex = 50
		Me.Label12.Text = "Data Returned"
		'
		'FloatReturned_TB
		'
		Me.FloatReturned_TB.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FloatReturned_TB.Location = New System.Drawing.Point(142, 466)
		Me.FloatReturned_TB.Name = "FloatReturned_TB"
		Me.FloatReturned_TB.Size = New System.Drawing.Size(380, 22)
		Me.FloatReturned_TB.TabIndex = 49
		'
		'GroupBox3
		'
		Me.GroupBox3.Location = New System.Drawing.Point(12, 325)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(510, 10)
		Me.GroupBox3.TabIndex = 29
		Me.GroupBox3.TabStop = false
		'
		'GroupBox4
		'
		Me.GroupBox4.Location = New System.Drawing.Point(12, 424)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(511, 10)
		Me.GroupBox4.TabIndex = 30
		Me.GroupBox4.TabStop = false
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(532, 608)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.FloatReturned_TB)
		Me.Controls.Add(Me.FloatKill_B)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.DWordReturned_TB)
		Me.Controls.Add(Me.DWordkill_B)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.WordReturned_TB)
		Me.Controls.Add(Me.WordKill_B)
		Me.Controls.Add(Me.ClearResults_B)
		Me.Controls.Add(Me.Results_RTB)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.FloatLoopDelay)
		Me.Controls.Add(Me.DWordLoopDelay)
		Me.Controls.Add(Me.WordLoopDelay_TB)
		Me.Controls.Add(Me.FloatLoop_CB)
		Me.Controls.Add(Me.DWordLoop_CB)
		Me.Controls.Add(Me.WordLoop_CkB)
		Me.Controls.Add(Me.SetFloatButton)
		Me.Controls.Add(Me.SetDWordButton)
		Me.Controls.Add(Me.SetWordButton)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.FloatValue)
		Me.Controls.Add(Me.GetFloatButton)
		Me.Controls.Add(Me.FloatAddress)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.DwordValue)
		Me.Controls.Add(Me.GetDWordButton)
		Me.Controls.Add(Me.DwordAddress)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.WordValue)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.WordAddress)
		Me.Controls.Add(Me.GetWordButton)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Modbus/RTU"
		Me.GroupBox1.ResumeLayout(false)
		Me.GroupBox1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConnectButton As System.Windows.Forms.Button
    Friend WithEvents DisconnectButton As System.Windows.Forms.Button
    Friend WithEvents GetWordButton As System.Windows.Forms.Button
    Friend WithEvents WordAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WordValue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DwordAddress As System.Windows.Forms.TextBox
    Friend WithEvents GetDWordButton As System.Windows.Forms.Button
    Friend WithEvents DwordValue As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ConnectionStatus As System.Windows.Forms.TextBox
    Friend WithEvents COMPortList As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FloatAddress As System.Windows.Forms.TextBox
    Friend WithEvents GetFloatButton As System.Windows.Forms.Button
    Friend WithEvents FloatValue As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SetWordButton As System.Windows.Forms.Button
    Friend WithEvents SetDWordButton As System.Windows.Forms.Button
    Friend WithEvents SetFloatButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SlaveId As System.Windows.Forms.TextBox
    Friend WithEvents WordLoop_CkB As System.Windows.Forms.CheckBox
    Friend WithEvents DWordLoop_CB As System.Windows.Forms.CheckBox
    Friend WithEvents FloatLoop_CB As System.Windows.Forms.CheckBox
    Friend WithEvents WordLoopDelay_TB As System.Windows.Forms.TextBox
    Friend WithEvents DWordLoopDelay As System.Windows.Forms.TextBox
    Friend WithEvents FloatLoopDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Results_RTB As System.Windows.Forms.RichTextBox
    Friend WithEvents ClearResults_B As System.Windows.Forms.Button
    Friend WithEvents WordKill_B As System.Windows.Forms.Button
    Friend WithEvents WordReturned_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DWordkill_B As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DWordReturned_TB As System.Windows.Forms.TextBox
    Friend WithEvents FloatKill_B As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FloatReturned_TB As System.Windows.Forms.TextBox
    Friend WithEvents IP_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TCP_RB As System.Windows.Forms.RadioButton
    Friend WithEvents RTU_RB As System.Windows.Forms.RadioButton
    Friend WithEvents SwapWords As System.Windows.Forms.CheckBox
    Friend WithEvents SwapBytes As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
