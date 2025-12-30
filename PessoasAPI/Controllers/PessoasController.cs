using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PessoasAPI.Models;

namespace PessoasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() //Qual tipo de retorno eu coloco? Não seria List<Pessoa> o tipo de retorno?
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa { Id = 1, Nome = "Aya" },
                new Pessoa { Id = 2, Nome = "Tanjiro" }
            };

            return Ok(pessoas);
        }
    }
}
