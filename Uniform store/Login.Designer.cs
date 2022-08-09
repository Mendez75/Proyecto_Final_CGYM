namespace Uniform_store
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.signInGroupBox = new System.Windows.Forms.GroupBox();
            this.RolecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.forgetPassword = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signInGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInGroupBox
            // 
            this.signInGroupBox.Controls.Add(this.RolecomboBox);
            this.signInGroupBox.Controls.Add(this.label2);
            this.signInGroupBox.Controls.Add(this.forgetPassword);
            this.signInGroupBox.Controls.Add(this.loginButton);
            this.signInGroupBox.Controls.Add(this.checkPassword);
            this.signInGroupBox.Controls.Add(this.password);
            this.signInGroupBox.Controls.Add(this.userName);
            this.signInGroupBox.Controls.Add(this.PasswordTextBox);
            this.signInGroupBox.Controls.Add(this.userNameTextBox);
            this.signInGroupBox.Location = new System.Drawing.Point(210, 74);
            this.signInGroupBox.Name = "signInGroupBox";
            this.signInGroupBox.Size = new System.Drawing.Size(241, 242);
            this.signInGroupBox.TabIndex = 3;
            this.signInGroupBox.TabStop = false;
            this.signInGroupBox.Enter += new System.EventHandler(this.signInGroupBox_Enter);
            // 
            // RolecomboBox
            // 
            this.RolecomboBox.FormattingEnabled = true;
            this.RolecomboBox.Items.AddRange(new object[] {
            "admin",
            "vendedor"});
            this.RolecomboBox.Location = new System.Drawing.Point(90, 41);
            this.RolecomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.RolecomboBox.Name = "RolecomboBox";
            this.RolecomboBox.Size = new System.Drawing.Size(142, 21);
            this.RolecomboBox.TabIndex = 9;
            this.RolecomboBox.SelectedIndexChanged += new System.EventHandler(this.RolecomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rol";
            // 
            // forgetPassword
            // 
            this.forgetPassword.AutoSize = true;
            this.forgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetPassword.Location = new System.Drawing.Point(7, 182);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(119, 13);
            this.forgetPassword.TabIndex = 6;
            this.forgetPassword.TabStop = true;
            this.forgetPassword.Text = "¿Olvidó su contraseña?";
            this.forgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPassword_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(6, 213);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(230, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Iniciar sesión";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkPassword
            // 
            this.checkPassword.AutoSize = true;
            this.checkPassword.BackColor = System.Drawing.Color.White;
            this.checkPassword.Location = new System.Drawing.Point(115, 155);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(117, 17);
            this.checkPassword.TabIndex = 4;
            this.checkPassword.Text = "Mostrar contraseña";
            this.checkPassword.UseVisualStyleBackColor = false;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged_1);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.password.Location = new System.Drawing.Point(7, 118);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(80, 15);
            this.password.TabIndex = 3;
            this.password.Text = "Contraseña";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(16, 77);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(57, 15);
            this.userName.TabIndex = 2;
            this.userName.Text = "Usuario";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.PasswordTextBox.Location = new System.Drawing.Point(90, 116);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(146, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.userNameTextBox.Location = new System.Drawing.Point(89, 72);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "INICIE SESION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(486, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signInGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio sesión";
            this.signInGroupBox.ResumeLayout(false);
            this.signInGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox signInGroupBox;
        private System.Windows.Forms.LinkLabel forgetPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox checkPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox RolecomboBox;
        private System.Windows.Forms.Label label2;
    }
}