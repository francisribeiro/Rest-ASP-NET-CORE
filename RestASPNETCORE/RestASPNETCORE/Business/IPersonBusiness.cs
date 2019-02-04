using RestASPNETCORE.Model;
using System.Collections.Generic;

namespace RestASPNETCORE.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);
    }
}
