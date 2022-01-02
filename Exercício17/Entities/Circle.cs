using Exercício17.Entities.Enums;
using System;
namespace Exercício17.Entities
{
    class Circle : Shape  //Herança
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color):
            base(color) //sobreposição de construtor utilizando a palabra base
        {
            Radius = radius;
        }

        public override double Area() //reutilizando método abstrato utilizando a palabra override
        {
            return Math.PI * Radius * Radius;
        }
    }
}
