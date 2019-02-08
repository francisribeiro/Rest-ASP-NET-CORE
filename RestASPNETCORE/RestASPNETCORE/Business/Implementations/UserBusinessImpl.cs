using RestASPNETCORE.Model;
using RestASPNETCORE.Repository;
using RestASPNETCORE.Security.Configuration;

namespace RestASPNETCORE.Business.Implementations
{
    public class UserBusinessImpl : IUserBusiness
    {
        private readonly IUserRepository _repository;
        private readonly SigningConfiguration _signingConfigurations;
        private readonly TokenConfiguration _tokenConfiguration;

        public UserBusinessImpl(IUserRepository repository,
            SigningConfiguration signingConfigurations,
            TokenConfiguration tokenConfiguration)
        {
            _signingConfigurations = signingConfigurations;
            _tokenConfiguration = tokenConfiguration;
            _repository = repository;
        }

        public object FindByLogin(User user)
        {
            bool credentialIsValid = false;

            if (user != null && !string.IsNullOrWhiteSpace(user.Login))
            {
                var baseUser = _repository.FindByLogin(user.Login);
                credentialIsValid = (baseUser != null && user.Login == baseUser.Login && user.AccessKey == baseUser.AccessKey);
            }
        }
    }
}
