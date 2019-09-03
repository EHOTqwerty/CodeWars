using System;

namespace Trailing_zeros
{
    class Program
    {
        static void Main(string[] args)
        {   
            int x = Convert.ToInt32(Console.ReadLine());
            int y;
            y = Calculating(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }

        static int Calculating(int input)
        {
            int count = 0;
            for (int i = 5; input / i >= 1; i *= 5)
                count += input / i;
            return count;   
        }
    }
}
