using System;

namespace C_Sharp_Classes_1
{

    class Program
    {
        static void Main(string[] args)
        {



            //UsePoints();
            //UseParams();

           

            
        }

        static void UseParams()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(4, 8, 12, 44));
        }


        static void UsePoints()
        {

            try
            {
                var point = new Point(10, 20);

                point.Move(100, 200);

                Console.WriteLine($"Point is now at: {point.X}, {point.Y}");
                point.Move(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occured: {ex}");
            }

        }
    }
}
