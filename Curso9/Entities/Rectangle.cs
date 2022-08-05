using System;
using Curso9.Entities.Enums;

namespace Curso9.Entities
{
    internal class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }
        
        public Rectangle(Color color,double width, double height) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
