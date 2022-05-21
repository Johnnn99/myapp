namespace Test9
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
            this.bt = new System.Windows.Forms.Button();
            this.lbn = new System.Windows.Forms.Label();
            this.tbn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt.Location = new System.Drawing.Point(365, 249);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(182, 106);
            this.bt.TabIndex = 0;
            this.bt.Text = "button1";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbn
            // 
            this.lbn.AutoSize = true;
            this.lbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn.Location = new System.Drawing.Point(185, 128);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(81, 25);
            this.lbn.TabIndex = 1;
            this.lbn.Text = "Number";
            // 
            // tbn
            // 
            this.tbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn.Location = new System.Drawing.Point(365, 128);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(182, 30);
            this.tbn.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 456);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.lbn);
            this.Controls.Add(this.bt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label lbn;
        private System.Windows.Forms.TextBox tbn;
    }
}

