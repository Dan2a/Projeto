using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using Projeto.Models.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class authController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public authController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<authController>
        [HttpGet]
        public bool Get(LoginDto login)
        {
            var user = _context.Colaboradores.FirstOrDefault(c => c.Email == login.Email);
            if (user is not null)
                return user.Senha == login.Senha;
            return false;
        }

    }
}
