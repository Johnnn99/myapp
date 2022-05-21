namespace Assignmentsample1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.lemailerr = new System.Windows.Forms.Label();
            this.lpwerr = new System.Windows.Forms.Label();
            this.lloginerr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // tbemail
            // 
            this.tbemail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(165, 69);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(257, 34);
            this.tbemail.TabIndex = 1;
            // 
            // tbpw
            // 
            this.tbpw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpw.Location = new System.Drawing.Point(165, 165);
            this.tbpw.Name = "tbpw";
            this.tbpw.PasswordChar = '*';
            this.tbpw.Size = new System.Drawing.Size(257, 34);
            this.tbpw.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btlogin.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.Location = new System.Drawing.Point(91, 277);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(103, 47);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btclear
            // 
            this.btclear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btclear.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.Location = new System.Drawing.Point(319, 277);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(103, 47);
            this.btclear.TabIndex = 5;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = false;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // lemailerr
            // 
            this.lemailerr.AutoSize = true;
            this.lemailerr.ForeColor = System.Drawing.Color.Red;
            this.lemailerr.Location = new System.Drawing.Point(162, 106);
            this.lemailerr.Name = "lemailerr";
            this.lemailerr.Size = new System.Drawing.Size(0, 17);
            this.lemailerr.TabIndex = 6;
            // 
            // lpwerr
            // 
            this.lpwerr.AutoSize = true;
            this.lpwerr.ForeColor = System.Drawing.Color.Red;
            this.lpwerr.Location = new System.Drawing.Point(162, 202);
            this.lpwerr.Name = "lpwerr";
            this.lpwerr.Size = new System.Drawing.Size(0, 17);
            this.lpwerr.TabIndex = 7;
            // 
            // lloginerr
            // 
            this.lloginerr.AutoSize = true;
            this.lloginerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lloginerr.ForeColor = System.Drawing.Color.Red;
            this.lloginerr.Location = new System.Drawing.Point(172, 32);
            this.lloginerr.Name = "lloginerr";
            this.lloginerr.Size = new System.Drawing.Size(0, 25);
            this.lloginerr.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(596, 491);
            this.Controls.Add(this.lloginerr);
            this.Controls.Add(this.lpwerr);
            this.Controls.Add(this.lemailerr);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.tbpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Label lemailerr;
        private System.Windows.Forms.Label lpwerr;
        private System.Windows.Forms.Label lloginerr;
    }
}

