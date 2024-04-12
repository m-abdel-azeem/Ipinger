<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddIPRange
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddIPRange))
        Me.lst_AddressesList = New System.Windows.Forms.ListBox()
        Me.menu_deleteaddress = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedAddressToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_lstAddressCount = New System.Windows.Forms.Label()
        Me.BackgroundWorkerCustomRange = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerStandardRange = New System.ComponentModel.BackgroundWorker()
        Me.btn_addtolist = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Clearlist = New System.Windows.Forms.Button()
        Me.btn_Stop = New System.Windows.Forms.Button()
        Me.btn_previewresults = New System.Windows.Forms.Button()
        Me.Rbtn_StandardRange = New System.Windows.Forms.RadioButton()
        Me.Rbtn_CustomRange = New System.Windows.Forms.RadioButton()
        Me.grp_StandardRange = New System.Windows.Forms.GroupBox()
        Me.lbl_standardrange = New System.Windows.Forms.Label()
        Me.tbox_RangeIP1 = New System.Windows.Forms.TextBox()
        Me.tbox_RangeIP2 = New System.Windows.Forms.TextBox()
        Me.cbox_subnet = New System.Windows.Forms.ComboBox()
        Me.tbox_RangeIP3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbox_RangeIP4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grp_CustomRange = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbox_IP1_1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkbox1 = New System.Windows.Forms.CheckBox()
        Me.tbox_IP1_2 = New System.Windows.Forms.TextBox()
        Me.tbox_IP1_3 = New System.Windows.Forms.TextBox()
        Me.tbox_IP1_4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbox_IP2_1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbox_IP2_2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbox_IP2_3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbox_IP2_4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkbox2 = New System.Windows.Forms.CheckBox()
        Me.chkbox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.menu_deleteaddress.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp_StandardRange.SuspendLayout()
        Me.grp_CustomRange.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_AddressesList
        '
        Me.lst_AddressesList.ContextMenuStrip = Me.menu_deleteaddress
        Me.lst_AddressesList.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lst_AddressesList.FormattingEnabled = True
        Me.lst_AddressesList.ItemHeight = 16
        Me.lst_AddressesList.Location = New System.Drawing.Point(18, 21)
        Me.lst_AddressesList.Name = "lst_AddressesList"
        Me.lst_AddressesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lst_AddressesList.Size = New System.Drawing.Size(178, 292)
        Me.lst_AddressesList.TabIndex = 17
        '
        'menu_deleteaddress
        '
        Me.menu_deleteaddress.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedAddressToolStripMenuItem1})
        Me.menu_deleteaddress.Name = "menu_deleteaddress"
        Me.menu_deleteaddress.Size = New System.Drawing.Size(197, 26)
        '
        'DeleteSelectedAddressToolStripMenuItem1
        '
        Me.DeleteSelectedAddressToolStripMenuItem1.Name = "DeleteSelectedAddressToolStripMenuItem1"
        Me.DeleteSelectedAddressToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.DeleteSelectedAddressToolStripMenuItem1.Text = "Delete selected address"
        '
        'lbl_lstAddressCount
        '
        Me.lbl_lstAddressCount.AutoSize = True
        Me.lbl_lstAddressCount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_lstAddressCount.Location = New System.Drawing.Point(16, 317)
        Me.lbl_lstAddressCount.Name = "lbl_lstAddressCount"
        Me.lbl_lstAddressCount.Size = New System.Drawing.Size(119, 14)
        Me.lbl_lstAddressCount.TabIndex = 37
        Me.lbl_lstAddressCount.Text = "Addresses Count: "
        Me.lbl_lstAddressCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackgroundWorkerCustomRange
        '
        '
        'BackgroundWorkerStandardRange
        '
        '
        'btn_addtolist
        '
        Me.btn_addtolist.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_addtolist.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtolist.Location = New System.Drawing.Point(19, 346)
        Me.btn_addtolist.Name = "btn_addtolist"
        Me.btn_addtolist.Size = New System.Drawing.Size(177, 32)
        Me.btn_addtolist.TabIndex = 1
        Me.btn_addtolist.Text = "Add All To Address List"
        Me.btn_addtolist.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(10, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(263, 18)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Select Your IP Range and Proceed"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lst_AddressesList)
        Me.GroupBox1.Controls.Add(Me.lbl_lstAddressCount)
        Me.GroupBox1.Controls.Add(Me.btn_addtolist)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(438, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 387)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IP Addresses List Preview"
        '
        'btn_Clearlist
        '
        Me.btn_Clearlist.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_Clearlist.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clearlist.Location = New System.Drawing.Point(540, 7)
        Me.btn_Clearlist.Name = "btn_Clearlist"
        Me.btn_Clearlist.Size = New System.Drawing.Size(110, 31)
        Me.btn_Clearlist.TabIndex = 4
        Me.btn_Clearlist.Text = "Clear List"
        Me.btn_Clearlist.UseVisualStyleBackColor = False
        '
        'btn_Stop
        '
        Me.btn_Stop.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_Stop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Stop.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Stop.Location = New System.Drawing.Point(438, 7)
        Me.btn_Stop.Name = "btn_Stop"
        Me.btn_Stop.Size = New System.Drawing.Size(80, 31)
        Me.btn_Stop.TabIndex = 3
        Me.btn_Stop.Text = "Stop"
        Me.btn_Stop.UseVisualStyleBackColor = False
        '
        'btn_previewresults
        '
        Me.btn_previewresults.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_previewresults.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previewresults.Location = New System.Drawing.Point(132, 337)
        Me.btn_previewresults.Name = "btn_previewresults"
        Me.btn_previewresults.Size = New System.Drawing.Size(149, 32)
        Me.btn_previewresults.TabIndex = 2
        Me.btn_previewresults.Text = "Preview Addresses"
        Me.btn_previewresults.UseVisualStyleBackColor = False
        '
        'Rbtn_StandardRange
        '
        Me.Rbtn_StandardRange.AutoSize = True
        Me.Rbtn_StandardRange.Location = New System.Drawing.Point(11, 218)
        Me.Rbtn_StandardRange.Name = "Rbtn_StandardRange"
        Me.Rbtn_StandardRange.Size = New System.Drawing.Size(14, 13)
        Me.Rbtn_StandardRange.TabIndex = 1
        Me.Rbtn_StandardRange.TabStop = True
        Me.Rbtn_StandardRange.UseVisualStyleBackColor = True
        '
        'Rbtn_CustomRange
        '
        Me.Rbtn_CustomRange.AutoSize = True
        Me.Rbtn_CustomRange.Location = New System.Drawing.Point(15, 31)
        Me.Rbtn_CustomRange.Name = "Rbtn_CustomRange"
        Me.Rbtn_CustomRange.Size = New System.Drawing.Size(14, 13)
        Me.Rbtn_CustomRange.TabIndex = 0
        Me.Rbtn_CustomRange.TabStop = True
        Me.Rbtn_CustomRange.UseVisualStyleBackColor = True
        '
        'grp_StandardRange
        '
        Me.grp_StandardRange.Controls.Add(Me.lbl_standardrange)
        Me.grp_StandardRange.Controls.Add(Me.tbox_RangeIP1)
        Me.grp_StandardRange.Controls.Add(Me.tbox_RangeIP2)
        Me.grp_StandardRange.Controls.Add(Me.cbox_subnet)
        Me.grp_StandardRange.Controls.Add(Me.tbox_RangeIP3)
        Me.grp_StandardRange.Controls.Add(Me.Label7)
        Me.grp_StandardRange.Controls.Add(Me.tbox_RangeIP4)
        Me.grp_StandardRange.Controls.Add(Me.Label8)
        Me.grp_StandardRange.Controls.Add(Me.Label9)
        Me.grp_StandardRange.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_StandardRange.Location = New System.Drawing.Point(35, 215)
        Me.grp_StandardRange.Name = "grp_StandardRange"
        Me.grp_StandardRange.Size = New System.Drawing.Size(343, 101)
        Me.grp_StandardRange.TabIndex = 33
        Me.grp_StandardRange.TabStop = False
        Me.grp_StandardRange.Text = "Standard IP Range"
        '
        'lbl_standardrange
        '
        Me.lbl_standardrange.AutoSize = True
        Me.lbl_standardrange.Enabled = False
        Me.lbl_standardrange.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_standardrange.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_standardrange.Location = New System.Drawing.Point(18, 70)
        Me.lbl_standardrange.Name = "lbl_standardrange"
        Me.lbl_standardrange.Size = New System.Drawing.Size(0, 14)
        Me.lbl_standardrange.TabIndex = 37
        Me.lbl_standardrange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbox_RangeIP1
        '
        Me.tbox_RangeIP1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_RangeIP1.Location = New System.Drawing.Point(17, 32)
        Me.tbox_RangeIP1.MaxLength = 3
        Me.tbox_RangeIP1.Name = "tbox_RangeIP1"
        Me.tbox_RangeIP1.Size = New System.Drawing.Size(34, 22)
        Me.tbox_RangeIP1.TabIndex = 0
        Me.tbox_RangeIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbox_RangeIP2
        '
        Me.tbox_RangeIP2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_RangeIP2.Location = New System.Drawing.Point(68, 32)
        Me.tbox_RangeIP2.MaxLength = 3
        Me.tbox_RangeIP2.Name = "tbox_RangeIP2"
        Me.tbox_RangeIP2.Size = New System.Drawing.Size(34, 22)
        Me.tbox_RangeIP2.TabIndex = 1
        Me.tbox_RangeIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbox_subnet
        '
        Me.cbox_subnet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_subnet.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbox_subnet.FormattingEnabled = True
        Me.cbox_subnet.Items.AddRange(New Object() {"255.255.255.0", "255.255.0.0", "255.0.0.0"})
        Me.cbox_subnet.Location = New System.Drawing.Point(213, 32)
        Me.cbox_subnet.Name = "cbox_subnet"
        Me.cbox_subnet.Size = New System.Drawing.Size(110, 22)
        Me.cbox_subnet.TabIndex = 4
        '
        'tbox_RangeIP3
        '
        Me.tbox_RangeIP3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_RangeIP3.Location = New System.Drawing.Point(119, 32)
        Me.tbox_RangeIP3.MaxLength = 3
        Me.tbox_RangeIP3.Name = "tbox_RangeIP3"
        Me.tbox_RangeIP3.Size = New System.Drawing.Size(34, 22)
        Me.tbox_RangeIP3.TabIndex = 2
        Me.tbox_RangeIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(156, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "."
        '
        'tbox_RangeIP4
        '
        Me.tbox_RangeIP4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_RangeIP4.Location = New System.Drawing.Point(170, 32)
        Me.tbox_RangeIP4.MaxLength = 3
        Me.tbox_RangeIP4.Name = "tbox_RangeIP4"
        Me.tbox_RangeIP4.Size = New System.Drawing.Size(34, 22)
        Me.tbox_RangeIP4.TabIndex = 22
        Me.tbox_RangeIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(105, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 14)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(54, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 14)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "."
        '
        'grp_CustomRange
        '
        Me.grp_CustomRange.Controls.Add(Me.Label12)
        Me.grp_CustomRange.Controls.Add(Me.Label13)
        Me.grp_CustomRange.Controls.Add(Me.Label11)
        Me.grp_CustomRange.Controls.Add(Me.tbox_IP1_1)
        Me.grp_CustomRange.Controls.Add(Me.Label10)
        Me.grp_CustomRange.Controls.Add(Me.chkbox1)
        Me.grp_CustomRange.Controls.Add(Me.tbox_IP1_2)
        Me.grp_CustomRange.Controls.Add(Me.tbox_IP1_3)
        Me.grp_CustomRange.Controls.Add(Me.tbox_IP1_4)
        Me.grp_CustomRange.Controls.Add(Me.Label1)
        Me.grp_CustomRange.Controls.Add(Me.Label4)
        Me.grp_CustomRange.Controls.Add(Me.tbox_IP2_1)
        Me.grp_CustomRange.Controls.Add(Me.Label5)
        Me.grp_CustomRange.Controls.Add(Me.tbox_IP2_2)
        Me.grp_CustomRange.Controls.Add(Me.Label6)
        Me.grp_CustomRange.Controls.Add(Me.tbox_IP2_3)
        Me.grp_CustomRange.Controls.Add(Me.Label3)
        Me.grp_CustomRange.Controls.Add(Me.tbox_IP2_4)
        Me.grp_CustomRange.Controls.Add(Me.Label2)
        Me.grp_CustomRange.Controls.Add(Me.chkbox2)
        Me.grp_CustomRange.Controls.Add(Me.chkbox3)
        Me.grp_CustomRange.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_CustomRange.Location = New System.Drawing.Point(35, 28)
        Me.grp_CustomRange.Name = "grp_CustomRange"
        Me.grp_CustomRange.Size = New System.Drawing.Size(343, 165)
        Me.grp_CustomRange.TabIndex = 32
        Me.grp_CustomRange.TabStop = False
        Me.grp_CustomRange.Text = "Special Custom Range"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(18, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 14)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Start Address"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(18, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 14)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "End Address"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(66, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(273, 14)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "crossponding section to checked boxes will vary."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbox_IP1_1
        '
        Me.tbox_IP1_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IP1_1.Location = New System.Drawing.Point(106, 70)
        Me.tbox_IP1_1.MaxLength = 3
        Me.tbox_IP1_1.Name = "tbox_IP1_1"
        Me.tbox_IP1_1.Size = New System.Drawing.Size(34, 22)
        Me.tbox_IP1_1.TabIndex = 0
        Me.tbox_IP1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(9, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(284, 14)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "This will create custom range of IP addresses, only"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkbox1
        '
        Me.chkbox1.AutoSize = True
        Me.chkbox1.Location = New System.Drawing.Point(161, 105)
        Me.chkbox1.Name = "chkbox1"
        Me.chkbox1.Size = New System.Drawing.Size(15, 14)
        Me.chkbox1.TabIndex = 10
        Me.chkbox1.UseVisualStyleBackColor = True
        '
        'tbox_IP1_2
        '
        Me.tbox_IP1_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IP1_2.Location = New System.Drawing.Point(157, 70)
        Me.tbox_IP1_2.MaxLength = 3
        Me.tbox_IP1_2.Name = "tbox_IP1_2"
        Me.tbox_IP1_2.Size = New System.Drawing.Size(34, 22)
        Me.tbox_IP1_2.TabIndex = 1
        Me.tbox_IP1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbox_IP1_3
        '
        Me.tbox_IP1_3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IP1_3.Location = New System.Drawing.Point(208, 70)
        Me.tbox_IP1_3.MaxLength = 3
        Me.tbox_IP1_3.Name = "tbox_IP1_3"
        Me.tbox_IP1_3.Size = New System.Drawing.Size(34, 22)
        Me.tbox_IP1_3.TabIndex = 2
        Me.tbox_IP1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbox_IP1_4
        '
        Me.tbox_IP1_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IP1_4.Location = New System.Drawing.Point(259, 70)
        Me.tbox_IP1_4.MaxLength = 3
        Me.tbox_IP1_4.Name = "tbox_IP1_4"
        Me.tbox_IP1_4.Size = New System.Drawing.Size(34, 22)
        Me.tbox_IP1_4.TabIndex = 3
        Me.tbox_IP1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(143, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(245, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "."
        '
        'tbox_IP2_1
        '
        Me.tbox_IP2_1.Enabled = False
        Me.tbox_IP2_1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IP2_1.Location = New System.Drawing.Point(106, 127)
        Me.tbox_IP2_1.MaxLength = 3
        Me.tbox_IP2_1.Name = "tbox_IP2_1"
        Me.tbox_IP2_1.Size = New System.Drawing.Size(34, 22)
        Me.tbox_IP2_1.TabIndex = 4
        Me.tbox_IP2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(194, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "."
        '
        'tbox_IP2_2
        '
        Me.tbox_IP2_2.Enabled = False
        Me.tbox_IP2_2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IP2_2.Location = New System.Drawing.Point(157, 127)
        Me.tbox_IP2_2.MaxLength = 3
        Me.tbox_IP2_2.Name = "tbox_IP2_2"
        Me.tbox_IP2_2.Size = New System.Drawing.Size(34, 22)
        Me.tbox_IP2_2.TabIndex = 5
        Me.tbox_IP2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(143, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 14)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "."
        '
        'tbox_IP2_3
        '
        Me.tbox_IP2_3.Enabled = False
        Me.tbox_IP2_3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IP2_3.Location = New System.Drawing.Point(208, 127)
        Me.tbox_IP2_3.MaxLength = 3
        Me.tbox_IP2_3.Name = "tbox_IP2_3"
        Me.tbox_IP2_3.Size = New System.Drawing.Size(34, 22)
        Me.tbox_IP2_3.TabIndex = 8
        Me.tbox_IP2_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(245, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 14)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "."
        '
        'tbox_IP2_4
        '
        Me.tbox_IP2_4.Enabled = False
        Me.tbox_IP2_4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IP2_4.Location = New System.Drawing.Point(259, 127)
        Me.tbox_IP2_4.MaxLength = 3
        Me.tbox_IP2_4.Name = "tbox_IP2_4"
        Me.tbox_IP2_4.Size = New System.Drawing.Size(34, 22)
        Me.tbox_IP2_4.TabIndex = 11
        Me.tbox_IP2_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(194, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 14)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "."
        '
        'chkbox2
        '
        Me.chkbox2.AutoSize = True
        Me.chkbox2.Location = New System.Drawing.Point(212, 105)
        Me.chkbox2.Name = "chkbox2"
        Me.chkbox2.Size = New System.Drawing.Size(15, 14)
        Me.chkbox2.TabIndex = 11
        Me.chkbox2.UseVisualStyleBackColor = True
        '
        'chkbox3
        '
        Me.chkbox3.AutoSize = True
        Me.chkbox3.Location = New System.Drawing.Point(263, 105)
        Me.chkbox3.Name = "chkbox3"
        Me.chkbox3.Size = New System.Drawing.Size(15, 14)
        Me.chkbox3.TabIndex = 12
        Me.chkbox3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grp_CustomRange)
        Me.GroupBox2.Controls.Add(Me.grp_StandardRange)
        Me.GroupBox2.Controls.Add(Me.Rbtn_CustomRange)
        Me.GroupBox2.Controls.Add(Me.Rbtn_StandardRange)
        Me.GroupBox2.Controls.Add(Me.btn_previewresults)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 387)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select IP Range"
        '
        'AddIPRange
        '
        Me.AcceptButton = Me.btn_previewresults
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Stop
        Me.ClientSize = New System.Drawing.Size(662, 442)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_Stop)
        Me.Controls.Add(Me.btn_Clearlist)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddIPRange"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add IP Address Range."
        Me.menu_deleteaddress.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp_StandardRange.ResumeLayout(False)
        Me.grp_StandardRange.PerformLayout()
        Me.grp_CustomRange.ResumeLayout(False)
        Me.grp_CustomRange.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_AddressesList As System.Windows.Forms.ListBox
    Friend WithEvents menu_deleteaddress As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedAddressToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_lstAddressCount As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorkerCustomRange As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerStandardRange As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_addtolist As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Clearlist As System.Windows.Forms.Button
    Friend WithEvents btn_Stop As System.Windows.Forms.Button
    Friend WithEvents btn_previewresults As System.Windows.Forms.Button
    Friend WithEvents Rbtn_StandardRange As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtn_CustomRange As System.Windows.Forms.RadioButton
    Friend WithEvents grp_StandardRange As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_standardrange As System.Windows.Forms.Label
    Friend WithEvents tbox_RangeIP1 As System.Windows.Forms.TextBox
    Friend WithEvents tbox_RangeIP2 As System.Windows.Forms.TextBox
    Friend WithEvents cbox_subnet As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_RangeIP3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbox_RangeIP4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grp_CustomRange As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbox_IP1_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkbox1 As System.Windows.Forms.CheckBox
    Friend WithEvents tbox_IP1_2 As System.Windows.Forms.TextBox
    Friend WithEvents tbox_IP1_3 As System.Windows.Forms.TextBox
    Friend WithEvents tbox_IP1_4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbox_IP2_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbox_IP2_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbox_IP2_3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbox_IP2_4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkbox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbox3 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
