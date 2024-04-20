using AccountWF.Models;

namespace AccountWF
{
    public partial class Register : Form
    {
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
                        DB.Database.users.Add(newUser);
                        MessageBox.Show("Qeydiyyat tamamlandı");
                        this.Hide();
                        signInButton_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Təkrar parol əsas parola bərəabər deyil :)");
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
