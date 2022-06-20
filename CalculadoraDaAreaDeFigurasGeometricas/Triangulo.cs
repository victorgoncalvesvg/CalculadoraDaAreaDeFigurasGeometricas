using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeAreas
{
    public class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double _base, double altura)
        {
            Base = _base;
            Altura = altura;
        }

        public Triangulo() { }

        public override string CalculaArea()
        {
            return $"A área do triângulo de base {Base} e altura {Altura} é {Base * Altura / 2}";
        }
    }
}