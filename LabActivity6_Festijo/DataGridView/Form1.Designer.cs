namespace DataGridView
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.address_BalangaToolStrip = new System.Windows.Forms.ToolStrip();
            this.address_BalangaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bCSS_studentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.BSCS_studentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bSIT_studentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSIT_studentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.second_Year_studentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.second_Year_studentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
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
            this.studentsDataSet = new DataGridView.studentsDataSet();
            this.tblStudent_InfoTableAdapter = new DataGridView.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this.lastnames_that_start_with_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastnames_that_start_with_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.section_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.section_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.firstnames_that_start__with_consonant_lettersToolStrip = new System.Windows.Forms.ToolStrip();
            this.firstnames_that_start__with_consonant_lettersToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.address_BalangaToolStrip.SuspendLayout();
            this.bCSS_studentsToolStrip.SuspendLayout();
            this.bSIT_studentsToolStrip.SuspendLayout();
            this.second_Year_studentsToolStrip.SuspendLayout();
            this.refreshToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.lastnames_that_start_with_A_and_CToolStrip.SuspendLayout();
            this.section_2BToolStrip.SuspendLayout();
            this.firstnames_that_start__with_consonant_lettersToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblStudentInfoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(941, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // address_BalangaToolStrip
            // 
            this.address_BalangaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.address_BalangaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.address_BalangaToolStripButton});
            this.address_BalangaToolStrip.Location = new System.Drawing.Point(12, 227);
            this.address_BalangaToolStrip.Name = "address_BalangaToolStrip";
            this.address_BalangaToolStrip.Size = new System.Drawing.Size(112, 25);
            this.address_BalangaToolStrip.TabIndex = 2;
            this.address_BalangaToolStrip.Text = "address_BalangaToolStrip";
            // 
            // address_BalangaToolStripButton
            // 
            this.address_BalangaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.address_BalangaToolStripButton.Name = "address_BalangaToolStripButton";
            this.address_BalangaToolStripButton.Size = new System.Drawing.Size(100, 22);
            this.address_BalangaToolStripButton.Text = "Address_Balanga";
            this.address_BalangaToolStripButton.Click += new System.EventHandler(this.address_BalangaToolStripButton_Click);
            // 
            // bCSS_studentsToolStrip
            // 
            this.bCSS_studentsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bCSS_studentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BSCS_studentsToolStripButton});
            this.bCSS_studentsToolStrip.Location = new System.Drawing.Point(12, 165);
            this.bCSS_studentsToolStrip.Name = "bCSS_studentsToolStrip";
            this.bCSS_studentsToolStrip.Size = new System.Drawing.Size(100, 25);
            this.bCSS_studentsToolStrip.TabIndex = 3;
            this.bCSS_studentsToolStrip.Text = "bCSS_studentsToolStrip";
            // 
            // BSCS_studentsToolStripButton
            // 
            this.BSCS_studentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BSCS_studentsToolStripButton.Name = "BSCS_studentsToolStripButton";
            this.BSCS_studentsToolStripButton.Size = new System.Drawing.Size(88, 22);
            this.BSCS_studentsToolStripButton.Text = "BSCS_students";
            this.BSCS_studentsToolStripButton.Click += new System.EventHandler(this.bCSS_studentsToolStripButton_Click);
            // 
            // bSIT_studentsToolStrip
            // 
            this.bSIT_studentsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSIT_studentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSIT_studentsToolStripButton});
            this.bSIT_studentsToolStrip.Location = new System.Drawing.Point(12, 190);
            this.bSIT_studentsToolStrip.Name = "bSIT_studentsToolStrip";
            this.bSIT_studentsToolStrip.Size = new System.Drawing.Size(96, 25);
            this.bSIT_studentsToolStrip.TabIndex = 4;
            this.bSIT_studentsToolStrip.Text = "bSIT_studentsToolStrip";
            // 
            // bSIT_studentsToolStripButton
            // 
            this.bSIT_studentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSIT_studentsToolStripButton.Name = "bSIT_studentsToolStripButton";
            this.bSIT_studentsToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.bSIT_studentsToolStripButton.Text = "BSIT_students";
            this.bSIT_studentsToolStripButton.Click += new System.EventHandler(this.bSIT_studentsToolStripButton_Click);
            // 
            // second_Year_studentsToolStrip
            // 
            this.second_Year_studentsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.second_Year_studentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.second_Year_studentsToolStripButton});
            this.second_Year_studentsToolStrip.Location = new System.Drawing.Point(133, 227);
            this.second_Year_studentsToolStrip.Name = "second_Year_studentsToolStrip";
            this.second_Year_studentsToolStrip.Size = new System.Drawing.Size(139, 25);
            this.second_Year_studentsToolStrip.TabIndex = 5;
            this.second_Year_studentsToolStrip.Text = "second_Year_studentsToolStrip";
            // 
            // second_Year_studentsToolStripButton
            // 
            this.second_Year_studentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.second_Year_studentsToolStripButton.Name = "second_Year_studentsToolStripButton";
            this.second_Year_studentsToolStripButton.Size = new System.Drawing.Size(127, 22);
            this.second_Year_studentsToolStripButton.Text = "Second_Year_students";
            this.second_Year_studentsToolStripButton.Click += new System.EventHandler(this.second_Year_studentsToolStripButton_Click);
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(871, 238);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(62, 25);
            this.refreshToolStrip.TabIndex = 6;
            this.refreshToolStrip.Text = "refreshToolStrip";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
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
            // lastnames_that_start_with_A_and_CToolStrip
            // 
            this.lastnames_that_start_with_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lastnames_that_start_with_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastnames_that_start_with_A_and_CToolStripButton});
            this.lastnames_that_start_with_A_and_CToolStrip.Location = new System.Drawing.Point(281, 227);
            this.lastnames_that_start_with_A_and_CToolStrip.Name = "lastnames_that_start_with_A_and_CToolStrip";
            this.lastnames_that_start_with_A_and_CToolStrip.Size = new System.Drawing.Size(212, 25);
            this.lastnames_that_start_with_A_and_CToolStrip.TabIndex = 7;
            this.lastnames_that_start_with_A_and_CToolStrip.Text = "lastnames_that_start_with_A_and_CToolStrip";
            // 
            // lastnames_that_start_with_A_and_CToolStripButton
            // 
            this.lastnames_that_start_with_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lastnames_that_start_with_A_and_CToolStripButton.Name = "lastnames_that_start_with_A_and_CToolStripButton";
            this.lastnames_that_start_with_A_and_CToolStripButton.Size = new System.Drawing.Size(200, 22);
            this.lastnames_that_start_with_A_and_CToolStripButton.Text = "Lastnames_that_start_with_A_and_C";
            this.lastnames_that_start_with_A_and_CToolStripButton.Click += new System.EventHandler(this.lastnames_that_start_with_A_and_CToolStripButton_Click);
            // 
            // section_2BToolStrip
            // 
            this.section_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.section_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.section_2BToolStripButton});
            this.section_2BToolStrip.Location = new System.Drawing.Point(502, 227);
            this.section_2BToolStrip.Name = "section_2BToolStrip";
            this.section_2BToolStrip.Size = new System.Drawing.Size(80, 25);
            this.section_2BToolStrip.TabIndex = 8;
            this.section_2BToolStrip.Text = "section_2BToolStrip";
            // 
            // section_2BToolStripButton
            // 
            this.section_2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.section_2BToolStripButton.Name = "section_2BToolStripButton";
            this.section_2BToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.section_2BToolStripButton.Text = "Section_2B";
            this.section_2BToolStripButton.Click += new System.EventHandler(this.section_2BToolStripButton_Click);
            // 
            // firstnames_that_start__with_consonant_lettersToolStrip
            // 
            this.firstnames_that_start__with_consonant_lettersToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.firstnames_that_start__with_consonant_lettersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstnames_that_start__with_consonant_lettersToolStripButton});
            this.firstnames_that_start__with_consonant_lettersToolStrip.Location = new System.Drawing.Point(133, 190);
            this.firstnames_that_start__with_consonant_lettersToolStrip.Name = "firstnames_that_start__with_consonant_lettersToolStrip";
            this.firstnames_that_start__with_consonant_lettersToolStrip.Size = new System.Drawing.Size(260, 25);
            this.firstnames_that_start__with_consonant_lettersToolStrip.TabIndex = 9;
            this.firstnames_that_start__with_consonant_lettersToolStrip.Text = "firstnames_that_start__with_consonant_lettersToolStrip";
            // 
            // firstnames_that_start__with_consonant_lettersToolStripButton
            // 
            this.firstnames_that_start__with_consonant_lettersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.firstnames_that_start__with_consonant_lettersToolStripButton.Name = "firstnames_that_start__with_consonant_lettersToolStripButton";
            this.firstnames_that_start__with_consonant_lettersToolStripButton.Size = new System.Drawing.Size(248, 22);
            this.firstnames_that_start__with_consonant_lettersToolStripButton.Text = "Firstnames_that_start_with_consonant_letters";
            this.firstnames_that_start__with_consonant_lettersToolStripButton.Click += new System.EventHandler(this.firstnames_that_start__with_consonant_lettersToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 283);
            this.Controls.Add(this.firstnames_that_start__with_consonant_lettersToolStrip);
            this.Controls.Add(this.section_2BToolStrip);
            this.Controls.Add(this.lastnames_that_start_with_A_and_CToolStrip);
            this.Controls.Add(this.refreshToolStrip);
            this.Controls.Add(this.second_Year_studentsToolStrip);
            this.Controls.Add(this.bSIT_studentsToolStrip);
            this.Controls.Add(this.bCSS_studentsToolStrip);
            this.Controls.Add(this.address_BalangaToolStrip);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.address_BalangaToolStrip.ResumeLayout(false);
            this.address_BalangaToolStrip.PerformLayout();
            this.bCSS_studentsToolStrip.ResumeLayout(false);
            this.bCSS_studentsToolStrip.PerformLayout();
            this.bSIT_studentsToolStrip.ResumeLayout(false);
            this.bSIT_studentsToolStrip.PerformLayout();
            this.second_Year_studentsToolStrip.ResumeLayout(false);
            this.second_Year_studentsToolStrip.PerformLayout();
            this.refreshToolStrip.ResumeLayout(false);
            this.refreshToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.lastnames_that_start_with_A_and_CToolStrip.ResumeLayout(false);
            this.lastnames_that_start_with_A_and_CToolStrip.PerformLayout();
            this.section_2BToolStrip.ResumeLayout(false);
            this.section_2BToolStrip.PerformLayout();
            this.firstnames_that_start__with_consonant_lettersToolStrip.ResumeLayout(false);
            this.firstnames_that_start__with_consonant_lettersToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.ToolStrip address_BalangaToolStrip;
        private System.Windows.Forms.ToolStripButton address_BalangaToolStripButton;
        private System.Windows.Forms.ToolStrip bCSS_studentsToolStrip;
        private System.Windows.Forms.ToolStripButton BSCS_studentsToolStripButton;
        private System.Windows.Forms.ToolStrip bSIT_studentsToolStrip;
        private System.Windows.Forms.ToolStripButton bSIT_studentsToolStripButton;
        private System.Windows.Forms.ToolStrip second_Year_studentsToolStrip;
        private System.Windows.Forms.ToolStripButton second_Year_studentsToolStripButton;
        private System.Windows.Forms.ToolStrip refreshToolStrip;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStrip lastnames_that_start_with_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton lastnames_that_start_with_A_and_CToolStripButton;
        private System.Windows.Forms.ToolStrip section_2BToolStrip;
        private System.Windows.Forms.ToolStripButton section_2BToolStripButton;
        private System.Windows.Forms.ToolStrip firstnames_that_start__with_consonant_lettersToolStrip;
        private System.Windows.Forms.ToolStripButton firstnames_that_start__with_consonant_lettersToolStripButton;
    }
}

