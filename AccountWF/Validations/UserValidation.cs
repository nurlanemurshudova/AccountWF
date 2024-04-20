using AccountWF.Models;

namespace AccountWF.Validations
{
    public class UserValidation
    {
        
        public bool MinLength(string name)
        {
            if(name.Length <= 3)
            {
                return false;
            }
            return true;
        }
        public bool HasName(User user)
        {
            var checkName = DB.Database.users.Find(x => x.Name == user.Name);
            if (checkName != null)
            {
                return true ;
            }
            return false;
        }
        public bool CheckPassword(string password , string repPassword)
        {
            if(password == repPassword)
            {
                return true ;
            }
            return false;
        }
        public bool IsEmail(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            return false;
        }
    }
}
