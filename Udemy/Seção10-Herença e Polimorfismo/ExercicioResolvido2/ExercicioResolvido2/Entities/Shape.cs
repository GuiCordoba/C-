using System;
using ExercicioResolvido2.Entities.Enums;

namespace ExercicioResolvido2.Entities
{
    abstract class Shape //Classe abstrata
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
