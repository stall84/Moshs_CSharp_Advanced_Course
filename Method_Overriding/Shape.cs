
using System;

namespace Method_Overriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
            // Can write any code specific to Circle class using override of Shape's Draw method
            //base.Draw();
        }
    }

    public class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }

    }
}
