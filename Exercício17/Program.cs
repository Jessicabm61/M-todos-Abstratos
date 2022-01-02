using System;
using Exercício17.Entities;
using Exercício17.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace Exercício17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>(); //Permitiu instanciar?
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red) :");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("SHAPES AREAS: ");
            foreach (Shape sh in list)
            {
                Console.WriteLine(sh.Area().ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
