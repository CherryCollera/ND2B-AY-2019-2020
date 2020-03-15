namespace LabActivity4_quisim
{
    partial class Form2
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
            this.btn_getmessage = new System.Windows.Forms.Button();
            this.txtbox_fname = new System.Windows.Forms.TextBox();
            this.label_fname = new System.Windows.Forms.Label();
            this.txtbox_lname = new System.Windows.Forms.TextBox();
            this.label_lname = new System.Windows.Forms.Label();
            this.btn_hide = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_getmessage
            // 
            this.btn_getmessage.Location = new System.Drawing.Point(74, 116);
            this.btn_getmessage.Name = "btn_getmessage";
            this.btn_getmessage.Size = new System.Drawing.Size(113, 45);
            this.btn_getmessage.TabIndex = 0;
            this.btn_getmessage.Text = "Get Message";
            this.btn_getmessage.UseVisualStyleBackColor = true;
            this.btn_getmessage.Click += new System.EventHandler(this.btn_getmessage_Click);
            // 
            // txtbox_fname
            // 
            this.txtbox_fname.Location = new System.Drawing.Point(74, 31);
            this.txtbox_fname.Name = "txtbox_fname";
            this.txtbox_fname.Size = new System.Drawing.Size(140, 20);
            this.txtbox_fname.TabIndex = 1;
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Location = new System.Drawing.Point(16, 34);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(55, 13);
            this.label_fname.TabIndex = 2;
            this.label_fname.Text = "Firstname:";
            // 
            // txtbox_lname
            // 
            this.txtbox_lname.Location = new System.Drawing.Point(74, 57);
            this.txtbox_lname.Name = "txtbox_lname";
            this.txtbox_lname.Size = new System.Drawing.Size(140, 20);
            this.txtbox_lname.TabIndex = 1;
            // 
            // label_lname
            // 
            this.label_lname.AutoSize = true;
            this.label_lname.Location = new System.Drawing.Point(16, 60);
            this.label_lname.Name = "label_lname";
            this.label_lname.Size = new System.Drawing.Size(56, 13);
            this.label_lname.TabIndex = 2;
            this.label_lname.Text = "Lastname:";
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(66, 227);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(76, 22);
            this.btn_hide.TabIndex = 0;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(148, 227);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label_lname);
            this.Controls.Add(this.label_fname);
            this.Controls.Add(this.txtbox_lname);
            this.Controls.Add(this.txtbox_fname);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_getmessage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getmessage;
        private System.Windows.Forms.TextBox txtbox_fname;
        private System.Windows.Forms.Label label_fname;
        private System.Windows.Forms.TextBox txtbox_lname;
        private System.Windows.Forms.Label label_lname;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button button_back;
    }
}