using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountWF.Models;

namespace AccountWF
{
    public class UserManager : IBaseOperation<User>, IUserOperation
    {
        public bool Add(User entity)
        {
            if (entity == null)
                return false;

            DB.Database.users.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var deletedEntity = DB.Database.users.Find(x => x.ID == id);
            if (deletedEntity == null)
                return false;

            DB.Database.users.Remove(deletedEntity);
            return true;
        }

        public List<User> GetAll()
        {
            var allUsers = DB.Database.users;
            return allUsers;
        }

        public User GetById(int id)
        {
            var foundEntity = DB.Database.users.Find(x => x.ID == id);
            return foundEntity;
        }

        public bool HasUser(User user,out User outUser)
        {
            var isUser = DB.Database.users
                .Find(
                x => x.Name == user.Name && 
                x.Password == user.Password
                );
            outUser = isUser;
            if (isUser == null)
                return false;

            return true;
        }

        public bool Update(User entity)
        {
            var oldEntity = DB.Database.users.Find(x => x.ID == entity.ID);

            if (oldEntity == null)
                return false;

            oldEntity.Name = entity.Name;
            oldEntity.Email = entity.Email;
            oldEntity.Password = entity.Password;
            return true;
        }
    }
}
