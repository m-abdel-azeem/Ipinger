Public Class IPinger_Main
    Dim OldHeight As Integer
    Dim OldWidth As Integer
    Dim ImportFileName As String
    Dim SaveFileName As String
    Dim MouseOverOnline As Boolean
    Dim MouseOverOffline As Boolean
    Dim MouseOverList As Boolean
    Dim SaveIPListFileName As String

    'GET TITLE BAR HEIGHT
    Dim TitleBarHeight As Integer = RectangleToScreen(Me.ClientRectangle).Top - (Me.Top)

    Private Sub IPinger_Main_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Get The Initial Hieght and Width.
        OldHeight = Me.Height
        OldWidth = Me.Width
        lbl_online.Text = ""
        lbl_offline.Text = ""
        lbl_invalid.Text = ""
        Control.CheckForIllegalCrossThreadCalls = False

    End Sub


    Private Sub IPinger_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        'Dim RatioWidth As Double = (Me.Width - OldWidth) / OldWidth
        'Dim RatioHeight As Double = (Me.Height - OldHeight) / OldHeight

        'For Each Ctrl As Control In Controls
        '    Ctrl.Width += CInt(Ctrl.Width * RatioWidth)
        '    Ctrl.Left += CInt(Ctrl.Left * RatioWidth)
        '    Ctrl.Height += CInt(Ctrl.Height * RatioHeight)
        '    Ctrl.Top += CInt(Ctrl.Top * RatioHeight)
        'Next

        'OldWidth = Me.Width
        'OldHeight = Me.Height


    End Sub

    Private Sub ADDIP_btn_Click(sender As Object, e As EventArgs) Handles ADDIP_btn.Click
        If tbox_IPAddress.Text <> "" Then lst_List_IPs.Items.Add(tbox_IPAddress.Text)
        UpdateCount("list")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartTesting_btn.Click
        lbl_working.Visible = True
        If Not BackgroundWorkerTest.IsBusy Then BackgroundWorkerTest.RunWorkerAsync()

    End Sub

    Private Sub ImportTXT_btn_Click(sender As Object, e As EventArgs) Handles ImportTXT_btn.Click

        Dim dDialog As New OpenFileDialog
        With dDialog
            .Title = "Open text file."
            .Filter = "Text Files|*.txt"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        End With

        If dDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            lst_OFFline_IPs.Items.Clear()
            lst_ONline_IPs.Items.Clear()
            lst_Invalid_IPs.Items.Clear()
            lbl_online.Text = ""
            lbl_offline.Text = ""
            lbl_invalid.Text = ""
            No_Offline_Address = 0
            No_ONline_Address = 0
            ReDim vAlidAddresses(0, 2)

            ImportFileName = dDialog.FileName

            If Not BackgroundWorkerImport.IsBusy Then BackgroundWorkerImport.RunWorkerAsync()

        Else
            ToolStripStatusLabel1.ForeColor = Color.Black
            ToolStripStatusLabel2.ForeColor = Color.Black
            ToolStripStatusLabel1.Text = "Ready..."
            ToolStripStatusLabel2.Text = ""
            Return
        End If

    End Sub


    Private Sub ClearResults_btn_Click(sender As Object, e As EventArgs) Handles ClearResults_btn.Click
        ToolStripStatusLabel1.Text = "Clearing results."
        lst_OFFline_IPs.Items.Clear()
        lst_ONline_IPs.Items.Clear()
        lst_Invalid_IPs.Items.Clear()
        ToolStripStatusLabel1.Text = "Ready..."
        lbl_online.Text = ""
        lbl_offline.Text = ""
        lbl_invalid.Text = ""
        No_Offline_Address = 0
        No_ONline_Address = 0
        ReDim vAlidAddresses(0, 2)
        btn_SaveResults.Enabled = False
        SaveResultsToolStripMenuItem.Enabled = False
    End Sub

    Private Sub tbox_IPAddress_TextChanged(sender As Object, e As EventArgs) Handles tbox_IPAddress.TextChanged
        If tbox_IPAddress.Text <> "" Then
            ADDIP_btn.Enabled = True
            AddAddressToolStripMenuItem.Enabled = True
        Else
            ADDIP_btn.Enabled = False
            AddAddressToolStripMenuItem.Enabled = False
        End If
    End Sub

    'Private Sub ShowProgressInfo(ShowProgressInfo As Boolean, Optional MessageText As String = "Testing In Progress .... Please Wait ....")
    '    If ShowProgressInfo Then
    '        lbl_working.Visible = True
    '    Else
    '        lbl_working.Visible = False
    '    End If
    'End Sub

    Private Sub DisableEnableBtns(DoIt As Boolean)
        If DoIt Then
            ADDIP_btn.Enabled = False
            ImportTXT_btn.Enabled = False
            ClearResults_btn.Enabled = False
            StartTesting_btn.Enabled = False
            btn_SaveResults.Enabled = False
            AddAddressToolStripMenuItem.Enabled = False
            ImportFromTextFileToolStripMenuItem.Enabled = False
            ClearResultsToolStripMenuItem.Enabled = False
            StartTestingToolStripMenuItem.Enabled = False
            SaveResultsToolStripMenuItem.Enabled = False
        Else
            'ADDIP_btn.Enabled = True
            ImportTXT_btn.Enabled = True
            ClearResults_btn.Enabled = True
            StartTesting_btn.Enabled = True
            btn_SaveResults.Enabled = True
            ImportFromTextFileToolStripMenuItem.Enabled = True
            ClearResultsToolStripMenuItem.Enabled = True
            StartTestingToolStripMenuItem.Enabled = True
            SaveResultsToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub BackgroundWorkerImport_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerImport.DoWork

        DisableEnableBtns(True)

        ToolStripStatusLabel1.ForeColor = Color.Blue
        ToolStripStatusLabel1.Text = "Importing data."
        ToolStripStatusLabel2.ForeColor = Color.Red
        ToolStripStatusLabel2.Text = "Please wait..."
        lst_List_IPs.Items.Clear()

        Dim objReader As New System.IO.StreamReader(ImportFileName)
            Do While objReader.Peek <> -1
                lst_List_IPs.Items.Add(objReader.ReadLine())
                UpdateCount("list")
            Loop

        DisableEnableBtns(False)
        btn_SaveResults.Enabled = False
        SaveResultsToolStripMenuItem.Enabled = False

        ToolStripStatusLabel1.ForeColor = Color.Black
        ToolStripStatusLabel2.ForeColor = Color.Black
        ToolStripStatusLabel1.Text = "Ready..."
        ToolStripStatusLabel2.Text = ""

    End Sub

    Private Sub BackgroundWorkerTest_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerTest.DoWork

        'Dim InValidCount As Integer = 0

        'STORE SCAN ADDRESSES LIST
        Array.Resize(sCANAddresslist, lst_List_IPs.Items.Count)
        For i = 0 To lst_List_IPs.Items.Count - 1
            sCANAddresslist(i) = lst_List_IPs.Items(i).ToString
        Next

        'DISABLE BUTTONS
        DisableEnableBtns(True)
        'CLEARING RESULTS
        ToolStripStatusLabel1.Text = "Clearing old results."
        lst_OFFline_IPs.Items.Clear()
        lst_ONline_IPs.Items.Clear()
        lst_Invalid_IPs.Items.Clear()
        lbl_online.Text = ""
        lbl_offline.Text = ""
        lbl_invalid.Text = ""
        No_Offline_Address = 0
        No_ONline_Address = 0
        ReDim vAlidAddresses(0, 2)
        ToolStripStatusLabel1.Text = "Ready..."

        'Dim wronglist(0) As String

        If lst_List_IPs.Items.Count > 0 Then
            'Array.Resize(wronglist, lst_List_IPs.Items.Count)
            ReDim vAlidAddresses(lst_List_IPs.Items.Count - 1, 2)

            For i = 0 To lst_List_IPs.Items.Count - 1

                ToolStripStatusLabel1.ForeColor = Color.Blue
                ToolStripStatusLabel1.Text = "Checking availability of " + lst_List_IPs.Items(i).ToString
                ToolStripStatusLabel2.Text = ""
                Try
                    If My.Computer.Network.Ping(lst_List_IPs.Items(i).ToString) Then
                        ToolStripStatusLabel2.ForeColor = Color.Green
                        ToolStripStatusLabel2.Text = lst_List_IPs.Items(i).ToString + " is available."
                        lst_ONline_IPs.Items.Add(lst_List_IPs.Items(i).ToString)
                        UpdateCount("online")
                        vAlidAddresses(i, 1) = lst_List_IPs.Items(i).ToString
                        vAlidAddresses(i, 2) = "ONLINE"
                    Else
                        ToolStripStatusLabel2.ForeColor = Color.Red
                        ToolStripStatusLabel2.Text = lst_List_IPs.Items(i).ToString + " is not available."
                        lst_OFFline_IPs.Items.Add(lst_List_IPs.Items(i).ToString)
                        UpdateCount("offline")
                        vAlidAddresses(i, 1) = lst_List_IPs.Items(i).ToString
                        vAlidAddresses(i, 2) = "OFFLINE"
                    End If
                    vAlidAddresses(i, 0) = CStr(i)
                    'wronglist(i) = lst_List_IPs.Items(i).ToString

                Catch ex As Exception
                    'wronglist(i) = ""
                    'InValidCount = InValidCount + 1
                    ToolStripStatusLabel2.ForeColor = Color.Red
                    ToolStripStatusLabel2.Text = lst_List_IPs.Items(i).ToString + " is invalid."
                    lst_Invalid_IPs.Items.Add(lst_List_IPs.Items(i).ToString)
                    UpdateCount("invalid")
                    vAlidAddresses(i, 1) = lst_List_IPs.Items(i).ToString
                    vAlidAddresses(i, 2) = "INVALID"
                End Try
                Threading.Thread.Sleep(100)
            Next

            'For Each elmnt In wronglist
            '    If elmnt <> "" Then
            '        lst_List_IPs.Items.Remove(elmnt)
            '        UpdateCount("list")
            '    End If
            'Next
        Else
            MsgBox("Please add some IPs to test and try again.", MsgBoxStyle.Exclamation, "No IPs")
        End If

        DisableEnableBtns(False)
        ADDIP_btn.Enabled = True
        AddAddressToolStripMenuItem.Enabled = True
        ToolStripStatusLabel1.ForeColor = Color.Black
        ToolStripStatusLabel1.Text = "Ready..."

        If lst_Invalid_IPs.Items.Count > 0 Then
            If lst_ONline_IPs.Items.Count = 0 And lst_OFFline_IPs.Items.Count = 0 Then
                ToolStripStatusLabel2.ForeColor = Color.Red
                ToolStripStatusLabel2.Text = "Check your network connectivity."
            End If
            ToolStripStatusLabel2.ForeColor = Color.Red
            ToolStripStatusLabel2.Text = "Some addresses are not valid."
        Else
            ToolStripStatusLabel2.ForeColor = Color.Black
            ToolStripStatusLabel2.Text = ""
        End If

        No_ONline_Address = lst_ONline_IPs.Items.Count
        No_Offline_Address = lst_OFFline_IPs.Items.Count
        'InvalidCountNo = InValidCount

        lbl_working.Visible = False

        'Dim rrrr As New LiveDisplay
        'rrrr.ShowDialog(Me)
    End Sub

    Private Sub UpdateCount(which As String)
        Select Case which
            Case "list"
                lbl_scan_count.Text = "Addresses Count: " + CStr(lst_List_IPs.Items.Count)
            Case "online"
                lbl_online.Text = "Online Addresses : " + CStr(lst_ONline_IPs.Items.Count)
            Case "offline"
                lbl_offline.Text = "Offline Addresses : " + CStr(lst_OFFline_IPs.Items.Count)
            Case "invalid"
                lbl_invalid.Text = "Invalid Addresses : " + CStr(lst_Invalid_IPs.Items.Count)
        End Select
    End Sub

    Private Sub AddToAddressListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToAddressListToolStripMenuItem.Click
        If Not BackgroundWorkerTest.IsBusy Then
            If lst_ONline_IPs.Focused Then
                Dim arr()
                Array.Resize(arr, lst_ONline_IPs.SelectedItems.Count)
                For i = 0 To lst_ONline_IPs.SelectedItems.Count - 1
                    arr(i) = lst_ONline_IPs.SelectedItems(i).ToString
                Next
                For Each itm In arr
                    lst_List_IPs.Items.Add(itm)
                Next
                lst_ONline_IPs.SelectedItem = Nothing
            End If
            If lst_OFFline_IPs.Focused Then
                Dim arr()
                Array.Resize(arr, lst_OFFline_IPs.SelectedItems.Count)
                For i = 0 To lst_OFFline_IPs.SelectedItems.Count - 1
                    arr(i) = lst_OFFline_IPs.SelectedItems(i).ToString
                Next
                For Each itm In arr
                    lst_List_IPs.Items.Add(itm)
                Next
                lst_OFFline_IPs.SelectedItem = Nothing
            End If
            UpdateCount("list")
        End If
    End Sub


    Private Sub DeleteSelectedAddressToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteSelectedAddressToolStripMenuItem1.Click
        If Not BackgroundWorkerTest.IsBusy Then
            If lst_List_IPs.Focused Then
                'lst_List_IPs.Items.Remove(lst_List_IPs.SelectedItems)
                Dim arr()
                Array.Resize(arr, lst_List_IPs.SelectedItems.Count)
                For i = 0 To lst_List_IPs.SelectedItems.Count - 1
                    arr(i) = lst_List_IPs.SelectedItems(i).ToString
                Next

                For Each itm In arr
                    lst_List_IPs.Items.Remove(itm)
                Next
                lst_List_IPs.SelectedItem = Nothing
            End If
            UpdateCount("list")
        End If
    End Sub


    Private Sub lst_List_IPs_DragDrop(sender As Object, e As DragEventArgs) Handles lst_List_IPs.DragDrop

        lst_OFFline_IPs.Items.Clear()
        lst_ONline_IPs.Items.Clear()
        lbl_online.Text = ""
        lbl_offline.Text = ""
        lbl_invalid.Text = ""
        No_Offline_Address = 0
        No_ONline_Address = 0
        ReDim vAlidAddresses(0, 2)

        If Not BackgroundWorkerImport.IsBusy Then BackgroundWorkerImport.RunWorkerAsync()

    End Sub

    Private Sub lst_List_IPs_DragEnter(sender As Object, e As DragEventArgs) Handles lst_List_IPs.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)

            If IO.Path.GetExtension(files(0)) = ".txt" Then

                e.Effect = DragDropEffects.Copy
                ImportFileName = files(0)

            Else
                e.Effect = DragDropEffects.None
            End If
        Else

        End If

    End Sub

    Private Sub btn_SaveResults_Click(sender As Object, e As EventArgs) Handles btn_SaveResults.Click

        Dim dDailaog As New SaveFileDialog
        With dDailaog
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            .FileName = "IPingerReport " + CStr(Now).Replace("/", "-").Replace(":", "_")
            .Filter = "Text Files|*.txt"
        End With


        If dDailaog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SaveFileName = dDailaog.FileName
            BackgroundWorkerSave.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorkerSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSave.DoWork

        Dim Results As String
        Results = vbNewLine + " ***************************************************" + vbNewLine
        Results = Results + " ****                                           ****" + vbNewLine
        Results = Results + " ****              IPinger Results              ****" + vbNewLine
        Results = Results + " ****                                           ****" + vbNewLine
        Results = Results + " ****  Online Address:" + lst_ONline_IPs.Items.Count.ToString
        For i = 1 To (26 - CStr(lst_ONline_IPs.Items.Count).Length)
            Results = Results + " "
        Next
        Results = Results + "****" + vbNewLine
        Results = Results + " ****  Offline Address:" + lst_OFFline_IPs.Items.Count.ToString
        For i = 1 To (25 - CStr(lst_OFFline_IPs.Items.Count).Length)
            Results = Results + " "
        Next
        Results = Results + "****" + vbNewLine
        Results = Results + " ****  Invalid Address:" + lst_Invalid_IPs.Items.Count.ToString
        For i = 1 To (25 - CStr(lst_Invalid_IPs.Items.Count).Length)
            Results = Results + " "
        Next
        Results = Results + "****" + vbNewLine
        Results = Results + " ****                                           ****" + vbNewLine
        Results = Results + " ***************************************************" + vbNewLine
        Results = Results + vbNewLine
        Results = Results + " ---------------------------------------------------" + vbNewLine
        Results = Results + " |                Online Addresses:                |" + vbNewLine
        Results = Results + " ---------------------------------------------------" + vbNewLine

        If (lst_ONline_IPs.Items.Count \ 2 > 0) Then
            For i = 0 To lst_ONline_IPs.Items.Count - 2 Step 2
                Results = Results + " " + lst_ONline_IPs.Items(i) + "          " + lst_ONline_IPs.Items(i + 1) + vbNewLine
            Next
            Results = Results + " " + lst_ONline_IPs.Items(lst_ONline_IPs.Items.Count - 1) + vbNewLine
        Else
            For i = 0 To lst_ONline_IPs.Items.Count - 2 Step 2
                Results = Results + " " + lst_ONline_IPs.Items(i) + "          " + lst_ONline_IPs.Items(i + 1) + vbNewLine
            Next
        End If

        Results = Results + vbNewLine
        Results = Results + " ---------------------------------------------------" + vbNewLine
        Results = Results + " |                Offline Addresses:               |" + vbNewLine
        Results = Results + " ---------------------------------------------------" + vbNewLine

        If (lst_OFFline_IPs.Items.Count \ 2 > 0) Then
            For i = 0 To lst_OFFline_IPs.Items.Count - 2 Step 2
                Results = Results + " " + lst_OFFline_IPs.Items(i) + "          " + lst_OFFline_IPs.Items(i + 1) + vbNewLine
            Next
            Results = Results + " " + lst_OFFline_IPs.Items(lst_OFFline_IPs.Items.Count - 1) + vbNewLine
        Else
            For i = 0 To lst_OFFline_IPs.Items.Count - 2 Step 2
                Results = Results + " " + lst_OFFline_IPs.Items(i) + "          " + lst_OFFline_IPs.Items(i + 1) + vbNewLine
            Next
        End If

        Results = Results + vbNewLine
        Results = Results + " ---------------------------------------------------" + vbNewLine
        Results = Results + " |                Invalid Addresses:               |" + vbNewLine
        Results = Results + " ---------------------------------------------------" + vbNewLine

        If (lst_Invalid_IPs.Items.Count \ 2 > 0) Then
            For i = 0 To lst_Invalid_IPs.Items.Count - 2 Step 2
                Results = Results + " " + lst_Invalid_IPs.Items(i) + "          " + lst_Invalid_IPs.Items(i + 1) + vbNewLine
            Next
            Results = Results + " " + lst_Invalid_IPs.Items(lst_Invalid_IPs.Items.Count - 1) + vbNewLine
        Else
            For i = 0 To lst_Invalid_IPs.Items.Count - 2 Step 2
                Results = Results + " " + lst_Invalid_IPs.Items(i) + "          " + lst_Invalid_IPs.Items(i + 1) + vbNewLine
            Next
        End If



        DisableEnableBtns(True)

        ToolStripStatusLabel1.ForeColor = Color.Blue
        ToolStripStatusLabel1.Text = "Saving results."
        ToolStripStatusLabel2.ForeColor = Color.Red
        ToolStripStatusLabel2.Text = "Please wait..."

        Dim objWriter As New System.IO.StreamWriter(SaveFileName)

        objWriter.Write(Results)
        objWriter.Close()

        DisableEnableBtns(False)
        ADDIP_btn.Enabled = True
        AddAddressToolStripMenuItem.Enabled = True

        ToolStripStatusLabel1.ForeColor = Color.Black
        ToolStripStatusLabel2.ForeColor = Color.Black
        ToolStripStatusLabel1.Text = "Ready..."
        ToolStripStatusLabel2.Text = ""

        Process.Start(SaveFileName)

    End Sub

    Private Sub AddAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAddressToolStripMenuItem.Click
        If tbox_IPAddress.Text <> "" Then lst_List_IPs.Items.Add(tbox_IPAddress.Text)
        UpdateCount("list")
    End Sub

    Private Sub ImportFromTextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFromTextFileToolStripMenuItem.Click

        Dim dDialog As New OpenFileDialog
        With dDialog
            .Title = "Open text file."
            .Filter = "Text Files|*.txt"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        End With

        If dDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            lst_OFFline_IPs.Items.Clear()
            lst_ONline_IPs.Items.Clear()
            lst_Invalid_IPs.Items.Clear()
            lbl_online.Text = ""
            lbl_offline.Text = ""
            lbl_invalid.Text = ""
            No_Offline_Address = 0
            No_ONline_Address = 0
            ReDim vAlidAddresses(0, 2)

            ImportFileName = dDialog.FileName

            If Not BackgroundWorkerImport.IsBusy Then BackgroundWorkerImport.RunWorkerAsync()

        Else
            ToolStripStatusLabel1.ForeColor = Color.Black
            ToolStripStatusLabel2.ForeColor = Color.Black
            ToolStripStatusLabel1.Text = "Ready..."
            ToolStripStatusLabel2.Text = ""
            Return
        End If
    End Sub

    Private Sub StartTestingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartTestingToolStripMenuItem.Click
        lbl_working.Visible = True
        If Not BackgroundWorkerTest.IsBusy Then BackgroundWorkerTest.RunWorkerAsync()
    End Sub

    Private Sub SaveResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveResultsToolStripMenuItem.Click
        Dim dDailaog As New SaveFileDialog
        With dDailaog
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            .FileName = "IPingerReport " + CStr(Now).Replace("/", "-").Replace(":", "_")
            .Filter = "Text Files|*.txt"
        End With


        If dDailaog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SaveFileName = dDailaog.FileName
            BackgroundWorkerSave.RunWorkerAsync()
        End If
    End Sub

    Private Sub ClearResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearResultsToolStripMenuItem.Click
        ToolStripStatusLabel1.Text = "Clearing results."
        lst_OFFline_IPs.Items.Clear()
        lst_ONline_IPs.Items.Clear()
        lst_Invalid_IPs.Items.Clear()
        ToolStripStatusLabel1.Text = "Ready..."
        lbl_online.Text = ""
        lbl_offline.Text = ""
        lbl_invalid.Text = ""
        No_Offline_Address = 0
        No_ONline_Address = 0
        ReDim vAlidAddresses(0, 2)
        btn_SaveResults.Enabled = False
    End Sub

    Public Sub UpdateDataFromLive(AddTowhat As String, Address As String)
        If AddTowhat = "Online" Then
            lst_OFFline_IPs.Items.Remove(Address)
            lst_ONline_IPs.Items.Add(Address)
        ElseIf AddTowhat = "Offline" Then
            lst_ONline_IPs.Items.Remove(Address)
            lst_OFFline_IPs.Items.Add(Address)
        End If
    End Sub

    Private Sub menu_addaddresslist_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menu_addaddresslist.Opening

        If MouseOverOnline Then
            Dim ix As Integer = CInt(((MousePosition.Y - Me.Location.Y - lst_ONline_IPs.Location.Y - TitleBarHeight) / lst_ONline_IPs.ItemHeight) + 0.49)
            If lst_ONline_IPs.Items.Count >= ix Then
                If lst_ONline_IPs.SelectedItems.Count > 1 Then
                    menu_addaddresslist.Enabled = True
                Else
                    menu_addaddresslist.Enabled = True
                    lst_ONline_IPs.SelectedItems.Clear()
                    lst_ONline_IPs.SelectedIndex = ix - 1
                End If
            Else
                menu_addaddresslist.Enabled = False
            End If
        End If

        If MouseOverOffline Then
            Dim ix As Integer = CInt(((MousePosition.Y - Me.Location.Y - lst_OFFline_IPs.Location.Y - TitleBarHeight) / lst_OFFline_IPs.ItemHeight) + 0.49)
            If lst_OFFline_IPs.Items.Count >= ix Then
                If lst_OFFline_IPs.SelectedItems.Count > 1 Then
                    menu_addaddresslist.Enabled = True
                Else
                    menu_addaddresslist.Enabled = True
                    lst_OFFline_IPs.SelectedItems.Clear()
                    lst_OFFline_IPs.SelectedIndex = ix - 1
                End If
            Else
                menu_addaddresslist.Enabled = False
            End If
        End If
    End Sub

    Private Sub menu_deleteaddress_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menu_deleteaddress.Opening
        If MouseOverList Then
            Dim ix As Integer = CInt(((MousePosition.Y - Me.Location.Y - lst_List_IPs.Location.Y - TitleBarHeight) / lst_List_IPs.ItemHeight) + 0.49)
            If lst_List_IPs.Items.Count >= ix Then
                If lst_List_IPs.SelectedItems.Count > 1 Then
                    menu_deleteaddress.Enabled = True
                Else
                    menu_deleteaddress.Enabled = True
                    lst_List_IPs.SelectedItems.Clear()
                    lst_List_IPs.SelectedIndex = ix - 1
                End If
            Else
                menu_deleteaddress.Enabled = False
            End If
        End If
    End Sub


    Private Sub lst_List_IPs_KeyDown(sender As Object, e As KeyEventArgs) Handles lst_List_IPs.KeyDown

        'If e.Control = True And e.KeyCode = Keys.A Then
        '    For i = 0 To lst_List_IPs.Items.Count - 1
        '        lst_List_IPs.SetSelected(i, True)
        '    Next
        'End If

        If e.KeyCode = Keys.Delete Then
            If Not BackgroundWorkerTest.IsBusy Then
                If lst_List_IPs.Focused Then
                    'lst_List_IPs.Items.Remove(lst_List_IPs.SelectedItems)
                    Dim arr()
                    Array.Resize(arr, lst_List_IPs.SelectedItems.Count)
                    For i = 0 To lst_List_IPs.SelectedItems.Count - 1
                        arr(i) = lst_List_IPs.SelectedItems(i).ToString
                    Next

                    For Each itm In arr
                        lst_List_IPs.Items.Remove(itm)
                    Next
                    lst_List_IPs.SelectedItem = Nothing
                End If
                UpdateCount("list")
                'If lst_List_IPs.Items.Count > 0 Then lst_List_IPs.SelectedIndex = lst_List_IPs.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub lst_List_IPs_MouseEnter(sender As Object, e As EventArgs) Handles lst_List_IPs.MouseEnter
        MouseOverList = True
    End Sub

    Private Sub lst_List_IPs_MouseLeave(sender As Object, e As EventArgs) Handles lst_List_IPs.MouseLeave
        MouseOverList = False
    End Sub

    Private Sub lst_OFFline_IPs_MouseEnter(sender As Object, e As EventArgs) Handles lst_OFFline_IPs.MouseEnter
        MouseOverOffline = True
    End Sub

    Private Sub lst_OFFline_IPs_MouseLeave(sender As Object, e As EventArgs) Handles lst_OFFline_IPs.MouseLeave
        MouseOverOffline = False
    End Sub

    Private Sub lst_ONline_IPs_MouseEnter(sender As Object, e As EventArgs) Handles lst_ONline_IPs.MouseEnter
        MouseOverOnline = True
    End Sub

    Private Sub lst_ONline_IPs_MouseLeave(sender As Object, e As EventArgs) Handles lst_ONline_IPs.MouseLeave
        MouseOverOnline = False
    End Sub

    Private Sub AddIPRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddIPRangeToolStripMenuItem.Click
        Dim AddRange As New AddIPRange
        AddRange.ShowDialog()
    End Sub

    Public Sub Addtolist()
        BackgroundAddrange.RunWorkerAsync()
    End Sub

    Private Sub BackgroundAddrange_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundAddrange.DoWork
        For Each ipstring In ipstringarr
            lst_List_IPs.Items.Add(ipstring)
            UpdateCount("list")
        Next

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If lst_List_IPs.Items.Count > 0 Then
            Dim dDialog As New SaveFileDialog
            With dDialog
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .FileName = "IPingerList"
                .Filter = "Text files|*.txt"
            End With

            If dDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                SaveIPListFileName = dDialog.FileName
                If Not BackgroundWorkerSaveList.IsBusy Then BackgroundWorkerSaveList.RunWorkerAsync()
            End If
        Else
            MsgBox("There are no IP addresses to save. Please add some and try again later.", MsgBoxStyle.Exclamation, "No IPs to save.")
        End If
        
    End Sub

    Private Sub BackgroundWorkerSaveList_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSaveList.DoWork
        If lst_List_IPs.Items.Count > 0 Then
            Dim SavelistString As String = lst_List_IPs.Items(0)
            For i = 1 To lst_List_IPs.Items.Count - 1
                SavelistString = SavelistString + vbNewLine + lst_List_IPs.Items(i)
            Next

            Dim objwriter As New System.IO.StreamWriter(SaveIPListFileName)
            objwriter.Write(SavelistString)
            objwriter.Close()
        End If

        Process.Start(SaveIPListFileName)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim abut As New About
        abut.ShowDialog()
    End Sub
End Class
