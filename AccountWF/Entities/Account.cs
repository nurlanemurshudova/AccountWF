namespace AccountWF.Entities
{
    public class Account
    {
        public User Profile { get; set; }
        public Account(User user)
        {
            Profile = user;
        }
    }
}
