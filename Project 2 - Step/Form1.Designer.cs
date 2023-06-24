namespace Project_2___Step
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.CarsDGV = new System.Windows.Forms.DataGridView();
            this.CarsLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ShowMyCarBtn = new System.Windows.Forms.Button();
            this.ShowAllCarBtn = new System.Windows.Forms.Button();
            this.Unamelabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.AdvancedSearchPBtn = new System.Windows.Forms.PictureBox();
            this.ManufacturersCB = new System.Windows.Forms.ComboBox();
            this.ModelCB = new System.Windows.Forms.ComboBox();
            this.ColorsCB = new System.Windows.Forms.ComboBox();
            this.MinYearNUAD = new System.Windows.Forms.NumericUpDown();
            this.MinYearL = new System.Windows.Forms.Label();
            this.MaxYearL = new System.Windows.Forms.Label();
            this.MaxYearNUAD = new System.Windows.Forms.NumericUpDown();
            this.MaxPriceL = new System.Windows.Forms.Label();
            this.MaxPriceNUAD = new System.Windows.Forms.NumericUpDown();
            this.MinPriceL = new System.Windows.Forms.Label();
            this.MinPriceNUAD = new System.Windows.Forms.NumericUpDown();
            this.TitleTb = new System.Windows.Forms.TextBox();
            this.SellerUsernameTb = new System.Windows.Forms.TextBox();
            this.TItleL = new System.Windows.Forms.Label();
            this.SellerUsernameL = new System.Windows.Forms.Label();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.AdvSearchPBtn = new System.Windows.Forms.PictureBox();
            this.BuyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancedSearchPBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinYearNUAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxYearNUAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPriceNUAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPriceNUAD)).BeginInit();
            this.UpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvSearchPBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(100)))), ((int)(((byte)(81)))));
            this.SignUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(100)))), ((int)(((byte)(81)))));
            this.SignUpBtn.FlatAppearance.BorderSize = 0;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(786, 10);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(75, 34);
            this.SignUpBtn.TabIndex = 0;
            this.SignUpBtn.Text = "Log In";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(100)))), ((int)(((byte)(81)))));
            this.RegisterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(100)))), ((int)(((byte)(81)))));
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(705, 10);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 34);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // CarsDGV
            // 
            this.CarsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDGV.Location = new System.Drawing.Point(15, 128);
            this.CarsDGV.Name = "CarsDGV";
            this.CarsDGV.Size = new System.Drawing.Size(586, 269);
            this.CarsDGV.TabIndex = 2;
            // 
            // CarsLabel
            // 
            this.CarsLabel.AutoSize = true;
            this.CarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsLabel.Location = new System.Drawing.Point(11, 98);
            this.CarsLabel.Name = "CarsLabel";
            this.CarsLabel.Size = new System.Drawing.Size(46, 20);
            this.CarsLabel.TabIndex = 3;
            this.CarsLabel.Text = "Cars:";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.Window;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(63, 83);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(81, 35);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add Car";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(159, 83);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(106, 35);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Remove Car";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Visible = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ShowMyCarBtn
            // 
            this.ShowMyCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMyCarBtn.Location = new System.Drawing.Point(383, 83);
            this.ShowMyCarBtn.Name = "ShowMyCarBtn";
            this.ShowMyCarBtn.Size = new System.Drawing.Size(106, 35);
            this.ShowMyCarBtn.TabIndex = 6;
            this.ShowMyCarBtn.Text = "ShowMyCars";
            this.ShowMyCarBtn.UseVisualStyleBackColor = true;
            this.ShowMyCarBtn.Visible = false;
            this.ShowMyCarBtn.Click += new System.EventHandler(this.ShowMyCarBtn_Click);
            // 
            // ShowAllCarBtn
            // 
            this.ShowAllCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllCarBtn.Location = new System.Drawing.Point(271, 83);
            this.ShowAllCarBtn.Name = "ShowAllCarBtn";
            this.ShowAllCarBtn.Size = new System.Drawing.Size(106, 35);
            this.ShowAllCarBtn.TabIndex = 7;
            this.ShowAllCarBtn.Text = "ShowAllCars";
            this.ShowAllCarBtn.UseVisualStyleBackColor = true;
            this.ShowAllCarBtn.Visible = false;
            this.ShowAllCarBtn.Click += new System.EventHandler(this.ShowAllCarBtn_Click);
            // 
            // Unamelabel
            // 
            this.Unamelabel.AutoSize = true;
            this.Unamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unamelabel.Location = new System.Drawing.Point(3, 3);
            this.Unamelabel.Name = "Unamelabel";
            this.Unamelabel.Size = new System.Drawing.Size(59, 20);
            this.Unamelabel.TabIndex = 8;
            this.Unamelabel.Text = "USER:";
            this.Unamelabel.Visible = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(604, 129);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(77, 21);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(687, 129);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(189, 20);
            this.SearchTb.TabIndex = 10;
            // 
            // AdvancedSearchPBtn
            // 
            this.AdvancedSearchPBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdvancedSearchPBtn.Image")));
            this.AdvancedSearchPBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("AdvancedSearchPBtn.InitialImage")));
            this.AdvancedSearchPBtn.Location = new System.Drawing.Point(604, 156);
            this.AdvancedSearchPBtn.Name = "AdvancedSearchPBtn";
            this.AdvancedSearchPBtn.Size = new System.Drawing.Size(24, 24);
            this.AdvancedSearchPBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AdvancedSearchPBtn.TabIndex = 11;
            this.AdvancedSearchPBtn.TabStop = false;
            this.AdvancedSearchPBtn.Click += new System.EventHandler(this.AdvancedSearchPBtn_Click);
            // 
            // ManufacturersCB
            // 
            this.ManufacturersCB.FormattingEnabled = true;
            this.ManufacturersCB.Location = new System.Drawing.Point(634, 159);
            this.ManufacturersCB.Name = "ManufacturersCB";
            this.ManufacturersCB.Size = new System.Drawing.Size(112, 21);
            this.ManufacturersCB.TabIndex = 12;
            this.ManufacturersCB.Text = "Manufacturer";
            this.ManufacturersCB.Visible = false;
            // 
            // ModelCB
            // 
            this.ModelCB.FormattingEnabled = true;
            this.ModelCB.Location = new System.Drawing.Point(752, 159);
            this.ModelCB.Name = "ModelCB";
            this.ModelCB.Size = new System.Drawing.Size(124, 21);
            this.ModelCB.TabIndex = 13;
            this.ModelCB.Text = "Model";
            this.ModelCB.Visible = false;
            // 
            // ColorsCB
            // 
            this.ColorsCB.FormattingEnabled = true;
            this.ColorsCB.Location = new System.Drawing.Point(604, 186);
            this.ColorsCB.Name = "ColorsCB";
            this.ColorsCB.Size = new System.Drawing.Size(88, 21);
            this.ColorsCB.TabIndex = 14;
            this.ColorsCB.Text = "Color";
            this.ColorsCB.Visible = false;
            // 
            // MinYearNUAD
            // 
            this.MinYearNUAD.Location = new System.Drawing.Point(604, 231);
            this.MinYearNUAD.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.MinYearNUAD.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.MinYearNUAD.Name = "MinYearNUAD";
            this.MinYearNUAD.Size = new System.Drawing.Size(59, 20);
            this.MinYearNUAD.TabIndex = 15;
            this.MinYearNUAD.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.MinYearNUAD.Visible = false;
            // 
            // MinYearL
            // 
            this.MinYearL.AutoSize = true;
            this.MinYearL.Location = new System.Drawing.Point(604, 215);
            this.MinYearL.Name = "MinYearL";
            this.MinYearL.Size = new System.Drawing.Size(49, 13);
            this.MinYearL.TabIndex = 16;
            this.MinYearL.Text = "Min Year";
            this.MinYearL.Visible = false;
            // 
            // MaxYearL
            // 
            this.MaxYearL.AutoSize = true;
            this.MaxYearL.Location = new System.Drawing.Point(672, 215);
            this.MaxYearL.Name = "MaxYearL";
            this.MaxYearL.Size = new System.Drawing.Size(52, 13);
            this.MaxYearL.TabIndex = 18;
            this.MaxYearL.Text = "Max Year";
            this.MaxYearL.Visible = false;
            // 
            // MaxYearNUAD
            // 
            this.MaxYearNUAD.Location = new System.Drawing.Point(672, 231);
            this.MaxYearNUAD.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.MaxYearNUAD.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.MaxYearNUAD.Name = "MaxYearNUAD";
            this.MaxYearNUAD.Size = new System.Drawing.Size(59, 20);
            this.MaxYearNUAD.TabIndex = 17;
            this.MaxYearNUAD.Tag = "0";
            this.MaxYearNUAD.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.MaxYearNUAD.Visible = false;
            // 
            // MaxPriceL
            // 
            this.MaxPriceL.AutoSize = true;
            this.MaxPriceL.Location = new System.Drawing.Point(812, 215);
            this.MaxPriceL.Name = "MaxPriceL";
            this.MaxPriceL.Size = new System.Drawing.Size(54, 13);
            this.MaxPriceL.TabIndex = 22;
            this.MaxPriceL.Text = "Max Price";
            this.MaxPriceL.Visible = false;
            // 
            // MaxPriceNUAD
            // 
            this.MaxPriceNUAD.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MaxPriceNUAD.Location = new System.Drawing.Point(812, 231);
            this.MaxPriceNUAD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxPriceNUAD.Name = "MaxPriceNUAD";
            this.MaxPriceNUAD.Size = new System.Drawing.Size(64, 20);
            this.MaxPriceNUAD.TabIndex = 21;
            this.MaxPriceNUAD.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxPriceNUAD.Visible = false;
            // 
            // MinPriceL
            // 
            this.MinPriceL.AutoSize = true;
            this.MinPriceL.Location = new System.Drawing.Point(743, 215);
            this.MinPriceL.Name = "MinPriceL";
            this.MinPriceL.Size = new System.Drawing.Size(51, 13);
            this.MinPriceL.TabIndex = 20;
            this.MinPriceL.Text = "Min Price";
            this.MinPriceL.Visible = false;
            // 
            // MinPriceNUAD
            // 
            this.MinPriceNUAD.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MinPriceNUAD.Location = new System.Drawing.Point(743, 231);
            this.MinPriceNUAD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MinPriceNUAD.Name = "MinPriceNUAD";
            this.MinPriceNUAD.Size = new System.Drawing.Size(64, 20);
            this.MinPriceNUAD.TabIndex = 19;
            this.MinPriceNUAD.Visible = false;
            // 
            // TitleTb
            // 
            this.TitleTb.Location = new System.Drawing.Point(604, 276);
            this.TitleTb.Multiline = true;
            this.TitleTb.Name = "TitleTb";
            this.TitleTb.Size = new System.Drawing.Size(127, 20);
            this.TitleTb.TabIndex = 23;
            this.TitleTb.Visible = false;
            // 
            // SellerUsernameTb
            // 
            this.SellerUsernameTb.Location = new System.Drawing.Point(749, 276);
            this.SellerUsernameTb.Name = "SellerUsernameTb";
            this.SellerUsernameTb.Size = new System.Drawing.Size(127, 20);
            this.SellerUsernameTb.TabIndex = 24;
            this.SellerUsernameTb.Visible = false;
            // 
            // TItleL
            // 
            this.TItleL.AutoSize = true;
            this.TItleL.Location = new System.Drawing.Point(604, 260);
            this.TItleL.Name = "TItleL";
            this.TItleL.Size = new System.Drawing.Size(27, 13);
            this.TItleL.TabIndex = 25;
            this.TItleL.Text = "Title";
            this.TItleL.Visible = false;
            // 
            // SellerUsernameL
            // 
            this.SellerUsernameL.AutoSize = true;
            this.SellerUsernameL.Location = new System.Drawing.Point(749, 260);
            this.SellerUsernameL.Name = "SellerUsernameL";
            this.SellerUsernameL.Size = new System.Drawing.Size(84, 13);
            this.SellerUsernameL.TabIndex = 26;
            this.SellerUsernameL.Text = "Seller Username";
            this.SellerUsernameL.Visible = false;
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(136)))), ((int)(((byte)(129)))));
            this.UpPanel.Controls.Add(this.Unamelabel);
            this.UpPanel.Controls.Add(this.RegisterBtn);
            this.UpPanel.Controls.Add(this.SignUpBtn);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(888, 65);
            this.UpPanel.TabIndex = 28;
            // 
            // AdvSearchPBtn
            // 
            this.AdvSearchPBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdvSearchPBtn.Image")));
            this.AdvSearchPBtn.Location = new System.Drawing.Point(846, 302);
            this.AdvSearchPBtn.Name = "AdvSearchPBtn";
            this.AdvSearchPBtn.Size = new System.Drawing.Size(30, 30);
            this.AdvSearchPBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AdvSearchPBtn.TabIndex = 29;
            this.AdvSearchPBtn.TabStop = false;
            this.AdvSearchPBtn.Click += new System.EventHandler(this.AdvSearchPBtn_Click_1);
            // 
            // BuyBtn
            // 
            this.BuyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBtn.Location = new System.Drawing.Point(495, 83);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(106, 35);
            this.BuyBtn.TabIndex = 30;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Visible = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 441);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.AdvSearchPBtn);
            this.Controls.Add(this.CarsLabel);
            this.Controls.Add(this.CarsDGV);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MinYearL);
            this.Controls.Add(this.SellerUsernameL);
            this.Controls.Add(this.MinYearNUAD);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.MaxYearNUAD);
            this.Controls.Add(this.TItleL);
            this.Controls.Add(this.ColorsCB);
            this.Controls.Add(this.ShowMyCarBtn);
            this.Controls.Add(this.MaxYearL);
            this.Controls.Add(this.SellerUsernameTb);
            this.Controls.Add(this.ModelCB);
            this.Controls.Add(this.ShowAllCarBtn);
            this.Controls.Add(this.MinPriceNUAD);
            this.Controls.Add(this.TitleTb);
            this.Controls.Add(this.ManufacturersCB);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.MinPriceL);
            this.Controls.Add(this.MaxPriceL);
            this.Controls.Add(this.AdvancedSearchPBtn);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.MaxPriceNUAD);
            this.Name = "MainPage";
            this.Text = "StepAuto";
            this.Activated += new System.EventHandler(this.MainPage_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancedSearchPBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinYearNUAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxYearNUAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPriceNUAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPriceNUAD)).EndInit();
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvSearchPBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.DataGridView CarsDGV;
        private System.Windows.Forms.Label CarsLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button ShowMyCarBtn;
        private System.Windows.Forms.Button ShowAllCarBtn;
        private System.Windows.Forms.Label Unamelabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.PictureBox AdvancedSearchPBtn;
        private System.Windows.Forms.ComboBox ManufacturersCB;
        private System.Windows.Forms.ComboBox ModelCB;
        private System.Windows.Forms.ComboBox ColorsCB;
        private System.Windows.Forms.NumericUpDown MinYearNUAD;
        private System.Windows.Forms.Label MinYearL;
        private System.Windows.Forms.Label MaxYearL;
        private System.Windows.Forms.NumericUpDown MaxYearNUAD;
        private System.Windows.Forms.Label MaxPriceL;
        private System.Windows.Forms.NumericUpDown MaxPriceNUAD;
        private System.Windows.Forms.Label MinPriceL;
        private System.Windows.Forms.NumericUpDown MinPriceNUAD;
        private System.Windows.Forms.TextBox TitleTb;
        private System.Windows.Forms.TextBox SellerUsernameTb;
        private System.Windows.Forms.Label TItleL;
        private System.Windows.Forms.Label SellerUsernameL;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.PictureBox AdvSearchPBtn;
        private System.Windows.Forms.Button BuyBtn;
    }
}

