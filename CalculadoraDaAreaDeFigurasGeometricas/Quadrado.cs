using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeAreas
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public Quadrado() { }


        public override string CalculaArea()
        {
            return $"A área do quadrado de lado {Lado} é {Lado * Lado}";
        }
    }
}