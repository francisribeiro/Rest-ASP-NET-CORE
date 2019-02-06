using RestASPNETCORE.Model;
using RestASPNETCORE.Repository.Generic;
using System.Collections.Generic;

namespace RestASPNETCORE.Business.Implementations
{
    public class BookBusinessImpl : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        public BookBusinessImpl(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long Id)
        {
            return _repository.FindById(Id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}
