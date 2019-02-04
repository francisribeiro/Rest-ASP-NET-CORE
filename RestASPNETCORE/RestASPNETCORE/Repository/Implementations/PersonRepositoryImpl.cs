using RestASPNETCORE.Model;
using RestASPNETCORE.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestASPNETCORE.Repository.Implementations
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        private MySQLContext _context;

        public PersonRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return person;
        }

        public void Delete(long Id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(Id));

            try
            {
                if (result != null)
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long Id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(Id));
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id))
                return null;

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return person;
        }

        public bool Exists(long? id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
