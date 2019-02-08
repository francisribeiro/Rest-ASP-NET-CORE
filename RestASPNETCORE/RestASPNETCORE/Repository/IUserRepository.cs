using RestASPNETCORE.Model;

namespace RestASPNETCORE.Repository
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
    }
}
