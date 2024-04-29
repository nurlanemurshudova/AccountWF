using AccountWF.Constant;
using AccountWF.DataAccess.Concrete;
using AccountWF.DataAccess.SqlDbContext;
using AccountWF.Entities;
using System.Data.SqlClient;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AccountWF
{
    public partial class FrmAdmin : Form
    {
        private UserRepository userRepository = new();
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

            var userList = userRepository.GetAll();
            int i = 0;
            dtTable.Rows.Clear();
            if (dtTable.Rows.Count < userList.Count)
                dtTable.Rows.Add(userList.Count - dtTable.Rows.Count);
            foreach (var item in userList)
            {
                dtTable.Rows[i].Cells[0].Value = item.Id;
                dtTable.Rows[i].Cells[1].Value = item.Name;
                dtTable.Rows[i].Cells[2].Value = item.Email;
                dtTable.Rows[i].Cells[3].Value = item.Password;
                i++;
            }
        }


        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDeleteUser.Text, out int userId))
            {
                if (!string.IsNullOrEmpty(txtDeleteUser.Text))
                {
                    var userToDelete = userRepository.GetById(userId).Id;

                    if (userToDelete != 0)
                    {
                        userRepository.Delete(userId);
                        MessageBox.Show(ErrorMessage.DeletedUser);
                        FillTable();
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessage.UserNotFound);
                    }
                }
                else
                {
                    MessageBox.Show(ErrorMessage.EnterOnlyUserId);
                }
            }
            else
            {
                MessageBox.Show(ErrorMessage.EnterOnlyUserId);
            }
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


                        try
                        {
                            userRepository.Add(newUser);
                            MessageBox.Show(ErrorMessage.SuccessAddUser);
                            FillTable();
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

                if (int.TryParse(dtTable.Rows[index].Cells[0].Value.ToString(), out int id))
                {
                    if (passwordBox.Text == repeatPasswordBox.Text)
                    {
                        User newUser = new User
                        {
                            Id = id,
                            Name = nameBox.Text,
                            Email = emailBox.Text,
                            Password = passwordBox.Text
                        };
                        userRepository.Update(newUser);
                        dtTable.Rows[index].Cells[1].Value = newUser.Name;
                        dtTable.Rows[index].Cells[2].Value = newUser.Email;
                        dtTable.Rows[index].Cells[3].Value = newUser.Password;
                        MessageBox.Show(ErrorMessage.SuccessUpdateUser);
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessage.CheckUserData);
                    }
                }

            }
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
