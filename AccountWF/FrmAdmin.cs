using AccountWF.Models;
using System.Security.Principal;

namespace AccountWF
{
    public partial class FrmAdmin : Form
    {
        int index;
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            FillTable();
        }
        private void FillTable()
        {

            var data = DB.Database.users;

            int i = 0;
            dtTable.Rows.Clear();
            if (dtTable.Rows.Count < data.Count)
                dtTable.Rows.Add(data.Count - dtTable.Rows.Count);
            foreach (var item in data)
            {
                dtTable.Rows[i].Cells[0].Value = item.ID;
                dtTable.Rows[i].Cells[1].Value = item.Name;
                dtTable.Rows[i].Cells[2].Value = item.Email;
                dtTable.Rows[i].Cells[3].Value = item.Password;
                i++;
            }
        }


        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var data = DB.Database.users.Find(x => x.Name == txtDeleteUser.Text);
            if (data != null)
            {
                DB.Database.users.Remove(data);
                FillTable();
                MessageBox.Show("Silindi");
                return;
            }
            MessageBox.Show("İstifadəçi tapılmadı!!");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (
               nameBox.Text != "" &&
               emailBox.Text != "" &&
               passwordBox.Text != "" &&
               repeatPasswordBox.Text != ""
               )
            {
                if (nameBox.Text.Length > 3 && passwordBox.Text.Length > 3)
                {
                    if (passwordBox.Text == repeatPasswordBox.Text)
                    {
                        User newUser = new User();
                        newUser.Name = nameBox.Text;
                        newUser.Email = emailBox.Text;
                        newUser.Password = passwordBox.Text;
                        DB.Database.users.Add(newUser);
                        MessageBox.Show("İstifadəçi əlavə olundu");
                        FillTable();
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

        private void dtTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && index < dtTable.Rows.Count)
            {
                nameBox.Text = dtTable.Rows[index].Cells[1].Value.ToString();
                emailBox.Text = dtTable.Rows[index].Cells[2].Value.ToString();
                passwordBox.Text = dtTable.Rows[index].Cells[3].Value.ToString();
                repeatPasswordBox.Text = dtTable.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (index >= 0 && index < dtTable.Rows.Count)
            {
                dtTable.Rows[index].Cells[1].Value = nameBox.Text;
                dtTable.Rows[index].Cells[2].Value = emailBox.Text;
                dtTable.Rows[index].Cells[3].Value = passwordBox.Text;

                MessageBox.Show("Məlumat yeniləndi");
            }
        }
    }
}
