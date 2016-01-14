using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static int GetIntegerFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);

                    string input = Console.ReadLine();

                    int x = int.Parse(input);

                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
        }
        static decimal GetDecimalFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);

                    string input = Console.ReadLine();

                    decimal x = decimal.Parse(input);

                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
        }
        static void Main(string[] args)
        {

            decimal price = GetDecimalFromUser("How much does the item cost?");

            decimal cost = GetDecimalFromUser("How much has the customer given you?");

            decimal Twenties = 0;
            decimal Tens = 0;
            decimal Fives = 0;
            decimal Ones = 0;
            decimal Quarters = 0;
            decimal Dimes = 0;
            decimal Nickels = 0;
            decimal Pennies = 0;

            decimal change = cost - price;

            if (change < 0)
            {
                Console.WriteLine("Please ask for more change.  You are {0} short.", change);
            }

            else
            {
                Console.WriteLine("The customer's change is {0}.", change);
                Twenties = Math.Floor(change / 20);
                Tens = Math.Floor((change % 20) / 10);
                Fives = Math.Floor(((change % 20) % 10) / 5);
                Ones = Math.Floor((((change % 20) % 10) % 5) / 1);
                Quarters = Math.Floor(((((change % 20) % 10) % 5) % 1) / 0.25m);
                Dimes = Math.Floor((((((change % 20) % 10) % 5) % 1) % 0.25m) / 0.1m);
                Nickels = Math.Floor(((((((change % 20) % 10) % 5) % 1) % 0.25m) % 0.1m) / 0.05m);
                Pennies = Math.Floor((((((((change % 20) % 10) % 5) % 1) % 0.25m) % 0.1m) % 0.05m) / 0.01m);

                Console.WriteLine("Please give the customer {0} twenties, {1} tens, {2} fives, {3} ones, {4} quarters, {5} dimes, {6} nickels, and {7} pennies.", Twenties, Tens, Fives, Ones, Quarters, Dimes, Nickels, Pennies
);
                    }
            Console.ReadKey();
        }
    }
}
