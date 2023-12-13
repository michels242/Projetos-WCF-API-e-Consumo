package webService;

public class Triangulo 
{

    public static String calcularTriangulo(java.lang.String baseT, java.lang.String altura) {
        org.tempuri.Service1 service = new org.tempuri.Service1();
        org.tempuri.IService1 port = service.getBasicHttpBindingIService1();
        return port.calcularTriangulo(baseT, altura);
    }
}
