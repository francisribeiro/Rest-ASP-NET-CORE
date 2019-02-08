using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestASPNETCORE.Business;
using RestASPNETCORE.Model;

namespace RestASPNETCORE.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        // POST api/values
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            if (user == null)
                return BadRequest();

            return _userBusiness.FindByLogin(user);
        }
    }
}