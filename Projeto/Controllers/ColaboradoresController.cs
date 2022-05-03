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

        // PUT api/<ColaboradoresController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Colaboradores colabToUpdate)
        {
            var colabPutDb = _context.Colaboradores.FirstOrDefault(c => c.Id == id);
            if (colabPutDb == null)
                return NotFound();
            colabPutDb.Nome = colabToUpdate.Nome;
            colabPutDb.Sobrenome = colabToUpdate.Sobrenome;
            colabPutDb.Senha = colabToUpdate.Senha;
            colabPutDb.Telefone = colabToUpdate.Telefone;
            colabPutDb.Ramal = colabToUpdate.Ramal; 
            colabPutDb.Email = colabToUpdate.Email;
            colabPutDb.Setor = colabToUpdate.Setor;
            _context.Colaboradores.Update(colabPutDb);
            return Ok(_context.SaveChanges());
        }

        // DELETE api/<ColaboradoresController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var colabFromDb = _context.Colaboradores.FirstOrDefault(c => c.Id == id);
            if (colabFromDb == null)
                return NotFound();
            _context.Colaboradores.Remove(colabFromDb);
            return Ok(_context.SaveChanges());

        }
    }
}
