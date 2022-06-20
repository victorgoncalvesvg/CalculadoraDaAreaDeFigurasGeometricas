using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeAreas
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public Circulo() { }

        public override string CalculaArea()
        {
            return $"A área do círculo de raio {Raio} é {Math.Round(Math.Pow(Raio, 2) * Math.PI, 2)}";
        }
    }
}