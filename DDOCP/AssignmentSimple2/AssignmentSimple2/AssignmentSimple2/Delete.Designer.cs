namespace AssignmentSimple2
{
    partial class Delete
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
            this.tbpw = new System.Windows.Forms.TextBox();
            this.lbpw = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.BTdl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbpw
            // 
            this.tbpw.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpw.Location = new System.Drawing.Point(296, 168);
            this.tbpw.Margin = new System.Windows.Forms.Padding(4);
            this.tbpw.Name = "tbpw";
            this.tbpw.Size = new System.Drawing.Size(209, 41);
            this.tbpw.TabIndex = 7;
            // 
            // lbpw
            // 
            this.lbpw.AutoSize = true;
            this.lbpw.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpw.Location = new System.Drawing.Point(63, 171);
            this.lbpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpw.Name = "lbpw";
            this.lbpw.Size = new System.Drawing.Size(225, 37);
            this.lbpw.TabIndex = 6;
            this.lbpw.Text = "Current Password";
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(296, 91);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(209, 41);
            this.tbname.TabIndex = 5;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(134, 91);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(84, 37);
            this.lbname.TabIndex = 4;
            this.lbname.Text = "Name";
            // 
            // BTdl
            // 
            this.BTdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdl.Location = new System.Drawing.Point(212, 261);
            this.BTdl.Name = "BTdl";
            this.BTdl.Size = new System.Drawing.Size(177, 59);
            this.BTdl.TabIndex = 8;
            this.BTdl.Text = "Delete";
            this.BTdl.UseVisualStyleBackColor = true;
            this.BTdl.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 412);
            this.Controls.Add(this.BTdl);
            this.Controls.Add(this.tbpw);
            this.Controls.Add(this.lbpw);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbname);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbpw;
        private System.Windows.Forms.Label lbpw;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button BTdl;
    }
}