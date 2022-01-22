using System;
using AbstractClassAndMethodsEx.Entities.Enums;

namespace AbstractClassAndMethodsEx.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
