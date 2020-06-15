<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnMeasure = New System.Windows.Forms.Button()
        Me.TxtMsg = New System.Windows.Forms.TextBox()
        Me.TxtFirstCH = New System.Windows.Forms.TextBox()
        Me.TxtLastCH = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.CH1Max = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CH1Min = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CH2Min = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CH2Max = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CH3Min = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CH3Max = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CH4Min = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CH4Max = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CH5Min = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CH5Max = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CH1Measure = New System.Windows.Forms.Label()
        Me.CH2Measure = New System.Windows.Forms.Label()
        Me.CH3Measure = New System.Windows.Forms.Label()
        Me.CH4Measure = New System.Windows.Forms.Label()
        Me.CH5Measure = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtTotalCH = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.textboxCOM = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblBarCode = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label27 = New System.Windows.Forms.Label()
        Me.modelNam = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.OrderNum = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.WkorderNum = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtOpCode = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.LblPASS = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LblNG = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.WkStationNam = New System.Windows.Forms.TextBox()
        Me.BtnSt = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.BtnAmount = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtnMeasure
        '
        Me.BtnMeasure.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnMeasure.Location = New System.Drawing.Point(875, 233)
        Me.BtnMeasure.Name = "BtnMeasure"
        Me.BtnMeasure.Size = New System.Drawing.Size(67, 54)
        Me.BtnMeasure.TabIndex = 39
        Me.BtnMeasure.Text = "測量開始"
        Me.BtnMeasure.UseVisualStyleBackColor = True
        '
        'TxtMsg
        '
        Me.TxtMsg.Enabled = False
        Me.TxtMsg.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtMsg.Location = New System.Drawing.Point(979, 84)
        Me.TxtMsg.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMsg.Multiline = True
        Me.TxtMsg.Name = "TxtMsg"
        Me.TxtMsg.Size = New System.Drawing.Size(286, 318)
        Me.TxtMsg.TabIndex = 42
        '
        'TxtFirstCH
        '
        Me.TxtFirstCH.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtFirstCH.Location = New System.Drawing.Point(727, 112)
        Me.TxtFirstCH.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFirstCH.Name = "TxtFirstCH"
        Me.TxtFirstCH.Size = New System.Drawing.Size(121, 30)
        Me.TxtFirstCH.TabIndex = 43
        '
        'TxtLastCH
        '
        Me.TxtLastCH.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtLastCH.Location = New System.Drawing.Point(727, 175)
        Me.TxtLastCH.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLastCH.Name = "TxtLastCH"
        Me.TxtLastCH.Size = New System.Drawing.Size(121, 30)
        Me.TxtLastCH.TabIndex = 44
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape7, Me.OvalShape6, Me.OvalShape5, Me.OvalShape4, Me.OvalShape3, Me.OvalShape2, Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1354, 714)
        Me.ShapeContainer1.TabIndex = 45
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape7
        '
        Me.OvalShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape7.Location = New System.Drawing.Point(1022, 483)
        Me.OvalShape7.Name = "OvalShape7"
        Me.OvalShape7.Size = New System.Drawing.Size(133, 123)
        '
        'OvalShape6
        '
        Me.OvalShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape6.Location = New System.Drawing.Point(743, 316)
        Me.OvalShape6.Name = "OvalShape6"
        Me.OvalShape6.Size = New System.Drawing.Size(80, 82)
        '
        'OvalShape5
        '
        Me.OvalShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape5.Location = New System.Drawing.Point(585, 316)
        Me.OvalShape5.Name = "OvalShape5"
        Me.OvalShape5.Size = New System.Drawing.Size(80, 83)
        '
        'OvalShape4
        '
        Me.OvalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape4.Location = New System.Drawing.Point(449, 314)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.Size = New System.Drawing.Size(80, 83)
        '
        'OvalShape3
        '
        Me.OvalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape3.Location = New System.Drawing.Point(309, 316)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(80, 83)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape2.Location = New System.Drawing.Point(161, 318)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(80, 83)
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.SystemColors.Control
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.Location = New System.Drawing.Point(16, 315)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(80, 83)
        '
        'CH1Max
        '
        Me.CH1Max.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH1Max.Location = New System.Drawing.Point(15, 112)
        Me.CH1Max.Margin = New System.Windows.Forms.Padding(2)
        Me.CH1Max.Name = "CH1Max"
        Me.CH1Max.Size = New System.Drawing.Size(121, 30)
        Me.CH1Max.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "產品條碼"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "CH1最大值(Ω)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 19)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "CH1最小值(Ω)"
        '
        'CH1Min
        '
        Me.CH1Min.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH1Min.Location = New System.Drawing.Point(15, 175)
        Me.CH1Min.Margin = New System.Windows.Forms.Padding(2)
        Me.CH1Min.Name = "CH1Min"
        Me.CH1Min.Size = New System.Drawing.Size(121, 30)
        Me.CH1Min.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 219)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "CH1測量值(Ω)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(147, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 19)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "CH2測量值(Ω)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(149, 148)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 19)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "CH2最小值(Ω)"
        '
        'CH2Min
        '
        Me.CH2Min.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH2Min.Location = New System.Drawing.Point(152, 175)
        Me.CH2Min.Margin = New System.Windows.Forms.Padding(2)
        Me.CH2Min.Name = "CH2Min"
        Me.CH2Min.Size = New System.Drawing.Size(121, 30)
        Me.CH2Min.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(149, 84)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 19)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "CH2最大值(Ω)"
        '
        'CH2Max
        '
        Me.CH2Max.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH2Max.Location = New System.Drawing.Point(152, 112)
        Me.CH2Max.Margin = New System.Windows.Forms.Padding(2)
        Me.CH2Max.Name = "CH2Max"
        Me.CH2Max.Size = New System.Drawing.Size(121, 30)
        Me.CH2Max.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(286, 219)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 19)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "CH3測量值(Ω)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 148)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 19)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "CH3最小值(Ω)"
        '
        'CH3Min
        '
        Me.CH3Min.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH3Min.Location = New System.Drawing.Point(291, 175)
        Me.CH3Min.Margin = New System.Windows.Forms.Padding(2)
        Me.CH3Min.Name = "CH3Min"
        Me.CH3Min.Size = New System.Drawing.Size(121, 30)
        Me.CH3Min.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(288, 84)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 19)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "CH3最大值(Ω)"
        '
        'CH3Max
        '
        Me.CH3Max.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH3Max.Location = New System.Drawing.Point(291, 112)
        Me.CH3Max.Margin = New System.Windows.Forms.Padding(2)
        Me.CH3Max.Name = "CH3Max"
        Me.CH3Max.Size = New System.Drawing.Size(121, 30)
        Me.CH3Max.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(425, 219)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 19)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "CH4測量值(Ω)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(427, 148)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 19)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "CH4最小值(Ω)"
        '
        'CH4Min
        '
        Me.CH4Min.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH4Min.Location = New System.Drawing.Point(430, 175)
        Me.CH4Min.Margin = New System.Windows.Forms.Padding(2)
        Me.CH4Min.Name = "CH4Min"
        Me.CH4Min.Size = New System.Drawing.Size(121, 30)
        Me.CH4Min.TabIndex = 67
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(427, 84)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 19)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "CH4最大值(Ω)"
        '
        'CH4Max
        '
        Me.CH4Max.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH4Max.Location = New System.Drawing.Point(430, 112)
        Me.CH4Max.Margin = New System.Windows.Forms.Padding(2)
        Me.CH4Max.Name = "CH4Max"
        Me.CH4Max.Size = New System.Drawing.Size(121, 30)
        Me.CH4Max.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(569, 219)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 19)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "CH5測量值(Ω)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(571, 148)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 19)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "CH5最小值(Ω)"
        '
        'CH5Min
        '
        Me.CH5Min.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH5Min.Location = New System.Drawing.Point(574, 175)
        Me.CH5Min.Margin = New System.Windows.Forms.Padding(2)
        Me.CH5Min.Name = "CH5Min"
        Me.CH5Min.Size = New System.Drawing.Size(121, 30)
        Me.CH5Min.TabIndex = 73
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(571, 84)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 19)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "CH5最大值(Ω)"
        '
        'CH5Max
        '
        Me.CH5Max.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH5Max.Location = New System.Drawing.Point(574, 112)
        Me.CH5Max.Margin = New System.Windows.Forms.Padding(2)
        Me.CH5Max.Name = "CH5Max"
        Me.CH5Max.Size = New System.Drawing.Size(121, 30)
        Me.CH5Max.TabIndex = 71
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 290)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 19)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "CH1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.Location = New System.Drawing.Point(753, 84)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 19)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "First CH"
        '
        'CH1Measure
        '
        Me.CH1Measure.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CH1Measure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CH1Measure.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH1Measure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CH1Measure.Location = New System.Drawing.Point(13, 252)
        Me.CH1Measure.Name = "CH1Measure"
        Me.CH1Measure.Size = New System.Drawing.Size(120, 28)
        Me.CH1Measure.TabIndex = 80
        '
        'CH2Measure
        '
        Me.CH2Measure.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CH2Measure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CH2Measure.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH2Measure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CH2Measure.Location = New System.Drawing.Point(150, 252)
        Me.CH2Measure.Name = "CH2Measure"
        Me.CH2Measure.Size = New System.Drawing.Size(120, 28)
        Me.CH2Measure.TabIndex = 81
        '
        'CH3Measure
        '
        Me.CH3Measure.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CH3Measure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CH3Measure.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH3Measure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CH3Measure.Location = New System.Drawing.Point(289, 252)
        Me.CH3Measure.Name = "CH3Measure"
        Me.CH3Measure.Size = New System.Drawing.Size(120, 28)
        Me.CH3Measure.TabIndex = 82
        '
        'CH4Measure
        '
        Me.CH4Measure.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CH4Measure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CH4Measure.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH4Measure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CH4Measure.Location = New System.Drawing.Point(428, 252)
        Me.CH4Measure.Name = "CH4Measure"
        Me.CH4Measure.Size = New System.Drawing.Size(120, 28)
        Me.CH4Measure.TabIndex = 83
        '
        'CH5Measure
        '
        Me.CH5Measure.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CH5Measure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CH5Measure.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CH5Measure.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CH5Measure.Location = New System.Drawing.Point(572, 252)
        Me.CH5Measure.Name = "CH5Measure"
        Me.CH5Measure.Size = New System.Drawing.Size(120, 28)
        Me.CH5Measure.TabIndex = 84
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.Location = New System.Drawing.Point(753, 148)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 19)
        Me.Label19.TabIndex = 85
        Me.Label19.Text = "Last CH"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.Location = New System.Drawing.Point(751, 219)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 19)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Total CH"
        '
        'TxtTotalCH
        '
        Me.TxtTotalCH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtTotalCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalCH.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtTotalCH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTotalCH.Location = New System.Drawing.Point(725, 252)
        Me.TxtTotalCH.Name = "TxtTotalCH"
        Me.TxtTotalCH.Size = New System.Drawing.Size(120, 28)
        Me.TxtTotalCH.TabIndex = 87
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.Location = New System.Drawing.Point(175, 290)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 19)
        Me.Label21.TabIndex = 88
        Me.Label21.Text = "CH2"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.Location = New System.Drawing.Point(327, 290)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 19)
        Me.Label22.TabIndex = 89
        Me.Label22.Text = "CH3"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label23.Location = New System.Drawing.Point(464, 290)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 19)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "CH4"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label24.Location = New System.Drawing.Point(606, 290)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 19)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "CH5"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label25.Location = New System.Drawing.Point(760, 290)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 19)
        Me.Label25.TabIndex = 92
        Me.Label25.Text = "條碼"
        '
        'textboxCOM
        '
        Me.textboxCOM.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.textboxCOM.Location = New System.Drawing.Point(97, 16)
        Me.textboxCOM.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxCOM.Name = "textboxCOM"
        Me.textboxCOM.Size = New System.Drawing.Size(121, 30)
        Me.textboxCOM.TabIndex = 95
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label26.Location = New System.Drawing.Point(14, 19)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 19)
        Me.Label26.TabIndex = 93
        Me.Label26.Text = "COM Port"
        '
        'LblBarCode
        '
        Me.LblBarCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBarCode.Font = New System.Drawing.Font("新細明體", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblBarCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblBarCode.Location = New System.Drawing.Point(430, 19)
        Me.LblBarCode.Name = "LblBarCode"
        Me.LblBarCode.Size = New System.Drawing.Size(392, 49)
        Me.LblBarCode.TabIndex = 96
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Timer2
        '
        '
        'BtnConnect
        '
        Me.BtnConnect.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnConnect.Location = New System.Drawing.Point(244, 6)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(67, 54)
        Me.BtnConnect.TabIndex = 98
        Me.BtnConnect.Text = "連線"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label27.Location = New System.Drawing.Point(11, 408)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 19)
        Me.Label27.TabIndex = 99
        Me.Label27.Text = "機種名稱"
        '
        'modelNam
        '
        Me.modelNam.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.modelNam.Location = New System.Drawing.Point(12, 429)
        Me.modelNam.Margin = New System.Windows.Forms.Padding(2)
        Me.modelNam.Name = "modelNam"
        Me.modelNam.Size = New System.Drawing.Size(243, 30)
        Me.modelNam.TabIndex = 100
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label28.Location = New System.Drawing.Point(272, 408)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 19)
        Me.Label28.TabIndex = 101
        Me.Label28.Text = "訂單號碼"
        '
        'OrderNum
        '
        Me.OrderNum.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OrderNum.Location = New System.Drawing.Point(276, 429)
        Me.OrderNum.Margin = New System.Windows.Forms.Padding(2)
        Me.OrderNum.Name = "OrderNum"
        Me.OrderNum.Size = New System.Drawing.Size(504, 30)
        Me.OrderNum.TabIndex = 102
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label29.Location = New System.Drawing.Point(12, 471)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(85, 19)
        Me.Label29.TabIndex = 103
        Me.Label29.Text = "工單號碼"
        '
        'WkorderNum
        '
        Me.WkorderNum.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WkorderNum.Location = New System.Drawing.Point(14, 492)
        Me.WkorderNum.Margin = New System.Windows.Forms.Padding(2)
        Me.WkorderNum.Name = "WkorderNum"
        Me.WkorderNum.Size = New System.Drawing.Size(366, 30)
        Me.WkorderNum.TabIndex = 104
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label30.Location = New System.Drawing.Point(411, 471)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(180, 19)
        Me.Label30.TabIndex = 105
        Me.Label30.Text = "工單排定的生產數量"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label31.Location = New System.Drawing.Point(616, 471)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 19)
        Me.Label31.TabIndex = 106
        Me.Label31.Text = "工作站站名"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label32.Location = New System.Drawing.Point(11, 534)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 19)
        Me.Label32.TabIndex = 107
        Me.Label32.Text = "作業員工號"
        '
        'TxtOpCode
        '
        Me.TxtOpCode.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtOpCode.Location = New System.Drawing.Point(11, 555)
        Me.TxtOpCode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOpCode.Name = "TxtOpCode"
        Me.TxtOpCode.Size = New System.Drawing.Size(168, 30)
        Me.TxtOpCode.TabIndex = 108
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label33.Location = New System.Drawing.Point(199, 534)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(90, 19)
        Me.Label33.TabIndex = 109
        Me.Label33.Text = "PASS總數"
        '
        'LblPASS
        '
        Me.LblPASS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPASS.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblPASS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblPASS.Location = New System.Drawing.Point(202, 558)
        Me.LblPASS.Name = "LblPASS"
        Me.LblPASS.Size = New System.Drawing.Size(166, 28)
        Me.LblPASS.TabIndex = 110
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label35.Location = New System.Drawing.Point(409, 534)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 19)
        Me.Label35.TabIndex = 111
        Me.Label35.Text = "NG總數"
        '
        'LblNG
        '
        Me.LblNG.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNG.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblNG.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblNG.Location = New System.Drawing.Point(413, 558)
        Me.LblNG.Name = "LblNG"
        Me.LblNG.Size = New System.Drawing.Size(167, 28)
        Me.LblNG.TabIndex = 112
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label37.Location = New System.Drawing.Point(616, 534)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(104, 19)
        Me.Label37.TabIndex = 113
        Me.Label37.Text = "已生產總數"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblTotal.Location = New System.Drawing.Point(618, 558)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(162, 28)
        Me.LblTotal.TabIndex = 114
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Quantity.Location = New System.Drawing.Point(413, 492)
        Me.Quantity.Margin = New System.Windows.Forms.Padding(2)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(168, 30)
        Me.Quantity.TabIndex = 115
        '
        'WkStationNam
        '
        Me.WkStationNam.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WkStationNam.Location = New System.Drawing.Point(617, 492)
        Me.WkStationNam.Margin = New System.Windows.Forms.Padding(2)
        Me.WkStationNam.Name = "WkStationNam"
        Me.WkStationNam.Size = New System.Drawing.Size(163, 30)
        Me.WkStationNam.TabIndex = 116
        '
        'BtnSt
        '
        Me.BtnSt.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnSt.Location = New System.Drawing.Point(875, 151)
        Me.BtnSt.Name = "BtnSt"
        Me.BtnSt.Size = New System.Drawing.Size(67, 54)
        Me.BtnSt.TabIndex = 118
        Me.BtnSt.Text = "啟動"
        Me.BtnSt.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label34.Location = New System.Drawing.Point(991, 421)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(256, 19)
        Me.Label34.TabIndex = 119
        Me.Label34.Text = "資料放置於D:\34972A_Measure"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label36.Location = New System.Drawing.Point(7, 603)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(128, 19)
        Me.Label36.TabIndex = 120
        Me.Label36.Text = "上次測量時間:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label38.Location = New System.Drawing.Point(11, 635)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(128, 19)
        Me.Label38.TabIndex = 121
        Me.Label38.Text = "本次測量時間:"
        '
        'BtnAmount
        '
        Me.BtnAmount.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnAmount.Location = New System.Drawing.Point(821, 421)
        Me.BtnAmount.Name = "BtnAmount"
        Me.BtnAmount.Size = New System.Drawing.Size(67, 54)
        Me.BtnAmount.TabIndex = 122
        Me.BtnAmount.Text = "數量歸零"
        Me.BtnAmount.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label39.Location = New System.Drawing.Point(1016, 456)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(128, 19)
        Me.Label39.TabIndex = 123
        Me.Label39.Text = "產品測試結果:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(841, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(217, 23)
        Me.RadioButton1.TabIndex = 124
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "條碼掃描器掃描即測量"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(841, 50)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(142, 23)
        Me.RadioButton2.TabIndex = 125
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "使用Enter測量"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label40.Location = New System.Drawing.Point(723, 612)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(535, 57)
        Me.Label40.TabIndex = 126
        Me.Label40.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & "如果有問題需要協助請找 張老師(分機742) 或 明叡(分機743)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label42.Location = New System.Drawing.Point(817, 593)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(55, 19)
        Me.Label42.TabIndex = 129
        Me.Label42.Text = "版本:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(875, 85)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(65, 23)
        Me.CheckBox1.TabIndex = 130
        Me.CheckBox1.Text = "MES"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1354, 714)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.BtnAmount)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.BtnSt)
        Me.Controls.Add(Me.WkStationNam)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.LblNG)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.LblPASS)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TxtOpCode)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.WkorderNum)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.OrderNum)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.modelNam)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.LblBarCode)
        Me.Controls.Add(Me.textboxCOM)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TxtTotalCH)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.CH5Measure)
        Me.Controls.Add(Me.CH4Measure)
        Me.Controls.Add(Me.CH3Measure)
        Me.Controls.Add(Me.CH2Measure)
        Me.Controls.Add(Me.CH1Measure)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CH5Min)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CH5Max)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CH4Min)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CH4Max)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CH3Min)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CH3Max)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CH2Min)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CH2Max)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CH1Min)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CH1Max)
        Me.Controls.Add(Me.TxtLastCH)
        Me.Controls.Add(Me.TxtFirstCH)
        Me.Controls.Add(Me.TxtMsg)
        Me.Controls.Add(Me.BtnMeasure)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMeasure As Button
    Friend WithEvents TxtMsg As TextBox
    Friend WithEvents TxtFirstCH As TextBox
    Friend WithEvents TxtLastCH As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents CH1Max As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CH1Min As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CH2Min As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CH2Max As TextBox
    Friend WithEvents OvalShape2 As PowerPacks.OvalShape
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CH3Min As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CH3Max As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CH4Min As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CH4Max As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CH5Min As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CH5Max As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents CH1Measure As Label
    Friend WithEvents CH2Measure As Label
    Friend WithEvents CH3Measure As Label
    Friend WithEvents CH4Measure As Label
    Friend WithEvents CH5Measure As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtTotalCH As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents OvalShape3 As PowerPacks.OvalShape
    Friend WithEvents OvalShape6 As PowerPacks.OvalShape
    Friend WithEvents OvalShape5 As PowerPacks.OvalShape
    Friend WithEvents OvalShape4 As PowerPacks.OvalShape
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents textboxCOM As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents LblBarCode As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BtnConnect As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label27 As Label
    Friend WithEvents modelNam As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents OrderNum As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents WkorderNum As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TxtOpCode As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents LblPASS As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents LblNG As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents Quantity As TextBox
    Friend WithEvents WkStationNam As TextBox
    Friend WithEvents BtnSt As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents BtnAmount As Button
    Friend WithEvents OvalShape7 As PowerPacks.OvalShape
    Friend WithEvents Label39 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label40 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Timer3 As Timer
End Class
