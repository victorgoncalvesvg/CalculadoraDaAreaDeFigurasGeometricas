using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeAreas
{
    public class Retangulo : Forma
    {
        public double Lado { get; set; }
        public double Altura { get; set; }

        public Retangulo(double lado, double altura)
        {
            Lado = lado;
            Altura = altura;
        }

        public Retangulo() { }

        public override string CalculaArea()
        {
            return $"A área do retangulo de lado {Lado} e altura {Altura} é {Lado * Altura}";
        }
    }
}