namespace Test2operators
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
            this.tbnum1 = new System.Windows.Forms.TextBox();
            this.tbnum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.btminus = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.btdi = new System.Windows.Forms.Button();
            this.btmod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "num1";
            // 
            // tbnum1
            // 
            this.tbnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnum1.Location = new System.Drawing.Point(255, 47);
            this.tbnum1.Name = "tbnum1";
            this.tbnum1.Size = new System.Drawing.Size(387, 34);
            this.tbnum1.TabIndex = 1;
            // 
            // tbnum2
            // 
            this.tbnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnum2.Location = new System.Drawing.Point(255, 134);
            this.tbnum2.Name = "tbnum2";
            this.tbnum2.Size = new System.Drawing.Size(387, 34);
            this.tbnum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "num2";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(65, 230);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(88, 51);
            this.btadd.TabIndex = 4;
            this.btadd.Text = "+";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btminus
            // 
            this.btminus.Location = new System.Drawing.Point(212, 230);
            this.btminus.Name = "btminus";
            this.btminus.Size = new System.Drawing.Size(88, 51);
            this.btminus.TabIndex = 5;
            this.btminus.Text = "-";
            this.btminus.UseVisualStyleBackColor = true;
            this.btminus.Click += new System.EventHandler(this.btminus_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(393, 230);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(88, 51);
            this.mul.TabIndex = 6;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // btdi
            // 
            this.btdi.Location = new System.Drawing.Point(575, 230);
            this.btdi.Name = "btdi";
            this.btdi.Size = new System.Drawing.Size(88, 51);
            this.btdi.TabIndex = 7;
            this.btdi.Text = "/";
            this.btdi.UseVisualStyleBackColor = true;
            this.btdi.Click += new System.EventHandler(this.btdi_Click);
            // 
            // btmod
            // 
            this.btmod.Location = new System.Drawing.Point(738, 230);
            this.btmod.Name = "btmod";
            this.btmod.Size = new System.Drawing.Size(88, 51);
            this.btmod.TabIndex = 8;
            this.btmod.Text = "%";
            this.btmod.UseVisualStyleBackColor = true;
            this.btmod.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 413);
            this.Controls.Add(this.btmod);
            this.Controls.Add(this.btdi);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.btminus);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.tbnum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnum1;
        private System.Windows.Forms.TextBox tbnum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btminus;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button btdi;
        private System.Windows.Forms.Button btmod;
    }
}

