using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager()
        {
        }

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public bool CheckLogin(string userName, string password)
        {
            var result = _userDal.GetAll(p => p.UserName == userName && p.UserPassword == password);
            if (result.Count>0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public bool IsExist(string userName, string password)
        {
            return _userDal.IsExist(p => p.UserName == userName && p.UserPassword == password);

        }

        
    }
}
