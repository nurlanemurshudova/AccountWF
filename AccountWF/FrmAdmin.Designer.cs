namespace AccountWF
{
    partial class FrmAdmin
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
            dtTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            repeatPasswordBox = new TextBox();
            label2 = new Label();
            emailBox = new TextBox();
            label1 = new Label();
            passwordBox = new TextBox();
            nameBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            txtDeleteUser = new TextBox();
            userName = new Label();
            deleteUser = new Label();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dtTable).BeginInit();
            SuspendLayout();
            // 
            // dtTable
            // 
            dtTable.AllowUserToResizeColumns = false;
            dtTable.AllowUserToResizeRows = false;
            dtTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTable.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Email, Password });
            dtTable.Location = new Point(-1, 473);
            dtTable.Name = "dtTable";
            dtTable.ReadOnly = true;
            dtTable.RowHeadersWidth = 51;
            dtTable.Size = new Size(1003, 227);
            dtTable.TabIndex = 0;
            dtTable.CellClick += dtTable_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // repeatPasswordBox
            // 
            repeatPasswordBox.Location = new Point(99, 307);
            repeatPasswordBox.Name = "repeatPasswordBox";
            repeatPasswordBox.Size = new Size(295, 27);
            repeatPasswordBox.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 266);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 24;
            label2.Text = "Repeat Password";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(99, 146);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(295, 27);
            emailBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 118);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 21;
            label1.Text = "Email";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(99, 226);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(295, 27);
            passwordBox.TabIndex = 22;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(99, 76);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(295, 27);
            nameBox.TabIndex = 20;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(99, 188);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(99, 48);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 25);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Name";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.LightGreen;
            btnAddUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(99, 365);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(127, 41);
            btnAddUser.TabIndex = 26;
            btnAddUser.Text = "User add";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.LightPink;
            btnDeleteUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteUser.Location = new Point(684, 304);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(127, 41);
            btnDeleteUser.TabIndex = 29;
            btnDeleteUser.Text = "User Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // txtDeleteUser
            // 
            txtDeleteUser.Location = new Point(605, 246);
            txtDeleteUser.Name = "txtDeleteUser";
            txtDeleteUser.Size = new Size(295, 27);
            txtDeleteUser.TabIndex = 28;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(605, 205);
            userName.Name = "userName";
            userName.Size = new Size(99, 25);
            userName.TabIndex = 27;
            userName.Text = "User Name";
            // 
            // deleteUser
            // 
            deleteUser.AutoSize = true;
            deleteUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteUser.Location = new Point(681, 119);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(180, 41);
            deleteUser.TabIndex = 30;
            deleteUser.Text = "Delete User";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumTurquoise;
            btnUpdate.Location = new Point(247, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 38);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(btnUpdate);
            Controls.Add(deleteUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(txtDeleteUser);
            Controls.Add(userName);
            Controls.Add(btnAddUser);
            Controls.Add(repeatPasswordBox);
            Controls.Add(label2);
            Controls.Add(emailBox);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(nameBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(dtTable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "FrmAdmin";
            FormClosed += FrmAdmin_FormClosed;
            Load += FrmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dtTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private TextBox repeatPasswordBox;
        private Label label2;
        private TextBox emailBox;
        private Label label1;
        private TextBox passwordBox;
        private TextBox nameBox;
        private Label passwordLabel;
        private Label emailLabel;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private TextBox txtDeleteUser;
        private Label userName;
        private Label deleteUser;
        private Button btnUpdate;
    }
}