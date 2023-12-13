using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Media.modelo
{
    public class Validacao
    {
        public Double nota1;
        public Double nota2;
        public String mensagem;

        public String validar(String n1, String n2)
        {
            this.mensagem = "";
            try
            {
                    this.nota1 = Double.Parse(n1);
                    this.nota2 = Double.Parse(n2);
            }
            catch (Exception ex)
            {
                this.mensagem = "Nota Invalida!";
            }

            return mensagem;
        }
    }
}