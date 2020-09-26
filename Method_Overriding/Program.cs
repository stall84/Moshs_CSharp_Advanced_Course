using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            var circle = new Circle();
            circle.Draw(); 
           
            

            //shapes.Add(new Circle());
            //shapes.Add(new Rectangle());

            //var canvas = new Canvas();
            //canvas.DrawShapes(shapes);
        }
    }
}
