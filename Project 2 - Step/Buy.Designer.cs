namespace Project_2___Step
{
    partial class Buy
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
            this.IdNUAD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buybtn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // IdNUAD
            // 
            this.IdNUAD.Location = new System.Drawing.Point(31, 7);
            this.IdNUAD.Name = "IdNUAD";
            this.IdNUAD.Size = new System.Drawing.Size(120, 20);
            this.IdNUAD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // buybtn
            // 
            this.buybtn.Location = new System.Drawing.Point(12, 62);
            this.buybtn.Name = "buybtn";
            this.buybtn.Size = new System.Drawing.Size(75, 23);
            this.buybtn.TabIndex = 2;
            this.buybtn.Text = "Buy";
            this.buybtn.UseVisualStyleBackColor = true;
            this.buybtn.Click += new System.EventHandler(this.buybtn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(289, 62);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 94);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.buybtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdNUAD);
            this.Name = "Buy";
            this.Text = "Buy";
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdNUAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buybtn;
        private System.Windows.Forms.Button Cancel;
    }
}