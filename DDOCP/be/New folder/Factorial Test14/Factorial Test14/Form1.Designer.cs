﻿namespace Factorial_Test14
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
            this.lans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnum
            // 
            this.btnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnum.Location = new System.Drawing.Point(377, 162);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(221, 62);
            this.btnum.TabIndex = 0;
            this.btnum.Text = "Factorial";
            this.btnum.UseVisualStyleBackColor = true;
            this.btnum.Click += new System.EventHandler(this.btnum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Number";
            // 
            // tbnum
            // 
            this.tbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnum.Location = new System.Drawing.Point(377, 65);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(221, 30);
            this.tbnum.TabIndex = 2;
            // 
            // lans
            // 
            this.lans.AutoSize = true;
            this.lans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lans.Location = new System.Drawing.Point(374, 277);
            this.lans.Name = "lans";
            this.lans.Size = new System.Drawing.Size(0, 25);
            this.lans.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 537);
            this.Controls.Add(this.lans);
            this.Controls.Add(this.tbnum);
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
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.Label lans;
    }
}

