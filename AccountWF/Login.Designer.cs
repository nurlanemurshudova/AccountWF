namespace AccountWF
{
    partial class Login
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
            panel = new Panel();
            signUpButton = new Button();
            signInButton = new Button();
            exitLabel = new LinkLabel();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            signIn = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ButtonFace;
            panel.Controls.Add(signUpButton);
            panel.Controls.Add(signInButton);
            panel.Controls.Add(exitLabel);
            panel.Controls.Add(passwordBox);
            panel.Controls.Add(emailBox);
            panel.Controls.Add(passwordLabel);
            panel.Controls.Add(emailLabel);
            panel.Controls.Add(signIn);
            panel.Location = new Point(117, 63);
            panel.Name = "panel";
            panel.Size = new Size(555, 493);
            panel.TabIndex = 1;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.LightGreen;
            signUpButton.Location = new Point(276, 334);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(158, 38);
            signUpButton.TabIndex = 7;
            signUpButton.Text = "Sign up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // signInButton
            // 
            signInButton.BackColor = SystemColors.GradientActiveCaption;
            signInButton.Location = new Point(140, 334);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(139, 38);
            signInButton.TabIndex = 6;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = SystemColors.ControlDarkDark;
            exitLabel.Location = new Point(260, 399);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(39, 25);
            exitLabel.TabIndex = 5;
            exitLabel.TabStop = true;
            exitLabel.Text = "Exit";
            exitLabel.LinkClicked += exitLabel_LinkClicked;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(139, 253);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(295, 27);
            passwordBox.TabIndex = 4;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(139, 163);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(295, 27);
            emailBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(139, 213);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(139, 124);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 25);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // signIn
            // 
            signIn.AutoSize = true;
            signIn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signIn.Location = new Point(223, 52);
            signIn.Name = "signIn";
            signIn.Size = new Size(117, 41);
            signIn.TabIndex = 0;
            signIn.Text = "Sign In";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 600);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            FormClosed += Login_FormClosed;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Label signIn;
        private Label emailLabel;
        private TextBox passwordBox;
        private TextBox emailBox;
        private Label passwordLabel;
        private LinkLabel exitLabel;
        private Button signUpButton;
        private Button signInButton;
    }
}
