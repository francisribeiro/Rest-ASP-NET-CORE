using RestASPNETCORE.Model;
using System.Collections.Generic;

namespace RestASPNETCORE.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);
    }
}
