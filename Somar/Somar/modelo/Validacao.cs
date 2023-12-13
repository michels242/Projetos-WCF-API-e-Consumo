using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Somar.modelo
{
    public class Validacao
    {
        public double valor1; 
        public double valor2;
        public String mensagem;

        public void validar(String v1, String v2) 
        {
            this.mensagem = "";
            try
            {
                this.valor1 = Double.Parse(v1);
                this.valor2 = Double.Parse(v2);
            }
            catch (Exception ex)
            {
                this.mensagem = "Valor Invalido!";
            }
        }
    }
}