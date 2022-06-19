namespace DesafioDoProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Qual forma deseja calcular? ");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triangulo");
            Console.WriteLine("3 - Circulo");
            int alternativa = int.Parse(Console.ReadLine());
            float area = 0.0f;

            Quadrado dimQuadrado = new Quadrado();
            Triangulo dimTriangulo = new Triangulo();
            Circulo dimCirculo = new Circulo();

            switch (alternativa)
            {
                case 1:
                    
                    area = dimQuadrado.CalculaDimensao();
                    break;
                case 2:

                    area = dimTriangulo.CalculaDimensao();
                    break;

                case 3:
                  
                    area = dimCirculo.CalculaDimensao();
                    break;

                default:

                    break;

            }

            Console.WriteLine($"Area: {area}");
            Console.WriteLine("===============================================");


        }
    }
}