using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication7.Interfaces;
using WebApplication7.Validadores;


namespace WebApplication7.controller
{
    [ApiController]
    [Route("/api-de-dados/[controller]")]
    public class PEPController : ControllerBase
    {
        private readonly IPEPService _ipepService;

        public PEPController(IPEPService ipepService)
        {
            _ipepService = ipepService;
        }

        [HttpGet("busca/{CPF}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarPEPporCpf([FromRoute]string CPF)
        {
           
            bool isValid = CpfValidador.IsValid(CPF);
            if (isValid)
            {
                var response = await _ipepService.BuscarPorCPF(CPF);
                if (response.CodigoHttp == HttpStatusCode.OK)
                {
                    return Ok(response.DadosRetorno);
                }

                return StatusCode((int)response.CodigoHttp,response.ErroRetorno);
            }

            return BadRequest("CPF invalido");
        }
    }
    
}