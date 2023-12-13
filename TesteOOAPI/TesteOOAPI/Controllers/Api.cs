using Microsoft.AspNetCore.Mvc;
using TesteOOAPI.modelo;

namespace TesteOOAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Api : ControllerBase
    {

        [HttpGet("Somar")]

        public String somar(String v1, String v2)
        {
            Controle controle = new Controle();
            return controle.executar(v1, v2);
        }

    }
}