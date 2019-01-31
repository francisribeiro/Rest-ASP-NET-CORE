using RestASPNETCORE.Model;
using System.Collections.Generic;
using System.Threading;

namespace RestASPNETCORE.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        public Person FindById(long Id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Francis",
                LastName = "Ribeiro",
                Address = "São Paulo - São Paulo, Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Firstname " + i,
                LastName = "Person Lastname " + i,
                Address = "Some Address " + i,
                Gender = "Male " + i
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
