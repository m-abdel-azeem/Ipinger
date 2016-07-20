<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IPinger_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IPinger_Main))
        Me.tbox_IPAddress = New System.Windows.Forms.TextBox()
        Me.ADDIP_btn = New System.Windows.Forms.Button()
        Me.ImportTXT_btn = New System.Windows.Forms.Button()
        Me.StartTesting_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClearResults_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_working = New System.Windows.Forms.Label()
        Me.lst_ONline_IPs = New System.Windows.Forms.ListBox()
        Me.menu_addaddresslist = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToAddressListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lst_OFFline_IPs = New System.Windows.Forms.ListBox()
        Me.lst_List_IPs = New System.Windows.Forms.ListBox()
        Me.menu_deleteaddress = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedAddressToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackgroundWorkerImport = New System.ComponentModel.BackgroundWorker()
        Me.lbl_online = New System.Windows.Forms.Label()
        Me.lbl_offline = New System.Windows.Forms.Label()
        Me.lbl_scan_count = New System.Windows.Forms.Label()
        Me.BackgroundWorkerTest = New System.ComponentModel.BackgroundWorker()
        Me.btn_SaveResults = New System.Windows.Forms.Button()
        Me.BackgroundWorkerSave = New System.ComponentModel.BackgroundWorker()
        Me.lst_Invalid_IPs = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_invalid = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddressesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddIPRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTestingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundAddrange = New System.ComponentModel.BackgroundWorker()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorkerSaveList = New System.ComponentModel.BackgroundWorker()
        Me.menu_addaddresslist.SuspendLayout()
        Me.menu_deleteaddress.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbox_IPAddress
        '
        Me.tbox_IPAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_IPAddress.Location = New System.Drawing.Point(24, 461)
        Me.tbox_IPAddress.Name = "tbox_IPAddress"
        Me.tbox_IPAddress.Size = New System.Drawing.Size(166, 23)
        Me.tbox_IPAddress.TabIndex = 0
        '
        'ADDIP_btn
        '
        Me.ADDIP_btn.BackColor = System.Drawing.Color.AliceBlue
        Me.ADDIP_btn.Enabled = False
        Me.ADDIP_btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDIP_btn.Location = New System.Drawing.Point(47, 489)
        Me.ADDIP_btn.Name = "ADDIP_btn"
        Me.ADDIP_btn.Size = New System.Drawing.Size(121, 32)
        Me.ADDIP_btn.TabIndex = 1
        Me.ADDIP_btn.Text = "Add Address"
        Me.ADDIP_btn.UseVisualStyleBackColor = False
        '
        'ImportTXT_btn
        '
        Me.ImportTXT_btn.BackColor = System.Drawing.Color.AliceBlue
        Me.ImportTXT_btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportTXT_btn.Location = New System.Drawing.Point(24, 547)
        Me.ImportTXT_btn.Name = "ImportTXT_btn"
        Me.ImportTXT_btn.Size = New System.Drawing.Size(166, 30)
        Me.ImportTXT_btn.TabIndex = 2
        Me.ImportTXT_btn.Text = "Import From Text File"
        Me.ImportTXT_btn.UseVisualStyleBackColor = False
        '
        'StartTesting_btn
        '
        Me.StartTesting_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.StartTesting_btn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTesting_btn.ForeColor = System.Drawing.Color.White
        Me.StartTesting_btn.Location = New System.Drawing.Point(671, 540)
        Me.StartTesting_btn.Name = "StartTesting_btn"
        Me.StartTesting_btn.Size = New System.Drawing.Size(167, 37)
        Me.StartTesting_btn.TabIndex = 3
        Me.StartTesting_btn.Text = "Start Testing > >"
        Me.StartTesting_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "IP Addresses List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(224, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Online Addresses List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(417, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Offline Addresses List"
        '
        'ClearResults_btn
        '
        Me.ClearResults_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClearResults_btn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearResults_btn.Location = New System.Drawing.Point(671, 29)
        Me.ClearResults_btn.Name = "ClearResults_btn"
        Me.ClearResults_btn.Size = New System.Drawing.Size(165, 34)
        Me.ClearResults_btn.TabIndex = 4
        Me.ClearResults_btn.Text = "Clear Results"
        Me.ClearResults_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(8, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(411, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "IPinger : Fast Check For Network Nodes' Availability"
        '
        'lbl_working
        '
        Me.lbl_working.AutoSize = True
        Me.lbl_working.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_working.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_working.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_working.Location = New System.Drawing.Point(242, 548)
        Me.lbl_working.Name = "lbl_working"
        Me.lbl_working.Size = New System.Drawing.Size(377, 25)
        Me.lbl_working.TabIndex = 12
        Me.lbl_working.Text = "Testing In Progress .... Please Wait ...."
        Me.lbl_working.Visible = False
        '
        'lst_ONline_IPs
        '
        Me.lst_ONline_IPs.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lst_ONline_IPs.ContextMenuStrip = Me.menu_addaddresslist
        Me.lst_ONline_IPs.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lst_ONline_IPs.FormattingEnabled = True
        Me.lst_ONline_IPs.IntegralHeight = False
        Me.lst_ONline_IPs.ItemHeight = 16
        Me.lst_ONline_IPs.Location = New System.Drawing.Point(224, 95)
        Me.lst_ONline_IPs.Name = "lst_ONline_IPs"
        Me.lst_ONline_IPs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lst_ONline_IPs.Size = New System.Drawing.Size(166, 420)
        Me.lst_ONline_IPs.TabIndex = 13
        '
        'menu_addaddresslist
        '
        Me.menu_addaddresslist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToAddressListToolStripMenuItem})
        Me.menu_addaddresslist.Name = "ContextMenuStrip1"
        Me.menu_addaddresslist.Size = New System.Drawing.Size(172, 26)
        Me.menu_addaddresslist.Text = "Add to address list"
        '
        'AddToAddressListToolStripMenuItem
        '
        Me.AddToAddressListToolStripMenuItem.Name = "AddToAddressListToolStripMenuItem"
        Me.AddToAddressListToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddToAddressListToolStripMenuItem.Text = "Add to address list"
        '
        'lst_OFFline_IPs
        '
        Me.lst_OFFline_IPs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lst_OFFline_IPs.ContextMenuStrip = Me.menu_addaddresslist
        Me.lst_OFFline_IPs.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lst_OFFline_IPs.FormattingEnabled = True
        Me.lst_OFFline_IPs.IntegralHeight = False
        Me.lst_OFFline_IPs.ItemHeight = 16
        Me.lst_OFFline_IPs.Location = New System.Drawing.Point(420, 95)
        Me.lst_OFFline_IPs.Name = "lst_OFFline_IPs"
        Me.lst_OFFline_IPs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lst_OFFline_IPs.Size = New System.Drawing.Size(166, 420)
        Me.lst_OFFline_IPs.TabIndex = 14
        '
        'lst_List_IPs
        '
        Me.lst_List_IPs.AllowDrop = True
        Me.lst_List_IPs.BackColor = System.Drawing.Color.Gainsboro
        Me.lst_List_IPs.ContextMenuStrip = Me.menu_deleteaddress
        Me.lst_List_IPs.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lst_List_IPs.FormattingEnabled = True
        Me.lst_List_IPs.IntegralHeight = False
        Me.lst_List_IPs.ItemHeight = 16
        Me.lst_List_IPs.Location = New System.Drawing.Point(23, 74)
        Me.lst_List_IPs.Name = "lst_List_IPs"
        Me.lst_List_IPs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lst_List_IPs.Size = New System.Drawing.Size(166, 363)
        Me.lst_List_IPs.TabIndex = 15
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
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusBar.Location = New System.Drawing.Point(0, 587)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(848, 24)
        Me.StatusBar.TabIndex = 16
        Me.StatusBar.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(416, 19)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Ready..."
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(416, 19)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.Text = "Add addresses, import or drag text file."
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackgroundWorkerImport
        '
        Me.BackgroundWorkerImport.WorkerReportsProgress = True
        '
        'lbl_online
        '
        Me.lbl_online.AutoSize = True
        Me.lbl_online.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_online.ForeColor = System.Drawing.Color.Green
        Me.lbl_online.Location = New System.Drawing.Point(220, 517)
        Me.lbl_online.Name = "lbl_online"
        Me.lbl_online.Size = New System.Drawing.Size(123, 14)
        Me.lbl_online.TabIndex = 17
        Me.lbl_online.Text = "Online Addresses : "
        '
        'lbl_offline
        '
        Me.lbl_offline.AutoSize = True
        Me.lbl_offline.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_offline.ForeColor = System.Drawing.Color.Red
        Me.lbl_offline.Location = New System.Drawing.Point(417, 517)
        Me.lbl_offline.Name = "lbl_offline"
        Me.lbl_offline.Size = New System.Drawing.Size(125, 14)
        Me.lbl_offline.TabIndex = 18
        Me.lbl_offline.Text = "Offline Addresses : "
        '
        'lbl_scan_count
        '
        Me.lbl_scan_count.AutoSize = True
        Me.lbl_scan_count.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_scan_count.ForeColor = System.Drawing.Color.Black
        Me.lbl_scan_count.Location = New System.Drawing.Point(21, 440)
        Me.lbl_scan_count.Name = "lbl_scan_count"
        Me.lbl_scan_count.Size = New System.Drawing.Size(119, 14)
        Me.lbl_scan_count.TabIndex = 19
        Me.lbl_scan_count.Text = "Addresses Count: "
        '
        'BackgroundWorkerTest
        '
        '
        'btn_SaveResults
        '
        Me.btn_SaveResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_SaveResults.Enabled = False
        Me.btn_SaveResults.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_SaveResults.Location = New System.Drawing.Point(481, 29)
        Me.btn_SaveResults.Name = "btn_SaveResults"
        Me.btn_SaveResults.Size = New System.Drawing.Size(165, 34)
        Me.btn_SaveResults.TabIndex = 3
        Me.btn_SaveResults.Text = "Save Results"
        Me.btn_SaveResults.UseVisualStyleBackColor = False
        '
        'BackgroundWorkerSave
        '
        '
        'lst_Invalid_IPs
        '
        Me.lst_Invalid_IPs.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lst_Invalid_IPs.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lst_Invalid_IPs.FormattingEnabled = True
        Me.lst_Invalid_IPs.IntegralHeight = False
        Me.lst_Invalid_IPs.ItemHeight = 16
        Me.lst_Invalid_IPs.Location = New System.Drawing.Point(615, 95)
        Me.lst_Invalid_IPs.Name = "lst_Invalid_IPs"
        Me.lst_Invalid_IPs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lst_Invalid_IPs.Size = New System.Drawing.Size(166, 420)
        Me.lst_Invalid_IPs.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(612, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Invalid Addresses List"
        '
        'lbl_invalid
        '
        Me.lbl_invalid.AutoSize = True
        Me.lbl_invalid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invalid.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_invalid.Location = New System.Drawing.Point(612, 517)
        Me.lbl_invalid.Name = "lbl_invalid"
        Me.lbl_invalid.Size = New System.Drawing.Size(126, 14)
        Me.lbl_invalid.TabIndex = 23
        Me.lbl_invalid.Text = "Invalid Addresses : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(97, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Or"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddressesToolStripMenuItem, Me.ResultsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddressesToolStripMenuItem
        '
        Me.AddressesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAddressToolStripMenuItem, Me.AddIPRangeToolStripMenuItem, Me.ImportFromTextFileToolStripMenuItem, Me.StartTestingToolStripMenuItem})
        Me.AddressesToolStripMenuItem.Name = "AddressesToolStripMenuItem"
        Me.AddressesToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AddressesToolStripMenuItem.Text = "Addresses"
        '
        'AddAddressToolStripMenuItem
        '
        Me.AddAddressToolStripMenuItem.Name = "AddAddressToolStripMenuItem"
        Me.AddAddressToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AddAddressToolStripMenuItem.Text = "Add Address"
        '
        'AddIPRangeToolStripMenuItem
        '
        Me.AddIPRangeToolStripMenuItem.Name = "AddIPRangeToolStripMenuItem"
        Me.AddIPRangeToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AddIPRangeToolStripMenuItem.Text = "Add IP Range"
        '
        'ImportFromTextFileToolStripMenuItem
        '
        Me.ImportFromTextFileToolStripMenuItem.Name = "ImportFromTextFileToolStripMenuItem"
        Me.ImportFromTextFileToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ImportFromTextFileToolStripMenuItem.Text = "Import From Text File"
        '
        'StartTestingToolStripMenuItem
        '
        Me.StartTestingToolStripMenuItem.Name = "StartTestingToolStripMenuItem"
        Me.StartTestingToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.StartTestingToolStripMenuItem.Text = "Start Testing"
        '
        'ResultsToolStripMenuItem
        '
        Me.ResultsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveResultsToolStripMenuItem, Me.ClearResultsToolStripMenuItem})
        Me.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem"
        Me.ResultsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ResultsToolStripMenuItem.Text = "Results"
        '
        'SaveResultsToolStripMenuItem
        '
        Me.SaveResultsToolStripMenuItem.Enabled = False
        Me.SaveResultsToolStripMenuItem.Name = "SaveResultsToolStripMenuItem"
        Me.SaveResultsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SaveResultsToolStripMenuItem.Text = "Save Results"
        '
        'ClearResultsToolStripMenuItem
        '
        Me.ClearResultsToolStripMenuItem.Name = "ClearResultsToolStripMenuItem"
        Me.ClearResultsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ClearResultsToolStripMenuItem.Text = "Clear Results"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'BackgroundAddrange
        '
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SaveToolStripMenuItem.Text = "Save IP Address List"
        '
        'BackgroundWorkerSaveList
        '
        '
        'IPinger_Main
        '
        Me.AcceptButton = Me.ADDIP_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 611)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lbl_working)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ImportTXT_btn)
        Me.Controls.Add(Me.tbox_IPAddress)
        Me.Controls.Add(Me.ADDIP_btn)
        Me.Controls.Add(Me.lbl_invalid)
        Me.Controls.Add(Me.lst_Invalid_IPs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_SaveResults)
        Me.Controls.Add(Me.lbl_scan_count)
        Me.Controls.Add(Me.lbl_offline)
        Me.Controls.Add(Me.lbl_online)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.lst_List_IPs)
        Me.Controls.Add(Me.lst_OFFline_IPs)
        Me.Controls.Add(Me.lst_ONline_IPs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ClearResults_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartTesting_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "IPinger_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IPinger"
        Me.menu_addaddresslist.ResumeLayout(False)
        Me.menu_deleteaddress.ResumeLayout(False)
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbox_IPAddress As System.Windows.Forms.TextBox
    Friend WithEvents ADDIP_btn As System.Windows.Forms.Button
    Friend WithEvents ImportTXT_btn As System.Windows.Forms.Button
    Friend WithEvents StartTesting_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClearResults_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_working As System.Windows.Forms.Label
    Friend WithEvents lst_ONline_IPs As System.Windows.Forms.ListBox
    Friend WithEvents lst_OFFline_IPs As System.Windows.Forms.ListBox
    Friend WithEvents lst_List_IPs As System.Windows.Forms.ListBox
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackgroundWorkerImport As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_online As System.Windows.Forms.Label
    Friend WithEvents lbl_offline As System.Windows.Forms.Label
    Friend WithEvents lbl_scan_count As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorkerTest As System.ComponentModel.BackgroundWorker
    Friend WithEvents menu_addaddresslist As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToAddressListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_deleteaddress As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedAddressToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_SaveResults As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorkerSave As System.ComponentModel.BackgroundWorker
    Friend WithEvents lst_Invalid_IPs As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_invalid As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddressesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportFromTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartTestingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddIPRangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundAddrange As System.ComponentModel.BackgroundWorker
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorkerSaveList As System.ComponentModel.BackgroundWorker

End Class
