namespace MaskON
{
    partial class boxRegister
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
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.Label();
            this.textFullname = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.Label();
            this.textGender = new System.Windows.Forms.Label();
            this.textNik = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.boxNik = new System.Windows.Forms.TextBox();
            this.boxLocation = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.textGenderr = new System.Windows.Forms.ComboBox();
            this.textTypee = new System.Windows.Forms.ComboBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxPassword
            // 
            this.boxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.boxPassword.Location = new System.Drawing.Point(168, 91);
            this.boxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(102, 21);
            this.boxPassword.TabIndex = 2;
            this.boxPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boxUsername
            // 
            this.boxUsername.Location = new System.Drawing.Point(168, 60);
            this.boxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(102, 20);
            this.boxUsername.TabIndex = 3;
            this.boxUsername.TextChanged += new System.EventHandler(this.boxUsername_TextChanged);
            // 
            // textUsername
            // 
            this.textUsername.AutoSize = true;
            this.textUsername.Location = new System.Drawing.Point(68, 60);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(55, 13);
            this.textUsername.TabIndex = 4;
            this.textUsername.Text = "Username";
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = true;
            this.textPassword.Location = new System.Drawing.Point(68, 91);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(53, 13);
            this.textPassword.TabIndex = 5;
            this.textPassword.Text = "Password";
            // 
            // textFullname
            // 
            this.textFullname.AutoSize = true;
            this.textFullname.Location = new System.Drawing.Point(68, 122);
            this.textFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textFullname.Name = "textFullname";
            this.textFullname.Size = new System.Drawing.Size(52, 13);
            this.textFullname.TabIndex = 6;
            this.textFullname.Text = "Full name";
            this.textFullname.Click += new System.EventHandler(this.label1_Click);
            // 
            // textEmail
            // 
            this.textEmail.AutoSize = true;
            this.textEmail.Location = new System.Drawing.Point(68, 153);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(32, 13);
            this.textEmail.TabIndex = 7;
            this.textEmail.Text = "Email";
            // 
            // textPhone
            // 
            this.textPhone.AutoSize = true;
            this.textPhone.Location = new System.Drawing.Point(68, 185);
            this.textPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textPhone.Name = "textPhone";
            this.textPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textPhone.Size = new System.Drawing.Size(78, 13);
            this.textPhone.TabIndex = 8;
            this.textPhone.Text = "Phone Number";
            // 
            // textGender
            // 
            this.textGender.AutoSize = true;
            this.textGender.Location = new System.Drawing.Point(67, 216);
            this.textGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(42, 13);
            this.textGender.TabIndex = 9;
            this.textGender.Text = "Gender";
            // 
            // textNik
            // 
            this.textNik.AutoSize = true;
            this.textNik.Location = new System.Drawing.Point(67, 247);
            this.textNik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textNik.Name = "textNik";
            this.textNik.Size = new System.Drawing.Size(25, 13);
            this.textNik.TabIndex = 10;
            this.textNik.Text = "NIK";
            // 
            // textLocation
            // 
            this.textLocation.AutoSize = true;
            this.textLocation.Location = new System.Drawing.Point(68, 278);
            this.textLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(73, 13);
            this.textLocation.TabIndex = 11;
            this.textLocation.Text = "User Location";
            // 
            // textType
            // 
            this.textType.AutoSize = true;
            this.textType.Location = new System.Drawing.Point(68, 309);
            this.textType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(74, 13);
            this.textType.TabIndex = 12;
            this.textType.Text = "Account Type";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(168, 122);
            this.boxName.Margin = new System.Windows.Forms.Padding(2);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(102, 20);
            this.boxName.TabIndex = 13;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(168, 153);
            this.boxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(102, 20);
            this.boxEmail.TabIndex = 14;
            // 
            // boxPhone
            // 
            this.boxPhone.Location = new System.Drawing.Point(168, 185);
            this.boxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(102, 20);
            this.boxPhone.TabIndex = 15;
            // 
            // boxNik
            // 
            this.boxNik.Location = new System.Drawing.Point(168, 247);
            this.boxNik.Margin = new System.Windows.Forms.Padding(2);
            this.boxNik.Name = "boxNik";
            this.boxNik.Size = new System.Drawing.Size(102, 20);
            this.boxNik.TabIndex = 17;
            // 
            // boxLocation
            // 
            this.boxLocation.Location = new System.Drawing.Point(168, 278);
            this.boxLocation.Margin = new System.Windows.Forms.Padding(2);
            this.boxLocation.Name = "boxLocation";
            this.boxLocation.Size = new System.Drawing.Size(102, 20);
            this.boxLocation.TabIndex = 18;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.title.Location = new System.Drawing.Point(138, 19);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(69, 20);
            this.title.TabIndex = 20;
            this.title.Text = "Register";
            // 
            // textGenderr
            // 
            this.textGenderr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textGenderr.FormattingEnabled = true;
            this.textGenderr.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.textGenderr.Location = new System.Drawing.Point(168, 216);
            this.textGenderr.Margin = new System.Windows.Forms.Padding(2);
            this.textGenderr.Name = "textGenderr";
            this.textGenderr.Size = new System.Drawing.Size(102, 21);
            this.textGenderr.TabIndex = 21;
            // 
            // textTypee
            // 
            this.textTypee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textTypee.FormattingEnabled = true;
            this.textTypee.Items.AddRange(new object[] {
            "Donator",
            "Reciever"});
            this.textTypee.Location = new System.Drawing.Point(168, 309);
            this.textTypee.Margin = new System.Windows.Forms.Padding(2);
            this.textTypee.Name = "textTypee";
            this.textTypee.Size = new System.Drawing.Size(102, 21);
            this.textTypee.TabIndex = 22;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(209, 345);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(54, 32);
            this.buttonRegister.TabIndex = 23;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(87, 345);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(54, 32);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // boxRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 394);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textTypee);
            this.Controls.Add(this.textGenderr);
            this.Controls.Add(this.title);
            this.Controls.Add(this.boxLocation);
            this.Controls.Add(this.boxNik);
            this.Controls.Add(this.boxPhone);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.textNik);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textFullname);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this.boxPassword);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "boxRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.TextBox boxUsername;
        private System.Windows.Forms.Label textUsername;
        private System.Windows.Forms.Label textPassword;
        private System.Windows.Forms.Label textFullname;
        private System.Windows.Forms.Label textEmail;
        private System.Windows.Forms.Label textPhone;
        private System.Windows.Forms.Label textGender;
        private System.Windows.Forms.Label textNik;
        private System.Windows.Forms.Label textLocation;
        private System.Windows.Forms.Label textType;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.TextBox boxNik;
        private System.Windows.Forms.TextBox boxLocation;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox textGenderr;
        private System.Windows.Forms.ComboBox textTypee;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonBack;
    }
}

