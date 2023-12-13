using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controle : ControllerBase
    {
        Validacao validacao = new Validacao();
        Calculadora calculadora = new Calculadora();
        public String mensagem = "";

        [HttpGet("Somar")]

        public String somar(String v1, String v2)
        {
            validacao.validar(v1, v2);

            if(validacao.mensagem.Equals("")) 
            {
                this.mensagem = calculadora.somar(validacao.valor1, validacao.valor2);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

            return mensagem;
        }

        [HttpGet("Subtrair")]

        public String subtrair(String v1, String v2)
        {
            validacao.validar(v1, v2);

            if (validacao.mensagem.Equals(""))
            {
                this.mensagem = calculadora.subtrair(validacao.valor1, validacao.valor2);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

            return mensagem;
        }

        [HttpGet("Multiplicar")]

        public String multiplicar(String v1, String v2)
        {
            validacao.validar(v1, v2);

            if (validacao.mensagem.Equals(""))
            {
                this.mensagem = calculadora.multiplicar(validacao.valor1, validacao.valor2);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

            return mensagem;
        }

        [HttpGet("Dividir")]

        public String divisao(String v1, String v2)
        {
            validacao.validar(v1, v2);

            if (validacao.mensagem.Equals(""))
            {
                this.mensagem = calculadora.divisao(validacao.valor1, validacao.valor2);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

            return mensagem;
        }

    }
}