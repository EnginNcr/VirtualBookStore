using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookTypesManager : IBookTypesService
    {
        private IBookTypesDal _bookTypesDal;
        public BookTypesManager(IBookTypesDal bookTypesDal)
        {
            _bookTypesDal = bookTypesDal;
        }

        public List<BookTypes> GetAll()
        {
            return _bookTypesDal.GetAll();
        }

       
    }
}
