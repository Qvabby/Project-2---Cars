namespace Project_2___Step
{
    partial class Add
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TitleTb = new System.Windows.Forms.TextBox();
            this.TitleL = new System.Windows.Forms.Label();
            this.YearNUAD = new System.Windows.Forms.NumericUpDown();
            this.ManufacturerL = new System.Windows.Forms.Label();
            this.ManufacturerTb = new System.Windows.Forms.TextBox();
            this.ModelL = new System.Windows.Forms.Label();
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.ColorL = new System.Windows.Forms.Label();
            this.ColorTb = new System.Windows.Forms.TextBox();
            this.YearL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceNUAD = new System.Windows.Forms.NumericUpDown();
            this.DescriptionL = new System.Windows.Forms.Label();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.YearNUAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 266);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(435, 266);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TitleTb
            // 
            this.TitleTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTb.Location = new System.Drawing.Point(64, 19);
            this.TitleTb.Multiline = true;
            this.TitleTb.Name = "TitleTb";
            this.TitleTb.Size = new System.Drawing.Size(446, 79);
            this.TitleTb.TabIndex = 3;
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleL.Location = new System.Drawing.Point(12, 22);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(46, 20);
            this.TitleL.TabIndex = 4;
            this.TitleL.Text = "Title: ";
            // 
            // YearNUAD
            // 
            this.YearNUAD.Location = new System.Drawing.Point(288, 144);
            this.YearNUAD.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.YearNUAD.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.YearNUAD.Name = "YearNUAD";
            this.YearNUAD.Size = new System.Drawing.Size(73, 20);
            this.YearNUAD.TabIndex = 5;
            this.YearNUAD.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // ManufacturerL
            // 
            this.ManufacturerL.AutoSize = true;
            this.ManufacturerL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerL.Location = new System.Drawing.Point(15, 110);
            this.ManufacturerL.Name = "ManufacturerL";
            this.ManufacturerL.Size = new System.Drawing.Size(108, 20);
            this.ManufacturerL.TabIndex = 7;
            this.ManufacturerL.Text = "Manufacturer:";
            // 
            // ManufacturerTb
            // 
            this.ManufacturerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTb.Location = new System.Drawing.Point(129, 107);
            this.ManufacturerTb.Name = "ManufacturerTb";
            this.ManufacturerTb.Size = new System.Drawing.Size(137, 26);
            this.ManufacturerTb.TabIndex = 6;
            // 
            // ModelL
            // 
            this.ModelL.AutoSize = true;
            this.ModelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelL.Location = new System.Drawing.Point(292, 110);
            this.ModelL.Name = "ModelL";
            this.ModelL.Size = new System.Drawing.Size(56, 20);
            this.ModelL.TabIndex = 9;
            this.ModelL.Text = "Model:";
            // 
            // ModelTb
            // 
            this.ModelTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTb.Location = new System.Drawing.Point(354, 108);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(137, 26);
            this.ModelTb.TabIndex = 8;
            // 
            // ColorL
            // 
            this.ColorL.AutoSize = true;
            this.ColorL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorL.Location = new System.Drawing.Point(15, 143);
            this.ColorL.Name = "ColorL";
            this.ColorL.Size = new System.Drawing.Size(50, 20);
            this.ColorL.TabIndex = 11;
            this.ColorL.Text = "Color:";
            // 
            // ColorTb
            // 
            this.ColorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorTb.Location = new System.Drawing.Point(71, 140);
            this.ColorTb.Name = "ColorTb";
            this.ColorTb.Size = new System.Drawing.Size(137, 26);
            this.ColorTb.TabIndex = 10;
            // 
            // YearL
            // 
            this.YearL.AutoSize = true;
            this.YearL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearL.Location = new System.Drawing.Point(235, 143);
            this.YearL.Name = "YearL";
            this.YearL.Size = new System.Drawing.Size(47, 20);
            this.YearL.TabIndex = 12;
            this.YearL.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Price:";
            // 
            // PriceNUAD
            // 
            this.PriceNUAD.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PriceNUAD.Location = new System.Drawing.Point(438, 144);
            this.PriceNUAD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PriceNUAD.Name = "PriceNUAD";
            this.PriceNUAD.Size = new System.Drawing.Size(73, 20);
            this.PriceNUAD.TabIndex = 13;
            // 
            // DescriptionL
            // 
            this.DescriptionL.AutoSize = true;
            this.DescriptionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionL.Location = new System.Drawing.Point(14, 196);
            this.DescriptionL.Name = "DescriptionL";
            this.DescriptionL.Size = new System.Drawing.Size(93, 20);
            this.DescriptionL.TabIndex = 16;
            this.DescriptionL.Text = "Description:";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTb.Location = new System.Drawing.Point(113, 196);
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(397, 64);
            this.DescriptionTb.TabIndex = 15;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 301);
            this.Controls.Add(this.DescriptionL);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceNUAD);
            this.Controls.Add(this.YearL);
            this.Controls.Add(this.ColorL);
            this.Controls.Add(this.ColorTb);
            this.Controls.Add(this.ModelL);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.ManufacturerL);
            this.Controls.Add(this.ManufacturerTb);
            this.Controls.Add(this.YearNUAD);
            this.Controls.Add(this.TitleL);
            this.Controls.Add(this.TitleTb);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Add";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.YearNUAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox TitleTb;
        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.NumericUpDown YearNUAD;
        private System.Windows.Forms.Label ManufacturerL;
        private System.Windows.Forms.TextBox ManufacturerTb;
        private System.Windows.Forms.Label ModelL;
        private System.Windows.Forms.TextBox ModelTb;
        private System.Windows.Forms.Label ColorL;
        private System.Windows.Forms.TextBox ColorTb;
        private System.Windows.Forms.Label YearL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PriceNUAD;
        private System.Windows.Forms.Label DescriptionL;
        private System.Windows.Forms.TextBox DescriptionTb;
    }
}