﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_HISTORY_CALLBACK
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_HISTORY_CALLBACK))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.dgColCustomerId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColTongDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColTongTime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColTongNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColCallBackResult = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColConsultType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColConsultResult = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColTongUser = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgColCallType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboCallBackResult = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.cboUser = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.cboConsultResult = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.cboConsultType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.dpt2 = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbT2 = New System.Windows.Forms.ComboBox
        Me.cbH2 = New System.Windows.Forms.ComboBox
        Me.cbT1 = New System.Windows.Forms.ComboBox
        Me.cbH1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTongNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dpt1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSubCustomerName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTongTime = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSubTongNo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtConsultType = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSubTongUser = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtConsultResult = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTongEtcInfo = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtCallBackResult = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.btnDetail = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgColCustomerId, Me.dgColCustomerName, Me.dgColTongDate, Me.dgColTongTime, Me.dgColTongNo, Me.dgColCallBackResult, Me.dgColConsultType, Me.dgColConsultResult, Me.dgColTongUser, Me.dgColCallType})
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView2.Location = New System.Drawing.Point(12, 96)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(871, 411)
        Me.DataGridView2.TabIndex = 80
        '
        'dgColCustomerId
        '
        Me.dgColCustomerId.HeaderText = "고객아이디"
        Me.dgColCustomerId.Name = "dgColCustomerId"
        Me.dgColCustomerId.ReadOnly = True
        '
        'dgColCustomerName
        '
        Me.dgColCustomerName.HeaderText = "고객명"
        Me.dgColCustomerName.Name = "dgColCustomerName"
        Me.dgColCustomerName.ReadOnly = True
        '
        'dgColTongDate
        '
        Me.dgColTongDate.HeaderText = "통화일자"
        Me.dgColTongDate.Name = "dgColTongDate"
        Me.dgColTongDate.ReadOnly = True
        '
        'dgColTongTime
        '
        Me.dgColTongTime.HeaderText = "통화시간"
        Me.dgColTongTime.Name = "dgColTongTime"
        Me.dgColTongTime.ReadOnly = True
        '
        'dgColTongNo
        '
        Me.dgColTongNo.HeaderText = "전화번호"
        Me.dgColTongNo.Name = "dgColTongNo"
        Me.dgColTongNo.ReadOnly = True
        '
        'dgColCallBackResult
        '
        Me.dgColCallBackResult.HeaderText = "콜백처리결과"
        Me.dgColCallBackResult.Name = "dgColCallBackResult"
        Me.dgColCallBackResult.ReadOnly = True
        '
        'dgColConsultType
        '
        Me.dgColConsultType.HeaderText = "상담유형"
        Me.dgColConsultType.Name = "dgColConsultType"
        Me.dgColConsultType.ReadOnly = True
        '
        'dgColConsultResult
        '
        Me.dgColConsultResult.HeaderText = "상담결과"
        Me.dgColConsultResult.Name = "dgColConsultResult"
        Me.dgColConsultResult.ReadOnly = True
        '
        'dgColTongUser
        '
        Me.dgColTongUser.HeaderText = "통화자"
        Me.dgColTongUser.Name = "dgColTongUser"
        Me.dgColTongUser.ReadOnly = True
        '
        'dgColCallType
        '
        Me.dgColCallType.HeaderText = "콜타입"
        Me.dgColCallType.Name = "dgColCallType"
        Me.dgColCallType.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.cboCallBackResult)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.cboUser)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.cboConsultResult)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.cboConsultType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.dpt2)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.cbT2)
        Me.GroupBox1.Controls.Add(Me.cbH2)
        Me.GroupBox1.Controls.Add(Me.cbT1)
        Me.GroupBox1.Controls.Add(Me.cbH1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTongNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dpt1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 78)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'cboCallBackResult
        '
        Me.cboCallBackResult.BackColor = System.Drawing.Color.MintCream
        Me.cboCallBackResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCallBackResult.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboCallBackResult.FormattingEnabled = True
        Me.cboCallBackResult.Location = New System.Drawing.Point(103, 50)
        Me.cboCallBackResult.Name = "cboCallBackResult"
        Me.cboCallBackResult.Size = New System.Drawing.Size(93, 20)
        Me.cboCallBackResult.TabIndex = 214
        '
        'Label28
        '
        Me.Label28.Image = CType(resources.GetObject("Label28.Image"), System.Drawing.Image)
        Me.Label28.Location = New System.Drawing.Point(7, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 12)
        Me.Label28.TabIndex = 216
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(19, 53)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 12)
        Me.Label29.TabIndex = 215
        Me.Label29.Text = "콜백처리여부"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(809, 15)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(45, 25)
        Me.btnSelect.TabIndex = 213
        Me.btnSelect.Text = "조회"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'cboUser
        '
        Me.cboUser.BackColor = System.Drawing.Color.MintCream
        Me.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(675, 50)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(93, 20)
        Me.cboUser.TabIndex = 211
        '
        'Label27
        '
        Me.Label27.Image = CType(resources.GetObject("Label27.Image"), System.Drawing.Image)
        Me.Label27.Location = New System.Drawing.Point(291, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 12)
        Me.Label27.TabIndex = 210
        '
        'Label35
        '
        Me.Label35.Image = CType(resources.GetObject("Label35.Image"), System.Drawing.Image)
        Me.Label35.Location = New System.Drawing.Point(616, 53)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(13, 12)
        Me.Label35.TabIndex = 209
        '
        'cboConsultResult
        '
        Me.cboConsultResult.BackColor = System.Drawing.Color.MintCream
        Me.cboConsultResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsultResult.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboConsultResult.FormattingEnabled = True
        Me.cboConsultResult.Location = New System.Drawing.Point(485, 50)
        Me.cboConsultResult.Name = "cboConsultResult"
        Me.cboConsultResult.Size = New System.Drawing.Size(93, 20)
        Me.cboConsultResult.TabIndex = 50
        '
        'Label34
        '
        Me.Label34.Image = CType(resources.GetObject("Label34.Image"), System.Drawing.Image)
        Me.Label34.Location = New System.Drawing.Point(416, 53)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 12)
        Me.Label34.TabIndex = 207
        '
        'cboConsultType
        '
        Me.cboConsultType.BackColor = System.Drawing.Color.MintCream
        Me.cboConsultType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsultType.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboConsultType.FormattingEnabled = True
        Me.cboConsultType.Location = New System.Drawing.Point(290, 50)
        Me.cboConsultType.Name = "cboConsultType"
        Me.cboConsultType.Size = New System.Drawing.Size(93, 20)
        Me.cboConsultType.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(630, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "통화자"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(429, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 203
        Me.Label15.Text = "상담결과"
        '
        'Label26
        '
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.Location = New System.Drawing.Point(222, 54)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 12)
        Me.Label26.TabIndex = 202
        '
        'Label25
        '
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.Location = New System.Drawing.Point(598, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 12)
        Me.Label25.TabIndex = 201
        '
        'dpt2
        '
        Me.dpt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpt2.Location = New System.Drawing.Point(192, 22)
        Me.dpt2.Name = "dpt2"
        Me.dpt2.Size = New System.Drawing.Size(91, 21)
        Me.dpt2.TabIndex = 43
        Me.dpt2.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label24
        '
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.Location = New System.Drawing.Point(6, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 12)
        Me.Label24.TabIndex = 199
        '
        'cbT2
        '
        Me.cbT2.FormattingEnabled = True
        Me.cbT2.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50", "60"})
        Me.cbT2.Location = New System.Drawing.Point(539, 22)
        Me.cbT2.Name = "cbT2"
        Me.cbT2.Size = New System.Drawing.Size(52, 20)
        Me.cbT2.TabIndex = 47
        '
        'cbH2
        '
        Me.cbH2.FormattingEnabled = True
        Me.cbH2.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbH2.Location = New System.Drawing.Point(485, 22)
        Me.cbH2.Name = "cbH2"
        Me.cbH2.Size = New System.Drawing.Size(52, 20)
        Me.cbH2.TabIndex = 46
        '
        'cbT1
        '
        Me.cbT1.FormattingEnabled = True
        Me.cbT1.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50", "60"})
        Me.cbT1.Location = New System.Drawing.Point(417, 22)
        Me.cbT1.Name = "cbT1"
        Me.cbT1.Size = New System.Drawing.Size(52, 20)
        Me.cbT1.TabIndex = 45
        '
        'cbH1
        '
        Me.cbH1.FormattingEnabled = True
        Me.cbH1.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbH1.Location = New System.Drawing.Point(365, 22)
        Me.cbH1.Name = "cbH1"
        Me.cbH1.Size = New System.Drawing.Size(52, 20)
        Me.cbH1.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(469, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 12)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "~"
        '
        'txtTongNo
        '
        Me.txtTongNo.Location = New System.Drawing.Point(666, 24)
        Me.txtTongNo.Name = "txtTongNo"
        Me.txtTongNo.Size = New System.Drawing.Size(103, 21)
        Me.txtTongNo.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(611, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "전화번호"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(234, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "상담유형"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "통화시간"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 12)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "~"
        '
        'dpt1
        '
        Me.dpt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpt1.Location = New System.Drawing.Point(78, 22)
        Me.dpt1.Name = "dpt1"
        Me.dpt1.Size = New System.Drawing.Size(91, 21)
        Me.dpt1.TabIndex = 42
        Me.dpt1.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "통화일자"
        '
        'txtSubCustomerName
        '
        Me.txtSubCustomerName.Location = New System.Drawing.Point(78, 513)
        Me.txtSubCustomerName.Name = "txtSubCustomerName"
        Me.txtSubCustomerName.Size = New System.Drawing.Size(130, 21)
        Me.txtSubCustomerName.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 516)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "고객명"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(280, 513)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(130, 21)
        Me.txtDate.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 516)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "통화일자"
        '
        'txtTongTime
        '
        Me.txtTongTime.Location = New System.Drawing.Point(486, 513)
        Me.txtTongTime.Name = "txtTongTime"
        Me.txtTongTime.Size = New System.Drawing.Size(130, 21)
        Me.txtTongTime.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(429, 519)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "통화시간"
        '
        'txtSubTongNo
        '
        Me.txtSubTongNo.Location = New System.Drawing.Point(689, 513)
        Me.txtSubTongNo.Name = "txtSubTongNo"
        Me.txtSubTongNo.Size = New System.Drawing.Size(111, 21)
        Me.txtSubTongNo.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(632, 519)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "통화번호"
        '
        'txtConsultType
        '
        Me.txtConsultType.Location = New System.Drawing.Point(280, 537)
        Me.txtConsultType.Name = "txtConsultType"
        Me.txtConsultType.Size = New System.Drawing.Size(130, 21)
        Me.txtConsultType.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(225, 540)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "상담유형"
        '
        'txtSubTongUser
        '
        Me.txtSubTongUser.Location = New System.Drawing.Point(689, 537)
        Me.txtSubTongUser.Name = "txtSubTongUser"
        Me.txtSubTongUser.Size = New System.Drawing.Size(130, 21)
        Me.txtSubTongUser.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(632, 544)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 12)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "통화자"
        '
        'txtConsultResult
        '
        Me.txtConsultResult.Location = New System.Drawing.Point(487, 537)
        Me.txtConsultResult.Name = "txtConsultResult"
        Me.txtConsultResult.Size = New System.Drawing.Size(129, 21)
        Me.txtConsultResult.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(429, 540)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "상담결과"
        '
        'txtTongEtcInfo
        '
        Me.txtTongEtcInfo.Location = New System.Drawing.Point(82, 570)
        Me.txtTongEtcInfo.Multiline = True
        Me.txtTongEtcInfo.Name = "txtTongEtcInfo"
        Me.txtTongEtcInfo.Size = New System.Drawing.Size(800, 53)
        Me.txtTongEtcInfo.TabIndex = 59
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 569)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "상담정보"
        '
        'Label23
        '
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.Location = New System.Drawing.Point(10, 569)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 12)
        Me.Label23.TabIndex = 205
        '
        'Label22
        '
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.Location = New System.Drawing.Point(214, 540)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 12)
        Me.Label22.TabIndex = 204
        '
        'Label21
        '
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.Location = New System.Drawing.Point(620, 519)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 12)
        Me.Label21.TabIndex = 203
        '
        'Label20
        '
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(620, 544)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 12)
        Me.Label20.TabIndex = 202
        '
        'Label19
        '
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.Location = New System.Drawing.Point(417, 519)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 12)
        Me.Label19.TabIndex = 201
        '
        'Label18
        '
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(417, 540)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 12)
        Me.Label18.TabIndex = 200
        '
        'Label17
        '
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(214, 516)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 12)
        Me.Label17.TabIndex = 199
        '
        'Label46
        '
        Me.Label46.Image = CType(resources.GetObject("Label46.Image"), System.Drawing.Image)
        Me.Label46.Location = New System.Drawing.Point(10, 516)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(13, 12)
        Me.Label46.TabIndex = 198
        '
        'Label30
        '
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.Location = New System.Drawing.Point(10, 540)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 12)
        Me.Label30.TabIndex = 208
        '
        'txtCallBackResult
        '
        Me.txtCallBackResult.Location = New System.Drawing.Point(78, 537)
        Me.txtCallBackResult.Name = "txtCallBackResult"
        Me.txtCallBackResult.Size = New System.Drawing.Size(130, 21)
        Me.txtCallBackResult.TabIndex = 206
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(22, 540)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 12)
        Me.Label31.TabIndex = 207
        Me.Label31.Text = "처리결과"
        '
        'btnDetail
        '
        Me.btnDetail.Location = New System.Drawing.Point(817, 510)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(65, 25)
        Me.btnDetail.TabIndex = 214
        Me.btnDetail.Text = "상세조회"
        Me.btnDetail.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(809, 43)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(45, 25)
        Me.btnExcel.TabIndex = 217
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "c"
        '
        'FRM_HISTORY_CALLBACK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtCallBackResult)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtTongEtcInfo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSubTongUser)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtConsultResult)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtConsultType)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSubTongNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTongTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSubCustomerName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_HISTORY_CALLBACK"
        Me.Text = "콜백조회"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dpt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTongNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSubCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTongTime As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSubTongNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtConsultType As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSubTongUser As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtConsultResult As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTongEtcInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbT2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbH2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbT1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbH1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dpt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cboConsultResult As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cboConsultType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents cboCallBackResult As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtCallBackResult As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents dgColCustomerId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColCustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColTongDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColTongTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColTongNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColCallBackResult As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColConsultType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColConsultResult As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColTongUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgColCallType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
