using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBooksService
    {
        List<Books> GetAll();
        List<Books> GetBooksByBookName(string bookName);
        List<Books> GetBooksByAuthorId(int authorId);

        List<Books> GetBooksByBookTypesId(int bookTypesId);
        void Add(Books books);
        void Update(Books books);
        void Delete(Books books);

    }
}
