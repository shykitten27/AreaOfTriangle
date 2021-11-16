using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int result;
            int baseOfTri =0;
            int heightOfTri =0;

            Console.WriteLine("Enter base of triangle:");
            input = Console.ReadLine();

            if (input == "" || !int.TryParse(input, out result)) //blank or IsNaN
            {
                Console.WriteLine("Invalid base - exiting program. ");
                Environment.Exit(0);
            }
            else
            {
                baseOfTri = result;
            }

            Console.WriteLine("Enter height of triangle:");
            input = Console.ReadLine();

            if (input == "" || !int.TryParse(input, out result)) //blank or IsNaN
            {
                Console.WriteLine("Invalid height - exiting program. ");
                Environment.Exit(0);
            }
            else
            {
                heightOfTri = result;
            }

            Console.WriteLine("The area of the triangle is: " + triArea(baseOfTri, heightOfTri));
        }

        public static int triArea(int b, int h)
        {
            int triArea = (b * h) / 2;
            return triArea;
        }

        private static bool IsNaN(int input)
        {
            throw new NotImplementedException();
        }
    }
}
