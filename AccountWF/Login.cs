using AccountWF.Models;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using Account = AccountWF.Models.Account;

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
                    if (CheckUser(emailBox.Text, passwordBox.Text,out User model))
                    {
                        
                            /*FrmAdmin frmAdmin = new FrmAdmin();
                            frmAdmin.Show();
                            this.Hide();*/

                        if(emailBox.Text == "admin")
                        {
                            FrmAdmin frmAdmin = new FrmAdmin();
                            this.Hide();
                            frmAdmin.Show();
                        }
                        else
                        {
                            if(model is not null)
                            {
                                Account account = new Account(model);
                                FrmAccount frmAccount = new FrmAccount(account);
                                this.Hide();
                                frmAccount.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Səhv Profil adı və ya Parol daxil etmisiniz!!");
                    }
                }
                else
                {
                    MessageBox.Show("Parol 3 simvoldan az olmamalıdır");
                }
            }
            else
            {
                MessageBox.Show("Xanalar doldurulmalıdır!!");

            }
        }
        private bool CheckUser(string login, string password,out User model)
        {
            foreach (User user in DB.Database.users)
            {
                
                if (login == user.Name && password == user.Password)
                {
                    //this.Hide();
                    //FrmAccount frmAccount = new FrmAccount();
                    //this.Close();
                    MessageBox.Show("Giris ugurludur!");
                    model = user;
                    return true;
                }
            }
            model = new User();
            return false;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
