using System;

namespace Indexers
{

    class Program
    {
        static void Main(string[] args)
        {

            var cookie = new HttpCookie();

                cookie["name"] = "Michael";

            Console.WriteLine($"Cookie Name: {cookie["name"]}");
        }
    }
}
