using System.Runtime.Intrinsics;

namespace CalculadoraAPI.Controllers
{
    public class Calculadora
    {
        public String mensagem = "";
        public String somar(double v1, double v2) 
        {
            double calc = v1 + v2;
            mensagem = calc.ToString();

            return mensagem;
        }

        public String subtrair(double v1, double v2)
        {
            double calc = v1 - v2;
            mensagem = calc.ToString();

            return mensagem;
        }

        public String multiplicar(double v1, double v2)
        {
            double calc = v1 * v2;
            mensagem = calc.ToString();

            return mensagem;
        }

        public String divisao(double v1, double v2)
        {
            double calc = v1 / v2;
            mensagem = calc.ToString();

            return mensagem;
        }
    }
}
