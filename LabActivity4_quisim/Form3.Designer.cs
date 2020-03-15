namespace LabActivity4_quisim
{
    partial class Form3
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
            this.label_lname = new System.Windows.Forms.Label();
            this.label_fname = new System.Windows.Forms.Label();
            this.txtbox_lname = new System.Windows.Forms.TextBox();
            this.txtbox_fname = new System.Windows.Forms.TextBox();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_getmyprofile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_hide = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_lname
            // 
            this.label_lname.AutoSize = true;
            this.label_lname.Location = new System.Drawing.Point(34, 125);
            this.label_lname.Name = "label_lname";
            this.label_lname.Size = new System.Drawing.Size(56, 13);
            this.label_lname.TabIndex = 7;
            this.label_lname.Text = "Lastname:";
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Location = new System.Drawing.Point(34, 85);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(55, 13);
            this.label_fname.TabIndex = 8;
            this.label_fname.Text = "Firstname:";
            // 
            // txtbox_lname
            // 
            this.txtbox_lname.Location = new System.Drawing.Point(111, 122);
            this.txtbox_lname.Name = "txtbox_lname";
            this.txtbox_lname.Size = new System.Drawing.Size(270, 20);
            this.txtbox_lname.TabIndex = 5;
            // 
            // txtbox_fname
            // 
            this.txtbox_fname.Location = new System.Drawing.Point(111, 82);
            this.txtbox_fname.Name = "txtbox_fname";
            this.txtbox_fname.Size = new System.Drawing.Size(270, 20);
            this.txtbox_fname.TabIndex = 6;
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(233, 278);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(76, 22);
            this.btn_hide.TabIndex = 3;
            this.btn_hide.Text = "Hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            // 
            // btn_getmyprofile
            // 
            this.btn_getmyprofile.Location = new System.Drawing.Point(26, 181);
            this.btn_getmyprofile.Name = "btn_getmyprofile";
            this.btn_getmyprofile.Size = new System.Drawing.Size(152, 45);
            this.btn_getmyprofile.TabIndex = 4;
            this.btn_getmyprofile.Text = "Get My Profile";
            this.btn_getmyprofile.UseVisualStyleBackColor = true;
            this.btn_getmyprofile.Click += new System.EventHandler(this.btn_getmyprofile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "My Profile";
            // 
            // button_hide
            // 
            this.button_hide.Location = new System.Drawing.Point(184, 181);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(102, 45);
            this.button_hide.TabIndex = 4;
            this.button_hide.Text = "Hide";
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(292, 181);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 45);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_lname);
            this.Controls.Add(this.label_fname);
            this.Controls.Add(this.txtbox_lname);
            this.Controls.Add(this.txtbox_fname);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_hide);
            this.Controls.Add(this.btn_getmyprofile);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_lname;
        private System.Windows.Forms.Label label_fname;
        private System.Windows.Forms.TextBox txtbox_lname;
        private System.Windows.Forms.TextBox txtbox_fname;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_getmyprofile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.Button button_back;
    }
}