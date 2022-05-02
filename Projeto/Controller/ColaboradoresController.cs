using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projeto.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradoresController : ControllerBase
    {
        private readonly ApplicationDbContext
        // GET: api/<ColaboradoresController>
        [HttpGet]
        public IEnumerable<UserListDo> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ColaboradoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ColaboradoresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ColaboradoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ColaboradoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
