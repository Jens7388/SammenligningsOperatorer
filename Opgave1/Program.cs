using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i = 17 < 10;
            bool ii = 20 > 20;
            bool iii = 20 <= 20;
            bool iv = 50 != 10 * 5;
            bool v = 27 - 0.15 >= 28 - 1.15;
            bool vi = 5 * 3 == 15;
            bool vii = 5 / 5 == 1;

            Console.WriteLine($"i. 17 < 10 = {i}");
            Console.WriteLine($"ii. 20 > 20 = {ii}");
            Console.WriteLine($"iii. 20 <= 20 = {iii}");
            Console.WriteLine($"iv. 50 != 10 * 5 = {iv}");
            Console.WriteLine($"v. 27 − 0.15 >= 28 − 1.15 = {v}");
            Console.WriteLine($"vi. 5 * 3 == 15 = {vi}");
            Console.WriteLine($"vii. 5/5 == 1 = {vii}");
            Console.ReadLine();
        }
    }
}
