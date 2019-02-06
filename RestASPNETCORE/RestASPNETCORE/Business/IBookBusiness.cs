using RestASPNETCORE.Model;
using System.Collections.Generic;

namespace RestASPNETCORE.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindById(long Id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long Id);
    }
}
