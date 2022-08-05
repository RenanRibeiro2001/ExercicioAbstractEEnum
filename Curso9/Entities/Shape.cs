using System;
using System.Collections.Generic;
using Curso9.Entities.Enums;

namespace Curso9.Entities
{
    internal abstract class Shape
    {
        public Color color{ get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();

    }
}
