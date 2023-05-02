namespace Academy
{
    partial class LoginForm
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
            lblTitle = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            lblCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(83, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Academy Login";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(33, 64);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "E-mail";
            tbEmail.Size = new Size(262, 23);
            tbEmail.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(33, 104);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '●';
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(262, 23);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(33, 141);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(262, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblCancel
            // 
            lblCancel.BackColor = Color.Firebrick;
            lblCancel.FlatAppearance.BorderSize = 0;
            lblCancel.FlatStyle = FlatStyle.Flat;
            lblCancel.Location = new Point(33, 170);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(262, 23);
            lblCancel.TabIndex = 6;
            lblCancel.Text = "Cancel";
            lblCancel.UseVisualStyleBackColor = false;
            lblCancel.Click += lblCancelClick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 243);
            Controls.Add(lblCancel);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button lblCancel;
    }
}