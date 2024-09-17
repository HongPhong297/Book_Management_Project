namespace Book_Management_PhongLe
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
            grbAccount = new GroupBox();
            btbCancel = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblHeader = new Label();
            grbAccount.SuspendLayout();
            SuspendLayout();
            // 
            // grbAccount
            // 
            grbAccount.BackColor = Color.FromArgb(0, 192, 0);
            grbAccount.Controls.Add(btbCancel);
            grbAccount.Controls.Add(btnLogin);
            grbAccount.Controls.Add(txtPassword);
            grbAccount.Controls.Add(txtEmail);
            grbAccount.Controls.Add(lblPassword);
            grbAccount.Controls.Add(lblEmail);
            grbAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAccount.Location = new Point(62, 118);
            grbAccount.Name = "grbAccount";
            grbAccount.Size = new Size(687, 310);
            grbAccount.TabIndex = 0;
            grbAccount.TabStop = false;
            grbAccount.Text = "Account Info";
            // 
            // btbCancel
            // 
            btbCancel.FlatStyle = FlatStyle.Flat;
            btbCancel.Location = new Point(407, 225);
            btbCancel.Name = "btbCancel";
            btbCancel.Size = new Size(190, 45);
            btbCancel.TabIndex = 3;
            btbCancel.Text = "Cancel";
            btbCancel.UseVisualStyleBackColor = true;
            btbCancel.Click += btbCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(189, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 45);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(189, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(454, 38);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(454, 38);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPassword.Location = new Point(48, 156);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 31);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblEmail.Location = new Point(48, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 31);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe Script", 36F, FontStyle.Bold);
            lblHeader.Location = new Point(62, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(694, 99);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Book Manager Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeader);
            Controls.Add(grbAccount);
            Name = "Login";
            Text = "Login";
            grbAccount.ResumeLayout(false);
            grbAccount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbAccount;
        private Label lblHeader;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btbCancel;
        private Button btnLogin;
    }
}