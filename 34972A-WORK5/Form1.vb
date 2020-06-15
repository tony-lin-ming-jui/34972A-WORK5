Imports Agilent.CommandExpert.ScpiNet.Ag3497x_1_13
Imports Microsoft.VisualBasic.PowerPacks
Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text

Public Class Form1
    Dim strSerialRead As String
    Dim laststrSerialRead As String '設定不與上一個條碼相同
    Dim blnRun As Boolean = True
    Dim arrOS(5) As OvalShape '亮燈
    Dim CHMeasure(5) As Label '5個測量值 
    Dim CHMeasures(5) As String '5個測量值 純數字值
    Dim CHMin(5) As TextBox
    Dim CHMax(5) As TextBox
    Dim FilePath As String
    Dim Measuretext, ProductionNum As String      ', ProductTesting
    'Dim y As Integer = 0 '判斷是否有連接電阻 y>0 代表至少有連1個
    Dim NG As Integer = 0
    Dim PASS As Integer = 0
    Dim ngORps As Integer = 0 '如果有NG品就+1,所以當ngORps>0時代表產品未通過
    Dim time As String
    Dim CH1Measures As String '純數字值
    'Dim Keysight34972A As String ' = "USB0::0x0957::0x2007::MY57012679::0::INSTR"
    Dim m_blnTimer1Busy As Boolean = False 'timer遇到msgbox會多抓 寫判斷設定走到False才跑
    'Dim v34972A As Ag3497x = New Ag3497x("34972A")
    Dim scan_list1, scan_list2 As String

    Dim m_wsMesProduction As New ServiceReferenceMesProduction.wsEQPSoapClient
    Dim m_strMesResult As String
    Dim AllInXmlStr As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrOS(0) = OvalShape1
        arrOS(1) = OvalShape2
        arrOS(2) = OvalShape3
        arrOS(3) = OvalShape4
        arrOS(4) = OvalShape5

        CHMeasure(0) = CH1Measure
        CHMeasure(1) = CH2Measure
        CHMeasure(2) = CH3Measure
        CHMeasure(3) = CH4Measure
        CHMeasure(4) = CH5Measure
        CHMin(0) = CH1Min
        CHMin(1) = CH2Min
        CHMin(2) = CH3Min
        CHMin(3) = CH4Min
        CHMin(4) = CH5Min

        CHMax(0) = CH1Max
        CHMax(1) = CH2Max
        CHMax(2) = CH3Max
        CHMax(3) = CH4Max
        CHMax(4) = CH5Max
        Timer1.Enabled = True

        LblTotal.Text = 0
        LblPASS.Text = 0
        LblNG.Text = 0
        BtnMeasure.Enabled = False
        laststrSerialRead = ""
        BtnSt.Enabled = False
        Label42.Text &= My.Application.Info.Version.ToString
    End Sub

    Private Sub TxtFirstCH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFirstCH.KeyPress, TxtLastCH.KeyPress, CH5Max.KeyPress, CH5Min.KeyPress, CH4Min.KeyPress, CH4Max.KeyPress, CH3Min.KeyPress, CH3Max.KeyPress, CH2Min.KeyPress, CH2Max.KeyPress, CH1Min.KeyPress, CH1Max.KeyPress, Quantity.KeyPress
        '只能輸入數字
        If e.KeyChar >= Chr(48) And e.KeyChar <= Chr(57) Or e.KeyChar = Chr(13) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True '取消KeyPress事件
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'Enter控制的地方
        If RadioButton2.Checked Then
            If BtnSt.Text = "結束" Then
                If keyData = Keys.Enter Then
                    'If strSerialRead <> laststrSerialRead Then
                    'MessageBox.Show("You pressed Enter arrow key")
                    'ngORps = 0

                    ButtonMeasure_Click(New Object, New EventArgs)
                    laststrSerialRead = LblBarCode.Text
                    'strSerialRead = ""
                    Return True
                    'ElseIf strSerialRead = "" Then
                    '    ngORps = 0
                    '    ngORps = ngORps + 1

                    '    laststrSerialRead = LblBarCode.Text
                    'Button1_Click(New Object, New EventArgs) '這裡已經寫在判斷裡了所以不用+1
                    'TxtMsg.Text &= "產品條碼未填" & vbNewLine
                    'Label39.Text = "產品測試結果:未通過"
                    'OvalShape7.BackColor = Color.Red
                    'OvalShape7.BorderColor = Color.Red

                    'strSerialRead = ""
                    'Return True
                    'ElseIf strSerialRead = laststrSerialRead Then '與上一個條碼相同
                    'ngORps = 0
                    'ngORps = ngORps + 1

                    'laststrSerialRead = LblBarCode.Text
                    'Button1_Click(New Object, New EventArgs)
                    'strSerialRead = LblBarCode.Text

                    'strSerialRead = ""
                    'Return True
                    'End If
                End If
            End If
            Return MyBase.ProcessCmdKey(msg, keyData)
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim strTemp As String
        strTemp = sp.ReadExisting() '讀到serialporrt的文字'
        ''''''''strTemp = sp.ReadLine()
        If blnRun Then 'and Button1.Text = "Stop"
            '''''''strTemp = sp.ReadExisting()
            strSerialRead = strTemp
            'Else
            'Console.Beep(1000, 500)
            'MsgBox("產品條碼與設定條碼不相同" + vbCrLf + "請點擊解除錯誤警告按鈕解除錯誤", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'FindSerialPort()
        Try
            Dim wmi As Object = GetObject("winmgmts:\\.\root\cimv2")
            Dim devices As Object = wmi.ExecQuery("Select DeviceID, Name from Win32_PnPEntity") '只抓DeviceID和Name
            '測試時抓全部資料要 Select * from Win32_PnPEntity
            Dim strDeviceId As String
            'textboxCOM.Text = "N/A"
            For Each d As Object In devices
                strDeviceId = IIf(IsDBNull(d.DeviceID), "N/A", d.DeviceID)
                If Strings.InStr(strDeviceId, "VID_0C2E&PID_090A") > 0 Then
                    If Strings.InStr(d.Name, "(") > 0 Then
                        Dim rm As MatchCollection
                        rm = Regex.Matches(d.Name, "\b(COM\w+)\b")
                        textboxCOM.Text = rm(0).Value
                    End If
                End If
            Next

        Catch ex As Exception
            'textboxCOM.Text = "N/A"
        End Try
        'SerialPort1.Close()
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Timer1.Enabled = True
        Try
            If BtnConnect.Text = "連線" Then
                BtnConnect.Text = "中斷連線"
                Timer1.Enabled = False
                textboxCOM.Enabled = False
                BtnSt.Enabled = True
                Timer3.Enabled = True
                SerialPort1.Close()

                SerialPort1.PortName = textboxCOM.Text '讀取COMport
                SerialPort1.Open()
                SerialPort1.DiscardInBuffer()
                SerialPort1.DiscardOutBuffer()

                strSerialRead = ""
            Else
                BtnConnect.Text = "連線"
                Timer1.Enabled = True
                SerialPort1.Close()
                LblBarCode.Text = ""
                BtnSt.Enabled = False
                Timer3.Enabled = False
                textboxCOM.Enabled = True
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")  '可以改如果comport錯誤想要輸入的文字  有兩種情況 空白和COM錯誤 先別改這個除非能判斷'
            MsgBox("COM Port 錯誤或未連接設備", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
            BtnConnect.Text = "連線"
            textboxCOM.Enabled = True
            Timer1.Enabled = True
            SerialPort1.Close()
            Timer2.Enabled = False
            Timer3.Enabled = False
            BtnSt.Enabled = False
        End Try
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles BtnSt.Click
        Dim readings As String = Nothing
        'Keysight34972A = "USB0::0x0957::0x2007::" & num34972A.Text & "::0::INSTR"
        Try
            Dim vv34972A As Ag3497x = New Ag3497x("34972A")
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("資料擷取器未連接或製造號碼錯誤", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
            MsureError(0)
            Exit Sub
        End Try
        Dim v34972A As Ag3497x = New Ag3497x("34972A")
        'Dim scan_list1, scan_list2 As String

        TxtMsg.Text = ""
        If BtnSt.Text = "啟動" Then
            BtnSt.Text = "結束"
            strSerialRead = "" '啟動就先清空 就算在啟動前先掃描條碼，我還是把它清掉了 
            SerialPort1.DiscardInBuffer() '這裡暫存也要清
            SerialPort1.DiscardOutBuffer()
            laststrSerialRead = ""
            m_blnTimer1Busy = False
            BtnMeasure.Enabled = True
            For i = 0 To 4
                CHMin(i).Enabled = False
                CHMax(i).Enabled = False
            Next
            TxtFirstCH.Enabled = False
            TxtLastCH.Enabled = False
            modelNam.Enabled = False
            OrderNum.Enabled = False
            WkorderNum.Enabled = False
            Quantity.Enabled = False
            WkStationNam.Enabled = False
            TxtOpCode.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            CheckBox1.Enabled = False
            BtnAmount.Enabled = False
            BtnConnect.Enabled = False


            LblBarCode.Text = ""
            If TxtFirstCH.Text = "" Then
                MsgBox("請輸入First CH", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                MsureError(1)
                Exit Sub
            ElseIf TxtFirstCH.Text < 121 And TxtFirstCH.Text > 100 Or
                TxtFirstCH.Text < 221 And TxtFirstCH.Text > 200 Or
                TxtFirstCH.Text < 321 And TxtFirstCH.Text > 300 Then
                If TxtLastCH.Text = "" Then
                    '單個啟動時的錯誤確認
                    Try

                        Keysight34972A(1)

                    Catch ex As Exception
                        'MsgBox(ex.ToString)
                        MsgBox(TxtFirstCH.Text & " Channel未使用", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                        MsureError(1)
                    End Try
                ElseIf TxtLastCH.Text > TxtFirstCH.Text - 1 And TxtLastCH.Text < 121 Then

                    ChannelUse()
                ElseIf TxtLastCH.Text > TxtFirstCH.Text - 1 And TxtLastCH.Text < 221 And TxtFirstCH.Text > 200 Then

                    ChannelUse()

                ElseIf TxtLastCH.Text > TxtFirstCH.Text - 1 And TxtLastCH.Text < 321 And TxtFirstCH.Text > 300 Then

                    ChannelUse()
                Else
                    MsgBox("錯誤Channel輸入", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                    MsureError(1)
                End If
            Else
                MsgBox("錯誤Channel輸入", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                MsureError(1)
            End If
            If modelNam.Text = "" Or OrderNum.Text = "" Or WkorderNum.Text = "" Or Quantity.Text = "" Or WkStationNam.Text = "" Or TxtOpCode.Text = "" Then
                If modelNam.Text = "" Then
                    TxtMsg.Text &= "機種名稱未填" & vbNewLine
                End If
                If OrderNum.Text = "" Then
                    TxtMsg.Text &= "訂單號碼未填" & vbNewLine
                End If
                If WkorderNum.Text = "" Then
                    TxtMsg.Text &= "工單號碼未填" & vbNewLine
                End If
                If Quantity.Text = "" Then
                    TxtMsg.Text &= "排定生產數量未填" & vbNewLine
                End If
                If WkStationNam.Text = "" Then
                    TxtMsg.Text &= "工作站站名未填" & vbNewLine
                End If
                If TxtOpCode.Text = "" Then
                    TxtMsg.Text &= "作業員代碼未填" & vbNewLine
                End If
                'MsgBox("匯出檔案失敗", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                TxtMsg.Text &= "啟動失敗，請確認表單是否填寫" & vbNewLine
                MsureError(1)
            Else
                '抓資料 抓產品NG和PASS的資料
                Dim Passtotal, NGtotal As Long
                Dim PassFile, NgFile As String
                Dim csvpassdata, csvngdata, Arrp(), Arrn() As String
                Dim srp, srn As StreamReader
                'My.Computer.FileSystem.CreateDirectory("D:\34972A_Measure\" & modelNam.Text)
                PassFile = "D:\34972A_Measure\" & modelNam.Text & "\" & WkorderNum.Text & "_PASS" & ".CSV"
                NgFile = "D:\34972A_Measure\" & modelNam.Text & "\" & WkorderNum.Text & "_NG" & ".CSV"
                If File.Exists(PassFile) = True Then
                    Dim flp As New FileInfo(PassFile)

                    srp = flp.OpenText
                    Do While srp.Peek() >= 0
                        'If sr.Peek() = -1 Then
                        csvpassdata = (srp.ReadLine()) & vbNewLine '迴圈不用& 就只會抓到最後一個值
                        'End If
                    Loop
                    srp.Close()
                    Arrp = Split(csvpassdata, ",")
                    Passtotal = Arrp(10)
                Else
                    Passtotal = 0
                End If

                If File.Exists(NgFile) = True Then
                    Dim fln As New FileInfo(NgFile)

                    srn = fln.OpenText
                    Do While srn.Peek() >= 0
                        'If sr.Peek() = -1 Then
                        csvngdata = (srn.ReadLine()) & vbNewLine '迴圈不用& 就只會抓到最後一個值
                        'End If
                    Loop
                    srn.Close()
                    Arrn = Split(csvngdata, ",")
                    NGtotal = Arrn(10)
                Else
                    NGtotal = 0
                End If

                '抓以生產的總數最大的表示就是最後一筆
                If Passtotal = 0 And NGtotal = 0 Then
                    LblPASS.Text = 0
                    LblNG.Text = 0
                    LblTotal.Text = 0
                ElseIf Passtotal > NGtotal Then
                    LblPASS.Text = Arrp(8)
                    LblNG.Text = Arrp(9)
                    LblTotal.Text = Arrp(10)
                Else
                    LblPASS.Text = Arrn(8)
                    LblNG.Text = Arrn(9)
                    LblTotal.Text = Arrn(10)
                End If

            End If
            Timer3.Enabled = False
            Timer2.Enabled = True '案啟動後判斷資料是否填寫正確，如果正確開啟Timer1
        Else '點結束的時候
            MsureError(1)
            LblBarCode.Text = ""
            For i = 0 To 4
                CHMeasure(i).Text = ""
                arrOS(i).BackColor = Color.FromKnownColor(KnownColor.Control)
                arrOS(i).BorderColor = Color.Black

            Next
            OvalShape6.BackColor = Color.FromKnownColor(KnownColor.Control)
            OvalShape6.BorderColor = Color.Black
            OvalShape7.BackColor = Color.FromKnownColor(KnownColor.Control)
            OvalShape7.BorderColor = Color.Black

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If m_blnTimer1Busy = False Then
            m_blnTimer1Busy = True

            If BtnSt.Text = "結束" Then '測量開始的按鈕是Enable
                If strSerialRead <> "" Then '條碼不是空的 因為條碼是空得timer這裡就不成立 因為每次都有把條碼清掉，所以會等待下次掃描條碼才會觸發這裡
                    If RadioButton1.Checked Then '點選條碼槍掃描即測量這個選項
                        'If strSerialRead <> laststrSerialRead Then '與上一個條碼不相同
                        '    ngORps = 0
                        LblBarCode.Text = strSerialRead
                        LblBarCode.Text = Replace(LblBarCode.Text, vbCr, "")
                        LblBarCode.Text = Replace(LblBarCode.Text, vbLf, "")
                        ButtonMeasure_Click(New Object, New EventArgs)
                        laststrSerialRead = LblBarCode.Text
                        strSerialRead = "" '這裡清掉條碼
                        'Else      '與上一個條碼相同
                        '    ngORps = 0
                        '    ngORps = ngORps + 1
                        '    LblBarCode.Text = strSerialRead
                        '    Button1_Click(New Object, New EventArgs)

                        '    strSerialRead = ""
                        'End If
                    Else
                        LblBarCode.Text = strSerialRead

                    End If
                End If
            End If
            m_blnTimer1Busy = False
        End If

    End Sub

    Private Sub ButtonMeasure_Click(sender As Object, e As EventArgs) Handles BtnMeasure.Click
        Dim readings As String = Nothing
        'In order to use the following driver class, you need to reference this assembly : [C:\ProgramData\Keysight\Command Expert\ScpiNetDrivers\Ag3497x_1_13.dll]

        CH1Measure.Text = ""
        CH2Measure.Text = ""
        CH3Measure.Text = ""
        CH4Measure.Text = ""
        CH5Measure.Text = ""
        OvalShape1.BackColor = Color.FromKnownColor(KnownColor.Control)
        OvalShape1.BorderColor = Color.Black
        OvalShape2.BackColor = Color.FromKnownColor(KnownColor.Control)
        OvalShape2.BorderColor = Color.Black
        OvalShape3.BackColor = Color.FromKnownColor(KnownColor.Control)
        OvalShape3.BorderColor = Color.Black
        OvalShape4.BackColor = Color.FromKnownColor(KnownColor.Control)
        OvalShape4.BorderColor = Color.Black
        OvalShape5.BackColor = Color.FromKnownColor(KnownColor.Control)
        OvalShape5.BorderColor = Color.Black
        OvalShape6.BackColor = Color.FromKnownColor(KnownColor.Control)
        OvalShape6.BorderColor = Color.Black
        OvalShape7.BackColor = Color.FromKnownColor(KnownColor.Control)
        OvalShape7.BorderColor = Color.Black
        Measuretext = ""
        ProductionNum = ""
        'y = 0
        ngORps = 0
        CH1Measures = ""
        'ProductTesting = ""
        Try
            Dim vv34972A As Ag3497x = New Ag3497x("34972A")
        Catch ex As Exception
            MsgBox("資料擷取器未連接或製造號碼錯誤", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
            Exit Sub
        End Try

        Dim v34972A As Ag3497x = New Ag3497x("34972A")
        TxtMsg.Text = ""

        For i = 0 To 4
            CHMin(i).Enabled = False
            CHMax(i).Enabled = False
        Next
        TxtFirstCH.Enabled = False
        TxtLastCH.Enabled = False
        modelNam.Enabled = False
        OrderNum.Enabled = False
        WkorderNum.Enabled = False
        Quantity.Enabled = False
        WkStationNam.Enabled = False
        TxtOpCode.Enabled = False

        If TxtLastCH.Text = "" Then
            'MessageBox.Show("單個")
            TxtTotalCH.Text = ""
            TxtTotalCH.Text = 1
            Try
                scan_list1 = "@" & TxtFirstCH.Text
                v34972A.SCPI.RST.Command()
                v34972A.SCPI.CLS.Command()
                v34972A.SCPI.SYSTem.REMote.Command()
                v34972A.SCPI.CONFigure.RESistance.Command("AUTO", DBNull.Value, scan_list1)
                v34972A.SCPI.ROUTe.SCAN.Command(scan_list1)
                v34972A.SCPI.INITiate.Command()
                v34972A.SCPI.FETCh.QueryAllData(readings)
                'readings = "+1.00109680E+03"
                TxtMsg.Text &= TxtFirstCH.Text & "號" '& CSng(readings) & "Ω"
                If CSng(readings) > 100000000 Then
                    CH1Measure.Text = "測量物未連接"
                    CH1Measures = "測量物未連接"
                    TxtMsg.Text &= CSng(readings) & "Ω" & vbNewLine
                    OvalShape1.BackColor = Color.Red
                    OvalShape1.BorderColor = Color.Red
                    'ProductTesting = "產品測試:未通過"
                    ngORps = ngORps + 1
                ElseIf CSng(readings) > 1000000 Then
                    CH1Measures = CSng(readings)
                    CH1Measure.Text &= Math.Round(CH1Measures / 1000000, 3) & "MΩ" '直接轉浮點數
                    TxtMsg.Text &= CH1Measure.Text & vbNewLine
                    'y = y + 1
                    If CH1Min.Text = "" Or CH1Max.Text = "" Then
                        'MsgBox("請輸入最大最小值", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                        TxtMsg.Text &= "(請輸入最大最小值)" & vbNewLine
                        OvalShape1.BackColor = Color.Red
                        OvalShape1.BorderColor = Color.Red
                        'ProductTesting = "產品測試:未通過"
                        ngORps = ngORps + 1
                    Else
                        If CSng(readings) >= CH1Min.Text And CSng(readings) <= CH1Max.Text Then
                            OvalShape1.BackColor = Color.Green
                            OvalShape1.BorderColor = Color.Green
                            'ProductTesting = "產品測試:通過"
                        Else
                            OvalShape1.BackColor = Color.Red
                            OvalShape1.BorderColor = Color.Red
                            'ProductTesting = "產品測試:未通過"
                            ngORps = ngORps + 1
                        End If
                    End If

                ElseIf CSng(readings) > 1000 Then
                    CH1Measures = CSng(readings)
                    CH1Measure.Text &= Math.Round(CH1Measures / 1000, 3) & "KΩ" '直接轉浮點數
                    TxtMsg.Text &= CH1Measure.Text & vbNewLine
                    'y = y + 1
                    If CH1Min.Text = "" Or CH1Max.Text = "" Then
                        'MsgBox("請輸入最大最小值", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                        TxtMsg.Text &= "(請輸入最大最小值)" & vbNewLine
                        OvalShape1.BackColor = Color.Red
                        OvalShape1.BorderColor = Color.Red
                        'ProductTesting = "產品測試:未通過"
                        ngORps = ngORps + 1
                        'Exit Sub
                    Else
                        If CSng(readings) >= CH1Min.Text And CSng(readings) <= CH1Max.Text Then
                            OvalShape1.BackColor = Color.Green
                            OvalShape1.BorderColor = Color.Green
                            'ProductTesting = "產品測試:通過"
                        Else
                            OvalShape1.BackColor = Color.Red
                            OvalShape1.BorderColor = Color.Red
                            'ProductTesting = "產品測試:未通過"
                            ngORps = ngORps + 1
                        End If
                    End If

                Else
                    CH1Measures = CSng(readings)
                    CH1Measure.Text &= Math.Round(CH1Measures / 1, 3) & "Ω" '直接轉浮點數
                    TxtMsg.Text &= CH1Measure.Text & vbNewLine
                    'y = y + 1
                    If CH1Min.Text = "" Or CH1Max.Text = "" Then
                        'MsgBox("請輸入最大最小值", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                        TxtMsg.Text &= "(請輸入最大最小值)" & vbNewLine
                        OvalShape1.BackColor = Color.Red
                        OvalShape1.BorderColor = Color.Red
                        'ProductTesting = "產品測試:未通過"
                        ngORps = ngORps + 1
                    Else
                        If CSng(readings) >= CH1Min.Text And CSng(readings) <= CH1Max.Text Then
                            OvalShape1.BackColor = Color.Green
                            OvalShape1.BorderColor = Color.Green
                            'ProductTesting = "產品測試:通過"
                        Else
                            OvalShape1.BackColor = Color.Red
                            OvalShape1.BorderColor = Color.Red
                            'ProductTesting = "產品測試:未通過"
                            ngORps = ngORps + 1
                        End If
                        'Exit Sub
                    End If
                End If
                Measuretext &= CH1Max.Text & "," & CH1Min.Text & "," & CH1Measures & "," '& ProductTesting
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox(TxtFirstCH.Text & " Channel未使用", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                For i = 0 To 4
                    CHMin(i).Enabled = True
                    CHMax(i).Enabled = True
                Next
                TxtFirstCH.Enabled = True
                TxtLastCH.Enabled = True
                modelNam.Enabled = True
                OrderNum.Enabled = True
                WkorderNum.Enabled = True
                Quantity.Enabled = True
                WkStationNam.Enabled = True
                TxtOpCode.Enabled = True

            End Try

        Else '(頻道兩個都有填的)
            'Measure()
            Dim a As Char() = New [Char]() {","c}
            scan_list1 = "@" & TxtFirstCH.Text
            scan_list2 = TxtLastCH.Text
            v34972A.SCPI.RST.Command()
            v34972A.SCPI.CLS.Command()
            v34972A.SCPI.SYSTem.REMote.Command()
            v34972A.SCPI.CONFigure.RESistance.Command("AUTO", DBNull.Value, scan_list1 & ":" & scan_list2)
            v34972A.SCPI.ROUTe.SCAN.Command(scan_list1 & ":" & scan_list2)
            v34972A.SCPI.INITiate.Command()
            v34972A.SCPI.FETCh.QueryAllData(readings)
            'readings = "+1.00109680E+03,+1.02072840E+02,+1.24557780E+01"
            Dim x As String() = Split(readings, a)
            TxtMsg.Text = ""
            TxtTotalCH.Text = ""
            TxtTotalCH.Text = TxtLastCH.Text - TxtFirstCH.Text + 1
            For i = 0 To (TxtLastCH.Text - TxtFirstCH.Text)
                TxtMsg.Text &= TxtFirstCH.Text + i & "號" & CSng(x(i)) & "Ω" & vbNewLine
                CHMeasure(i).Text = ""
                CHMeasures(i) = ""
                arrOS(i).BackColor = Color.FromKnownColor(KnownColor.Control)
                arrOS(i).BorderColor = Color.Black

                If CSng(x(i)) > 100000000 Then
                    TxtMsg.Text &= "測量物未連接" & vbNewLine
                    CHMeasure(i).Text = "測量物未連接"
                    CHMeasures(i) = "測量物未連接"
                    arrOS(i).BackColor = Color.Red
                    arrOS(i).BorderColor = Color.Red
                    'ProductTesting = "產品測試:未通過"
                    ngORps = ngORps + 1
                ElseIf CSng(x(i)) > 1000000 Then
                    CHMeasures(i) = CSng(x(i))
                    CHMeasure(i).Text &= Math.Round(CHMeasures(i) / 1000000, 3) & "MΩ" '直接轉浮點數

                    'y = y + 1
                    If CHMin(i).Text = "" Or CHMax(i).Text = "" Then
                        'MsgBox("請輸入最大最小值")
                        TxtMsg.Text &= "(請輸入最大最小值)" & vbNewLine
                        arrOS(i).BackColor = Color.Red
                        arrOS(i).BorderColor = Color.Red
                        'ProductTesting = "產品測試:未通過"
                        ngORps = ngORps + 1
                    Else
                        'TxtMsg.Text &= vbNewLine
                        If CSng(x(i)) >= CHMin(i).Text And CSng(x(i)) <= CHMax(i).Text Then
                            arrOS(i).BackColor = Color.Green
                            arrOS(i).BorderColor = Color.Green
                            'ProductTesting = "產品測試:通過"
                        Else
                            arrOS(i).BackColor = Color.Red
                            arrOS(i).BorderColor = Color.Red
                            'ProductTesting = "產品測試:未通過"
                            ngORps = ngORps + 1
                        End If
                    End If

                ElseIf CSng(x(i)) > 1000 Then
                    CHMeasures(i) = CSng(x(i))
                    CHMeasure(i).Text &= Math.Round(CHMeasures(i) / 1000, 3) & "KΩ" '直接轉浮點數

                    'y = y + 1
                    If CHMin(i).Text = "" Or CHMax(i).Text = "" Then
                        'MsgBox("請輸入最大最小值", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                        TxtMsg.Text &= "(請輸入最大最小值)" & vbNewLine
                        arrOS(i).BackColor = Color.Red
                        arrOS(i).BorderColor = Color.Red

                        ngORps = ngORps + 1
                    Else
                        ' TxtMsg.Text &= vbNewLine
                        If CSng(x(i)) >= CHMin(i).Text And CSng(x(i)) <= CHMax(i).Text Then
                            arrOS(i).BackColor = Color.Green
                            arrOS(i).BorderColor = Color.Green
                        Else
                            arrOS(i).BackColor = Color.Red
                            arrOS(i).BorderColor = Color.Red
                            ngORps = ngORps + 1
                        End If
                    End If
                Else
                    CHMeasures(i) = CSng(x(i))
                    CHMeasure(i).Text = Math.Round(CHMeasures(i) / 1, 3) & "Ω" '直接轉浮點數

                    'y = y + 1
                    If CHMin(i).Text = "" Or CHMax(i).Text = "" Then
                        'MsgBox("請輸入最大最小值", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                        TxtMsg.Text &= "(請輸入最大最小值)" & vbNewLine
                        arrOS(i).BackColor = Color.Red
                        arrOS(i).BorderColor = Color.Red
                        ngORps = ngORps + 1
                    Else
                        'TxtMsg.Text &= vbNewLine
                        If CSng(x(i)) >= CHMin(i).Text And CSng(x(i)) <= CHMax(i).Text Then
                            arrOS(i).BackColor = Color.Green
                            arrOS(i).BorderColor = Color.Green
                        Else
                            arrOS(i).BackColor = Color.Red
                            arrOS(i).BorderColor = Color.Red
                            ngORps = ngORps + 1
                        End If
                    End If
                End If
                Measuretext &= CHMax(i).Text & "," & CHMin(i).Text & "," & CHMeasures(i) & "," ' & ProductTesting & ","

            Next i
        End If

        If LblBarCode.Text = "" Then
            ngORps = ngORps + 1
            OvalShape6.BackColor = Color.Red
            OvalShape6.BorderColor = Color.Red
            TxtMsg.Text &= "產品條碼未填" & vbNewLine
        ElseIf LblBarCode.Text = laststrSerialRead Then
            'ngORps = ngORps + 1 '條碼沒更新也給過
            TxtMsg.Text &= "產品條碼未更新" & vbNewLine
            OvalShape6.BackColor = Color.Green
            OvalShape6.BorderColor = Color.Green
        Else
            OvalShape6.BackColor = Color.Green
            OvalShape6.BorderColor = Color.Green
        End If

        Label36.Text = "上次產品測量時間: " & time
        time = Now.ToString("yyyy-MM-dd HH:mm:ss")
        Label38.Text = "本次產品測量時間: " & time

        Try
            If ngORps > 0 Then         'NG的CSV檔
                LblNG.Text = Int(LblNG.Text) + 1
                'ProductTesting = "未通過"
                Label39.Text = "產品測試結果:未通過"
                OvalShape7.BackColor = Color.Red
                OvalShape7.BorderColor = Color.Red
                If CheckBox1.Checked Then
                    '上傳NG到MES
                    Dim strMesResponse As String
                    strMesResponse = mesTestTESTUniCheckOut(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text, "Ng")
                    If strMesResponse <> "OK" Then
                        MsgBox("MES發生錯誤，請排除錯誤再重新啟動" & strMesResponse)
                        MsureError(0)
                    End If
                End If

                    MyWriteFile(0)

            Else      'PASS的CSV檔
                LblPASS.Text = Int(LblPASS.Text) + 1
                'ProductTesting = "通過"
                Label39.Text = "產品測試結果:通過"
                OvalShape7.BackColor = Color.Green
                OvalShape7.BorderColor = Color.Green

                If CheckBox1.Checked Then
                    Dim strMesResponse As String
                    strMesResponse = mesTestTESTUniCheckOut(TxtOpCode.Text, "0", WkStationNam.Text, WkorderNum.Text, LblBarCode.Text, "Pass")
                    If strMesResponse <> "OK" Then
                        MsgBox("MES發生錯誤，請排除錯誤再重新啟動" & strMesResponse)
                        MsureError(0)
                    End If
                End If

                MyWriteFile(1)
            End If


            If Quantity.Text = LblTotal.Text Then
                'TxtMsg.Text &= "提醒您已達工單排定生產數量" & vbNewLine
                MsgBox("提醒您已達工單排定生產數量", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "提醒")
                'Exit Sub
            End If
        Catch ex As Exception

            'MsgBox(ex.ToString)
            TxtMsg.Text &= "請關閉CSV檔，在進行測量"
            ngORps = ngORps + 1

            LblNG.Text = Int(LblNG.Text) - 1

            LblBarCode.Text = "請關閉CSV檔在進行測量"
            laststrSerialRead = ""
            If ngORps > 0 Then
                LblNG.Text = Int(LblNG.Text) + 1
                'ProductTesting = "未通過"
                Label39.Text = "產品測試結果:未通過"
                OvalShape7.BackColor = Color.Red
                OvalShape7.BorderColor = Color.Red
            Else
                LblPASS.Text = Int(LblPASS.Text) + 1
                'ProductTesting = "通過"
                Label39.Text = "產品測試結果:通過"
                OvalShape7.BackColor = Color.Green
                OvalShape7.BorderColor = Color.Green
            End If
            LblTotal.Text = Int(LblNG.Text) + Int(LblPASS.Text)
            If Quantity.Text = LblTotal.Text Then
                'TxtMsg.Text &= "提醒您已達工單排定生產數量" & vbNewLine
                MsgBox("提醒您已達工單排定生產數量", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "提醒")
                'Exit Sub
            End If
        End Try
    End Sub

    Private Sub ButtonZero_Click(sender As Object, e As EventArgs) Handles BtnAmount.Click
        '數量歸0
        LblNG.Text = 0
        LblPASS.Text = 0
        LblTotal.Text = Int(LblNG.Text) + Int(LblPASS.Text)
    End Sub

    Sub MsureError(BtnA As Integer)
        For i = 0 To 4
            CHMin(i).Enabled = True
            CHMax(i).Enabled = True
        Next
        Timer3.Enabled = True
        TxtFirstCH.Enabled = True
        TxtLastCH.Enabled = True
        modelNam.Enabled = True
        OrderNum.Enabled = True
        WkorderNum.Enabled = True
        Quantity.Enabled = True
        WkStationNam.Enabled = True
        TxtOpCode.Enabled = True
        BtnMeasure.Enabled = False
        BtnSt.Text = "啟動"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        CheckBox1.Enabled = True
        BtnConnect.Enabled = True
        Label39.Text = "產品測試結果:"
        If BtnA = 1 Then
            BtnAmount.Enabled = True
        End If
    End Sub

    Sub ChannelUse()
        If TxtLastCH.Text - TxtFirstCH.Text > 4 Then
            MsgBox("最多只能測量5個")
            MsureError(1)
            TxtTotalCH.Text = ""
            Exit Sub
        Else
            Try
                Keysight34972A(2)
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox(TxtFirstCH.Text & " Channel未使用", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                MsureError(1)
            End Try
            'MsgBox("正確CH 第一排")
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If BtnSt.Text = "啟動" Then
            If strSerialRead <> "" Then
                TxtOpCode.Text = strSerialRead
                strSerialRead = ""
            End If
        End If
    End Sub

    Sub Keysight34972A(MyChannel As Integer)
        Dim v34972A As Ag3497x = New Ag3497x("34972A")
        If MyChannel = 1 Then
            TxtTotalCH.Text = ""
            TxtTotalCH.Text = 1
            scan_list1 = "@" & TxtFirstCH.Text
            v34972A.SCPI.RST.Command()
            v34972A.SCPI.CLS.Command()
            v34972A.SCPI.SYSTem.REMote.Command()
            v34972A.SCPI.CONFigure.RESistance.Command("AUTO", DBNull.Value, scan_list1)
        ElseIf MyChannel = 2 Then
            TxtTotalCH.Text = ""
            TxtTotalCH.Text = TxtLastCH.Text - TxtFirstCH.Text + 1
            scan_list1 = "@" & TxtFirstCH.Text
            scan_list2 = TxtLastCH.Text
            v34972A.SCPI.RST.Command()
            v34972A.SCPI.CLS.Command()
            v34972A.SCPI.SYSTem.REMote.Command()
            v34972A.SCPI.CONFigure.RESistance.Command("AUTO", DBNull.Value, scan_list1 & ":" & scan_list2)
        End If
    End Sub

    Sub MyWriteFile(WtF As Integer)
        LblTotal.Text = Int(LblNG.Text) + Int(LblPASS.Text)
        My.Computer.FileSystem.CreateDirectory("D:\34972A_Measure\" & modelNam.Text)
        If WtF = 1 Then

            FilePath = "D:\34972A_Measure\" & modelNam.Text & "\" & WkorderNum.Text & "_PASS" & ".CSV"
        ElseIf WtF = 0 Then
            FilePath = "D:\34972A_Measure\" & modelNam.Text & "\" & WkorderNum.Text & "_NG" & ".CSV"
        End If

        If File.Exists(FilePath) = True Then
            Using fs As IO.FileStream = New IO.FileStream(FilePath, FileMode.Append)
                Using sw As StreamWriter = New StreamWriter(fs, Encoding.Default)

                    ' sw.Write(str)   '第一行
                    ProductionNum &= time & "," & "=" & Chr(34) & modelNam.Text & Chr(34) & "," & "=" & Chr(34) & OrderNum.Text & Chr(34) &
                        "," & "=" & Chr(34) & WkorderNum.Text & Chr(34) & "," & Quantity.Text &
                        "," & "=" & Chr(34) & WkStationNam.Text & Chr(34) & "," & "=" & Chr(34) & TxtOpCode.Text & Chr(34) &
                        "," & "=" & Chr(34) & LblBarCode.Text & Chr(34) & "," & LblPASS.Text & "," & LblNG.Text &
                        "," & LblTotal.Text & ","
                    sw.WriteLine(ProductionNum & Measuretext) ' & ProductTesting)   '插入一整行
                    sw.Flush()
                    sw.Close()
                End Using
            End Using
        Else
            My.Computer.FileSystem.CreateDirectory("D:\34972A_Measure\" & modelNam.Text)
            Using fs As IO.FileStream = New IO.FileStream(FilePath, FileMode.Append)
                Using sw As StreamWriter = New StreamWriter(fs, Encoding.Default)
                    sw.WriteLine("時間日期,機種名稱,訂單編號,工單號碼,工單排定生產數量,工作站站名,作業員代碼,產品條碼,PASS總數,NG總數,已生產總數," &
                     "CH1電阻最大值(Ω),CH1電阻最小值(Ω),CH1電阻測量值(Ω),CH2電阻最大值(Ω),CH2電阻最小值(Ω),CH2電阻測量值(Ω)," &
                     "CH3電阻最大值(Ω),CH3電阻最小值(Ω),CH3電阻測量值(Ω),CH4電阻最大值(Ω),CH4電阻最小值(Ω),CH4電阻測量值(Ω)," &
                     "CH5電阻最大值(Ω),CH5電阻最小值(Ω),CH5電阻測量值(Ω)")


                    ProductionNum &= time & "," & "=" & Chr(34) & modelNam.Text & Chr(34) & "," & "=" & Chr(34) & OrderNum.Text & Chr(34) &
"," & "=" & Chr(34) & WkorderNum.Text & Chr(34) & "," & Quantity.Text &
"," & "=" & Chr(34) & WkStationNam.Text & Chr(34) & "," & "=" & Chr(34) & TxtOpCode.Text & Chr(34) &
"," & "=" & Chr(34) & LblBarCode.Text & Chr(34) & "," & LblPASS.Text & "," & LblNG.Text &
"," & LblTotal.Text & ","
                    sw.WriteLine(ProductionNum & Measuretext) ' & ProductTesting)   '插入一整行
                    sw.Flush()
                    sw.Close()
                End Using
            End Using
        End If
    End Sub
    Private Function mesProductionTestDBConnection() As Boolean
        Dim responseStr As String
        responseStr = m_wsMesProduction.TestDBConnection("iMES")
        If responseStr = "Test successfully, UserName:IMES, DataBase is oracle !" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function mesTestTESTUniCheckOut(usernoStr As String, curusernoStr As String, opnoStr As String, monoStr As String, lotnoStr As String, resultStr As String) As String
        Dim InXmlStr, responseStr As String
        InXmlStr = My.Resources.InXmlTemplateString
        InXmlStr = Replace(InXmlStr, "transactionidReplace", Now.Millisecond.ToString)
        InXmlStr = Replace(InXmlStr, "moduleidReplace", "請改自己模組名稱縮寫")
        InXmlStr = Replace(InXmlStr, "functionidReplace", "mesTestTESTUniCheckOut")
        InXmlStr = Replace(InXmlStr, "computernameReplace", My.Computer.Name)
        InXmlStr = Replace(InXmlStr, "curusernoReplace", curusernoStr)
        InXmlStr = Replace(InXmlStr, "sendtimeReplace", Format(Now, "yyyy-MM-dd HH:mm:ss"))
        InXmlStr = Replace(InXmlStr, "languagemodeReplace", "zh-CHT")
        InXmlStr = Replace(InXmlStr, "usernoReplace", usernoStr)
        InXmlStr = Replace(InXmlStr, "equitmentnoReplace", "")
        InXmlStr = Replace(InXmlStr, "monoReplace", monoStr)
        InXmlStr = Replace(InXmlStr, "opnoReplace", opnoStr)
        InXmlStr = Replace(InXmlStr, "lotnoReplace", lotnoStr)
        InXmlStr = Replace(InXmlStr, "resultReplace", resultStr)
        responseStr = m_wsMesProduction.wsTESTUniCheckOut(InXmlStr)
        If InStr(responseStr, "<result>success</result>") > 0 Then
            Return "OK"
        Else
            Return responseStr
        End If
    End Function
End Class
