using Microsoft.AspNetCore.Mvc;

namespace TrianguloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controle : ControllerBase
    {

        public String mensagem = "";

        [HttpGet("calcular")]
        public String executar(String baseT, String altura) 
        {
            Validacao validacao = new Validacao();
            validacao.validar(baseT, altura);
            if (validacao.mensagem.Equals(""))
            {
                Triangulo triangulo = new Triangulo();
                this.mensagem = triangulo.calcular(validacao.baseTConvertido, validacao.alturaConvertida);
            }
            else
            {
                this.mensagem = validacao.validar(baseT, altura);
            }

            return mensagem;
        }
    }
}