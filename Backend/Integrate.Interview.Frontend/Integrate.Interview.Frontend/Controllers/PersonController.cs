using System.Collections.Generic;
using System.Linq;
using Integrate.Interview.Frontend.Database;
using Integrate.Interview.Frontend.Database.Models;
using Integrate.Interview.Frontend.Mappers;
using Integrate.Interview.Frontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrate.Interview.Frontend.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("person")]
    public class PersonController : ControllerBase
    {
        private readonly PersonContext _db;
        private readonly IToDbMapper<ApiPerson, Person> _toPersonMapper;

        public PersonController(PersonContext db, IToDbMapper<ApiPerson, Person> toPersonMapper)
        {
            _db = db;
            _toPersonMapper = toPersonMapper;
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a person.",
            OperationId = "PostPerson",
            Tags = new[] {"Person"}
        )]
        [SwaggerResponse(StatusCodes.Status201Created, "The person was successfully created.", typeof(ApiPerson))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "The person can not be created.")]
        public IActionResult Create([FromBody] ApiPerson personToCreate)
        {
            try
            {
                var person = _db.People.Add(_toPersonMapper.Map(personToCreate));
                _db.SaveChanges();
                return StatusCode(201, person.Entity);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id:int}")]
        [SwaggerOperation(
            Summary = "Gets a person by ID",
            OperationId = "GetPersonById",
            Tags = new[] {"Person"}
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The person is found and returned.", typeof(ApiPerson))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "The person was not found.")]
        public IActionResult Get(int id)
        {
            var person = _db.People.FirstOrDefault(p => p.Id == id);
            return person != null ? Ok(person) : NotFound();
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Gets all people.",
            OperationId = "GetPeople",
            Tags = new[] {"Person"}
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "An array of all people.", typeof(IEnumerable<ApiPerson>))]
        public IActionResult GetList()
        {
            return Ok(_db.People.ToList());
        }

        [HttpDelete("{id:int}")]
        [SwaggerOperation(
            Summary = "Deletes a person by ID",
            OperationId = "DeletePersonById",
            Tags = new[] {"Person"}
        )]
        [SwaggerResponse(StatusCodes.Status204NoContent, "The person was deleted.")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "The person was not found.")]
        public IActionResult Delete(int id)
        {
            var person = _db.People.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            _db.People.Remove(person);
            _db.SaveChanges();
            return NoContent();
        }
    }
}