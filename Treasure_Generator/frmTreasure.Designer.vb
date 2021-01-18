<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreasure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTreasure))
        Me.grpTreasure = New System.Windows.Forms.GroupBox()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.lstGoods = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstCoins = New System.Windows.Forms.ListBox()
        Me.grpBooks = New System.Windows.Forms.GroupBox()
        Me.btnMultiSource = New System.Windows.Forms.RadioButton()
        Me.btnMIC = New System.Windows.Forms.RadioButton()
        Me.btnEPH = New System.Windows.Forms.RadioButton()
        Me.btnDMG = New System.Windows.Forms.RadioButton()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.grpSpecial = New System.Windows.Forms.GroupBox()
        Me.btnNone = New System.Windows.Forms.RadioButton()
        Me.grpItems = New System.Windows.Forms.GroupBox()
        Me.btnitemtpl = New System.Windows.Forms.RadioButton()
        Me.btnitem50 = New System.Windows.Forms.RadioButton()
        Me.btnitemno = New System.Windows.Forms.RadioButton()
        Me.btnitemdbl = New System.Windows.Forms.RadioButton()
        Me.btnitemstd = New System.Windows.Forms.RadioButton()
        Me.btnTplStandard = New System.Windows.Forms.RadioButton()
        Me.grpGoods = New System.Windows.Forms.GroupBox()
        Me.btngoodtpl = New System.Windows.Forms.RadioButton()
        Me.btngood50 = New System.Windows.Forms.RadioButton()
        Me.btngoodno = New System.Windows.Forms.RadioButton()
        Me.btngooddbl = New System.Windows.Forms.RadioButton()
        Me.btngoodstd = New System.Windows.Forms.RadioButton()
        Me.grpCoins = New System.Windows.Forms.GroupBox()
        Me.btncointpl = New System.Windows.Forms.RadioButton()
        Me.chkCoinTweak = New System.Windows.Forms.CheckBox()
        Me.btncoin50 = New System.Windows.Forms.RadioButton()
        Me.btncoinno = New System.Windows.Forms.RadioButton()
        Me.btncoin10 = New System.Windows.Forms.RadioButton()
        Me.btncoindbl = New System.Windows.Forms.RadioButton()
        Me.btncoinstd = New System.Windows.Forms.RadioButton()
        Me.btnNonstandard = New System.Windows.Forms.RadioButton()
        Me.btnDblStandard = New System.Windows.Forms.RadioButton()
        Me.btnStandard = New System.Windows.Forms.RadioButton()
        Me.spnLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeepCoinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeepGoodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeepItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreezeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreezeCoinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreezeGoodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreezeItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpPercent = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.spnPercentXPH = New System.Windows.Forms.NumericUpDown()
        Me.spnPercentDMG = New System.Windows.Forms.NumericUpDown()
        Me.grpTreasure.SuspendLayout()
        Me.grpBooks.SuspendLayout()
        Me.grpSpecial.SuspendLayout()
        Me.grpItems.SuspendLayout()
        Me.grpGoods.SuspendLayout()
        Me.grpCoins.SuspendLayout()
        CType(Me.spnLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpPercent.SuspendLayout()
        CType(Me.spnPercentXPH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnPercentDMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTreasure
        '
        Me.grpTreasure.Controls.Add(Me.lstItems)
        Me.grpTreasure.Controls.Add(Me.lstGoods)
        Me.grpTreasure.Controls.Add(Me.Label3)
        Me.grpTreasure.Controls.Add(Me.Label2)
        Me.grpTreasure.Controls.Add(Me.Label1)
        Me.grpTreasure.Controls.Add(Me.lstCoins)
        Me.grpTreasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTreasure.Location = New System.Drawing.Point(12, 300)
        Me.grpTreasure.Name = "grpTreasure"
        Me.grpTreasure.Size = New System.Drawing.Size(1063, 373)
        Me.grpTreasure.TabIndex = 0
        Me.grpTreasure.TabStop = False
        Me.grpTreasure.Text = "Treasure"
        '
        'lstItems
        '
        Me.lstItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 16
        Me.lstItems.Items.AddRange(New Object() {"No Items"})
        Me.lstItems.Location = New System.Drawing.Point(617, 43)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(440, 324)
        Me.lstItems.TabIndex = 7
        '
        'lstGoods
        '
        Me.lstGoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGoods.FormattingEnabled = True
        Me.lstGoods.ItemHeight = 16
        Me.lstGoods.Items.AddRange(New Object() {"No Goods"})
        Me.lstGoods.Location = New System.Drawing.Point(170, 43)
        Me.lstGoods.Name = "lstGoods"
        Me.lstGoods.Size = New System.Drawing.Size(441, 324)
        Me.lstGoods.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(613, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Items:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Goods:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Coins:"
        '
        'lstCoins
        '
        Me.lstCoins.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCoins.FormattingEnabled = True
        Me.lstCoins.ItemHeight = 16
        Me.lstCoins.Items.AddRange(New Object() {"No Coins"})
        Me.lstCoins.Location = New System.Drawing.Point(6, 43)
        Me.lstCoins.Name = "lstCoins"
        Me.lstCoins.Size = New System.Drawing.Size(158, 324)
        Me.lstCoins.TabIndex = 0
        '
        'grpBooks
        '
        Me.grpBooks.Controls.Add(Me.btnMultiSource)
        Me.grpBooks.Controls.Add(Me.btnMIC)
        Me.grpBooks.Controls.Add(Me.btnEPH)
        Me.grpBooks.Controls.Add(Me.btnDMG)
        Me.grpBooks.Location = New System.Drawing.Point(12, 27)
        Me.grpBooks.Name = "grpBooks"
        Me.grpBooks.Size = New System.Drawing.Size(182, 123)
        Me.grpBooks.TabIndex = 1
        Me.grpBooks.TabStop = False
        Me.grpBooks.Text = "Treasure Chart"
        '
        'btnMultiSource
        '
        Me.btnMultiSource.AutoSize = True
        Me.btnMultiSource.Location = New System.Drawing.Point(6, 88)
        Me.btnMultiSource.Name = "btnMultiSource"
        Me.btnMultiSource.Size = New System.Drawing.Size(84, 17)
        Me.btnMultiSource.TabIndex = 9
        Me.btnMultiSource.Text = "Multi-Source"
        Me.btnMultiSource.UseVisualStyleBackColor = True
        '
        'btnMIC
        '
        Me.btnMIC.AutoSize = True
        Me.btnMIC.Enabled = False
        Me.btnMIC.Location = New System.Drawing.Point(6, 65)
        Me.btnMIC.Name = "btnMIC"
        Me.btnMIC.Size = New System.Drawing.Size(141, 17)
        Me.btnMIC.TabIndex = 8
        Me.btnMIC.Text = "Magic Item Compendium"
        Me.btnMIC.UseVisualStyleBackColor = True
        '
        'btnEPH
        '
        Me.btnEPH.AutoSize = True
        Me.btnEPH.Location = New System.Drawing.Point(6, 42)
        Me.btnEPH.Name = "btnEPH"
        Me.btnEPH.Size = New System.Drawing.Size(168, 17)
        Me.btnEPH.TabIndex = 7
        Me.btnEPH.Text = "Expanded Psionics Handbook"
        Me.btnEPH.UseVisualStyleBackColor = True
        '
        'btnDMG
        '
        Me.btnDMG.AutoSize = True
        Me.btnDMG.Checked = True
        Me.btnDMG.Location = New System.Drawing.Point(6, 19)
        Me.btnDMG.Name = "btnDMG"
        Me.btnDMG.Size = New System.Drawing.Size(140, 17)
        Me.btnDMG.TabIndex = 6
        Me.btnDMG.TabStop = True
        Me.btnDMG.Text = "Dungeon Masters Guide"
        Me.btnDMG.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 257)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(83, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'grpSpecial
        '
        Me.grpSpecial.Controls.Add(Me.btnNone)
        Me.grpSpecial.Controls.Add(Me.grpItems)
        Me.grpSpecial.Controls.Add(Me.btnTplStandard)
        Me.grpSpecial.Controls.Add(Me.grpGoods)
        Me.grpSpecial.Controls.Add(Me.grpCoins)
        Me.grpSpecial.Controls.Add(Me.btnNonstandard)
        Me.grpSpecial.Controls.Add(Me.btnDblStandard)
        Me.grpSpecial.Controls.Add(Me.btnStandard)
        Me.grpSpecial.Location = New System.Drawing.Point(620, 27)
        Me.grpSpecial.Name = "grpSpecial"
        Me.grpSpecial.Size = New System.Drawing.Size(455, 268)
        Me.grpSpecial.TabIndex = 3
        Me.grpSpecial.TabStop = False
        Me.grpSpecial.Text = "Special Treasure"
        '
        'btnNone
        '
        Me.btnNone.AutoSize = True
        Me.btnNone.Location = New System.Drawing.Point(392, 26)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(51, 17)
        Me.btnNone.TabIndex = 5
        Me.btnNone.Text = "None"
        Me.btnNone.UseVisualStyleBackColor = True
        '
        'grpItems
        '
        Me.grpItems.Controls.Add(Me.btnitemtpl)
        Me.grpItems.Controls.Add(Me.btnitem50)
        Me.grpItems.Controls.Add(Me.btnitemno)
        Me.grpItems.Controls.Add(Me.btnitemdbl)
        Me.grpItems.Controls.Add(Me.btnitemstd)
        Me.grpItems.Location = New System.Drawing.Point(280, 49)
        Me.grpItems.Name = "grpItems"
        Me.grpItems.Size = New System.Drawing.Size(131, 213)
        Me.grpItems.TabIndex = 4
        Me.grpItems.TabStop = False
        '
        'btnitemtpl
        '
        Me.btnitemtpl.AutoSize = True
        Me.btnitemtpl.Location = New System.Drawing.Point(6, 65)
        Me.btnitemtpl.Name = "btnitemtpl"
        Me.btnitemtpl.Size = New System.Drawing.Size(79, 17)
        Me.btnitemtpl.TabIndex = 5
        Me.btnitemtpl.Text = "Triple Items"
        Me.btnitemtpl.UseVisualStyleBackColor = True
        '
        'btnitem50
        '
        Me.btnitem50.AutoSize = True
        Me.btnitem50.Location = New System.Drawing.Point(6, 111)
        Me.btnitem50.Name = "btnitem50"
        Me.btnitem50.Size = New System.Drawing.Size(73, 17)
        Me.btnitem50.TabIndex = 4
        Me.btnitem50.Text = "50% Items"
        Me.btnitem50.UseVisualStyleBackColor = True
        '
        'btnitemno
        '
        Me.btnitemno.AutoSize = True
        Me.btnitemno.Location = New System.Drawing.Point(6, 88)
        Me.btnitemno.Name = "btnitemno"
        Me.btnitemno.Size = New System.Drawing.Size(67, 17)
        Me.btnitemno.TabIndex = 3
        Me.btnitemno.Text = "No Items"
        Me.btnitemno.UseVisualStyleBackColor = True
        '
        'btnitemdbl
        '
        Me.btnitemdbl.AutoSize = True
        Me.btnitemdbl.Location = New System.Drawing.Point(6, 42)
        Me.btnitemdbl.Name = "btnitemdbl"
        Me.btnitemdbl.Size = New System.Drawing.Size(87, 17)
        Me.btnitemdbl.TabIndex = 2
        Me.btnitemdbl.Text = "Double Items"
        Me.btnitemdbl.UseVisualStyleBackColor = True
        '
        'btnitemstd
        '
        Me.btnitemstd.AutoSize = True
        Me.btnitemstd.Checked = True
        Me.btnitemstd.Location = New System.Drawing.Point(6, 19)
        Me.btnitemstd.Name = "btnitemstd"
        Me.btnitemstd.Size = New System.Drawing.Size(96, 17)
        Me.btnitemstd.TabIndex = 1
        Me.btnitemstd.TabStop = True
        Me.btnitemstd.Text = "Standard Items"
        Me.btnitemstd.UseVisualStyleBackColor = True
        '
        'btnTplStandard
        '
        Me.btnTplStandard.AutoSize = True
        Me.btnTplStandard.Location = New System.Drawing.Point(197, 26)
        Me.btnTplStandard.Name = "btnTplStandard"
        Me.btnTplStandard.Size = New System.Drawing.Size(97, 17)
        Me.btnTplStandard.TabIndex = 6
        Me.btnTplStandard.Text = "Triple Standard"
        Me.btnTplStandard.UseVisualStyleBackColor = True
        '
        'grpGoods
        '
        Me.grpGoods.Controls.Add(Me.btngoodtpl)
        Me.grpGoods.Controls.Add(Me.btngood50)
        Me.grpGoods.Controls.Add(Me.btngoodno)
        Me.grpGoods.Controls.Add(Me.btngooddbl)
        Me.grpGoods.Controls.Add(Me.btngoodstd)
        Me.grpGoods.Location = New System.Drawing.Point(143, 49)
        Me.grpGoods.Name = "grpGoods"
        Me.grpGoods.Size = New System.Drawing.Size(131, 213)
        Me.grpGoods.TabIndex = 4
        Me.grpGoods.TabStop = False
        '
        'btngoodtpl
        '
        Me.btngoodtpl.AutoSize = True
        Me.btngoodtpl.Location = New System.Drawing.Point(6, 65)
        Me.btngoodtpl.Name = "btngoodtpl"
        Me.btngoodtpl.Size = New System.Drawing.Size(85, 17)
        Me.btngoodtpl.TabIndex = 6
        Me.btngoodtpl.Text = "Triple Goods"
        Me.btngoodtpl.UseVisualStyleBackColor = True
        '
        'btngood50
        '
        Me.btngood50.AutoSize = True
        Me.btngood50.Location = New System.Drawing.Point(6, 111)
        Me.btngood50.Name = "btngood50"
        Me.btngood50.Size = New System.Drawing.Size(79, 17)
        Me.btngood50.TabIndex = 5
        Me.btngood50.Text = "50% Goods"
        Me.btngood50.UseVisualStyleBackColor = True
        '
        'btngoodno
        '
        Me.btngoodno.AutoSize = True
        Me.btngoodno.Location = New System.Drawing.Point(6, 88)
        Me.btngoodno.Name = "btngoodno"
        Me.btngoodno.Size = New System.Drawing.Size(73, 17)
        Me.btngoodno.TabIndex = 3
        Me.btngoodno.Text = "No Goods"
        Me.btngoodno.UseVisualStyleBackColor = True
        '
        'btngooddbl
        '
        Me.btngooddbl.AutoSize = True
        Me.btngooddbl.Location = New System.Drawing.Point(6, 42)
        Me.btngooddbl.Name = "btngooddbl"
        Me.btngooddbl.Size = New System.Drawing.Size(93, 17)
        Me.btngooddbl.TabIndex = 2
        Me.btngooddbl.Text = "Double Goods"
        Me.btngooddbl.UseVisualStyleBackColor = True
        '
        'btngoodstd
        '
        Me.btngoodstd.AutoSize = True
        Me.btngoodstd.Checked = True
        Me.btngoodstd.Location = New System.Drawing.Point(6, 19)
        Me.btngoodstd.Name = "btngoodstd"
        Me.btngoodstd.Size = New System.Drawing.Size(102, 17)
        Me.btngoodstd.TabIndex = 1
        Me.btngoodstd.TabStop = True
        Me.btngoodstd.Text = "Standard Goods"
        Me.btngoodstd.UseVisualStyleBackColor = True
        '
        'grpCoins
        '
        Me.grpCoins.Controls.Add(Me.btncointpl)
        Me.grpCoins.Controls.Add(Me.chkCoinTweak)
        Me.grpCoins.Controls.Add(Me.btncoin50)
        Me.grpCoins.Controls.Add(Me.btncoinno)
        Me.grpCoins.Controls.Add(Me.btncoin10)
        Me.grpCoins.Controls.Add(Me.btncoindbl)
        Me.grpCoins.Controls.Add(Me.btncoinstd)
        Me.grpCoins.Location = New System.Drawing.Point(6, 49)
        Me.grpCoins.Name = "grpCoins"
        Me.grpCoins.Size = New System.Drawing.Size(131, 213)
        Me.grpCoins.TabIndex = 3
        Me.grpCoins.TabStop = False
        '
        'btncointpl
        '
        Me.btncointpl.AutoSize = True
        Me.btncointpl.Location = New System.Drawing.Point(6, 65)
        Me.btncointpl.Name = "btncointpl"
        Me.btncointpl.Size = New System.Drawing.Size(80, 17)
        Me.btncointpl.TabIndex = 7
        Me.btncointpl.Text = "Triple Coins"
        Me.btncointpl.UseVisualStyleBackColor = True
        '
        'chkCoinTweak
        '
        Me.chkCoinTweak.AutoSize = True
        Me.chkCoinTweak.Location = New System.Drawing.Point(6, 190)
        Me.chkCoinTweak.Name = "chkCoinTweak"
        Me.chkCoinTweak.Size = New System.Drawing.Size(83, 17)
        Me.chkCoinTweak.TabIndex = 6
        Me.chkCoinTweak.Text = "Coin Tweak"
        Me.chkCoinTweak.UseVisualStyleBackColor = True
        '
        'btncoin50
        '
        Me.btncoin50.AutoSize = True
        Me.btncoin50.Location = New System.Drawing.Point(6, 111)
        Me.btncoin50.Name = "btncoin50"
        Me.btncoin50.Size = New System.Drawing.Size(71, 17)
        Me.btncoin50.TabIndex = 6
        Me.btncoin50.Text = "1/2 Coins"
        Me.btncoin50.UseVisualStyleBackColor = True
        '
        'btncoinno
        '
        Me.btncoinno.AutoSize = True
        Me.btncoinno.Location = New System.Drawing.Point(6, 88)
        Me.btncoinno.Name = "btncoinno"
        Me.btncoinno.Size = New System.Drawing.Size(68, 17)
        Me.btncoinno.TabIndex = 4
        Me.btncoinno.Text = "No Coins"
        Me.btncoinno.UseVisualStyleBackColor = True
        '
        'btncoin10
        '
        Me.btncoin10.AutoSize = True
        Me.btncoin10.Location = New System.Drawing.Point(6, 134)
        Me.btncoin10.Name = "btncoin10"
        Me.btncoin10.Size = New System.Drawing.Size(77, 17)
        Me.btncoin10.TabIndex = 3
        Me.btncoin10.Text = "1/10 Coins"
        Me.btncoin10.UseVisualStyleBackColor = True
        '
        'btncoindbl
        '
        Me.btncoindbl.AutoSize = True
        Me.btncoindbl.Location = New System.Drawing.Point(6, 42)
        Me.btncoindbl.Name = "btncoindbl"
        Me.btncoindbl.Size = New System.Drawing.Size(88, 17)
        Me.btncoindbl.TabIndex = 2
        Me.btncoindbl.Text = "Double Coins"
        Me.btncoindbl.UseVisualStyleBackColor = True
        '
        'btncoinstd
        '
        Me.btncoinstd.AutoSize = True
        Me.btncoinstd.Checked = True
        Me.btncoinstd.Location = New System.Drawing.Point(6, 19)
        Me.btncoinstd.Name = "btncoinstd"
        Me.btncoinstd.Size = New System.Drawing.Size(91, 17)
        Me.btncoinstd.TabIndex = 1
        Me.btncoinstd.TabStop = True
        Me.btncoinstd.Text = "Stadard Coins"
        Me.btncoinstd.UseVisualStyleBackColor = True
        '
        'btnNonstandard
        '
        Me.btnNonstandard.AutoSize = True
        Me.btnNonstandard.Location = New System.Drawing.Point(300, 26)
        Me.btnNonstandard.Name = "btnNonstandard"
        Me.btnNonstandard.Size = New System.Drawing.Size(86, 17)
        Me.btnNonstandard.TabIndex = 2
        Me.btnNonstandard.Text = "Nonstandard"
        Me.btnNonstandard.UseVisualStyleBackColor = True
        '
        'btnDblStandard
        '
        Me.btnDblStandard.AutoSize = True
        Me.btnDblStandard.Location = New System.Drawing.Point(86, 26)
        Me.btnDblStandard.Name = "btnDblStandard"
        Me.btnDblStandard.Size = New System.Drawing.Size(105, 17)
        Me.btnDblStandard.TabIndex = 1
        Me.btnDblStandard.Text = "Double Standard"
        Me.btnDblStandard.UseVisualStyleBackColor = True
        '
        'btnStandard
        '
        Me.btnStandard.AutoSize = True
        Me.btnStandard.Checked = True
        Me.btnStandard.Location = New System.Drawing.Point(12, 26)
        Me.btnStandard.Name = "btnStandard"
        Me.btnStandard.Size = New System.Drawing.Size(68, 17)
        Me.btnStandard.TabIndex = 0
        Me.btnStandard.TabStop = True
        Me.btnStandard.Text = "Standard"
        Me.btnStandard.UseVisualStyleBackColor = True
        '
        'spnLevel
        '
        Me.spnLevel.Location = New System.Drawing.Point(50, 231)
        Me.spnLevel.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.spnLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnLevel.Name = "spnLevel"
        Me.spnLevel.Size = New System.Drawing.Size(45, 20)
        Me.spnLevel.TabIndex = 4
        Me.spnLevel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Level:"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(101, 257)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(83, 23)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1082, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExportToolStripMenuItem.Text = "&Export"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(104, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeepToolStripMenuItem, Me.FreezeToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'KeepToolStripMenuItem
        '
        Me.KeepToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeepCoinsToolStripMenuItem, Me.KeepGoodsToolStripMenuItem, Me.KeepItemsToolStripMenuItem})
        Me.KeepToolStripMenuItem.Name = "KeepToolStripMenuItem"
        Me.KeepToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeepToolStripMenuItem.Text = "Keep"
        '
        'KeepCoinsToolStripMenuItem
        '
        Me.KeepCoinsToolStripMenuItem.Name = "KeepCoinsToolStripMenuItem"
        Me.KeepCoinsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.KeepCoinsToolStripMenuItem.Text = "Keep Coins"
        '
        'KeepGoodsToolStripMenuItem
        '
        Me.KeepGoodsToolStripMenuItem.Name = "KeepGoodsToolStripMenuItem"
        Me.KeepGoodsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.KeepGoodsToolStripMenuItem.Text = "Keep Goods"
        '
        'KeepItemsToolStripMenuItem
        '
        Me.KeepItemsToolStripMenuItem.Name = "KeepItemsToolStripMenuItem"
        Me.KeepItemsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.KeepItemsToolStripMenuItem.Text = "Keep Items"
        '
        'FreezeToolStripMenuItem
        '
        Me.FreezeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FreezeCoinsToolStripMenuItem, Me.FreezeGoodsToolStripMenuItem, Me.FreezeItemsToolStripMenuItem})
        Me.FreezeToolStripMenuItem.Name = "FreezeToolStripMenuItem"
        Me.FreezeToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.FreezeToolStripMenuItem.Text = "Freeze"
        '
        'FreezeCoinsToolStripMenuItem
        '
        Me.FreezeCoinsToolStripMenuItem.Name = "FreezeCoinsToolStripMenuItem"
        Me.FreezeCoinsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FreezeCoinsToolStripMenuItem.Text = "Freeze Coins"
        '
        'FreezeGoodsToolStripMenuItem
        '
        Me.FreezeGoodsToolStripMenuItem.Name = "FreezeGoodsToolStripMenuItem"
        Me.FreezeGoodsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FreezeGoodsToolStripMenuItem.Text = "Freeze Goods"
        '
        'FreezeItemsToolStripMenuItem
        '
        Me.FreezeItemsToolStripMenuItem.Name = "FreezeItemsToolStripMenuItem"
        Me.FreezeItemsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FreezeItemsToolStripMenuItem.Text = "Freeze Items"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'grpPercent
        '
        Me.grpPercent.Controls.Add(Me.Label6)
        Me.grpPercent.Controls.Add(Me.Label5)
        Me.grpPercent.Controls.Add(Me.spnPercentXPH)
        Me.grpPercent.Controls.Add(Me.spnPercentDMG)
        Me.grpPercent.Location = New System.Drawing.Point(200, 27)
        Me.grpPercent.Name = "grpPercent"
        Me.grpPercent.Size = New System.Drawing.Size(219, 123)
        Me.grpPercent.TabIndex = 8
        Me.grpPercent.TabStop = False
        Me.grpPercent.Text = "Multi-Source Percentages"
        Me.grpPercent.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Expanded Psionic Handbook"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Dungeon Masters Guide"
        '
        'spnPercentXPH
        '
        Me.spnPercentXPH.Location = New System.Drawing.Point(6, 45)
        Me.spnPercentXPH.Name = "spnPercentXPH"
        Me.spnPercentXPH.Size = New System.Drawing.Size(45, 20)
        Me.spnPercentXPH.TabIndex = 1
        '
        'spnPercentDMG
        '
        Me.spnPercentDMG.Location = New System.Drawing.Point(6, 19)
        Me.spnPercentDMG.Name = "spnPercentDMG"
        Me.spnPercentDMG.Size = New System.Drawing.Size(45, 20)
        Me.spnPercentDMG.TabIndex = 0
        Me.spnPercentDMG.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'frmTreasure
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 685)
        Me.Controls.Add(Me.grpPercent)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.spnLevel)
        Me.Controls.Add(Me.grpSpecial)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.grpBooks)
        Me.Controls.Add(Me.grpTreasure)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTreasure"
        Me.Text = "DJ's Treasure Generator v.3.0.0"
        Me.grpTreasure.ResumeLayout(False)
        Me.grpTreasure.PerformLayout()
        Me.grpBooks.ResumeLayout(False)
        Me.grpBooks.PerformLayout()
        Me.grpSpecial.ResumeLayout(False)
        Me.grpSpecial.PerformLayout()
        Me.grpItems.ResumeLayout(False)
        Me.grpItems.PerformLayout()
        Me.grpGoods.ResumeLayout(False)
        Me.grpGoods.PerformLayout()
        Me.grpCoins.ResumeLayout(False)
        Me.grpCoins.PerformLayout()
        CType(Me.spnLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpPercent.ResumeLayout(False)
        Me.grpPercent.PerformLayout()
        CType(Me.spnPercentXPH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnPercentDMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpTreasure As System.Windows.Forms.GroupBox
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents lstGoods As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCoins As System.Windows.Forms.ListBox
    Friend WithEvents grpBooks As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents grpSpecial As System.Windows.Forms.GroupBox
    Friend WithEvents spnLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnNonstandard As System.Windows.Forms.RadioButton
    Friend WithEvents btnDblStandard As System.Windows.Forms.RadioButton
    Friend WithEvents btnStandard As System.Windows.Forms.RadioButton
    Friend WithEvents grpCoins As System.Windows.Forms.GroupBox
    Friend WithEvents btncoindbl As System.Windows.Forms.RadioButton
    Friend WithEvents btncoinstd As System.Windows.Forms.RadioButton
    Friend WithEvents grpItems As System.Windows.Forms.GroupBox
    Friend WithEvents btnitemdbl As System.Windows.Forms.RadioButton
    Friend WithEvents btnitemstd As System.Windows.Forms.RadioButton
    Friend WithEvents grpGoods As System.Windows.Forms.GroupBox
    Friend WithEvents btngooddbl As System.Windows.Forms.RadioButton
    Friend WithEvents btngoodstd As System.Windows.Forms.RadioButton
    Friend WithEvents btnNone As System.Windows.Forms.RadioButton
    Friend WithEvents btncoinno As System.Windows.Forms.RadioButton
    Friend WithEvents btncoin10 As System.Windows.Forms.RadioButton
    Friend WithEvents btnMIC As System.Windows.Forms.RadioButton
    Friend WithEvents btnEPH As System.Windows.Forms.RadioButton
    Friend WithEvents btnDMG As System.Windows.Forms.RadioButton
    Friend WithEvents btnitem50 As System.Windows.Forms.RadioButton
    Friend WithEvents btnitemno As System.Windows.Forms.RadioButton
    Friend WithEvents btngood50 As System.Windows.Forms.RadioButton
    Friend WithEvents btngoodno As System.Windows.Forms.RadioButton
    Friend WithEvents btncoin50 As System.Windows.Forms.RadioButton
    Friend WithEvents chkCoinTweak As System.Windows.Forms.CheckBox
    Friend WithEvents btnTplStandard As System.Windows.Forms.RadioButton
    Friend WithEvents btncointpl As System.Windows.Forms.RadioButton
    Friend WithEvents btnitemtpl As System.Windows.Forms.RadioButton
    Friend WithEvents btngoodtpl As System.Windows.Forms.RadioButton
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeepCoinsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeepGoodsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeepItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreezeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreezeCoinsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreezeGoodsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreezeItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMultiSource As System.Windows.Forms.RadioButton
    Friend WithEvents grpPercent As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents spnPercentXPH As System.Windows.Forms.NumericUpDown
    Friend WithEvents spnPercentDMG As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
