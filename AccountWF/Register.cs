using AccountWF.Constant;
using AccountWF.DataAccess.Concrete;
using AccountWF.DataAccess.SqlDbContext;
using AccountWF.Entities;
using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;
using System.Reflection;

namespace AccountWF
{
    public partial class Register : Form
    {
        private UserRepository userRepository = new();

        public Register()
        {
            InitializeComponent();
        }

        private void exitLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (
               nameBox.Text != "" &&
               emailBox.Text != "" &&
               passwordBox.Text != "" &&
               repeatPasswordBox.Text != ""
               )
            {
                if (passwordBox.Text.Length > 3 && repeatPasswordBox.Text.Length > 3)
                {
                    if (passwordBox.Text == repeatPasswordBox.Text)
                    {
                        User newUser = new User();
                        newUser.Name = nameBox.Text;
                        newUser.Email = emailBox.Text;
                        newUser.Password = passwordBox.Text;
                        

                        try
                        {
                            userRepository.Add(newUser);
                            MessageBox.Show(ErrorMessage.SuccessSignUp);
                            this.Hide();
                            signInButton_Click(null, null);
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2601 || ex.Number == 2627) // Unique constraint violation
                            {
                                MessageBox.Show(ErrorMessage.CheckDuplicateEmail);
                            }
                            else
                            {
                                MessageBox.Show(ErrorMessage.ExceptionMessage);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessage.PasswordMismatch);
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
