namespace Project_2___Step
{
    partial class Remove
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
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.CarsDGV = new System.Windows.Forms.DataGridView();
            this.IdNUAD = new System.Windows.Forms.NumericUpDown();
            this.ShowmycarsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(12, 286);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 0;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // CarsDGV
            // 
            this.CarsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDGV.Location = new System.Drawing.Point(12, 12);
            this.CarsDGV.Name = "CarsDGV";
            this.CarsDGV.Size = new System.Drawing.Size(735, 268);
            this.CarsDGV.TabIndex = 1;
            // 
            // IdNUAD
            // 
            this.IdNUAD.Location = new System.Drawing.Point(104, 288);
            this.IdNUAD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IdNUAD.Name = "IdNUAD";
            this.IdNUAD.Size = new System.Drawing.Size(88, 20);
            this.IdNUAD.TabIndex = 2;
            // 
            // ShowmycarsBtn
            // 
            this.ShowmycarsBtn.Location = new System.Drawing.Point(672, 285);
            this.ShowmycarsBtn.Name = "ShowmycarsBtn";
            this.ShowmycarsBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowmycarsBtn.TabIndex = 3;
            this.ShowmycarsBtn.Text = "Show Mine";
            this.ShowmycarsBtn.UseVisualStyleBackColor = true;
            this.ShowmycarsBtn.Click += new System.EventHandler(this.ShowmycarsBtn_Click);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 321);
            this.Controls.Add(this.ShowmycarsBtn);
            this.Controls.Add(this.IdNUAD);
            this.Controls.Add(this.CarsDGV);
            this.Controls.Add(this.RemoveBtn);
            this.Name = "Remove";
            this.Text = "Remove";
            this.Load += new System.EventHandler(this.Remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.DataGridView CarsDGV;
        private System.Windows.Forms.NumericUpDown IdNUAD;
        private System.Windows.Forms.Button ShowmycarsBtn;
    }
}