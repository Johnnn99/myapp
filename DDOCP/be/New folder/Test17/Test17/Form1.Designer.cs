namespace Test17
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
            this.btnum = new System.Windows.Forms.Button();
            this.lbnum = new System.Windows.Forms.Label();
            this.lans = new System.Windows.Forms.Label();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnum
            // 
            this.btnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnum.Location = new System.Drawing.Point(294, 174);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(183, 57);
            this.btnum.TabIndex = 0;
            this.btnum.Text = "Generate";
            this.btnum.UseVisualStyleBackColor = true;
            this.btnum.Click += new System.EventHandler(this.btnum_Click);
            // 
            // lbnum
            // 
            this.lbnum.AutoSize = true;
            this.lbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnum.Location = new System.Drawing.Point(82, 91);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(81, 25);
            this.lbnum.TabIndex = 1;
            this.lbnum.Text = "Number";
            // 
            // lans
            // 
            this.lans.AutoSize = true;
            this.lans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lans.Location = new System.Drawing.Point(237, 281);
            this.lans.Name = "lans";
            this.lans.Size = new System.Drawing.Size(0, 25);
            this.lans.TabIndex = 2;
            // 
            // tbnum
            // 
            this.tbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnum.Location = new System.Drawing.Point(294, 91);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(183, 30);
            this.tbnum.TabIndex = 3;
           // this.tbnum.TextChanged += new System.EventHandler(this.tbnum_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 529);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.lans);
            this.Controls.Add(this.lbnum);
            this.Controls.Add(this.btnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnum;
        private System.Windows.Forms.Label lbnum;
        private System.Windows.Forms.Label lans;
        private System.Windows.Forms.TextBox tbnum;
    }
}

