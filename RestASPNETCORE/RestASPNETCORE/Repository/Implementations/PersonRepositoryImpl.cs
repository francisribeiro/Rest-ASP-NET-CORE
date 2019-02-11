using RestASPNETCORE.Model;
using RestASPNETCORE.Model.Context;
using RestASPNETCORE.Repository.Generic;
using System.Collections.Generic;
using System.Linq;

namespace RestASPNETCORE.Repository.Implementations
{
    public class PersonRepositoryImpl : GenericRepository<Person>, IPersonRepository
    {

        public PersonRepositoryImpl(MySQLContext context) : base(context) { }

        public List<Person> FindByName(string firstname, string lastname)
        {
            if (!string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(lastname))
                return _context.Persons.Where(p => p.FirstName.Contains(firstname) && p.LastName.Contains(lastname)).ToList();
            else if (string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(lastname))
                return _context.Persons.Where(p => p.LastName.Equals(lastname)).ToList();
            else if (!string.IsNullOrEmpty(firstname) && string.IsNullOrEmpty(lastname))
                return _context.Persons.Where(p => p.FirstName.Equals(firstname)).ToList();
            else
                return _context.Persons.ToList();
        }
    }
}
