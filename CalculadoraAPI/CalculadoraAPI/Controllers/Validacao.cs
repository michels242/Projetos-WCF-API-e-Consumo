namespace CalculadoraAPI.Controllers
{
    public class Validacao
    {
        public Double valor1;
        public Double valor2;
        public String mensagem = "";

        public void validar(String v1, String v2)
        {
            try
            {
                this.valor1 = double.Parse(v1);
                this.valor2 = double.Parse(v2);
            }
            catch (Exception ex)
            {
                this.mensagem = "Valor Invalido!";
            }
        }
    }
}
