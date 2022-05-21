namespace Text3
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
            this.tbw = new System.Windows.Forms.TextBox();
            this.tbh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btbmi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight(lb)";
            // 
            // tbw
            // 
            this.tbw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbw.Location = new System.Drawing.Point(299, 34);
            this.tbw.Name = "tbw";
            this.tbw.Size = new System.Drawing.Size(314, 34);
            this.tbw.TabIndex = 1;
            // 
            // tbh
            // 
            this.tbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbh.Location = new System.Drawing.Point(299, 117);
            this.tbh.Name = "tbh";
            this.tbh.Size = new System.Drawing.Size(314, 34);
            this.tbh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height(inches)";
            // 
            // btbmi
            // 
            this.btbmi.Location = new System.Drawing.Point(299, 208);
            this.btbmi.Name = "btbmi";
            this.btbmi.Size = new System.Drawing.Size(265, 58);
            this.btbmi.TabIndex = 4;
            this.btbmi.Text = "Calculate BMI";
            this.btbmi.UseVisualStyleBackColor = true;
            this.btbmi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 449);
            this.Controls.Add(this.btbmi);
            this.Controls.Add(this.tbh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbw);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbw;
        private System.Windows.Forms.TextBox tbh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbmi;
    }
}

