using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return "Teste";
        }

    }

}