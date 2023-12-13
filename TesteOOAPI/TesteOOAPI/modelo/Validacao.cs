namespace TesteOOAPI.modelo
{
    public class Validacao
    {
        public int valor1;
        public int valor2;
        public String mensagem = "";

        public void validar(String v1, String v2)
        {
            try
            {
                this.valor1 = int.Parse(v1);
                this.valor2 = int.Parse(v2);
            }
            catch (Exception e)
            {
                this.mensagem = "Valor Invalido!";
            }
        }
    }
}
