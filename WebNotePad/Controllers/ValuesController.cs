using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebNotePad.Infrastructure;

namespace WebNotePad.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        Context context = new Context();

         
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            context.Add(new Note() { DateCreated = DateTime.Now, Message = "Example First", Title = "Example Note Pad 1" });
            context.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
