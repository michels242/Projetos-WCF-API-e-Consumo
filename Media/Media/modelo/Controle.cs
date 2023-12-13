using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Media.modelo
{
    public class Controle
    {
        public String mensagem;
        public String executar(String n1, String n2) 
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.validar(n1, n2);
            if(validacao.mensagem.Equals("")) 
            {
                Calculo calculo = new Calculo();
                this.mensagem = calculo.calcular(validacao.nota1, validacao.nota2);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

            return mensagem;
        }
    }
}