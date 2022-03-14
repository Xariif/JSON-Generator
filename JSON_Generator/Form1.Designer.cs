namespace JSON_Generator
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bGenerate = new System.Windows.Forms.Button();
            this.cLogin = new System.Windows.Forms.CheckBox();
            this.cPassword = new System.Windows.Forms.CheckBox();
            this.cEmail = new System.Windows.Forms.CheckBox();
            this.cPhone = new System.Windows.Forms.CheckBox();
            this.cAddress = new System.Windows.Forms.CheckBox();
            this.cName = new System.Windows.Forms.CheckBox();
            this.cSurname = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.cCountry = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(279, 108);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(81, 23);
            this.bGenerate.TabIndex = 0;
            this.bGenerate.Text = "Generuj";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.BGenerate_Click);
            // 
            // cLogin
            // 
            this.cLogin.AutoSize = true;
            this.cLogin.Location = new System.Drawing.Point(12, 12);
            this.cLogin.Name = "cLogin";
            this.cLogin.Size = new System.Drawing.Size(56, 19);
            this.cLogin.TabIndex = 1;
            this.cLogin.Text = "Login";
            this.cLogin.UseVisualStyleBackColor = true;
            // 
            // cPassword
            // 
            this.cPassword.AutoSize = true;
            this.cPassword.Location = new System.Drawing.Point(12, 37);
            this.cPassword.Name = "cPassword";
            this.cPassword.Size = new System.Drawing.Size(76, 19);
            this.cPassword.TabIndex = 2;
            this.cPassword.Text = "Password";
            this.cPassword.UseVisualStyleBackColor = true;
            // 
            // cEmail
            // 
            this.cEmail.AutoSize = true;
            this.cEmail.Location = new System.Drawing.Point(12, 62);
            this.cEmail.Name = "cEmail";
            this.cEmail.Size = new System.Drawing.Size(60, 19);
            this.cEmail.TabIndex = 3;
            this.cEmail.Text = "E-mail";
            this.cEmail.UseVisualStyleBackColor = true;
            // 
            // cPhone
            // 
            this.cPhone.AutoSize = true;
            this.cPhone.Location = new System.Drawing.Point(119, 62);
            this.cPhone.Name = "cPhone";
            this.cPhone.Size = new System.Drawing.Size(60, 19);
            this.cPhone.TabIndex = 4;
            this.cPhone.Text = "Phone";
            this.cPhone.UseVisualStyleBackColor = true;
            // 
            // cAddress
            // 
            this.cAddress.AutoSize = true;
            this.cAddress.Location = new System.Drawing.Point(119, 37);
            this.cAddress.Name = "cAddress";
            this.cAddress.Size = new System.Drawing.Size(68, 19);
            this.cAddress.TabIndex = 5;
            this.cAddress.Text = "Address";
            this.cAddress.UseVisualStyleBackColor = true;
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Location = new System.Drawing.Point(12, 87);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(58, 19);
            this.cName.TabIndex = 6;
            this.cName.Text = "Name";
            this.cName.UseVisualStyleBackColor = true;
            // 
            // cSurname
            // 
            this.cSurname.AutoSize = true;
            this.cSurname.Location = new System.Drawing.Point(12, 112);
            this.cSurname.Name = "cSurname";
            this.cSurname.Size = new System.Drawing.Size(73, 19);
            this.cSurname.TabIndex = 7;
            this.cSurname.Text = "Surname";
            this.cSurname.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Location = new System.Drawing.Point(279, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 19);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Liczba wierszy";
            // 
            // cCountry
            // 
            this.cCountry.AutoSize = true;
            this.cCountry.Location = new System.Drawing.Point(119, 12);
            this.cCountry.Name = "cCountry";
            this.cCountry.Size = new System.Drawing.Size(69, 19);
            this.cCountry.TabIndex = 11;
            this.cCountry.Text = "Country";
            this.cCountry.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 145);
            this.Controls.Add(this.cCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cSurname);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.cAddress);
            this.Controls.Add(this.cPhone);
            this.Controls.Add(this.cEmail);
            this.Controls.Add(this.cPassword);
            this.Controls.Add(this.cLogin);
            this.Controls.Add(this.bGenerate);
            this.Text = "Data Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bGenerate;
        private CheckBox cLogin;
        private CheckBox cPassword;
        private CheckBox cEmail;
        private CheckBox cPhone;
        private CheckBox cAddress;
        private CheckBox cName;
        private CheckBox cSurname;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private SaveFileDialog saveFile;
        private CheckBox cCountry;
    }
}