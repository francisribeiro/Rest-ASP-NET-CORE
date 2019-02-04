using RestASPNETCORE.Model;
using RestASPNETCORE.Repository;
using System.Collections.Generic;

namespace RestASPNETCORE.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long Id)
        {
            return _repository.FindById(Id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
