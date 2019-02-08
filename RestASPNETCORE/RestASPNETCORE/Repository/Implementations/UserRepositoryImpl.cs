using RestASPNETCORE.Model;
using RestASPNETCORE.Model.Context;
using System.Linq;

namespace RestASPNETCORE.Repository.Implementations
{
    public class UserRepositoryImpl : IUserRepository
    {
        private MySQLContext _context;

        public UserRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(u => u.Login.Equals(login));
        }
    }
}
