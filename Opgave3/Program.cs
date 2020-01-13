using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast dit fødselsår: ");
                string birthYearInput = Console.ReadLine();
                int.TryParse(birthYearInput, out int birthYear);
                int userAge = 2019 - birthYear;
                Console.WriteLine($"Du er {userAge} år gammel");

                if(userAge >= 18)
                {
                    Console.WriteLine("Du må både købe øl og spiritus");
                }
                else if(userAge >= 16 && userAge < 18)
                {
                    Console.WriteLine("Du må gerne købe øl, men du må ikke købe spiritus");
                }
                else
                {
                    Console.WriteLine("Du må hverken købe øl eller spiritus");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
