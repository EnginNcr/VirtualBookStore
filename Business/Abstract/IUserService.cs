using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);

        bool CheckLogin(string userName ,string password);
        bool IsExist(string userName, string password);





    }
}
