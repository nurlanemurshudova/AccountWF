using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountWF.Models;

namespace AccountWF
{
    public interface IUserOperation
    {
        bool HasUser(User user, out User outUser);
    }
}
