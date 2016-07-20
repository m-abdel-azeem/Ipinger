Public Class LiveDisplay
    Dim FlowPanelItems()
    Dim OldvAlidAddresses(0, 2)


    Private Sub LiveDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load

        ReDim OldvAlidAddresses(vAlidAddresses.Length / 3, 2)
        OldvAlidAddresses = vAlidAddresses

        If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Array.Resize(FlowPanelItems, vAlidAddresses.Length / 3)

        For i = 0 To (vAlidAddresses.Length / 3) - 1
            If vAlidAddresses(i, 2) <> "INVALID" Then
                Dim Nodelbl As New Label
                With Nodelbl
                    .Text = vbNewLine + vbNewLine + vbNewLine + vbNewLine + vAlidAddresses(i, 1)
                    .TextAlign = ContentAlignment.BottomCenter
                    .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                    .ImageAlign = ContentAlignment.MiddleCenter
                    .Name = "Lbl" + CStr(i)
                    .Size = New Size(100, 90)
                    If vAlidAddresses(i, 2) = "ONLINE" Then
                        .Image = My.Resources.Online
                    ElseIf vAlidAddresses(i, 2) = "OFFLINE" Then
                        .Image = My.Resources.Offline
                    End If
                End With

                FlowPanelItems(i) = Nodelbl
            End If

        Next


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        For Each item In FlowPanelItems
            FlowLayoutPanel2.Controls.Add(item)
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not BackgroundWorker2.IsBusy Then BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

        For i = 0 To (vAlidAddresses.Length / 3) - 1

            Try

                If My.Computer.Network.Ping(vAlidAddresses(i, 1)) Then

                    If Not OldvAlidAddresses(i, 2) = "ONLINE" Then
                        For Each Lbl As Label In FlowLayoutPanel2.Controls
                            If Lbl.Name = "Lbl" + CStr(i) Then
                                Lbl.Image = My.Resources.Online
                                vAlidAddresses(i, 2) = "ONLINE"
                                IPinger_Main.UpdateDataFromLive("Online", vAlidAddresses(i, 1))
                            End If
                        Next

                    End If
                Else

                    If Not OldvAlidAddresses(i, 2) = "OFFLINE" Then
                        For Each Lbl As Label In FlowLayoutPanel2.Controls
                            If Lbl.Name = "Lbl" + CStr(i) Then
                                Lbl.Image = My.Resources.Offline
                                vAlidAddresses(i, 2) = "OFFLINE"
                                IPinger_Main.UpdateDataFromLive("Offline", vAlidAddresses(i, 1))
                            End If
                        Next
                    End If
                End If
            Catch ex As Exception

            End Try

        Next

        OldvAlidAddresses = vAlidAddresses

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim koko As String = "3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46"
        'Dim parts() = koko.Split(",")
        'For i = 0 To parts.Length - 1
        '    Dim name As String
        '    If parts(i).Length > 1 Then
        '        name = parts(i)
        '    Else
        '        name = "0" + parts(i)
        '    End If
        '    Dim contents As String = "C	# # File Version" + vbNewLine
        '    contents = contents + "AH" + name + "A1	# # Subestation Text" + vbNewLine
        '    contents = contents + "1	# Protocol" + vbNewLine
        '    contents = contents + "2	# Tipo de comunicación (2, red)" + vbNewLine
        '    contents = contents + "1	 #(UCS ZIV=0, Transparente=1, telnet=2)" + vbNewLine
        '    contents = contents + "0	# (ipv4=0 , ipv6=1)" + vbNewLine
        '    contents = contents + "21." + parts(i) + ".16.172	# IPv4" + vbNewLine
        '    contents = contents + "32001	, 5000 # Puerto TCPIP, t mensaje red" + vbNewLine

        '    Dim objwriter As New IO.StreamWriter("AH" + name + "A1_Ethernet.sbs")
        '    objwriter.Write(contents)
        '    objwriter.Close()

        'Next

        'IPinger_Main.UpdateDataFromLive("Online", "127.0.0.1")

        If vAlidAddresses(0, 1) = "172.0.0.1" Then
            vAlidAddresses(0, 1) = "127.0.0.1"
        Else
            vAlidAddresses(0, 1) = "172.0.0.1"
        End If

        'MsgBox(vAlidAddresses(0, 1))
        'MsgBox(vAlidAddresses(0, 2))
        'vAlidAddresses(0, 2) = "OFFLINE"


        'For Each Lbl In FlowLayoutPanel2.Controls
        '    'MsgBox(Lbl.Name)
        '    Try
        '        Lbl.Image = My.Resources.Offline
        '    Catch ex As Exception

        '    End Try
        'Next
    End Sub
End Class