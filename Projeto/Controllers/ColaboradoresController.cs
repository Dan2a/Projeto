using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.Models;
using Projeto.Models.Dtos;


namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ColaboradoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ColaboradoresController>
        [HttpGet]
        public IEnumerable<UserListDto> GetCadastro()
        {
            var users = _context.Colaboradores.Include(s => s.Setor).ToList();
            var usersToReturn = new List<UserListDto>();
            foreach (var user in users)
            {
                var userListDto = new UserListDto
                {
                    Id = user.Id,
                    Nome = user.Nome,
                    Sobrenome = user.Sobrenome,
                    Telefone = user.Telefone,
                    Ramal = user.Ramal,
                    Email = user.Email,
                };
                usersToReturn.Add(userListDto);
            }
            return usersToReturn;
        }
        // POST api/<ColaboradoresController>
        [HttpPost]
        public async Task<IActionResult> PostCadastro(Colaboradores colaborador)
        {
            if (colaborador == null)
                return BadRequest();

            _context.Colaboradores.Add(colaborador);
            return Ok(_context.SaveChanges());
        }

        // GET api/<ColaboradoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
