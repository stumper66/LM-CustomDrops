
namespace LM_CustomDrops
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboMobOrGroup = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dtMobOrGroup = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dtItem = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.nameIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobOrGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noMultiplierDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noSpawnerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.enchantmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equippedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dvMain = new System.Data.DataView();
            this.lstMobOrGroup = new System.Windows.Forms.ListBox();
            this.cmenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMobOrGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleOverrideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.cboMaterials = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEquipped = new System.Windows.Forms.CheckBox();
            this.chkNoSpawner = new System.Windows.Forms.CheckBox();
            this.chkNoMultiplier = new System.Windows.Forms.CheckBox();
            this.numChance = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numMaxValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMinValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkOverride = new System.Windows.Forms.CheckBox();
            this.btnShowAllItems = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.cmenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnchantments = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMobOrGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            this.cmenu1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinValue)).BeginInit();
            this.cmenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cboMobOrGroup
            // 
            this.cboMobOrGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMobOrGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMobOrGroup.FormattingEnabled = true;
            this.cboMobOrGroup.Location = new System.Drawing.Point(9, 48);
            this.cboMobOrGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cboMobOrGroup.Name = "cboMobOrGroup";
            this.cboMobOrGroup.Size = new System.Drawing.Size(174, 21);
            this.cboMobOrGroup.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(186, 48);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(56, 20);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mob or group:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtMobOrGroup,
            this.dtItem});
            // 
            // dtMobOrGroup
            // 
            this.dtMobOrGroup.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn19});
            this.dtMobOrGroup.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Id"}, true)});
            this.dtMobOrGroup.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.dtMobOrGroup.TableName = "MobOrGroup";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.AutoIncrement = true;
            this.dataColumn1.ColumnName = "Id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Name";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "Override";
            this.dataColumn19.DataType = typeof(bool);
            this.dataColumn19.DefaultValue = false;
            // 
            // dtItem
            // 
            this.dtItem.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn18});
            this.dtItem.TableName = "Item";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "NameId";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Material";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "MinLevel";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "MaxLevel";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Chance";
            this.dataColumn7.DataType = typeof(double);
            // 
            // dataColumn8
            // 
            this.dataColumn8.AllowDBNull = false;
            this.dataColumn8.ColumnName = "Amount";
            this.dataColumn8.DefaultValue = "1";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "NoMultiplier";
            this.dataColumn9.DataType = typeof(bool);
            this.dataColumn9.DefaultValue = false;
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "NoSpawner";
            this.dataColumn10.DataType = typeof(bool);
            this.dataColumn10.DefaultValue = false;
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Enchantments";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "GroupId";
            this.dataColumn12.DataType = typeof(int);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Lore";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "CustomName";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Damage";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "Equipped";
            this.dataColumn16.DataType = typeof(bool);
            this.dataColumn16.DefaultValue = false;
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "MobOrGroup";
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToOrderColumns = true;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItem.AutoGenerateColumns = false;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameIdDataGridViewTextBoxColumn,
            this.mobOrGroupDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.minLevelDataGridViewTextBoxColumn,
            this.maxLevelDataGridViewTextBoxColumn,
            this.chanceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.noMultiplierDataGridViewCheckBoxColumn,
            this.noSpawnerDataGridViewCheckBoxColumn,
            this.enchantmentsDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn,
            this.loreDataGridViewTextBoxColumn,
            this.customNameDataGridViewTextBoxColumn,
            this.damageDataGridViewTextBoxColumn,
            this.equippedDataGridViewCheckBoxColumn});
            this.dgvItem.DataSource = this.dvMain;
            this.dgvItem.Location = new System.Drawing.Point(163, 154);
            this.dgvItem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.Size = new System.Drawing.Size(724, 276);
            this.dgvItem.TabIndex = 5;
            this.dgvItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvItem_MouseClick);
            // 
            // nameIdDataGridViewTextBoxColumn
            // 
            this.nameIdDataGridViewTextBoxColumn.DataPropertyName = "NameId";
            this.nameIdDataGridViewTextBoxColumn.HeaderText = "NameId";
            this.nameIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameIdDataGridViewTextBoxColumn.Name = "nameIdDataGridViewTextBoxColumn";
            this.nameIdDataGridViewTextBoxColumn.Visible = false;
            this.nameIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobOrGroupDataGridViewTextBoxColumn
            // 
            this.mobOrGroupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mobOrGroupDataGridViewTextBoxColumn.DataPropertyName = "MobOrGroup";
            this.mobOrGroupDataGridViewTextBoxColumn.HeaderText = "MobOrGroup";
            this.mobOrGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobOrGroupDataGridViewTextBoxColumn.Name = "mobOrGroupDataGridViewTextBoxColumn";
            this.mobOrGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobOrGroupDataGridViewTextBoxColumn.Width = 93;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.Width = 69;
            // 
            // minLevelDataGridViewTextBoxColumn
            // 
            this.minLevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.minLevelDataGridViewTextBoxColumn.DataPropertyName = "MinLevel";
            this.minLevelDataGridViewTextBoxColumn.HeaderText = "MinLevel";
            this.minLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minLevelDataGridViewTextBoxColumn.Name = "minLevelDataGridViewTextBoxColumn";
            this.minLevelDataGridViewTextBoxColumn.Width = 75;
            // 
            // maxLevelDataGridViewTextBoxColumn
            // 
            this.maxLevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maxLevelDataGridViewTextBoxColumn.DataPropertyName = "MaxLevel";
            this.maxLevelDataGridViewTextBoxColumn.HeaderText = "MaxLevel";
            this.maxLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxLevelDataGridViewTextBoxColumn.Name = "maxLevelDataGridViewTextBoxColumn";
            this.maxLevelDataGridViewTextBoxColumn.Width = 78;
            // 
            // chanceDataGridViewTextBoxColumn
            // 
            this.chanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chanceDataGridViewTextBoxColumn.DataPropertyName = "Chance";
            dataGridViewCellStyle1.Format = "N4";
            dataGridViewCellStyle1.NullValue = null;
            this.chanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.chanceDataGridViewTextBoxColumn.HeaderText = "Chance";
            this.chanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chanceDataGridViewTextBoxColumn.Name = "chanceDataGridViewTextBoxColumn";
            this.chanceDataGridViewTextBoxColumn.Width = 69;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 68;
            // 
            // noMultiplierDataGridViewCheckBoxColumn
            // 
            this.noMultiplierDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noMultiplierDataGridViewCheckBoxColumn.DataPropertyName = "NoMultiplier";
            this.noMultiplierDataGridViewCheckBoxColumn.HeaderText = "NoMultiplier";
            this.noMultiplierDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.noMultiplierDataGridViewCheckBoxColumn.Name = "noMultiplierDataGridViewCheckBoxColumn";
            this.noMultiplierDataGridViewCheckBoxColumn.Width = 68;
            // 
            // noSpawnerDataGridViewCheckBoxColumn
            // 
            this.noSpawnerDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noSpawnerDataGridViewCheckBoxColumn.DataPropertyName = "NoSpawner";
            this.noSpawnerDataGridViewCheckBoxColumn.HeaderText = "NoSpawner";
            this.noSpawnerDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.noSpawnerDataGridViewCheckBoxColumn.Name = "noSpawnerDataGridViewCheckBoxColumn";
            this.noSpawnerDataGridViewCheckBoxColumn.Width = 69;
            // 
            // enchantmentsDataGridViewTextBoxColumn
            // 
            this.enchantmentsDataGridViewTextBoxColumn.DataPropertyName = "Enchantments";
            this.enchantmentsDataGridViewTextBoxColumn.HeaderText = "Enchantments";
            this.enchantmentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enchantmentsDataGridViewTextBoxColumn.Name = "enchantmentsDataGridViewTextBoxColumn";
            this.enchantmentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // loreDataGridViewTextBoxColumn
            // 
            this.loreDataGridViewTextBoxColumn.DataPropertyName = "Lore";
            this.loreDataGridViewTextBoxColumn.HeaderText = "Lore";
            this.loreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loreDataGridViewTextBoxColumn.Name = "loreDataGridViewTextBoxColumn";
            this.loreDataGridViewTextBoxColumn.Width = 125;
            // 
            // customNameDataGridViewTextBoxColumn
            // 
            this.customNameDataGridViewTextBoxColumn.DataPropertyName = "CustomName";
            this.customNameDataGridViewTextBoxColumn.HeaderText = "CustomName";
            this.customNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customNameDataGridViewTextBoxColumn.Name = "customNameDataGridViewTextBoxColumn";
            this.customNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // damageDataGridViewTextBoxColumn
            // 
            this.damageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.damageDataGridViewTextBoxColumn.DataPropertyName = "Damage";
            this.damageDataGridViewTextBoxColumn.HeaderText = "Damage";
            this.damageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.damageDataGridViewTextBoxColumn.Name = "damageDataGridViewTextBoxColumn";
            this.damageDataGridViewTextBoxColumn.Width = 72;
            // 
            // equippedDataGridViewCheckBoxColumn
            // 
            this.equippedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equippedDataGridViewCheckBoxColumn.DataPropertyName = "Equipped";
            this.equippedDataGridViewCheckBoxColumn.HeaderText = "Equipped";
            this.equippedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.equippedDataGridViewCheckBoxColumn.Name = "equippedDataGridViewCheckBoxColumn";
            this.equippedDataGridViewCheckBoxColumn.Width = 58;
            // 
            // dvMain
            // 
            this.dvMain.Table = this.dtItem;
            // 
            // lstMobOrGroup
            // 
            this.lstMobOrGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMobOrGroup.ContextMenuStrip = this.cmenu1;
            this.lstMobOrGroup.FormattingEnabled = true;
            this.lstMobOrGroup.Location = new System.Drawing.Point(9, 154);
            this.lstMobOrGroup.Margin = new System.Windows.Forms.Padding(2);
            this.lstMobOrGroup.Name = "lstMobOrGroup";
            this.lstMobOrGroup.Size = new System.Drawing.Size(150, 277);
            this.lstMobOrGroup.TabIndex = 6;
            this.lstMobOrGroup.SelectedIndexChanged += new System.EventHandler(this.lstMobOrGroup_SelectedIndexChanged);
            // 
            // cmenu1
            // 
            this.cmenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMobOrGroupToolStripMenuItem,
            this.toolStripMenuItem2,
            this.renameToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toggleOverrideToolStripMenuItem});
            this.cmenu1.Name = "cmenu1";
            this.cmenu1.Size = new System.Drawing.Size(186, 82);
            // 
            // deleteMobOrGroupToolStripMenuItem
            // 
            this.deleteMobOrGroupToolStripMenuItem.Name = "deleteMobOrGroupToolStripMenuItem";
            this.deleteMobOrGroupToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.deleteMobOrGroupToolStripMenuItem.Text = "Delete Mob or Group";
            this.deleteMobOrGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteMobOrGroupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 6);
            // 
            // toggleOverrideToolStripMenuItem
            // 
            this.toggleOverrideToolStripMenuItem.Name = "toggleOverrideToolStripMenuItem";
            this.toggleOverrideToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.toggleOverrideToolStripMenuItem.Text = "Toggle Override";
            this.toggleOverrideToolStripMenuItem.Click += new System.EventHandler(this.toggleOverrideToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Materials:";
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Enabled = false;
            this.btnAddMaterial.Location = new System.Drawing.Point(186, 89);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(80, 20);
            this.btnAddMaterial.TabIndex = 8;
            this.btnAddMaterial.Text = "Add material";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // cboMaterials
            // 
            this.cboMaterials.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaterials.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaterials.FormattingEnabled = true;
            this.cboMaterials.Location = new System.Drawing.Point(9, 89);
            this.cboMaterials.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaterials.Name = "cboMaterials";
            this.cboMaterials.Size = new System.Drawing.Size(174, 21);
            this.cboMaterials.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEnchantments);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGroupId);
            this.groupBox1.Controls.Add(this.chkEquipped);
            this.groupBox1.Controls.Add(this.chkNoSpawner);
            this.groupBox1.Controls.Add(this.chkNoMultiplier);
            this.groupBox1.Controls.Add(this.numChance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numMaxValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numMinValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(301, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(586, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defaults For New Items";
            // 
            // chkEquipped
            // 
            this.chkEquipped.AutoSize = true;
            this.chkEquipped.Location = new System.Drawing.Point(392, 25);
            this.chkEquipped.Margin = new System.Windows.Forms.Padding(2);
            this.chkEquipped.Name = "chkEquipped";
            this.chkEquipped.Size = new System.Drawing.Size(65, 17);
            this.chkEquipped.TabIndex = 10;
            this.chkEquipped.Text = "Equiped";
            this.chkEquipped.UseVisualStyleBackColor = true;
            // 
            // chkNoSpawner
            // 
            this.chkNoSpawner.AutoSize = true;
            this.chkNoSpawner.Location = new System.Drawing.Point(297, 45);
            this.chkNoSpawner.Margin = new System.Windows.Forms.Padding(2);
            this.chkNoSpawner.Name = "chkNoSpawner";
            this.chkNoSpawner.Size = new System.Drawing.Size(85, 17);
            this.chkNoSpawner.TabIndex = 9;
            this.chkNoSpawner.Text = "No Spawner";
            this.chkNoSpawner.UseVisualStyleBackColor = true;
            // 
            // chkNoMultiplier
            // 
            this.chkNoMultiplier.AutoSize = true;
            this.chkNoMultiplier.Location = new System.Drawing.Point(297, 23);
            this.chkNoMultiplier.Margin = new System.Windows.Forms.Padding(2);
            this.chkNoMultiplier.Name = "chkNoMultiplier";
            this.chkNoMultiplier.Size = new System.Drawing.Size(84, 17);
            this.chkNoMultiplier.TabIndex = 8;
            this.chkNoMultiplier.Text = "No Multiplier";
            this.chkNoMultiplier.UseVisualStyleBackColor = true;
            // 
            // numChance
            // 
            this.numChance.DecimalPlaces = 2;
            this.numChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numChance.Location = new System.Drawing.Point(210, 44);
            this.numChance.Margin = new System.Windows.Forms.Padding(2);
            this.numChance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChance.Name = "numChance";
            this.numChance.Size = new System.Drawing.Size(68, 20);
            this.numChance.TabIndex = 7;
            this.numChance.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chance:";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(210, 21);
            this.numAmount.Margin = new System.Windows.Forms.Padding(2);
            this.numAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(68, 20);
            this.numAmount.TabIndex = 5;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount:";
            // 
            // numMaxValue
            // 
            this.numMaxValue.Location = new System.Drawing.Point(74, 44);
            this.numMaxValue.Margin = new System.Windows.Forms.Padding(2);
            this.numMaxValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMaxValue.Name = "numMaxValue";
            this.numMaxValue.Size = new System.Drawing.Size(68, 20);
            this.numMaxValue.TabIndex = 3;
            this.numMaxValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MaxLevel:";
            // 
            // numMinValue
            // 
            this.numMinValue.Location = new System.Drawing.Point(74, 21);
            this.numMinValue.Margin = new System.Windows.Forms.Padding(2);
            this.numMinValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMinValue.Name = "numMinValue";
            this.numMinValue.Size = new System.Drawing.Size(68, 20);
            this.numMinValue.TabIndex = 1;
            this.numMinValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "MinLevel:";
            // 
            // chkOverride
            // 
            this.chkOverride.AutoSize = true;
            this.chkOverride.Location = new System.Drawing.Point(186, 28);
            this.chkOverride.Margin = new System.Windows.Forms.Padding(2);
            this.chkOverride.Name = "chkOverride";
            this.chkOverride.Size = new System.Drawing.Size(66, 17);
            this.chkOverride.TabIndex = 11;
            this.chkOverride.Text = "Override";
            this.chkOverride.UseVisualStyleBackColor = true;
            // 
            // btnShowAllItems
            // 
            this.btnShowAllItems.Enabled = false;
            this.btnShowAllItems.Location = new System.Drawing.Point(163, 131);
            this.btnShowAllItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAllItems.Name = "btnShowAllItems";
            this.btnShowAllItems.Size = new System.Drawing.Size(94, 19);
            this.btnShowAllItems.TabIndex = 12;
            this.btnShowAllItems.Text = "Show all items";
            this.btnShowAllItems.UseVisualStyleBackColor = true;
            this.btnShowAllItems.Click += new System.EventHandler(this.btnShowAllItems_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "YML Files|*.yml|All Files|*.*";
            // 
            // SFD
            // 
            this.SFD.Filter = "YML Files|*.yml|All Files|*.*";
            // 
            // cmenu2
            // 
            this.cmenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemsToolStripMenuItem});
            this.cmenu2.Name = "cmenu2";
            this.cmenu2.Size = new System.Drawing.Size(158, 26);
            // 
            // removeItemsToolStripMenuItem
            // 
            this.removeItemsToolStripMenuItem.Name = "removeItemsToolStripMenuItem";
            this.removeItemsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.removeItemsToolStripMenuItem.Text = "Remove item(s)";
            this.removeItemsToolStripMenuItem.Click += new System.EventHandler(this.removeItemsToolStripMenuItem_Click);
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(443, 45);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(46, 20);
            this.txtGroupId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "GroupId:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Enchantments:";
            // 
            // txtEnchantments
            // 
            this.txtEnchantments.Location = new System.Drawing.Point(104, 69);
            this.txtEnchantments.Name = "txtEnchantments";
            this.txtEnchantments.Size = new System.Drawing.Size(385, 20);
            this.txtEnchantments.TabIndex = 13;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 445);
            this.Controls.Add(this.btnShowAllItems);
            this.Controls.Add(this.chkOverride);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.cboMaterials);
            this.Controls.Add(this.lstMobOrGroup);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cboMobOrGroup);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LM - Custom Drops Formatter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMobOrGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            this.cmenu1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinValue)).EndInit();
            this.cmenu2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboMobOrGroup;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtMobOrGroup;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable dtItem;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn18;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.ListBox lstMobOrGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.ComboBox cboMaterials;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMaxValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMinValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkNoSpawner;
        private System.Windows.Forms.CheckBox chkNoMultiplier;
        private System.Windows.Forms.NumericUpDown numChance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkEquipped;
        private System.Windows.Forms.CheckBox chkOverride;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataView dvMain;
        private System.Windows.Forms.Button btnShowAllItems;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobOrGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn noMultiplierDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn noSpawnerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enchantmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn equippedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmenu1;
        private System.Windows.Forms.ToolStripMenuItem deleteMobOrGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toggleOverrideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmenu2;
        private System.Windows.Forms.ToolStripMenuItem removeItemsToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnchantments;
    }
}

