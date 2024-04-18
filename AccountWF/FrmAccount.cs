using Profil = AccountWF.Models.Account;

namespace AccountWF
{
    public partial class FrmAccount : Form
    {
        private List<TextBox> boxes = new List<TextBox>();
        private UserManager _manager = new UserManager();
        private Profil _account;
        public FrmAccount(Profil account)
        {
            InitializeComponent();
            _account = account;
        }
        private void FrmAccount_Load(object sender, EventArgs e)
        {
            boxes.Add(nameBox);
            boxes.Add(emailBox);
            boxes.Add(passwordBox);
            TextBoxFill();
        }

        private void FrmAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxFill()
        {
            nameBox.Text = _account.Profile.Name;
            emailBox.Text = _account.Profile.Email;
            passwordBox.Text = _account.Profile.Password;
        }
        private void TextBoxClear()
        {
            foreach (var box in boxes)
            {
                box.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            BoxsEnabled();
        }

        private void BoxsEnabledFalse()
        {
            foreach (var box in boxes)
            {
                box.Enabled = false;
            }
        }

        private void BoxsEnabled()
        {
            foreach (var box in boxes)
            {
                box.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var oldProfile = _account.Profile;
            oldProfile.Name = nameBox.Text;
            oldProfile.Email = emailBox.Text;
            oldProfile.Password = passwordBox.Text;
            _manager.Update(oldProfile);
            BoxsEnabledFalse();
            TextBoxFill();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _account = null;
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
