using Microsoft.AspNetCore.Mvc;
using RestASPNETCORE.Business;
using RestASPNETCORE.Data.VO;
using Tapioca.HATEOAS;

namespace RestASPNETCORE.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookBusiness _bookBusiness;

        public BooksController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        // GET api/values
        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Get(int id)
        {
            var book = _bookBusiness.FindById(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        // POST api/values
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Post([FromBody]BookVO book)
        {
            if (book == null)
                return BadRequest();

            return new ObjectResult(_bookBusiness.Create(book));
        }

        // PUT api/values/5
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Put([FromBody]BookVO book)
        {
            if (book == null)
                return BadRequest();

            var updatebook = _bookBusiness.Update(book);

            if (updatebook == null)
                return NoContent();

            return new ObjectResult(_bookBusiness.Update(book));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public ActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}