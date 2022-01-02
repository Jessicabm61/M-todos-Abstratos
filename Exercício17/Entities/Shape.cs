using Exercício17.Entities.Enums;
namespace Exercício17.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); //Método abstrato 
    }
}
