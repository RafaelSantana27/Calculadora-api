using Calculadora_api.Services;
using Calculadora_api.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly CalculadoraService _calculadoraService;

        public CalculadoraController(CalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }


        [HttpGet("soma/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Somar(string primeiroNumero, string segundoNumero)
        {
            if (HelperNumero.EhNumero(primeiroNumero) && HelperNumero.EhNumero(segundoNumero))
            {
               var soma = _calculadoraService.Somar(
                   HelperNumero.ConverterParaDecimal(primeiroNumero), HelperNumero.ConverterParaDecimal(segundoNumero));

                return Ok(soma.ToString());
            }
            return BadRequest("Entrada inválida. Certifique-se de fornecer números válidos.");
        }

        [HttpGet("subtrair/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Subtrair(string primeiroNumero, string segundoNumero)
        {
            if (HelperNumero.EhNumero(primeiroNumero) && HelperNumero.EhNumero(segundoNumero))
            {
                var subtracao = _calculadoraService.Subtrair(
                    HelperNumero.ConverterParaDecimal(primeiroNumero), HelperNumero.ConverterParaDecimal(segundoNumero));

                return Ok(subtracao.ToString());
            }
            return BadRequest("Entrada inválida. Certifique-se de fornecer números válidos.");
        }

        [HttpGet("multiplicar/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Multiplicar(string primeiroNumero, string segundoNumero)
        {
            if (HelperNumero.EhNumero(primeiroNumero) && HelperNumero.EhNumero(segundoNumero))
            {
                var multiplicacao = _calculadoraService.Multiplicar(
                    HelperNumero.ConverterParaDecimal(primeiroNumero), HelperNumero.ConverterParaDecimal(segundoNumero));

                return Ok(multiplicacao.ToString());
            }
            return BadRequest("Entrada inválida. Certifique-se de fornecer números válidos.");
        }

        [HttpGet("dividir/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Dividir(string primeiroNumero, string segundoNumero)
        {
            if (HelperNumero.EhNumero(primeiroNumero) && HelperNumero.EhNumero(segundoNumero))
            {
                var divisao = _calculadoraService.Dividir(
                    HelperNumero.ConverterParaDecimal(primeiroNumero), HelperNumero.ConverterParaDecimal(segundoNumero));

                return Ok(divisao.ToString());
            }
            return BadRequest("Entrada inválida. Certifique-se de fornecer números válidos.");
        }

        [HttpGet("media/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Media(string primeiroNumero, string segundoNumero)
        {
            if (HelperNumero.EhNumero(primeiroNumero) && HelperNumero.EhNumero(segundoNumero))
            {
                var media = _calculadoraService.Media(
                    HelperNumero.ConverterParaDecimal(primeiroNumero), HelperNumero.ConverterParaDecimal(segundoNumero));

                return Ok(media.ToString());
            }
            return BadRequest("Entrada inválida. Certifique-se de fornecer números válidos.");
        }
    }
}
