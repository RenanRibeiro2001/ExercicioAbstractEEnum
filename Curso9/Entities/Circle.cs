using System;
using Curso9.Entities.Enums;

namespace Curso9.Entities
{
    internal class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(Color color, double radius) : base (color)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
