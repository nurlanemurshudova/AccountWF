using AccountWF.Entities;

namespace AccountWF.DataAccess.Abstract
{
    public interface IUserOperation
    {
        bool HasUser(User user, out User outUser);
    }
}
