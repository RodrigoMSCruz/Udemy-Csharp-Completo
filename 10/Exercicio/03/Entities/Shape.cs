using System;
using 10.Exercicio.03.Entities.Enuns;

namespace 10.Exercicio.03.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    
    
    }

}