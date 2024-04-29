namespace AccountWF
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
            panel1 = new Panel();
            repeatPasswordBox = new TextBox();
            label2 = new Label();
            emailBox = new TextBox();
            label1 = new Label();
            signUpButton = new Button();
            signInButton = new Button();
            exitLabel = new LinkLabel();
            passwordBox = new TextBox();
            nameBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            signIn = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(repeatPasswordBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signUpButton);
            panel1.Controls.Add(signInButton);
            panel1.Controls.Add(exitLabel);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(signIn);
            panel1.Location = new Point(72, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 669);
            panel1.TabIndex = 0;
            // 
            // repeatPasswordBox
            // 
            repeatPasswordBox.Location = new Point(181, 433);
            repeatPasswordBox.Name = "repeatPasswordBox";
            repeatPasswordBox.Size = new Size(295, 27);
            repeatPasswordBox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(181, 402);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 16;
            label2.Text = "Repeat Password";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(181, 275);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(295, 27);
            emailBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 247);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 12;
            label1.Text = "Email";
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.LightGreen;
            signUpButton.Location = new Point(318, 499);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(158, 38);
            signUpButton.TabIndex = 15;
            signUpButton.Text = "Sign up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // signInButton
            // 
            signInButton.BackColor = SystemColors.GradientActiveCaption;
            signInButton.Location = new Point(182, 499);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(139, 38);
            signInButton.TabIndex = 14;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = SystemColors.ControlDarkDark;
            exitLabel.Location = new Point(302, 564);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(39, 25);
            exitLabel.TabIndex = 13;
            exitLabel.TabStop = true;
            exitLabel.Text = "Exit";
            exitLabel.LinkClicked += exitLabel_LinkClicked;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(181, 355);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(295, 27);
            passwordBox.TabIndex = 12;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(181, 196);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(295, 27);
            nameBox.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(181, 327);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(181, 168);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 25);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Name";
            // 
            // signIn
            // 
            signIn.AutoSize = true;
            signIn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signIn.Location = new Point(265, 96);
            signIn.Name = "signIn";
            signIn.Size = new Size(130, 41);
            signIn.TabIndex = 8;
            signIn.Text = "Sign Up";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 800);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            FormClosed += Register_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button signUpButton;
        private Button signInButton;
        private LinkLabel exitLabel;
        private TextBox passwordBox;
        private TextBox nameBox;
        private Label passwordLabel;
        private Label emailLabel;
        private Label signIn;
        private TextBox emailBox;
        private Label label1;
        private TextBox repeatPasswordBox;
        private Label label2;
    }
}