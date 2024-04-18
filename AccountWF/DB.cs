using AccountWF.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace AccountWF.Models
{
    public class DB
    {
        private static DB _instance;
        public static DB Database
        {
            get
            {
                if(_instance is null)
                    _instance = new DB();
                return _instance;
            }
        }

        private DB()
        {
            
        }
        public List<User> users = new List<User>();
    }
}
