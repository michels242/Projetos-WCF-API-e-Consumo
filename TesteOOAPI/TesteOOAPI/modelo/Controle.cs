namespace TesteOOAPI.modelo
{
    public class Controle
    {
        public String mensagem = "";

        public String executar(String v1, String v2)
        {
            Validacao validacao = new Validacao();
            validacao.validar(v1, v2);

            if (validacao.mensagem.Equals(""))
            {
                Calculo calculo = new Calculo();
                this.mensagem = calculo.somar(validacao.valor1, validacao.valor2);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

            return mensagem;
        }
    }
}
