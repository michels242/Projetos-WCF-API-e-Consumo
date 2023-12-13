using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triangulo.modelo
{
    public class Controle
    {
        public String mensagem;

        public String executar(String baseT, String altura)
        {
            this.mensagem = "";

            Validacao validacao = new Validacao();
            validacao.validar(baseT, altura);

            if (validacao.mensagem.Equals(""))
            {
                Triangulo triangulo = new Triangulo();
                this.mensagem = triangulo.calculo(validacao.baseTConvertido, validacao.alturaConvertido);
            }
            else
            {
                this.mensagem = validacao.validar(baseT, altura);
            }

            return mensagem;
        }
    }
}