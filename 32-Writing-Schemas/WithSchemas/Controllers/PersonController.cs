using Microsoft.AspNetCore.Mvc;
using WithSchemas.Models;
using System.Collections.Generic;

namespace WithSchemas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private static List<Person> _people = new List<Person>
        {
            new Person { Name = "John Doe", Age = 30, Address = new Address { Street = "123 Main St", City = "Anytown", State = "NY", Zip = "12345" } },
            new Person { Name = "Jane Doe", Age = 25, Address = new Address { Street = "456 Elm St", City = "Othertown", State = "CA", Zip = "67890" } }
        };

        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return _people;
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return _people[id];
        }

        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            _people.Add(person);
            return person;
        }

        [HttpPut("{id}")]
        public ActionResult<Person> Put(int id, Person person)
        {
            _people[id] = person;
            return person;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _people.RemoveAt(id);
            return Ok();
        }
    }
}