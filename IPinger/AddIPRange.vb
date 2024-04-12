Public Class AddIPRange
    Dim Stillloading As Boolean
    Dim Stopit As Boolean

    'GET TITLE BAR HEIGHT
    Dim TitleBarHeight As Integer = RectangleToScreen(Me.ClientRectangle).Top - (Me.Top)

    Private Sub AddIPRange_Load(sender As Object, e As EventArgs) Handles Me.Load
        Stillloading = True
        Call InitialVars()
        Rbtn_CustomRange.Checked = True
        grp_StandardRange.Enabled = False
        cbox_subnet.SelectedIndex = 0
        UpdateCount()
    End Sub

    Private Sub InitialVars()

        tbox_IP1_1.Text = "100"
        tbox_IP2_2.Text = "100"
        tbox_IP2_3.Text = "100"
        tbox_IP2_4.Text = "100"
        tbox_IP1_2.Text = "100"
        tbox_IP1_3.Text = "100"
        tbox_IP1_4.Text = "100"
        tbox_RangeIP1.Text = "100"
        tbox_RangeIP2.Text = "100"
        tbox_RangeIP3.Text = "100"
        Stillloading = False
        tbox_RangeIP4.Text = "100"
    End Sub


    Private Sub tbox_IP1_1_TextChanged(sender As Object, e As EventArgs) Handles tbox_IP1_1.TextChanged
        tbox_IP2_1.Text = tbox_IP1_1.Text
    End Sub

    Private Sub chkbox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox1.CheckedChanged
        If chkbox1.Checked Then
            tbox_IP2_2.Enabled = True
        Else
            tbox_IP2_2.Text = tbox_IP1_2.Text
            tbox_IP2_2.Enabled = False
        End If
    End Sub

    Private Sub chkbox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox2.CheckedChanged
        If chkbox2.Checked Then
            tbox_IP2_3.Enabled = True
        Else
            tbox_IP2_3.Text = tbox_IP1_3.Text
            tbox_IP2_3.Enabled = False
        End If
    End Sub

    Private Sub chkbox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbox3.CheckedChanged
        If chkbox3.Checked Then
            tbox_IP2_4.Enabled = True
        Else
            tbox_IP2_4.Text = tbox_IP1_4.Text
            tbox_IP2_4.Enabled = False
        End If
    End Sub

    Private Sub keyPressOnTboxs(sender As Object, e As KeyPressEventArgs) Handles tbox_IP1_1.KeyPress, tbox_IP1_2.KeyPress, tbox_IP1_3.KeyPress,
        tbox_IP1_4.KeyPress, tbox_IP2_2.KeyPress, tbox_IP2_3.KeyPress, tbox_IP2_4.KeyPress, tbox_RangeIP1.KeyPress, tbox_RangeIP2.KeyPress,
        tbox_RangeIP3.KeyPress, tbox_RangeIP4.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If IsNumeric(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
                If e.KeyChar.ToString = "." Then
                    ' Points to the current textbox.
                    Dim boxName As String = DirectCast(sender, TextBox).Name
                    If boxName.Contains("tbox_IP2") Then Return
                    Dim boxNum As Int32 = Convert.ToInt32(boxName.Last.ToString)
                    ' First expression calculates the nextnum, the latter is zero except when boxNum=4,
                    ' So the nextnum of the last textbox is its num.
                    ' boxNum=1         -->          2              +            0
                    ' boxNum=2         -->          3              +            0
                    ' boxNum=3         -->          4              +            0
                    ' boxNum=4         -->          0              +            4
                    Dim nextBoxNum As Int32 = ((boxNum + 1) Mod 5) + ((6 Mod boxNum) * 2)
                    'Dim nextBoxNum As Int32 = ((boxNum) Mod 4) + 1
                    ''If boxName.Contains("IP2") And nextBoxNum = 1 Then nextBoxNum += 1
                    Dim nextBoxName As String = boxName.Remove(boxName.Length - 1) + nextBoxNum.ToString
                    Me.Controls.Find(nextBoxName, True).First().Focus()
                End If
            End If
        End If

    End Sub

    Private Sub TextChangedinTboxs(sender As Object, e As EventArgs) Handles tbox_IP1_1.TextChanged, tbox_IP1_2.TextChanged, tbox_IP1_3.TextChanged,
        tbox_IP1_4.TextChanged, tbox_IP2_2.TextChanged, tbox_IP2_3.TextChanged, tbox_IP2_4.TextChanged

        If Not Stillloading Then
            GoTo Start
        Else
            Return
        End If

Start:
        Dim tboxobj As TextBox = sender

        'If (Not chkbox1.Checked) And (Not tbox_IP1_2.Text = "") Then tbox_IP2_2.Text = tbox_IP1_2.Text
        'If (Not chkbox2.Checked) And (Not tbox_IP1_3.Text = "") Then tbox_IP2_3.Text = tbox_IP1_3.Text
        'If (Not chkbox2.Checked) And (Not tbox_IP1_4.Text = "") Then tbox_IP2_4.Text = tbox_IP1_4.Text

        If Not chkbox1.Checked Then
            If Not tbox_IP1_2.Text = "" Then
                tbox_IP2_2.Text = tbox_IP1_2.Text
            End If
        End If

        If Not chkbox2.Checked Then
            If Not tbox_IP1_3.Text = "" Then
                tbox_IP2_3.Text = tbox_IP1_3.Text
            End If
        End If

        If Not chkbox3.Checked Then
            If Not tbox_IP1_4.Text = "" Then
                tbox_IP2_4.Text = tbox_IP1_4.Text
            End If
        End If

        If tboxobj.Name = "tbox_IP1_4" Or tboxobj.Name = "tbox_IP2_4" Then
            If Not tboxobj.Text = "" Then
                If CInt(tboxobj.Text) > 254 Then
                    tboxobj.Text = "254"
                End If
            End If
        End If

        If Not tboxobj.Text = "" Then
            If CInt(tboxobj.Text) > 255 Then
                tboxobj.Text = "255"
            End If
        End If

        If tboxobj.Name = "tbox_IP1_1" Or tboxobj.Name = "tbox_IP1_4" Or tboxobj.Name = "tbox_IP2_4" Then
            If Not tboxobj.Text = "" Then
                If CInt(tboxobj.Text) = 0 Then
                    tboxobj.Text = "1"
                End If
            End If
        End If

    End Sub

    Private Sub tboxs_LostFocus(sender As Object, e As EventArgs) Handles tbox_IP1_1.LostFocus, tbox_IP1_2.LostFocus, tbox_IP1_3.LostFocus,
        tbox_IP1_4.LostFocus, tbox_IP2_2.LostFocus, tbox_IP2_3.LostFocus, tbox_IP2_4.LostFocus

        Dim tboxobj As TextBox = sender

        If tboxobj.Text = "" Then
            tboxobj.Text = "100"
        End If

        If tboxobj.Name = "tbox_IP1_2" Or tboxobj.Name = "tbox_IP2_2" Then
            If tboxobj.Name = "tbox_IP2_2" Then
                Call tBoxIP_2(True)
            Else
                Call tBoxIP_2(False)
            End If
        End If

        If tboxobj.Name = "tbox_IP1_3" Or tboxobj.Name = "tbox_IP2_3" Then
            If tboxobj.Name = "tbox_IP2_3" Then
                Call tBoxIP_3(True)
            Else
                Call tBoxIP_3(False)
            End If
        End If

        If tboxobj.Name = "tbox_IP1_4" Or tboxobj.Name = "tbox_IP2_4" Then
            If tboxobj.Name = "tbox_IP2_4" Then
                Call tBoxIP_4(True)
            Else
                Call tBoxIP_4(False)
            End If
        End If

        If tbox_IP1_2.Text = tbox_IP2_2.Text Then chkbox1.Checked = False
        If tbox_IP1_3.Text = tbox_IP2_3.Text Then chkbox2.Checked = False
        If tbox_IP1_4.Text = tbox_IP2_4.Text Then chkbox3.Checked = False

    End Sub

    Private Sub tBoxIP_4(ChangeNo1 As Boolean)
        If CInt(tbox_IP1_4.Text) > CInt(tbox_IP2_4.Text) Then
            If tbox_IP2_4.Text = "1" Then
                tbox_IP1_4.Text = "1"
            ElseIf tbox_IP1_4.Text = "254" Then
                tbox_IP2_4.Text = "254"
            Else
                If ChangeNo1 Then
                    tbox_IP1_4.Text = CInt(tbox_IP2_4.Text) - 1
                Else
                    tbox_IP2_4.Text = CInt(tbox_IP1_4.Text) + 1
                End If
            End If
        End If
    End Sub

    Private Sub tBoxIP_3(ChangeNo1 As Boolean)
        If CInt(tbox_IP1_3.Text) > CInt(tbox_IP2_3.Text) Then
            If tbox_IP2_3.Text = "0" Then
                Call tBoxIP_4(ChangeNo1)
                tbox_IP1_3.Text = "0"
            ElseIf tbox_IP1_3.Text = "255" Then
                Call tBoxIP_4(ChangeNo1)
                tbox_IP2_3.Text = "255"
            Else
                If ChangeNo1 Then
                    tbox_IP1_3.Text = CInt(tbox_IP2_3.Text) - 1
                Else
                    tbox_IP2_3.Text = CInt(tbox_IP1_3.Text) + 1
                End If
            End If
        End If
    End Sub

    Private Sub tBoxIP_2(ChangeNo1 As Boolean)
        If CInt(tbox_IP1_2.Text) > CInt(tbox_IP2_2.Text) Then
            If tbox_IP2_2.Text = "0" Then
                Call tBoxIP_3(ChangeNo1)
                tbox_IP1_2.Text = "0"
            ElseIf tbox_IP1_2.Text = "255" Then
                Call tBoxIP_3(ChangeNo1)
                tbox_IP2_2.Text = "255"
            Else
                If ChangeNo1 Then
                    tbox_IP1_2.Text = CInt(tbox_IP2_2.Text) - 1
                Else
                    tbox_IP2_2.Text = CInt(tbox_IP1_2.Text) + 1
                End If
            End If
        End If
    End Sub

    Private Sub btn_previewresults_Click(sender As Object, e As EventArgs) Handles btn_previewresults.Click

        Stopit = False

        If Rbtn_CustomRange.Checked Then
            If Not BackgroundWorkerCustomRange.IsBusy Then BackgroundWorkerCustomRange.RunWorkerAsync()
        End If

        If Rbtn_StandardRange.Checked Then
            If Not BackgroundWorkerStandardRange.IsBusy Then BackgroundWorkerStandardRange.RunWorkerAsync()
        End If

    End Sub

    Private Sub menu_deleteaddress_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menu_deleteaddress.Opening

        Dim ix As Integer = CInt(((MousePosition.Y - Me.Location.Y - lst_AddressesList.Location.Y - TitleBarHeight) / lst_AddressesList.ItemHeight) + 0.49)
        If lst_AddressesList.Items.Count >= ix Then
            If lst_AddressesList.SelectedItems.Count > 1 Then
                menu_deleteaddress.Enabled = True
            Else
                menu_deleteaddress.Enabled = True
                lst_AddressesList.SelectedItems.Clear()
                lst_AddressesList.SelectedIndex = ix - 1
            End If
        Else
            menu_deleteaddress.Enabled = False
        End If

    End Sub

    Private Sub lst_AddressesList_KeyDown(sender As Object, e As KeyEventArgs) Handles lst_AddressesList.KeyDown

        'If e.Control = True And e.KeyCode = Keys.A Then
        '    For i = 0 To lst_AddressesList.Items.Count - 1
        '        lst_AddressesList.SetSelected(i, True)
        '    Next
        'End If

        If e.KeyCode = Keys.Delete Then
            If lst_AddressesList.Focused Then
                'lst_List_IPs.Items.Remove(lst_List_IPs.SelectedItems)
                Dim arr()
                Array.Resize(arr, lst_AddressesList.SelectedItems.Count)
                For i = 0 To lst_AddressesList.SelectedItems.Count - 1
                    arr(i) = lst_AddressesList.SelectedItems(i).ToString
                Next

                For Each itm In arr
                    lst_AddressesList.Items.Remove(itm)
                Next
                lst_AddressesList.SelectedItem = Nothing
            End If
            UpdateCount()
        End If
    End Sub

    Private Sub DeleteSelectedAddressToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteSelectedAddressToolStripMenuItem1.Click

        Dim arr()
        Array.Resize(arr, lst_AddressesList.SelectedItems.Count)
        For i = 0 To lst_AddressesList.SelectedItems.Count - 1
            arr(i) = lst_AddressesList.SelectedItems(i).ToString
        Next

        For Each itm In arr
            lst_AddressesList.Items.Remove(itm)
        Next
        lst_AddressesList.SelectedItem = Nothing
        UpdateCount()

    End Sub

    Private Sub UpdateCount()
        lbl_lstAddressCount.Text = "Addresses Count: " + CStr(lst_AddressesList.Items.Count)
    End Sub

    Private Sub cbox_subnet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_subnet.SelectedIndexChanged
        If tbox_RangeIP1.Text <> "" And tbox_RangeIP2.Text <> "" And tbox_RangeIP3.Text <> "" And tbox_RangeIP4.Text <> "" Then

            Select Case cbox_subnet.Items(cbox_subnet.SelectedIndex)
                Case "255.255.255.0"
                    lbl_standardrange.Text = "Range: " + tbox_RangeIP1.Text + "." + tbox_RangeIP2.Text +
                        "." + tbox_RangeIP3.Text + ".1  >>  " + tbox_RangeIP1.Text + "." +
                    tbox_RangeIP2.Text + "." + tbox_RangeIP3.Text + ".254"

                Case "255.255.0.0"
                    lbl_standardrange.Text = "Range: " + tbox_RangeIP1.Text + "." + tbox_RangeIP2.Text +
                        ".0.1  >>  " + tbox_RangeIP1.Text + "." +
                    tbox_RangeIP2.Text + ".255.254"

                Case "255.0.0.0"
                    lbl_standardrange.Text = "Range: " + tbox_RangeIP1.Text + ".0.0.1  >>  " + tbox_RangeIP1.Text + ".255.255.254"

                Case Else
                    lbl_standardrange.Text = ""
            End Select
        End If
    End Sub

    Private Sub TextChangedinRangetBoxs(sender As Object, e As EventArgs) Handles tbox_RangeIP1.TextChanged, tbox_RangeIP2.TextChanged, tbox_RangeIP3.TextChanged, tbox_RangeIP4.TextChanged
        If Not Stillloading Then
            GoTo Start
        Else
            Return
        End If

Start:
        Dim tboxobj As TextBox = sender

        If tboxobj.Name = "tbox_RangeIP4" Then
            If Not tboxobj.Text = "" Then
                If CInt(tboxobj.Text) > 254 Then
                    tboxobj.Text = "254"
                End If
            End If
        Else
            If Not tboxobj.Text = "" Then
                If CInt(tboxobj.Text) > 255 Then
                    tboxobj.Text = "255"
                End If
            End If
        End If

        
        If tboxobj.Name = "tbox_RangeIP1" Or tboxobj.Name = "tbox_RangeIP4" Then
            If Not tboxobj.Text = "" Then
                If CInt(tboxobj.Text) = 0 Then
                    tboxobj.Text = "1"
                End If
            End If
        End If
    End Sub

    Private Sub Rangetboxs_LostFocus(sender As Object, e As EventArgs) Handles tbox_RangeIP1.LostFocus, tbox_RangeIP2.LostFocus, tbox_RangeIP3.LostFocus,
        tbox_RangeIP4.LostFocus

        Dim tboxobj As TextBox = sender

        If tboxobj.Text = "" Then
            tboxobj.Text = "100"
        End If

        Call cbox_subnet_SelectedIndexChanged(cbox_subnet, New EventArgs)

    End Sub

    Private Sub Rbtn_CustomRange_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_CustomRange.CheckedChanged
        If Rbtn_CustomRange.Checked Then
            Rbtn_StandardRange.Checked = False
            grp_CustomRange.Enabled = True
        Else
            grp_CustomRange.Enabled = False
        End If
    End Sub

    Private Sub Rbtn_StandardRange_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_StandardRange.CheckedChanged
        If Rbtn_StandardRange.Checked Then
            Rbtn_CustomRange.Checked = False
            grp_StandardRange.Enabled = True
        Else
            grp_StandardRange.Enabled = False
        End If
    End Sub

    Private Sub BackgroundWorkerCustomRange_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerCustomRange.DoWork
        For i = CInt(tbox_IP1_2.Text) To CInt(tbox_IP2_2.Text)
            For y = CInt(tbox_IP1_3.Text) To CInt(tbox_IP2_3.Text)
                For z = CInt(tbox_IP1_4.Text) To CInt(tbox_IP2_4.Text)
                    Dim Result As String = tbox_IP1_1.Text + "." + CStr(i) + "." + CStr(y) + "." + CStr(z)
                    lst_AddressesList.Items.Add(Result)
                    UpdateCount()
                Next
            Next
        Next
    End Sub

    Private Sub BackgroundWorkerStandardRange_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerStandardRange.DoWork
        If tbox_RangeIP1.Text <> "" And tbox_RangeIP2.Text <> "" And tbox_RangeIP3.Text <> "" And tbox_RangeIP4.Text <> "" Then

            Select Case cbox_subnet.Items(cbox_subnet.SelectedIndex)
                Case "255.255.255.0"
                    For i = 1 To 254
                        Try
                            Dim val As String = tbox_RangeIP1.Text + "." + tbox_RangeIP2.Text + "." + tbox_RangeIP3.Text + "." + CStr(i)
                            lst_AddressesList.Items.Add(val)
                            UpdateCount()
                        Catch ex As Exception
                        End Try
                    Next


                Case "255.255.0.0"
                    Dim val As String
                    For i = 0 To 255
                        For y = 0 To 255
                            If Not Stopit Then
                                If i = 0 And y = 0 Then

                                ElseIf i = 255 And y = 255 Then

                                Else
                                    Try
                                        val = tbox_RangeIP1.Text + "." + tbox_RangeIP2.Text + "." + CStr(i) + "." + CStr(y)
                                        lst_AddressesList.Items.Add(val)
                                        UpdateCount()
                                    Catch ex As Exception
                                    End Try
                                End If
                            End If
                        Next
                    Next


                Case "255.0.0.0"
                    Dim val As String
                    For i = 0 To 255
                        For y = 0 To 255
                            For x = 0 To 255
                                If Not Stopit Then
                                    If i = 0 And y = 0 And x = 0 Then

                                    ElseIf i = 255 And y = 255 And x = 255 Then

                                    Else
                                        Try
                                            val = tbox_RangeIP1.Text + "." + CStr(i) + "." + CStr(y) + "." + CStr(x)
                                            lst_AddressesList.Items.Add(val)
                                            UpdateCount()
                                        Catch ex As Exception
                                        End Try
                                    End If
                                End If
                            Next
                        Next
                    Next
            End Select
        End If
    End Sub

    Private Sub btn_addtolist_Click(sender As Object, e As EventArgs) Handles btn_addtolist.Click
        Array.Resize(ipstringarr, lst_AddressesList.Items.Count)
        For i = 0 To lst_AddressesList.Items.Count - 1
            ipstringarr(i) = lst_AddressesList.Items(i)
        Next
        IPinger_Main.Addtolist()
    End Sub

    Private Sub btn_Clearlist_Click(sender As Object, e As EventArgs) Handles btn_Clearlist.Click
        lst_AddressesList.Items.Clear()
        UpdateCount()
    End Sub


    Private Sub btn_Stop_Click(sender As Object, e As EventArgs) Handles btn_Stop.Click
        Stopit = True
    End Sub
End Class