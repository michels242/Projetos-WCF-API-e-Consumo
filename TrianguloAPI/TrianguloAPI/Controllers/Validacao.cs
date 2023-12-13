namespace TrianguloAPI.Controllers
{
    public class Validacao
    {
        public Double baseTConvertido;
        public Double alturaConvertida;
        public String mensagem = "";

        public String validar(String baseT, String altura)
        {
            try
            {
                this.baseTConvertido = double.Parse(baseT);
                this.alturaConvertida = double.Parse(altura);
            }
            catch
            {
                this.mensagem = "Erro!";
            }

            return mensagem;
        }
    }
}
