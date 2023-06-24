namespace Project_2___Step
{
    partial class Register
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
            this.BalanceNUAD = new System.Windows.Forms.NumericUpDown();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.LNameTb = new System.Windows.Forms.TextBox();
            this.FNameTb = new System.Windows.Forms.TextBox();
            this.SellerR = new System.Windows.Forms.RadioButton();
            this.BuyerR = new System.Windows.Forms.RadioButton();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.usernameerrorlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // BalanceNUAD
            // 
            this.BalanceNUAD.Location = new System.Drawing.Point(108, 170);
            this.BalanceNUAD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BalanceNUAD.Name = "BalanceNUAD";
            this.BalanceNUAD.Size = new System.Drawing.Size(120, 20);
            this.BalanceNUAD.TabIndex = 27;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(108, 132);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(157, 26);
            this.PasswordTb.TabIndex = 26;
            this.PasswordTb.TextChanged += new System.EventHandler(this.PasswordTb_TextChanged);
            // 
            // UnameTb
            // 
            this.UnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameTb.Location = new System.Drawing.Point(108, 93);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(157, 26);
            this.UnameTb.TabIndex = 25;
            this.UnameTb.TextChanged += new System.EventHandler(this.UnameTb_TextChanged);
            // 
            // LNameTb
            // 
            this.LNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameTb.Location = new System.Drawing.Point(108, 47);
            this.LNameTb.Name = "LNameTb";
            this.LNameTb.Size = new System.Drawing.Size(157, 26);
            this.LNameTb.TabIndex = 24;
            this.LNameTb.TextChanged += new System.EventHandler(this.LNameTb_TextChanged);
            // 
            // FNameTb
            // 
            this.FNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameTb.Location = new System.Drawing.Point(108, 6);
            this.FNameTb.Name = "FNameTb";
            this.FNameTb.Size = new System.Drawing.Size(157, 26);
            this.FNameTb.TabIndex = 23;
            this.FNameTb.TextChanged += new System.EventHandler(this.FNameTb_TextChanged);
            // 
            // SellerR
            // 
            this.SellerR.AutoSize = true;
            this.SellerR.Location = new System.Drawing.Point(75, 207);
            this.SellerR.Name = "SellerR";
            this.SellerR.Size = new System.Drawing.Size(51, 17);
            this.SellerR.TabIndex = 22;
            this.SellerR.TabStop = true;
            this.SellerR.Text = "Seller";
            this.SellerR.UseVisualStyleBackColor = true;
            // 
            // BuyerR
            // 
            this.BuyerR.AutoSize = true;
            this.BuyerR.Location = new System.Drawing.Point(17, 207);
            this.BuyerR.Name = "BuyerR";
            this.BuyerR.Size = new System.Drawing.Size(52, 17);
            this.BuyerR.TabIndex = 21;
            this.BuyerR.TabStop = true;
            this.BuyerR.Text = "Buyer";
            this.BuyerR.UseVisualStyleBackColor = true;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(12, 170);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(71, 20);
            this.BalanceLabel.TabIndex = 20;
            this.BalanceLabel.Text = "Balance:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 132);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 19;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 93);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 18;
            this.UsernameLabel.Text = "Username:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(12, 47);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.LastNameLabel.TabIndex = 17;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(90, 20);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "First Name:";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(17, 237);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(54, 23);
            this.RegisterBtn.TabIndex = 15;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // usernameerrorlabel
            // 
            this.usernameerrorlabel.AutoSize = true;
            this.usernameerrorlabel.Location = new System.Drawing.Point(117, 76);
            this.usernameerrorlabel.Name = "usernameerrorlabel";
            this.usernameerrorlabel.Size = new System.Drawing.Size(123, 13);
            this.usernameerrorlabel.TabIndex = 28;
            this.usernameerrorlabel.Text = "Username Already Exists";
            this.usernameerrorlabel.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 272);
            this.Controls.Add(this.usernameerrorlabel);
            this.Controls.Add(this.BalanceNUAD);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.LNameTb);
            this.Controls.Add(this.FNameTb);
            this.Controls.Add(this.SellerR);
            this.Controls.Add(this.BuyerR);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RegisterBtn);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.BalanceNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown BalanceNUAD;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.TextBox LNameTb;
        private System.Windows.Forms.TextBox FNameTb;
        private System.Windows.Forms.RadioButton SellerR;
        private System.Windows.Forms.RadioButton BuyerR;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label usernameerrorlabel;
    }
}