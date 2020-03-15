namespace LabActivity4_quisim
{
    partial class Form4
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
            this.label_Snum = new System.Windows.Forms.Label();
            this.label_fnum = new System.Windows.Forms.Label();
            this.txtbox_snum = new System.Windows.Forms.TextBox();
            this.txtbox_fnum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.label_amnt = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Snum
            // 
            this.label_Snum.AutoSize = true;
            this.label_Snum.Location = new System.Drawing.Point(11, 68);
            this.label_Snum.Name = "label_Snum";
            this.label_Snum.Size = new System.Drawing.Size(87, 13);
            this.label_Snum.TabIndex = 11;
            this.label_Snum.Text = "Second Number:";
            // 
            // label_fnum
            // 
            this.label_fnum.AutoSize = true;
            this.label_fnum.Location = new System.Drawing.Point(11, 28);
            this.label_fnum.Name = "label_fnum";
            this.label_fnum.Size = new System.Drawing.Size(69, 13);
            this.label_fnum.TabIndex = 12;
            this.label_fnum.Text = "First Number:";
            // 
            // txtbox_snum
            // 
            this.txtbox_snum.Location = new System.Drawing.Point(107, 65);
            this.txtbox_snum.Name = "txtbox_snum";
            this.txtbox_snum.Size = new System.Drawing.Size(104, 20);
            this.txtbox_snum.TabIndex = 9;
            // 
            // txtbox_fnum
            // 
            this.txtbox_fnum.Location = new System.Drawing.Point(107, 25);
            this.txtbox_fnum.Name = "txtbox_fnum";
            this.txtbox_fnum.Size = new System.Drawing.Size(104, 20);
            this.txtbox_fnum.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(130, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(63, 234);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(46, 20);
            this.tb_amount.TabIndex = 9;
            // 
            // label_amnt
            // 
            this.label_amnt.AutoSize = true;
            this.label_amnt.Location = new System.Drawing.Point(11, 237);
            this.label_amnt.Name = "label_amnt";
            this.label_amnt.Size = new System.Drawing.Size(46, 13);
            this.label_amnt.TabIndex = 11;
            this.label_amnt.Text = "Amount:";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(113, 230);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 27);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(194, 230);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 27);
            this.btn_next.TabIndex = 14;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 283);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_amnt);
            this.Controls.Add(this.label_Snum);
            this.Controls.Add(this.label_fnum);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.txtbox_snum);
            this.Controls.Add(this.txtbox_fnum);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Snum;
        private System.Windows.Forms.Label label_fnum;
        private System.Windows.Forms.TextBox txtbox_snum;
        private System.Windows.Forms.TextBox txtbox_fnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label label_amnt;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
    }
}