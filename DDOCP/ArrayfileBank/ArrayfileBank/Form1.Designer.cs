namespace ArrayFileBank
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbnrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbdob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lnameerr = new System.Windows.Forms.Label();
            this.lnrcerr = new System.Windows.Forms.Label();
            this.ldoberr = new System.Windows.Forms.Label();
            this.ltypeerr = new System.Windows.Forms.Label();
            this.lamounterr = new System.Windows.Forms.Label();
            this.tbaccountno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbrepassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.laccountnoerr = new System.Windows.Forms.Label();
            this.lpassworderr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(135, 24);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(191, 38);
            this.tbname.TabIndex = 1;
            // 
            // tbnrc
            // 
            this.tbnrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnrc.Location = new System.Drawing.Point(135, 96);
            this.tbnrc.Name = "tbnrc";
            this.tbnrc.Size = new System.Drawing.Size(191, 38);
            this.tbnrc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "NRC";
            // 
            // tbdob
            // 
            this.tbdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdob.Location = new System.Drawing.Point(135, 164);
            this.tbdob.Name = "tbdob";
            this.tbdob.Size = new System.Drawing.Size(191, 38);
            this.tbdob.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbfemale);
            this.groupBox1.Controls.Add(this.rbmale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 76);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(127, 41);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(104, 29);
            this.rbfemale.TabIndex = 1;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Checked = true;
            this.rbmale.Location = new System.Drawing.Point(6, 41);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(80, 29);
            this.rbmale.TabIndex = 0;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Account Type";
            // 
            // cbtype
            // 
            this.cbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "Saving",
            "Fixed"});
            this.cbtype.Location = new System.Drawing.Point(583, 12);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(206, 37);
            this.cbtype.TabIndex = 9;
            // 
            // tbamount
            // 
            this.tbamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamount.Location = new System.Drawing.Point(583, 68);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(206, 38);
            this.tbamount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Amount";
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(208, 294);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(118, 45);
            this.btnregister.TabIndex = 12;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(386, 294);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(118, 45);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lnameerr
            // 
            this.lnameerr.AutoSize = true;
            this.lnameerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameerr.ForeColor = System.Drawing.Color.Red;
            this.lnameerr.Location = new System.Drawing.Point(321, 30);
            this.lnameerr.Name = "lnameerr";
            this.lnameerr.Size = new System.Drawing.Size(0, 32);
            this.lnameerr.TabIndex = 14;
            // 
            // lnrcerr
            // 
            this.lnrcerr.AutoSize = true;
            this.lnrcerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnrcerr.ForeColor = System.Drawing.Color.Red;
            this.lnrcerr.Location = new System.Drawing.Point(321, 99);
            this.lnrcerr.Name = "lnrcerr";
            this.lnrcerr.Size = new System.Drawing.Size(0, 32);
            this.lnrcerr.TabIndex = 15;
            // 
            // ldoberr
            // 
            this.ldoberr.AutoSize = true;
            this.ldoberr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldoberr.ForeColor = System.Drawing.Color.Red;
            this.ldoberr.Location = new System.Drawing.Point(321, 168);
            this.ldoberr.Name = "ldoberr";
            this.ldoberr.Size = new System.Drawing.Size(0, 32);
            this.ldoberr.TabIndex = 16;
            // 
            // ltypeerr
            // 
            this.ltypeerr.AutoSize = true;
            this.ltypeerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltypeerr.ForeColor = System.Drawing.Color.Red;
            this.ltypeerr.Location = new System.Drawing.Point(577, 21);
            this.ltypeerr.Name = "ltypeerr";
            this.ltypeerr.Size = new System.Drawing.Size(0, 32);
            this.ltypeerr.TabIndex = 17;
            // 
            // lamounterr
            // 
            this.lamounterr.AutoSize = true;
            this.lamounterr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamounterr.ForeColor = System.Drawing.Color.Red;
            this.lamounterr.Location = new System.Drawing.Point(577, 74);
            this.lamounterr.Name = "lamounterr";
            this.lamounterr.Size = new System.Drawing.Size(0, 32);
            this.lamounterr.TabIndex = 18;
            // 
            // tbaccountno
            // 
            this.tbaccountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaccountno.Location = new System.Drawing.Point(583, 129);
            this.tbaccountno.Name = "tbaccountno";
            this.tbaccountno.Size = new System.Drawing.Size(206, 38);
            this.tbaccountno.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "Account No";
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(583, 187);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(206, 38);
            this.tbpassword.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 34);
            this.label7.TabIndex = 21;
            this.label7.Text = "Password";
            // 
            // tbrepassword
            // 
            this.tbrepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrepassword.Location = new System.Drawing.Point(583, 244);
            this.tbrepassword.Name = "tbrepassword";
            this.tbrepassword.PasswordChar = '*';
            this.tbrepassword.Size = new System.Drawing.Size(206, 38);
            this.tbrepassword.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 34);
            this.label8.TabIndex = 23;
            this.label8.Text = "Re_Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(400, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 25;
            // 
            // laccountnoerr
            // 
            this.laccountnoerr.AutoSize = true;
            this.laccountnoerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laccountnoerr.ForeColor = System.Drawing.Color.Red;
            this.laccountnoerr.Location = new System.Drawing.Point(578, 135);
            this.laccountnoerr.Name = "laccountnoerr";
            this.laccountnoerr.Size = new System.Drawing.Size(0, 32);
            this.laccountnoerr.TabIndex = 26;
            // 
            // lpassworderr
            // 
            this.lpassworderr.AutoSize = true;
            this.lpassworderr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassworderr.ForeColor = System.Drawing.Color.Red;
            this.lpassworderr.Location = new System.Drawing.Point(576, 191);
            this.lpassworderr.Name = "lpassworderr";
            this.lpassworderr.Size = new System.Drawing.Size(0, 32);
            this.lpassworderr.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(801, 416);
            this.Controls.Add(this.lpassworderr);
            this.Controls.Add(this.laccountnoerr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbrepassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbaccountno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lamounterr);
            this.Controls.Add(this.ltypeerr);
            this.Controls.Add(this.ldoberr);
            this.Controls.Add(this.lnrcerr);
            this.Controls.Add(this.lnameerr);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbdob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Account Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbnrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbdob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lnameerr;
        private System.Windows.Forms.Label lnrcerr;
        private System.Windows.Forms.Label ldoberr;
        private System.Windows.Forms.Label ltypeerr;
        private System.Windows.Forms.Label lamounterr;
        private System.Windows.Forms.TextBox tbaccountno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbrepassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label laccountnoerr;
        private System.Windows.Forms.Label lpassworderr;
    }
}

