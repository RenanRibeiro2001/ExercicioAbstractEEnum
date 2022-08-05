using System;
using System.Collections.Generic;
using Curso9.Entities;
using Curso9.Entities.Enums;

namespace Curso9
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Shape ${i} data: ");
                Console.Write("Rectangle or circle (r/c) ?");
                char formato = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(formato == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(color, width, height));
                }else if(formato == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine("Shape Areas: ");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}