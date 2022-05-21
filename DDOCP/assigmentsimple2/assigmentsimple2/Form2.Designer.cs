namespace assigmentsimple2
{
    partial class Form2
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
            this.btname = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.richtbname = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btname
            // 
            this.btname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btname.Location = new System.Drawing.Point(476, 69);
            this.btname.Name = "btname";
            this.btname.Size = new System.Drawing.Size(86, 30);
            this.btname.TabIndex = 0;
            this.btname.Text = "Search";
            this.btname.UseVisualStyleBackColor = true;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(66, 72);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(60, 22);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name";
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(237, 69);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(175, 30);
            this.tbname.TabIndex = 2;
            // 
            // richtbname
            // 
            this.richtbname.Location = new System.Drawing.Point(122, 171);
            this.richtbname.Name = "richtbname";
            this.richtbname.Size = new System.Drawing.Size(440, 109);
            this.richtbname.TabIndex = 3;
            this.richtbname.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 400);
            this.Controls.Add(this.richtbname);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btname;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.RichTextBox richtbname;
    }
}