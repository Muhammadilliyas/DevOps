namespace loginpage
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
            this.pss_txt = new System.Windows.Forms.TextBox();
            this.usr_nme_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.cncel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pss_txt
            // 
            this.pss_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pss_txt.Location = new System.Drawing.Point(271, 136);
            this.pss_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pss_txt.Name = "pss_txt";
            this.pss_txt.Size = new System.Drawing.Size(226, 36);
            this.pss_txt.TabIndex = 1;
            this.pss_txt.TextChanged += new System.EventHandler(this.pss_txt_TextChanged);
            // 
            // usr_nme_txt
            // 
            this.usr_nme_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_nme_txt.Location = new System.Drawing.Point(276, 88);
            this.usr_nme_txt.Margin = new System.Windows.Forms.Padding(2);
            this.usr_nme_txt.Name = "usr_nme_txt";
            this.usr_nme_txt.Size = new System.Drawing.Size(221, 36);
            this.usr_nme_txt.TabIndex = 2;
            this.usr_nme_txt.TextChanged += new System.EventHandler(this.usr_nme_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.login_btn.Location = new System.Drawing.Point(385, 198);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(126, 39);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // cncel_btn
            // 
            this.cncel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cncel_btn.Location = new System.Drawing.Point(221, 198);
            this.cncel_btn.Name = "cncel_btn";
            this.cncel_btn.Size = new System.Drawing.Size(126, 39);
            this.cncel_btn.TabIndex = 7;
            this.cncel_btn.Text = "CLEAR";
            this.cncel_btn.UseVisualStyleBackColor = true;
            this.cncel_btn.Click += new System.EventHandler(this.cncel_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 399);
            this.Controls.Add(this.cncel_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usr_nme_txt);
            this.Controls.Add(this.pss_txt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pss_txt;
        private System.Windows.Forms.TextBox usr_nme_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button cncel_btn;
    }
}

