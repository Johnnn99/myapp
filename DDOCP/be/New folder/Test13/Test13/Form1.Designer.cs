namespace Test13
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
            this.lb = new System.Windows.Forms.Label();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.btnum = new System.Windows.Forms.Button();
            this.lans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(128, 66);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(81, 25);
            this.lb.TabIndex = 0;
            this.lb.Text = "Number";
            // 
            // tbnum
            // 
            this.tbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnum.Location = new System.Drawing.Point(380, 66);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(160, 30);
            this.tbnum.TabIndex = 1;
            this.tbnum.TextChanged += new System.EventHandler(this.tbnum_TextChanged);
            // 
            // btnum
            // 
            this.btnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnum.Location = new System.Drawing.Point(380, 202);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(160, 56);
            this.btnum.TabIndex = 2;
            this.btnum.Text = "P / N";
            this.btnum.UseVisualStyleBackColor = true;
            this.btnum.Click += new System.EventHandler(this.btnum_Click);
            // 
            // lans
            // 
            this.lans.AutoSize = true;
            this.lans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lans.Location = new System.Drawing.Point(377, 296);
            this.lans.Name = "lans";
            this.lans.Size = new System.Drawing.Size(0, 25);
            this.lans.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 420);
            this.Controls.Add(this.lans);
            this.Controls.Add(this.btnum);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.Button btnum;
        private System.Windows.Forms.Label lans;
    }
}

