
namespace DesafioDoProfessor
{
    public abstract class Forma
    {
        public abstract float CalculaDimensao();

    }

    public class Quadrado : Forma
    {
        float areaQuadrado = 0.0f;
        float medidaFace = 0.0f;

        public override float CalculaDimensao()
        {
            Console.WriteLine("==[       Calculo da Area do QUADRADO       ]==");
            Console.Write("Informe a medida de 1 dos lados do quadrado: ");
            medidaFace = float.Parse(Console.ReadLine());

            areaQuadrado = medidaFace * medidaFace;
            //areaQuadrado   = Math.Pow(medidaFace, 2);
           
            return areaQuadrado;
            
        }
    }

    public class Triangulo : Forma
    {
        float alturaTriangulo = 0.0f;
        float baseTriangulo = 0.0f;
        float areaTriangulo = 0.0f;
        public override float CalculaDimensao()
        {

            Console.WriteLine("==[       Calculo da Area do TRIANGULO      ]==");

            Console.Write("Informe a medida da base do triangulo: ");
            baseTriangulo = float.Parse(Console.ReadLine());

            Console.Write("Informe a medida da altura do triangulo: ");
            alturaTriangulo = float.Parse(Console.ReadLine());

            areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            return areaTriangulo;

        }
    }

    public class Circulo : Forma
    {
        float raioCirculo = 0.0f;
        float numeroPi = 3.14159f;
        float areaCirculo = 0.00f;
        public override float CalculaDimensao()
        {

            Console.WriteLine("==[        Calculo da Area do CIRCULO       ]==");

            Console.Write("Informe o raio do circulo: ");
            raioCirculo = float.Parse(Console.ReadLine());

            areaCirculo = numeroPi * (raioCirculo * raioCirculo) ;

            return areaCirculo;
        }
    }
}
