using AccountWF.DataAccess.Abstract;
using AccountWF.DataAccess.SqlDbContext;
using AccountWF.Entities;
using System.Data.SqlClient;

namespace AccountWF.DataAccess.Concrete
{
    public class UserRepository : IBaseOperation<User>
    {
        private readonly string _connection;
        public UserRepository()
        {
            _connection = DB.Database.ConnectionString;
        }

        public void Add(User entity)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string cmdText = @"Insert into Users (Name,Password,Email,RoleId)
                values (@name,@password,@email,@roleId)";

                using (SqlCommand cmd = new SqlCommand(cmdText, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@password", entity.Password);
                    cmd.Parameters.AddWithValue("@email", entity.Email);
                    cmd.Parameters.AddWithValue("@roleId", entity.RoleId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string cmdText = @"Update Users set Deleted=@id where id=@id";

                using (SqlCommand cmd = new SqlCommand(cmdText, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<User> GetAll()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string cmdText = @"Select * from Users where Deleted=0";

                using (SqlCommand cmd = new SqlCommand(cmdText, sqlConnection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<User> studentList = new();

                    while (reader.Read())
                    {
                        User student = new()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = Convert.ToString(reader["Name"]),
                            Password = Convert.ToString(reader["Password"]),
                            Email = Convert.ToString(reader["Email"]),
                        };
                        studentList.Add(student);
                    }
                    return studentList;
                }
            }
        }

        public User GetById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string cmdText = @"Select * from Users where id=@id";

                using (SqlCommand cmd = new SqlCommand(cmdText, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    User user = new ();

                    if (reader.Read())
                    {
                        user.Id = Convert.ToInt32(reader["Id"]);
                        user.Name = Convert.ToString(reader["Name"]);
                        user.Password = Convert.ToString(reader["Password"]);
                        user.Email = Convert.ToString(reader["Email"]);
                    }
                    return user;
                }
            }
        }

        public void Update(User entity)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string cmdText = @"Update Users set Name=@Name,
                                    Password=@Password,Email= @Email where Id=@Id";

                using (SqlCommand cmd = new SqlCommand(cmdText, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@Password", entity.Password);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
