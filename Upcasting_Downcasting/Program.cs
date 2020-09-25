using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Upcasting_Downcasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(2);
            list.Add("salamanders");
            list.Add(new Text());

            var anotherList = new List<Shape>();
            //StreamReader reader = new StreamReader(new MemoryStream());

            // Upcasting example. Converting derived updwards to the base class
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;               // Because we've instantiated the shape object directly to the OBJECT created 
            //shape.Width = 150;              // In the first line (Text text = new Text()).. Because it's not pointing at the class,
            //                                // text.Width will indeed be 150 not 200
            //Console.WriteLine($"Text Width: {text.Width}");
        }
    }
}
