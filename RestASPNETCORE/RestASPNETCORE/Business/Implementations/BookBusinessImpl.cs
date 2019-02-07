using RestASPNETCORE.Data.Converters;
using RestASPNETCORE.Data.VO;
using RestASPNETCORE.Model;
using RestASPNETCORE.Repository.Generic;
using System.Collections.Generic;

namespace RestASPNETCORE.Business.Implementations
{
    public class BookBusinessImpl : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImpl(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            var bookVO = _repository.Create(bookEntity);

            return _converter.Parse(bookVO);
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<BookVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public BookVO FindById(long Id)
        {
            return _converter.Parse(_repository.FindById(Id));
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            var bookVO = _repository.Update(bookEntity);

            return _converter.Parse(bookVO);
        }
    }
}
