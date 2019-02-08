using RestASPNETCORE.Model;

namespace RestASPNETCORE.Business
{
    public interface IUserBusiness
    {
        object FindByLogin(User user);
    }
}
