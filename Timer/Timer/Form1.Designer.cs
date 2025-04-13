namespace Timer
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
            this.strtbtn = new System.Windows.Forms.Button();
            this.btnstp = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.plusbtn = new System.Windows.Forms.Button();
            this.Countdowntimer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.minusbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // strtbtn
            // 
            this.strtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strtbtn.Location = new System.Drawing.Point(279, 152);
            this.strtbtn.Name = "strtbtn";
            this.strtbtn.Size = new System.Drawing.Size(175, 32);
            this.strtbtn.TabIndex = 1;
            this.strtbtn.Text = "Start";
            this.strtbtn.UseVisualStyleBackColor = true;
            this.strtbtn.Click += new System.EventHandler(this.strtbtn_Click);
            // 
            // btnstp
            // 
            this.btnstp.AutoSize = true;
            this.btnstp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstp.Location = new System.Drawing.Point(360, 116);
            this.btnstp.Name = "btnstp";
            this.btnstp.Size = new System.Drawing.Size(94, 30);
            this.btnstp.TabIndex = 2;
            this.btnstp.Text = "Stop";
            this.btnstp.UseVisualStyleBackColor = true;
            this.btnstp.Click += new System.EventHandler(this.btnstp_Click);
            // 
            // btnrest
            // 
            this.btnrest.AutoSize = true;
            this.btnrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.Location = new System.Drawing.Point(279, 116);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(75, 30);
            this.btnrest.TabIndex = 3;
            this.btnrest.Text = "Reset";
            this.btnrest.UseVisualStyleBackColor = true;
            this.btnrest.Click += new System.EventHandler(this.btnrest_Click);
            // 
            // plusbtn
            // 
            this.plusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbtn.Location = new System.Drawing.Point(360, 190);
            this.plusbtn.Name = "plusbtn";
            this.plusbtn.Size = new System.Drawing.Size(94, 23);
            this.plusbtn.TabIndex = 4;
            this.plusbtn.Text = "+";
            this.plusbtn.UseVisualStyleBackColor = true;
            this.plusbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Countdowntimer
            // 
            this.Countdowntimer.Interval = 1000;
            this.Countdowntimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(297, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(157, 29);
            this.label.TabIndex = 5;
            this.label.Text = "60 Seconds";
            this.label.Click += new System.EventHandler(this.timerlabel);
            // 
            // minusbtn
            // 
            this.minusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusbtn.Location = new System.Drawing.Point(279, 190);
            this.minusbtn.Name = "minusbtn";
            this.minusbtn.Size = new System.Drawing.Size(75, 23);
            this.minusbtn.TabIndex = 6;
            this.minusbtn.Text = "-";
            this.minusbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(711, 314);
            this.Controls.Add(this.minusbtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.plusbtn);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnstp);
            this.Controls.Add(this.strtbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button strtbtn;
        private System.Windows.Forms.Button btnstp;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button plusbtn;
        private System.Windows.Forms.Timer Countdowntimer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button minusbtn;
    }
}

