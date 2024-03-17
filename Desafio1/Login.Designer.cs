namespace Desafio1
{
    partial class FormLogin
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
            lblUsuario = new Label();
            lblClave = new Label();
            lblLogin = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnSesion = new Button();
            pictureBoxLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(460, 140);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += label1_Click;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.ForeColor = SystemColors.ControlLightLight;
            lblClave.Location = new Point(460, 235);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(58, 25);
            lblClave.TabIndex = 1;
            lblClave.Text = "Clave";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ControlLightLight;
            lblLogin.Location = new Point(483, 38);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(146, 32);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Inicia Sesión";
            lblLogin.Click += lblLogin_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Control;
            txtUser.ImeMode = ImeMode.On;
            txtUser.Location = new Point(464, 185);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(165, 23);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.ImeMode = ImeMode.On;
            txtPassword.Location = new Point(464, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(165, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSesion
            // 
            btnSesion.BackColor = Color.FromArgb(28, 11, 43);
            btnSesion.ForeColor = SystemColors.ControlLightLight;
            btnSesion.Location = new Point(464, 335);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(165, 42);
            btnSesion.TabIndex = 5;
            btnSesion.Text = "Iniciar Sesión";
            btnSesion.UseVisualStyleBackColor = false;
            btnSesion.Click += btnSesion_Click;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.BackgroundImage = Properties.Resources.login;
            pictureBoxLogin.Location = new Point(83, 86);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(256, 262);
            pictureBoxLogin.TabIndex = 6;
            pictureBoxLogin.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 28, 65);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxLogin);
            Controls.Add(btnSesion);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblLogin);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblClave;
        private Label lblLogin;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnSesion;
        private PictureBox pictureBoxLogin;
    }
}