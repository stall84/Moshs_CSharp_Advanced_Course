using System;

namespace Abstract_Classes
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public abstract void Draw();
        
        public void Copy()
        {
            Console.WriteLine("Shape being copied to clipboard");
        }
    }
}
