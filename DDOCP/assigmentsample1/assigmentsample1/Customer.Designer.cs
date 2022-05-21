namespace assigmentsample1
{
    partial class Customer
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
            this.btlogin = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbaccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laccounterr = new System.Windows.Forms.Label();
            this.lpassword = new System.Windows.Forms.Label();
            this.lerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btlogin
            // 
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.Location = new System.Drawing.Point(65, 287);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(78, 31);
            this.btlogin.TabIndex = 32;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(170, 287);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(81, 31);
            this.btnclear.TabIndex = 31;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(170, 159);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(100, 26);
            this.tbpassword.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Password";
            // 
            // tbaccount
            // 
            this.tbaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaccount.Location = new System.Drawing.Point(170, 83);
            this.tbaccount.Name = "tbaccount";
            this.tbaccount.Size = new System.Drawing.Size(100, 26);
            this.tbaccount.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Account No";
            // 
            // laccounterr
            // 
            this.laccounterr.AutoSize = true;
            this.laccounterr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laccounterr.ForeColor = System.Drawing.Color.Red;
            this.laccounterr.Location = new System.Drawing.Point(130, 86);
            this.laccounterr.Name = "laccounterr";
            this.laccounterr.Size = new System.Drawing.Size(0, 20);
            this.laccounterr.TabIndex = 33;
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassword.ForeColor = System.Drawing.Color.Red;
            this.lpassword.Location = new System.Drawing.Point(130, 159);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(0, 20);
            this.lpassword.TabIndex = 34;
            // 
            // lerror
            // 
            this.lerror.AutoSize = true;
            this.lerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lerror.ForeColor = System.Drawing.Color.Red;
            this.lerror.Location = new System.Drawing.Point(134, 31);
            this.lerror.Name = "lerror";
            this.lerror.Size = new System.Drawing.Size(0, 20);
            this.lerror.TabIndex = 35;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(370, 371);
            this.Controls.Add(this.lerror);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.laccounterr);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbaccount);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbaccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laccounterr;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.Label lerror;
    }
}