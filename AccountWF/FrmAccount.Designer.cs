namespace AccountWF
{
    partial class FrmAccount
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
            emailBox = new TextBox();
            label1 = new Label();
            passwordBox = new TextBox();
            nameBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            btnUpdate = new Button();
            btnSave = new Button();
            label = new Label();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // emailBox
            // 
            emailBox.Location = new Point(65, 205);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(295, 27);
            emailBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 177);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 17;
            label1.Text = "Email";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(65, 285);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(295, 27);
            passwordBox.TabIndex = 18;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(65, 126);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(295, 27);
            nameBox.TabIndex = 16;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(47, 257);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 15;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(47, 98);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 25);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Name";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGreen;
            btnUpdate.Location = new Point(65, 361);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 38);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Location = new Point(232, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 38);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(313, 36);
            label.Name = "label";
            label.Size = new Size(147, 41);
            label.TabIndex = 22;
            label.Text = "Welcome";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.LightSalmon;
            btnLogOut.Location = new Point(608, 361);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(128, 38);
            btnLogOut.TabIndex = 23;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogOut);
            Controls.Add(label);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(emailBox);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(nameBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Name = "FrmAccount";
            Text = "FrmAccount";
            FormClosed += FrmAccount_FormClosed;
            Load += FrmAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailBox;
        private Label label1;
        private TextBox passwordBox;
        private TextBox nameBox;
        private Label passwordLabel;
        private Label emailLabel;
        private Button btnUpdate;
        private Button btnSave;
        private Label label;
        private Button btnLogOut;
    }
}