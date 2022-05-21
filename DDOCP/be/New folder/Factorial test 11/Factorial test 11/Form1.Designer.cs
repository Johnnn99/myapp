namespace Factorial_test_11
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
            this.tbnum = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnum
            // 
            this.btnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnum.Location = new System.Drawing.Point(437, 146);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(284, 54);
            this.btnum.TabIndex = 0;
            this.btnum.Text = "Calculate Factorial";
            this.btnum.UseVisualStyleBackColor = true;
            this.btnum.Click += new System.EventHandler(this.btnum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // tbnum
            // 
            this.tbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnum.Location = new System.Drawing.Point(437, 64);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(186, 30);
            this.tbnum.TabIndex = 2;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(434, 234);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(0, 25);
            this.lb2.TabIndex = 3;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(440, 234);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 25);
            this.lb.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 418);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb;
    }
}

