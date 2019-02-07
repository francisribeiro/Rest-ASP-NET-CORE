using Microsoft.AspNetCore.Mvc;
using RestASPNETCORE.Business;
using RestASPNETCORE.Data.VO;
using Tapioca.HATEOAS;

namespace RestASPNETCORE.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonBusiness _personBusiness;

        public PersonsController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        // GET api/values
        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Get(int id)
        {
            var person = _personBusiness.FindById(id);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        // POST api/values
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Post([FromBody] PersonVO person)
        {
            if (person == null)
                return BadRequest();

            return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT api/values/5
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Put([FromBody]PersonVO person)
        {
            if (person == null)
                return BadRequest();

            var updatePerson = _personBusiness.Update(person);

            if (updatePerson == null)
                return NoContent();

            return new ObjectResult(_personBusiness.Update(person));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Delete(int id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
