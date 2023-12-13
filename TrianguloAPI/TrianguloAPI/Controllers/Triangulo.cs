namespace TrianguloAPI.Controllers
{
    public class Triangulo
    {
        public String mensagem = "";

        public String calcular(double baseT, double altura)
        {
            double calc = (baseT * altura) / 2;
            this.mensagem = calc.ToString();

            return mensagem;
        }
    }
}
