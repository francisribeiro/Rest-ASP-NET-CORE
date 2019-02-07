using RestASPNETCORE.Data.Converters;
using RestASPNETCORE.Data.VO;
using RestASPNETCORE.Model;
using RestASPNETCORE.Repository.Generic;
using System.Collections.Generic;

namespace RestASPNETCORE.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            var personVO = _repository.Create(personEntity);

            return _converter.Parse(personVO);
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO FindById(long Id)
        {
            return _converter.Parse(_repository.FindById(Id));
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            var personVO = _repository.Update(personEntity);

            return _converter.Parse(personVO);
        }
    }
}
