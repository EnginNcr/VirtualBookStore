using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminManager : IAdminService 
    {
        private IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public bool IsAdmin(string userName, string password)
        {
            return _adminDal.IsExist(p => p.AdminName == userName && p.AdminPassword.Equals(password));

        }
    }
}
