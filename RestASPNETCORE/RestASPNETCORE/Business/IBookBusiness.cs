using RestASPNETCORE.Data.VO;
using System.Collections.Generic;

namespace RestASPNETCORE.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long Id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long Id);
    }
}
