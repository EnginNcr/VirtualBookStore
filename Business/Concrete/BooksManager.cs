using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BooksManager : IBooksService
    {
        private IBooksDal _booksDal;
        public BooksManager(IBooksDal booksDal)
        {
            _booksDal = booksDal;
        }

        public void Add(Books books)
        {
           _booksDal.Add(books);
        }

        public void Delete(Books books)
        {
            _booksDal.Delete(books);
        }

        public List<Books> GetAll()
        {
            return _booksDal.GetAll();

        }

        public List<Books> GetBooksByAuthorId(int authorId)
        {
            return _booksDal.GetAll(p => p.AuthorId == authorId);

        }

        public List<Books> GetBooksByBookName(string bookName)
        {
            return _booksDal.GetAll(p => p.BookName.ToLower().Contains(bookName.ToLower()));



        }

        public List<Books> GetBooksByBookTypesId(int bookTypesId)
        {
            return _booksDal.GetAll(p => p.BookTypeId == bookTypesId);
        }

        public void Update(Books books)
        {
           _booksDal.Update(books);
        }


    }
}
