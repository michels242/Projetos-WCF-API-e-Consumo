using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Media.modelo
{
    public class Calculo
    {
        public String mensagem;
        public String calcular(Double n1, Double n2) 
        {
            Double calc = (n1 + n2) / 2;
            mensagem = calc.ToString();

            return mensagem;
        }
    }
}