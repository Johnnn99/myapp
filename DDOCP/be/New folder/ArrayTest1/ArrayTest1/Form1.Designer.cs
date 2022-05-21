namespace ArrayTest1
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
            this.btadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.btdisplay = new System.Windows.Forms.Button();
            this.lbdisplay = new System.Windows.Forms.Label();
            this.lans = new System.Windows.Forms.Label();
            this.bttotal = new System.Windows.Forms.Button();
            this.btaverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(602, 147);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(98, 44);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // tbnum
            // 
            this.tbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnum.Location = new System.Drawing.Point(402, 147);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(132, 30);
            this.tbnum.TabIndex = 2;
            // 
            // btdisplay
            // 
            this.btdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdisplay.Location = new System.Drawing.Point(171, 247);
            this.btdisplay.Name = "btdisplay";
            this.btdisplay.Size = new System.Drawing.Size(118, 58);
            this.btdisplay.TabIndex = 3;
            this.btdisplay.Text = "Display";
            this.btdisplay.UseVisualStyleBackColor = true;
            this.btdisplay.Click += new System.EventHandler(this.btdisplay_Click);
            // 
            // lbdisplay
            // 
            this.lbdisplay.AutoSize = true;
            this.lbdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdisplay.Location = new System.Drawing.Point(166, 361);
            this.lbdisplay.Name = "lbdisplay";
            this.lbdisplay.Size = new System.Drawing.Size(0, 25);
            this.lbdisplay.TabIndex = 4;
            // 
            // lans
            // 
            this.lans.AutoSize = true;
            this.lans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lans.Location = new System.Drawing.Point(175, 335);
            this.lans.Name = "lans";
            this.lans.Size = new System.Drawing.Size(0, 25);
            this.lans.TabIndex = 5;
            // 
            // bttotal
            // 
            this.bttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttotal.Location = new System.Drawing.Point(368, 247);
            this.bttotal.Name = "bttotal";
            this.bttotal.Size = new System.Drawing.Size(118, 58);
            this.bttotal.TabIndex = 6;
            this.bttotal.Text = "Total";
            this.bttotal.UseVisualStyleBackColor = true;
            this.bttotal.Click += new System.EventHandler(this.bttotal_Click);
            // 
            // btaverage
            // 
            this.btaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaverage.Location = new System.Drawing.Point(582, 247);
            this.btaverage.Name = "btaverage";
            this.btaverage.Size = new System.Drawing.Size(157, 58);
            this.btaverage.TabIndex = 7;
            this.btaverage.Text = "Average";
            this.btaverage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 618);
            this.Controls.Add(this.btaverage);
            this.Controls.Add(this.bttotal);
            this.Controls.Add(this.lans);
            this.Controls.Add(this.lbdisplay);
            this.Controls.Add(this.btdisplay);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.Button btdisplay;
        private System.Windows.Forms.Label lbdisplay;
        private System.Windows.Forms.Label lans;
        private System.Windows.Forms.Button bttotal;
        private System.Windows.Forms.Button btaverage;
    }
}

