namespace Test15
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
            this.label1 = new System.Windows.Forms.Label();
            this.lans = new System.Windows.Forms.Label();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnum
            // 
            this.btnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnum.Location = new System.Drawing.Point(280, 173);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(131, 43);
            this.btnum.TabIndex = 0;
            this.btnum.Text = "Check";
            this.btnum.UseVisualStyleBackColor = true;
            this.btnum.Click += new System.EventHandler(this.btnum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // lans
            // 
            this.lans.AutoSize = true;
            this.lans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lans.Location = new System.Drawing.Point(277, 270);
            this.lans.Name = "lans";
            this.lans.Size = new System.Drawing.Size(0, 25);
            this.lans.TabIndex = 2;
            // 
            // tbnum
            // 
            this.tbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnum.Location = new System.Drawing.Point(280, 81);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(156, 30);
            this.tbnum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 451);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.lans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lans;
        private System.Windows.Forms.TextBox tbnum;
    }
}

