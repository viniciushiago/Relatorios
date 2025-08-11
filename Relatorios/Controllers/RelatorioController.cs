using Aplicacao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Relatorios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly IRelatorioService _service;

        public RelatorioController(IRelatorioService service)
        {
            _service = service;
        }

        [HttpGet("resumo")]
        public async Task<IActionResult> GetResumo([FromQuery] DateTime? inicio, [FromQuery] DateTime? fim)
        {
            var resumo = await _service.ObterResumoAsync(inicio, fim);
            return Ok(resumo);
        }

        [HttpGet("por-categoria")]
        public async Task<IActionResult> GetResumoPorCategoria([FromQuery] DateTime? inicio, [FromQuery] DateTime? fim)
        {
            var resumo = await _service.ObterPorCategoriaAsync(inicio, fim);
            return Ok(resumo);
        }
    }
}
