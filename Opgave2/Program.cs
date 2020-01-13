using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast din månedsløn:");
                string salaryInput = Console.ReadLine();
                int.TryParse(salaryInput, out int monthlySalary);
                if(monthlySalary == 0)
                {
                    Console.WriteLine("Kom tilbage når du har en indkomst");
                }
                else
                {
                    int yearlySalary = monthlySalary * 12;
                    Console.WriteLine($"Din årsløn er: {yearlySalary} kr");
                    Console.WriteLine("Indtast prisen på det hus du vil købe: ");
                    string housePriceInput = Console.ReadLine();
                    int.TryParse(housePriceInput, out int housePrice);
                    bool canBuyHouse = yearlySalary >= housePrice * 0.2;
                    if(canBuyHouse)
                    {
                        Console.WriteLine("Tillykke! du har råd til at købe huset.");
                    }
                    else
                    {
                        Console.WriteLine("Du har desværre ikke råd til at købe huset");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
