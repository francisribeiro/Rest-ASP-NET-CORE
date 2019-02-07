using RestASPNETCORE.Data.Converter;
using RestASPNETCORE.Data.VO;
using RestASPNETCORE.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestASPNETCORE.Data.Converters
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;

            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;

            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public List<Book> ParseList(List<BookVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> ParseList(List<Book> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
