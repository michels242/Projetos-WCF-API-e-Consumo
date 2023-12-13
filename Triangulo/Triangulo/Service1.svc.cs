using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Triangulo.modelo;

namespace Triangulo
{
    public class Service1 : IService1
    {
        public string calcularTriangulo(String baseT, String altura)
        {
            Controle controle = new Controle();
            return controle.executar(baseT, altura);
        }
    }
}
