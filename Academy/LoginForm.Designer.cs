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
            lblEmail = new Label();
            lblPassword = new Label();
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
            lblTitle.Location = new Point(83, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Academy Login";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(43, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(27, 123);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(101, 77);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(174, 23);
            tbEmail.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(101, 120);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(174, 23);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(200, 182);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblCancel
            // 
            lblCancel.Location = new Point(119, 182);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(75, 23);
            lblCancel.TabIndex = 6;
            lblCancel.Text = "Cancel";
            lblCancel.UseVisualStyleBackColor = true;
            lblCancel.Click += lblCancelClick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 230);
            Controls.Add(lblCancel);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button lblCancel;
    }
}