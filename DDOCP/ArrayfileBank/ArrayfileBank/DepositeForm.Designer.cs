namespace ArrayFileBank
{
    partial class DepositeForm
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btndeposite = new System.Windows.Forms.Button();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(227, 125);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(88, 37);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btndeposite
            // 
            this.btndeposite.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeposite.Location = new System.Drawing.Point(85, 125);
            this.btndeposite.Margin = new System.Windows.Forms.Padding(2);
            this.btndeposite.Name = "btndeposite";
            this.btndeposite.Size = new System.Drawing.Size(88, 37);
            this.btndeposite.TabIndex = 16;
            this.btndeposite.Text = "Deposite";
            this.btndeposite.UseVisualStyleBackColor = true;
            this.btndeposite.Click += new System.EventHandler(this.btndeposite_Click);
            // 
            // tbamount
            // 
            this.tbamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamount.Location = new System.Drawing.Point(200, 42);
            this.tbamount.Margin = new System.Windows.Forms.Padding(2);
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(156, 32);
            this.tbamount.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount";
            // 
            // DepositeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(672, 304);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndeposite);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.label5);
            this.Name = "DepositeForm";
            this.Text = "DepositeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndeposite;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.Label label5;
    }
}