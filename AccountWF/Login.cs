using AccountWF.Constant;
using AccountWF.DataAccess.SqlDbContext;
using AccountWF.Entities;
using System.Data.SqlClient;
using Account = AccountWF.Entities.Account;

namespace AccountWF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void exitLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (emailBox.Text != "" && passwordBox.Text != "")
            {
                if (passwordBox.Text.Length > 3)
                {
                    using (SqlConnection connection = new SqlConnection(DB.Database.ConnectionString))
                    {
                        connection.Open();
                        string cmdText = @"SELECT * FROM Roles where id=1";
                        using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {

                                if (emailBox.Text.ToLower() == "admin" && passwordBox.Text.ToLower() == "admin")
                                {
                                    //MessageBox.Show("Admin xos geldin");
                                    FrmAdmin frmAdmin = new FrmAdmin();
                                    this.Hide();
                                    frmAdmin.Show();
                                    return;
                                }

                            }
                        }
                    }


                    if (CheckUser(emailBox.Text, passwordBox.Text, out User model))
                    {
                        if (model is not null)
                        {
                            //MessageBox.Show("Ugurla daxil oldun");
                            Account account = new Account(model);
                            FrmAccount frmAccount = new FrmAccount(account);
                            this.Hide();
                            frmAccount.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessage.InvalidProfileOrPassword);
                    }
                }
                else
                {
                    MessageBox.Show(ErrorMessage.PasswordLengthError);
                }
            }
            else
            {
                MessageBox.Show(ErrorMessage.EmptyFields);

            }
        }
        private bool CheckUser(string login, string password, out User model)
        {
            model = null;

            using (SqlConnection connection = new SqlConnection(DB.Database.ConnectionString))
            {
                connection.Open();
                string cmdText = "SELECT * FROM users WHERE Name = @Name";
                using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (password == reader["password"].ToString())
                        {
                            model = new User
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Name"].ToString(),
                                Password = reader["password"].ToString(),
                                Email = reader["email"].ToString()
                            };
                            return true;
                        }
                    }
                }
            }



            return false;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
