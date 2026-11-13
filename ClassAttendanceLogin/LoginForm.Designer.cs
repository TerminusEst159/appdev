namespace ClassAttendanceLogin
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblMessage = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(80, 36);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Attendance";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(127, 65);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(107, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sign in to continue";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10F);
            lblEmail.Location = new Point(30, 121);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10F);
            lblPassword.Location = new Point(34, 200);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 145);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(116, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 224);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(116, 23);
            txtPassword.TabIndex = 5;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(30, 273);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(236, 15);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "Login Failed. Double check your credentials";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(14, 331);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(346, 51);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 414);
            Controls.Add(btnLogin);
            Controls.Add(lblMessage);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "Attendance Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLogin;
    }
}

