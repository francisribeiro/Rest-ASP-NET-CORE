using RestASPNETCORE.Data.Converter;
using RestASPNETCORE.Data.VO;
using RestASPNETCORE.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestASPNETCORE.Data.Converters
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return null;

            return new Person
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return null;

            return new PersonVO
            {
                Id = origin.Id,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public List<Person> ParseList(List<PersonVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PersonVO> ParseList(List<Person> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
