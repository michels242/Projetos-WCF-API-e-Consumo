using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triangulo.modelo
{
    public class Validacao
    {
        public double baseTConvertido;
        public double alturaConvertido;
        public String mensagem;

        public String validar(String baseT, String altura) 
        {
            this.mensagem = "";
            try
            {
                this.baseTConvertido = double.Parse(baseT);
                this.alturaConvertido = double.Parse(altura);
            }
            catch 
            {
                this.mensagem = "Erro!";
            }

            return mensagem;
        }
    }
}