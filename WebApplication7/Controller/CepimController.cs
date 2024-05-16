using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication7.Interfaces;
using WebApplication7.Validadores;


namespace WebApplication7.controller
{
    [ApiController]
    [Route("/[controller]")]
    public class CepimController : ControllerBase
    {
        private readonly ICepimService _iCepimService;

        public CepimController(ICepimService icepimService)
        {
            _iCepimService = icepimService;
        }

        [HttpGet("busca/{CNPJ}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCepimporCNPJ([FromRoute] string CNPJ)
        {

            bool isValid = CnpjValidador.IsValid(CNPJ);
            if (isValid)
            {
                var response = await _iCepimService.BuscarPorCNPJ(CNPJ);
                if (response.CodigoHttp == HttpStatusCode.OK)
                {
                    return Ok(response.DadosRetorno);
                }

                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
                
            }
            return BadRequest("cnpj invalido");
        }
    }
}    
