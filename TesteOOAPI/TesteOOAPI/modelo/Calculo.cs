namespace TesteOOAPI.modelo
{
    public class Calculo
    {
        public String somar(int v1, int v2)
        {
            String resposta = "";
            double calc = v1 + v2;
            resposta = calc.ToString();

            return resposta;
        }
    }
}
