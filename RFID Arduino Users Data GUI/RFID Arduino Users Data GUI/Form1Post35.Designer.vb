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
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.LabelConnectionStatus = New System.Windows.Forms.Label()
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.LabelBaudRate = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.PanelTopHeader = New System.Windows.Forms.Panel()
        Me.PanelUserData = New System.Windows.Forms.Panel()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelCity = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRegistrationandEditUserData = New System.Windows.Forms.Panel()
        Me.PanelReadingTagProcess = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearSectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelGetID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonScanID = New System.Windows.Forms.Button()
        Me.ButtonClearForm = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxBalance = New System.Windows.Forms.TextBox()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TimerTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSerialIn = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBoxStatusConnect = New System.Windows.Forms.PictureBox()
        Me.ButtonConnection = New System.Windows.Forms.Button()
        Me.PictureBoxSelect = New System.Windows.Forms.PictureBox()
        Me.ButtonRegistration = New System.Windows.Forms.Button()
        Me.ButtonUserData = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonCloseReadingTag = New System.Windows.Forms.Button()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.PictureBoxUserImage = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelConnection.SuspendLayout()
        Me.PanelUserData.SuspendLayout()
        Me.GroupBoxImage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelRegistrationandEditUserData.SuspendLayout()
        Me.PanelReadingTagProcess.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxStatusConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PictureBoxSelect)
        Me.PanelMenu.Controls.Add(Me.ButtonRegistration)
        Me.PanelMenu.Controls.Add(Me.ButtonUserData)
        Me.PanelMenu.Controls.Add(Me.PictureBoxLogo)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(324, 579)
        Me.PanelMenu.TabIndex = 0
        '
        'LabelDateTime
        '
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.Location = New System.Drawing.Point(728, 4)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(179, 12)
        Me.LabelDateTime.TabIndex = 5
        Me.LabelDateTime.Text = "Time 00:00:00 Date 00 mm, 000"
        '
        'LabelConnectionStatus
        '
        Me.LabelConnectionStatus.AutoSize = True
        Me.LabelConnectionStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConnectionStatus.Location = New System.Drawing.Point(330, 4)
        Me.LabelConnectionStatus.Name = "LabelConnectionStatus"
        Me.LabelConnectionStatus.Size = New System.Drawing.Size(190, 12)
        Me.LabelConnectionStatus.TabIndex = 2
        Me.LabelConnectionStatus.Text = "Connection Status: Disconnected"
        '
        'PanelConnection
        '
        Me.PanelConnection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelConnection.Controls.Add(Me.ButtonScanPort)
        Me.PanelConnection.Controls.Add(Me.ButtonConnect)
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.LabelBaudRate)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.PanelTopHeader)
        Me.PanelConnection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelConnection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelConnection.Location = New System.Drawing.Point(332, 20)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(588, 546)
        Me.PanelConnection.TabIndex = 6
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Location = New System.Drawing.Point(22, 20)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(95, 23)
        Me.ButtonScanPort.TabIndex = 6
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConnect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonConnect.Location = New System.Drawing.Point(14, 65)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(555, 30)
        Me.ButtonConnect.TabIndex = 5
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxBaudRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(479, 20)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(90, 20)
        Me.ComboBoxBaudRate.TabIndex = 4
        '
        'LabelBaudRate
        '
        Me.LabelBaudRate.AutoSize = True
        Me.LabelBaudRate.Location = New System.Drawing.Point(404, 23)
        Me.LabelBaudRate.Name = "LabelBaudRate"
        Me.LabelBaudRate.Size = New System.Drawing.Size(66, 12)
        Me.LabelBaudRate.TabIndex = 3
        Me.LabelBaudRate.Text = "Baud Rate:"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(133, 20)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(265, 20)
        Me.ComboBoxPort.TabIndex = 2
        '
        'PanelTopHeader
        '
        Me.PanelTopHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTopHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelTopHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopHeader.Name = "PanelTopHeader"
        Me.PanelTopHeader.Size = New System.Drawing.Size(588, 5)
        Me.PanelTopHeader.TabIndex = 0
        '
        'PanelUserData
        '
        Me.PanelUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUserData.Controls.Add(Me.GroupBoxImage)
        Me.PanelUserData.Controls.Add(Me.Panel2)
        Me.PanelUserData.Controls.Add(Me.GroupBox1)
        Me.PanelUserData.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelUserData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelUserData.Location = New System.Drawing.Point(333, 20)
        Me.PanelUserData.Name = "PanelUserData"
        Me.PanelUserData.Size = New System.Drawing.Size(588, 546)
        Me.PanelUserData.TabIndex = 7
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Controls.Add(Me.LabelID)
        Me.GroupBoxImage.Controls.Add(Me.PictureBoxUserImage)
        Me.GroupBoxImage.Location = New System.Drawing.Point(206, 11)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Size = New System.Drawing.Size(208, 239)
        Me.GroupBoxImage.TabIndex = 1
        Me.GroupBoxImage.TabStop = False
        Me.GroupBoxImage.Text = "Image and ID"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.ForeColor = System.Drawing.Color.Black
        Me.LabelID.Location = New System.Drawing.Point(25, 201)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(131, 22)
        Me.LabelID.TabIndex = 1
        Me.LabelID.Text = "ID: _________"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(588, 5)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelCity)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LabelAddress)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelBalance)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.LabelName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 263)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detailed Data"
        '
        'LabelCity
        '
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCity.ForeColor = System.Drawing.Color.Black
        Me.LabelCity.Location = New System.Drawing.Point(129, 146)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(97, 22)
        Me.LabelCity.TabIndex = 14
        Me.LabelCity.Text = "Waiting..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(97, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "City"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.ForeColor = System.Drawing.Color.Black
        Me.LabelAddress.Location = New System.Drawing.Point(129, 88)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(97, 22)
        Me.LabelAddress.TabIndex = 11
        Me.LabelAddress.Text = "Waiting..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(97, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Address"
        '
        'LabelBalance
        '
        Me.LabelBalance.AutoSize = True
        Me.LabelBalance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBalance.ForeColor = System.Drawing.Color.Black
        Me.LabelBalance.Location = New System.Drawing.Point(129, 208)
        Me.LabelBalance.Name = "LabelBalance"
        Me.LabelBalance.Size = New System.Drawing.Size(97, 22)
        Me.LabelBalance.TabIndex = 8
        Me.LabelBalance.Text = "Waiting..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(97, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Balance"
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClear.Location = New System.Drawing.Point(477, 229)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(68, 21)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.Color.Black
        Me.LabelName.Location = New System.Drawing.Point(129, 28)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(97, 22)
        Me.LabelName.TabIndex = 4
        Me.LabelName.Text = "Waiting..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(97, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'PanelRegistrationandEditUserData
        '
        Me.PanelRegistrationandEditUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.PanelReadingTagProcess)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox4)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox3)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.ButtonClearForm)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.ButtonSave)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label12)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label11)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxBalance)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxCity)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxAddress)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label10)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxName)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label7)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Panel3)
        Me.PanelRegistrationandEditUserData.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRegistrationandEditUserData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelRegistrationandEditUserData.Location = New System.Drawing.Point(332, 20)
        Me.PanelRegistrationandEditUserData.Name = "PanelRegistrationandEditUserData"
        Me.PanelRegistrationandEditUserData.Size = New System.Drawing.Size(588, 546)
        Me.PanelRegistrationandEditUserData.TabIndex = 8
        '
        'PanelReadingTagProcess
        '
        Me.PanelReadingTagProcess.Controls.Add(Me.PictureBox1)
        Me.PanelReadingTagProcess.Controls.Add(Me.ButtonCloseReadingTag)
        Me.PanelReadingTagProcess.Controls.Add(Me.Label15)
        Me.PanelReadingTagProcess.Location = New System.Drawing.Point(36, 18)
        Me.PanelReadingTagProcess.Name = "PanelReadingTagProcess"
        Me.PanelReadingTagProcess.Size = New System.Drawing.Size(264, 165)
        Me.PanelReadingTagProcess.TabIndex = 19
        Me.PanelReadingTagProcess.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 14)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Reading tag..."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBoxImagePreview)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.CheckBoxByID)
        Me.GroupBox4.Controls.Add(Me.CheckBoxByName)
        Me.GroupBox4.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 271)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(555, 263)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Record View"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(9, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(420, 195)
        Me.DataGridView1.TabIndex = 12
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ClearSectionToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.RefreshToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 98)
        '
        'ClearSectionToolStripMenuItem
        '
        Me.ClearSectionToolStripMenuItem.Name = "ClearSectionToolStripMenuItem"
        Me.ClearSectionToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ClearSectionToolStripMenuItem.Text = "Clear Section"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(140, 6)
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Location = New System.Drawing.Point(465, 22)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(94, 16)
        Me.CheckBoxByID.TabIndex = 11
        Me.CheckBoxByID.Text = "Search by ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Location = New System.Drawing.Point(354, 22)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(115, 16)
        Me.CheckBoxByName.TabIndex = 10
        Me.CheckBoxByName.Text = "Search by Name"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxSearch.Location = New System.Drawing.Point(100, 20)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(248, 20)
        Me.TextBoxSearch.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 14)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Search Here:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox3.Location = New System.Drawing.Point(449, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 130)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Image"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LabelGetID)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.ButtonScanID)
        Me.GroupBox2.Location = New System.Drawing.Point(323, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 130)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Get ID"
        '
        'LabelGetID
        '
        Me.LabelGetID.AutoSize = True
        Me.LabelGetID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGetID.ForeColor = System.Drawing.Color.Black
        Me.LabelGetID.Location = New System.Drawing.Point(35, 98)
        Me.LabelGetID.Name = "LabelGetID"
        Me.LabelGetID.Size = New System.Drawing.Size(67, 14)
        Me.LabelGetID.TabIndex = 16
        Me.LabelGetID.Text = "__________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 14)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "ID"
        '
        'ButtonScanID
        '
        Me.ButtonScanID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonScanID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanID.Location = New System.Drawing.Point(6, 22)
        Me.ButtonScanID.Name = "ButtonScanID"
        Me.ButtonScanID.Size = New System.Drawing.Size(102, 49)
        Me.ButtonScanID.TabIndex = 14
        Me.ButtonScanID.Text = "Scan"
        Me.ButtonScanID.UseVisualStyleBackColor = True
        '
        'ButtonClearForm
        '
        Me.ButtonClearForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClearForm.Location = New System.Drawing.Point(102, 203)
        Me.ButtonClearForm.Name = "ButtonClearForm"
        Me.ButtonClearForm.Size = New System.Drawing.Size(82, 49)
        Me.ButtonClearForm.TabIndex = 12
        Me.ButtonClearForm.Text = "Clear"
        Me.ButtonClearForm.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Location = New System.Drawing.Point(14, 203)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(82, 49)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 14)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "City"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 14)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Balance"
        '
        'TextBoxBalance
        '
        Me.TextBoxBalance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBalance.Location = New System.Drawing.Point(83, 97)
        Me.TextBoxBalance.Name = "TextBoxBalance"
        Me.TextBoxBalance.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxBalance.TabIndex = 8
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCity.Location = New System.Drawing.Point(83, 71)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxCity.TabIndex = 7
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxAddress.Location = New System.Drawing.Point(83, 44)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxAddress.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 14)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Address"
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxName.Location = New System.Drawing.Point(83, 18)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxName.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Name"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(588, 5)
        Me.Panel3.TabIndex = 0
        '
        'TimerTimeDate
        '
        Me.TimerTimeDate.Enabled = True
        '
        'TimerSerialIn
        '
        Me.TimerSerialIn.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBoxStatusConnect
        '
        Me.PictureBoxStatusConnect.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.images__1_
        Me.PictureBoxStatusConnect.Location = New System.Drawing.Point(526, 4)
        Me.PictureBoxStatusConnect.Name = "PictureBoxStatusConnect"
        Me.PictureBoxStatusConnect.Size = New System.Drawing.Size(12, 12)
        Me.PictureBoxStatusConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStatusConnect.TabIndex = 3
        Me.PictureBoxStatusConnect.TabStop = False
        '
        'ButtonConnection
        '
        Me.ButtonConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonConnection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ButtonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnection.ForeColor = System.Drawing.Color.White
        Me.ButtonConnection.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.iconfinder_Computer__Computer_Hardware_USB_Port_Connection_4064143
        Me.ButtonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonConnection.Location = New System.Drawing.Point(22, 193)
        Me.ButtonConnection.Name = "ButtonConnection"
        Me.ButtonConnection.Size = New System.Drawing.Size(302, 36)
        Me.ButtonConnection.TabIndex = 1
        Me.ButtonConnection.Text = "Connection"
        Me.ButtonConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConnection.UseVisualStyleBackColor = False
        '
        'PictureBoxSelect
        '
        Me.PictureBoxSelect.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.images__2_
        Me.PictureBoxSelect.Location = New System.Drawing.Point(0, 193)
        Me.PictureBoxSelect.Name = "PictureBoxSelect"
        Me.PictureBoxSelect.Size = New System.Drawing.Size(18, 36)
        Me.PictureBoxSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSelect.TabIndex = 4
        Me.PictureBoxSelect.TabStop = False
        '
        'ButtonRegistration
        '
        Me.ButtonRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ButtonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistration.ForeColor = System.Drawing.Color.White
        Me.ButtonRegistration.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.iconfinder_user_half_edit_103775
        Me.ButtonRegistration.Location = New System.Drawing.Point(22, 277)
        Me.ButtonRegistration.Name = "ButtonRegistration"
        Me.ButtonRegistration.Size = New System.Drawing.Size(302, 36)
        Me.ButtonRegistration.TabIndex = 3
        Me.ButtonRegistration.Text = "Registration / Edit User Data"
        Me.ButtonRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegistration.UseVisualStyleBackColor = False
        '
        'ButtonUserData
        '
        Me.ButtonUserData.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonUserData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ButtonUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUserData.ForeColor = System.Drawing.Color.White
        Me.ButtonUserData.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.iconfinder_user_profile_103780
        Me.ButtonUserData.Location = New System.Drawing.Point(22, 235)
        Me.ButtonUserData.Name = "ButtonUserData"
        Me.ButtonUserData.Size = New System.Drawing.Size(302, 36)
        Me.ButtonUserData.TabIndex = 2
        Me.ButtonUserData.Text = "User Data"
        Me.ButtonUserData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUserData.UseVisualStyleBackColor = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.images
        Me.PictureBoxLogo.Location = New System.Drawing.Point(62, 25)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(200, 142)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(91, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ButtonCloseReadingTag
        '
        Me.ButtonCloseReadingTag.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCloseReadingTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCloseReadingTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonCloseReadingTag.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.iconfinder_close15_216468
        Me.ButtonCloseReadingTag.Location = New System.Drawing.Point(224, 5)
        Me.ButtonCloseReadingTag.Name = "ButtonCloseReadingTag"
        Me.ButtonCloseReadingTag.Size = New System.Drawing.Size(25, 23)
        Me.ButtonCloseReadingTag.TabIndex = 8
        Me.ButtonCloseReadingTag.UseVisualStyleBackColor = True
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(435, 55)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(110, 110)
        Me.PictureBoxImagePreview.TabIndex = 13
        Me.PictureBoxImagePreview.TabStop = False
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.iconfinder_Bin_2202256
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.iconfinder_select_all_326691
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.iconfinder_refresh_01_186390
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImageInput.Image = Global.RFID_Arduino_Users_Data_GUI.My.Resources.Resources.iconfinder_user_half_edit_103775
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(10, 22)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 0
        Me.PictureBoxImageInput.TabStop = False
        '
        'PictureBoxUserImage
        '
        Me.PictureBoxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxUserImage.Location = New System.Drawing.Point(18, 24)
        Me.PictureBoxUserImage.Name = "PictureBoxUserImage"
        Me.PictureBoxUserImage.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxUserImage.TabIndex = 0
        Me.PictureBoxUserImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 578)
        Me.Controls.Add(Me.LabelDateTime)
        Me.Controls.Add(Me.PictureBoxStatusConnect)
        Me.Controls.Add(Me.LabelConnectionStatus)
        Me.Controls.Add(Me.ButtonConnection)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelRegistrationandEditUserData)
        Me.Controls.Add(Me.PanelConnection)
        Me.Controls.Add(Me.PanelUserData)
        Me.Name = "Form1"
        Me.Text = "RFID Arduino User Data"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        Me.PanelUserData.ResumeLayout(False)
        Me.GroupBoxImage.ResumeLayout(False)
        Me.GroupBoxImage.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelRegistrationandEditUserData.ResumeLayout(False)
        Me.PanelRegistrationandEditUserData.PerformLayout()
        Me.PanelReadingTagProcess.ResumeLayout(False)
        Me.PanelReadingTagProcess.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxStatusConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PictureBoxSelect As PictureBox
    Friend WithEvents ButtonRegistration As Button
    Friend WithEvents ButtonUserData As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonConnection As Button
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents LabelConnectionStatus As Label
    Friend WithEvents PictureBoxStatusConnect As PictureBox
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents PanelTopHeader As Panel
    Friend WithEvents LabelBaudRate As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents PanelUserData As Panel
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents LabelID As Label
    Friend WithEvents PictureBoxUserImage As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelCity As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelBalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents PanelRegistrationandEditUserData As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxBalance As TextBox
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelReadingTagProcess As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonCloseReadingTag As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBoxImagePreview As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelGetID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonScanID As Button
    Friend WithEvents ButtonClearForm As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TimerTimeDate As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimerSerialIn As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
