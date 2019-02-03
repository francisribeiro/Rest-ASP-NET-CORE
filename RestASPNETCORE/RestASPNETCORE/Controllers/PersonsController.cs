﻿using Microsoft.AspNetCore.Mvc;
using RestASPNETCORE.Model;
using RestASPNETCORE.Services;
using System.Collections.Generic;

namespace RestASPNETCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_personService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var person = _personService.FindById(id);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return new ObjectResult(_personService.Create(person));
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public ActionResult Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public ActionResult Delete(int id)
        //{
        //}
    }
}