using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triangulo.modelo
{
    public class Triangulo
    {
        public String mensagem;

        public String calculo(double baseT, double altura) 
        {
            double calc = (baseT * altura) / 2;
            this.mensagem = calc.ToString();

            return this.mensagem;
        }
    }
}