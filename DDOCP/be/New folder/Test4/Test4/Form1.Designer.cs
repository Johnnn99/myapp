namespace Test4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbh = new System.Windows.Forms.TextBox();
            this.tbl = new System.Windows.Forms.TextBox();
            this.tbw = new System.Windows.Forms.TextBox();
            this.btgallon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width";
            // 
            // tbh
            // 
            this.tbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbh.Location = new System.Drawing.Point(350, 55);
            this.tbh.Name = "tbh";
            this.tbh.Size = new System.Drawing.Size(251, 34);
            this.tbh.TabIndex = 3;
            // 
            // tbl
            // 
            this.tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl.Location = new System.Drawing.Point(350, 116);
            this.tbl.Name = "tbl";
            this.tbl.Size = new System.Drawing.Size(251, 34);
            this.tbl.TabIndex = 4;
            this.tbl.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbw
            // 
            this.tbw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbw.Location = new System.Drawing.Point(350, 179);
            this.tbw.Name = "tbw";
            this.tbw.Size = new System.Drawing.Size(251, 34);
            this.tbw.TabIndex = 5;
            // 
            // btgallon
            // 
            this.btgallon.Location = new System.Drawing.Point(403, 254);
            this.btgallon.Name = "btgallon";
            this.btgallon.Size = new System.Drawing.Size(138, 50);
            this.btgallon.TabIndex = 6;
            this.btgallon.Text = "Calculate Gallon";
            this.btgallon.UseVisualStyleBackColor = true;
            this.btgallon.Click += new System.EventHandler(this.bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 438);
            this.Controls.Add(this.btgallon);
            this.Controls.Add(this.tbw);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.tbh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbh;
        private System.Windows.Forms.TextBox tbl;
        private System.Windows.Forms.TextBox tbw;
        private System.Windows.Forms.Button btgallon;
    }
}

