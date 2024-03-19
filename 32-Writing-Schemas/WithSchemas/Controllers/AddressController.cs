using Microsoft.AspNetCore.Mvc;
using WithSchemas.Models;
using System.Collections.Generic;

namespace WithSchemas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private static List<Address> _addresses = new List<Address>
        {
            new Address { Street = "123 Main St", City = "Anytown", State = "NY", Zip = "12345" },
            new Address { Street = "456 Elm St", City = "Othertown", State = "CA", Zip = "67890" }
        };

        [HttpGet]
        public ActionResult<List<Address>> Get()
        {
            return _addresses;
        }

        [HttpGet("{id}")]
        public ActionResult<Address> Get(int id)
        {
            return _addresses[id];
        }

        [HttpPost]
        public ActionResult<Address> Post(Address address)
        {
            _addresses.Add(address);
            return address;
        }

        [HttpPut("{id}")]
        public ActionResult<Address> Put(int id, Address address)
        {
            _addresses[id] = address;
            return address;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _addresses.RemoveAt(id);
            return Ok();
        }
    }
}