using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Somar.modelo
{
    public class Calculadora
    {
        public String somar(double v1, double v2) 
        {
            String resposta = "";
            double calc = v1 + v2;
            resposta = calc.ToString();

            return resposta;
        }
    }
}