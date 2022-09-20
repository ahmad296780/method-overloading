using System;

namespace method_overloading
{
    internal class Program
    {
        public static int Add(int x, int y)
        { return x + y; }
        public static decimal Add(decimal x, decimal y)
        { return x + y; }
        public static string Add(int x, int y, bool z)

        {


            if (z = true)
            {
                return ($"{x + y} dollars");
            }
            else if (z = true && (x + y) == 1)
            {
                return ($"{x + y} dollar");
            }
            else
                return null;
        }




        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,3,true));
        }
    }
}
