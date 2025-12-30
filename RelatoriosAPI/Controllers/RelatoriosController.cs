using Microsoft.AspNetCore.Mvc;
using RelatoriosAPI.Models;
using RelatoriosAPI.Services;

namespace RelatoriosAPI.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatoriosController : ControllerBase
    {
        private readonly PessoasService _pessoasService;

        public RelatoriosController(PessoasService pessoasService)
        {
            _pessoasService = pessoasService;
        }

        [HttpGet("pessoas")]
        public async Task<IActionResult> GetPessoas()
        {
            List<Pessoa> pessoas = await _pessoasService.ObterPessoasAsync();

            return Ok(pessoas);
        }
    }
}
