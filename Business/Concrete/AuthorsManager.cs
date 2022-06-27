using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorsManager : IAuthorsService
    {
        private IAuthorsDal _authorsDal;
        public AuthorsManager(IAuthorsDal authorsDal)
        {
            _authorsDal = authorsDal;
        }

        public List<Authors> GetAll()
        {
            return _authorsDal.GetAll();    
        }
    }
}
