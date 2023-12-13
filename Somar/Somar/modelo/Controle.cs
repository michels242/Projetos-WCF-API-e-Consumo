using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Somar.modelo
{
    public class Controle
    {
        public String mensagem;

        public String executar(String v1, String v2) 
        {
            this.mensagem = "";

            Validacao validacao = new Validacao();
            validacao.validar(v1, v2);

            if (validacao.mensagem.Equals(""))
            { 
                Calculadora calculadora = new Calculadora();
                this.mensagem = calculadora.somar(validacao.valor1, validacao.valor2);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

            return mensagem;   
        }
    }
}