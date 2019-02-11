using RestASPNETCORE.Model;
using RestASPNETCORE.Repository.Generic;
using System.Collections.Generic;

namespace RestASPNETCORE.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        List<Person> FindByName(string firstname, string lastname);
    }
}
