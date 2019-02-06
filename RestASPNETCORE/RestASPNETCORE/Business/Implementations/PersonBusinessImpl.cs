﻿using RestASPNETCORE.Model;
using RestASPNETCORE.Repository.Generic;
using System.Collections.Generic;

namespace RestASPNETCORE.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IRepository<Person> _repository;

        public PersonBusinessImpl(IRepository<Person> repository)
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
