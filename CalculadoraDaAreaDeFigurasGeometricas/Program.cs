namespace CalculadoraDeAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadrado = new Quadrado(5);
            Console.WriteLine(quadrado.CalculaArea());

            Console.WriteLine("================");

            var triangulo = new Triangulo(5,5);
            Console.WriteLine(triangulo.CalculaArea());

            Console.WriteLine("================");

            var retangulo = new Retangulo(5,5);
            Console.WriteLine(retangulo.CalculaArea());

            Console.WriteLine("================");

            var circulo = new Circulo(5);
            Console.WriteLine(circulo.CalculaArea());

        }
    }
}