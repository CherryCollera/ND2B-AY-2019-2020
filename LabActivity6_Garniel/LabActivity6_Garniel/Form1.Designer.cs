namespace LabActivity6_Garniel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshToolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bSCSToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCSToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new LabActivity6_Garniel.studentsDataSet();
            this.tblStudent_InfoTableAdapter = new LabActivity6_Garniel.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this.bSITToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSITToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._2nd_YearToolStrip = new System.Windows.Forms.ToolStrip();
            this._2nd_YearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.address_Balanga1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.address_Balanga1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastname_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastname_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.section_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.section_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.firstnames_ConsonantToolStrip = new System.Windows.Forms.ToolStrip();
            this.firstnames_ConsonantToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.refreshToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.bSCSToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.bSITToolStrip.SuspendLayout();
            this._2nd_YearToolStrip.SuspendLayout();
            this.address_Balanga1ToolStrip.SuspendLayout();
            this.lastname_A_and_CToolStrip.SuspendLayout();
            this.section_2BToolStrip.SuspendLayout();
            this.firstnames_ConsonantToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.AutoSize = false;
            this.refreshToolStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(760, 282);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(106, 59);
            this.refreshToolStrip.Stretch = true;
            this.refreshToolStrip.TabIndex = 1;
            this.refreshToolStrip.Text = "refreshToolStrip";
            this.refreshToolStrip.UseWaitCursor = true;
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.AutoSize = false;
            this.refreshToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.refreshToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(50, 56);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.SteelBlue;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(341, 231);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.UseWaitCursor = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bSCSToolStrip
            // 
            this.bSCSToolStrip.AutoSize = false;
            this.bSCSToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSCSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCSToolStripButton});
            this.bSCSToolStrip.Location = new System.Drawing.Point(96, 282);
            this.bSCSToolStrip.Name = "bSCSToolStrip";
            this.bSCSToolStrip.Size = new System.Drawing.Size(111, 25);
            this.bSCSToolStrip.TabIndex = 3;
            this.bSCSToolStrip.Text = "bSCSToolStrip";
            this.bSCSToolStrip.UseWaitCursor = true;
            // 
            // bSCSToolStripButton
            // 
            this.bSCSToolStripButton.AutoSize = false;
            this.bSCSToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSCSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCSToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSCSToolStripButton.Name = "bSCSToolStripButton";
            this.bSCSToolStripButton.Size = new System.Drawing.Size(38, 22);
            this.bSCSToolStripButton.Text = "BSCS";
            this.bSCSToolStripButton.Click += new System.EventHandler(this.bSCSToolStripButton_Click);
            // 
            // studIDDataGridViewTextBoxColumn
            // 
            this.studIDDataGridViewTextBoxColumn.DataPropertyName = "StudID";
            this.studIDDataGridViewTextBoxColumn.HeaderText = "StudID";
            this.studIDDataGridViewTextBoxColumn.Name = "studIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // yearLevelDataGridViewTextBoxColumn
            // 
            this.yearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.Name = "yearLevelDataGridViewTextBoxColumn";
            // 
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tblStudent_Info";
            this.tblStudentInfoBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudent_InfoTableAdapter
            // 
            this.tblStudent_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // bSITToolStrip
            // 
            this.bSITToolStrip.AutoSize = false;
            this.bSITToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSITToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSITToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSITToolStripButton});
            this.bSITToolStrip.Location = new System.Drawing.Point(96, 316);
            this.bSITToolStrip.Name = "bSITToolStrip";
            this.bSITToolStrip.Size = new System.Drawing.Size(111, 25);
            this.bSITToolStrip.TabIndex = 4;
            this.bSITToolStrip.Text = "bSITToolStrip";
            this.bSITToolStrip.UseWaitCursor = true;
            // 
            // bSITToolStripButton
            // 
            this.bSITToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSITToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSITToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSITToolStripButton.Name = "bSITToolStripButton";
            this.bSITToolStripButton.Size = new System.Drawing.Size(34, 22);
            this.bSITToolStripButton.Text = "BSIT";
            this.bSITToolStripButton.Click += new System.EventHandler(this.bSITToolStripButton_Click);
            // 
            // _2nd_YearToolStrip
            // 
            this._2nd_YearToolStrip.AutoSize = false;
            this._2nd_YearToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._2nd_YearToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2nd_YearToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2nd_YearToolStripButton});
            this._2nd_YearToolStrip.Location = new System.Drawing.Point(239, 282);
            this._2nd_YearToolStrip.Name = "_2nd_YearToolStrip";
            this._2nd_YearToolStrip.Size = new System.Drawing.Size(143, 25);
            this._2nd_YearToolStrip.TabIndex = 5;
            this._2nd_YearToolStrip.Text = "_2nd_YearToolStrip";
            this._2nd_YearToolStrip.UseWaitCursor = true;
            // 
            // _2nd_YearToolStripButton
            // 
            this._2nd_YearToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._2nd_YearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2nd_YearToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._2nd_YearToolStripButton.Name = "_2nd_YearToolStripButton";
            this._2nd_YearToolStripButton.Size = new System.Drawing.Size(63, 22);
            this._2nd_YearToolStripButton.Text = "_2nd_Year";
            this._2nd_YearToolStripButton.Click += new System.EventHandler(this._2nd_YearToolStripButton_Click);
            // 
            // address_Balanga1ToolStrip
            // 
            this.address_Balanga1ToolStrip.AutoSize = false;
            this.address_Balanga1ToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.address_Balanga1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.address_Balanga1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.address_Balanga1ToolStripButton});
            this.address_Balanga1ToolStrip.Location = new System.Drawing.Point(239, 316);
            this.address_Balanga1ToolStrip.Name = "address_Balanga1ToolStrip";
            this.address_Balanga1ToolStrip.Size = new System.Drawing.Size(143, 25);
            this.address_Balanga1ToolStrip.TabIndex = 6;
            this.address_Balanga1ToolStrip.Text = "address_Balanga1ToolStrip";
            this.address_Balanga1ToolStrip.UseWaitCursor = true;
            // 
            // address_Balanga1ToolStripButton
            // 
            this.address_Balanga1ToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.address_Balanga1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.address_Balanga1ToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.address_Balanga1ToolStripButton.Name = "address_Balanga1ToolStripButton";
            this.address_Balanga1ToolStripButton.Size = new System.Drawing.Size(106, 22);
            this.address_Balanga1ToolStripButton.Text = "Address_Balanga1";
            this.address_Balanga1ToolStripButton.Click += new System.EventHandler(this.address_Balanga1ToolStripButton_Click);
            // 
            // lastname_A_and_CToolStrip
            // 
            this.lastname_A_and_CToolStrip.AutoSize = false;
            this.lastname_A_and_CToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastname_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lastname_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastname_A_and_CToolStripButton});
            this.lastname_A_and_CToolStrip.Location = new System.Drawing.Point(577, 316);
            this.lastname_A_and_CToolStrip.Name = "lastname_A_and_CToolStrip";
            this.lastname_A_and_CToolStrip.Size = new System.Drawing.Size(145, 25);
            this.lastname_A_and_CToolStrip.TabIndex = 7;
            this.lastname_A_and_CToolStrip.Text = "lastname_A_and_CToolStrip";
            this.lastname_A_and_CToolStrip.UseWaitCursor = true;
            // 
            // lastname_A_and_CToolStripButton
            // 
            this.lastname_A_and_CToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastname_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lastname_A_and_CToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastname_A_and_CToolStripButton.Name = "lastname_A_and_CToolStripButton";
            this.lastname_A_and_CToolStripButton.Size = new System.Drawing.Size(113, 22);
            this.lastname_A_and_CToolStripButton.Text = "Lastname_A_and_C";
            this.lastname_A_and_CToolStripButton.Click += new System.EventHandler(this.lastname_A_and_CToolStripButton_Click);
            // 
            // section_2BToolStrip
            // 
            this.section_2BToolStrip.AutoSize = false;
            this.section_2BToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.section_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.section_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.section_2BToolStripButton});
            this.section_2BToolStrip.Location = new System.Drawing.Point(421, 316);
            this.section_2BToolStrip.Name = "section_2BToolStrip";
            this.section_2BToolStrip.Size = new System.Drawing.Size(143, 25);
            this.section_2BToolStrip.TabIndex = 8;
            this.section_2BToolStrip.Text = "section_2BToolStrip";
            this.section_2BToolStrip.UseWaitCursor = true;
            // 
            // section_2BToolStripButton
            // 
            this.section_2BToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.section_2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.section_2BToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.section_2BToolStripButton.Name = "section_2BToolStripButton";
            this.section_2BToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.section_2BToolStripButton.Text = "Section_2B";
            this.section_2BToolStripButton.Click += new System.EventHandler(this.section_2BToolStripButton_Click);
            // 
            // firstnames_ConsonantToolStrip
            // 
            this.firstnames_ConsonantToolStrip.AutoSize = false;
            this.firstnames_ConsonantToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstnames_ConsonantToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.firstnames_ConsonantToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstnames_ConsonantToolStripButton});
            this.firstnames_ConsonantToolStrip.Location = new System.Drawing.Point(421, 282);
            this.firstnames_ConsonantToolStrip.Name = "firstnames_ConsonantToolStrip";
            this.firstnames_ConsonantToolStrip.Size = new System.Drawing.Size(301, 25);
            this.firstnames_ConsonantToolStrip.TabIndex = 9;
            this.firstnames_ConsonantToolStrip.Text = "firstnames_ConsonantToolStrip";
            this.firstnames_ConsonantToolStrip.UseWaitCursor = true;
            // 
            // firstnames_ConsonantToolStripButton
            // 
            this.firstnames_ConsonantToolStripButton.AutoSize = false;
            this.firstnames_ConsonantToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstnames_ConsonantToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.firstnames_ConsonantToolStripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstnames_ConsonantToolStripButton.Name = "firstnames_ConsonantToolStripButton";
            this.firstnames_ConsonantToolStripButton.Size = new System.Drawing.Size(131, 22);
            this.firstnames_ConsonantToolStripButton.Text = "Firstnames_Consonant";
            this.firstnames_ConsonantToolStripButton.Click += new System.EventHandler(this.firstnames_ConsonantToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "STUDENT\'S RECORD MONITORING SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstnames_ConsonantToolStrip);
            this.Controls.Add(this.section_2BToolStrip);
            this.Controls.Add(this.lastname_A_and_CToolStrip);
            this.Controls.Add(this.address_Balanga1ToolStrip);
            this.Controls.Add(this._2nd_YearToolStrip);
            this.Controls.Add(this.bSITToolStrip);
            this.Controls.Add(this.bSCSToolStrip);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.refreshToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "STUDENT\'S RECORD MONITORING SYSTEM";
            this.TransparencyKey = System.Drawing.Color.White;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.refreshToolStrip.ResumeLayout(false);
            this.refreshToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.bSCSToolStrip.ResumeLayout(false);
            this.bSCSToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.bSITToolStrip.ResumeLayout(false);
            this.bSITToolStrip.PerformLayout();
            this._2nd_YearToolStrip.ResumeLayout(false);
            this._2nd_YearToolStrip.PerformLayout();
            this.address_Balanga1ToolStrip.ResumeLayout(false);
            this.address_Balanga1ToolStrip.PerformLayout();
            this.lastname_A_and_CToolStrip.ResumeLayout(false);
            this.lastname_A_and_CToolStrip.PerformLayout();
            this.section_2BToolStrip.ResumeLayout(false);
            this.section_2BToolStrip.PerformLayout();
            this.firstnames_ConsonantToolStrip.ResumeLayout(false);
            this.firstnames_ConsonantToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private studentsDataSetTableAdapters.tblStudent_InfoTableAdapter tblStudent_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip refreshToolStrip;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip bSCSToolStrip;
        private System.Windows.Forms.ToolStripButton bSCSToolStripButton;
        private System.Windows.Forms.ToolStrip bSITToolStrip;
        private System.Windows.Forms.ToolStripButton bSITToolStripButton;
        private System.Windows.Forms.ToolStrip _2nd_YearToolStrip;
        private System.Windows.Forms.ToolStripButton _2nd_YearToolStripButton;
        private System.Windows.Forms.ToolStrip address_Balanga1ToolStrip;
        private System.Windows.Forms.ToolStripButton address_Balanga1ToolStripButton;
        private System.Windows.Forms.ToolStrip lastname_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton lastname_A_and_CToolStripButton;
        private System.Windows.Forms.ToolStrip section_2BToolStrip;
        private System.Windows.Forms.ToolStripButton section_2BToolStripButton;
        private System.Windows.Forms.ToolStrip firstnames_ConsonantToolStrip;
        private System.Windows.Forms.ToolStripButton firstnames_ConsonantToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}

