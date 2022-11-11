using System;
using System.IO.Pipes;

namespace Pre_work_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string anwer;
            do
            {
                Console.WriteLine("Welcome for change for a Dollar game");

                Console.WriteLine("Enter the number of Pennies");
                int Pennies = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number of Nickels");
                int Nickels = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number of Dimes");
                int Dimes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number of Quarters");
                int Quarters = Convert.ToInt32(Console.ReadLine());

                //math calculations 
                double total = (Pennies * .01) + (Nickels * .05) + (Dimes * .10) + (Quarters * .25);

                if (total == 1)
                {
                    Console.WriteLine("Congratulations you won!");
                }
                else if (total > 1)
                {
                    Console.WriteLine($"The amount was : {total.ToString("C")} which is more then one dollar");
                }else if (total < 1)
                {
                    Console.WriteLine($"The amount was : {total.ToString("C")} which is less then one dollar");
                }
                Console.WriteLine($"Do you want to play again? Y/N");
                anwer = Console.ReadLine();

                //try the game again?
            } while (anwer == "Y" );
            Console.WriteLine("Press any key to exit the game!");

            
        }
    }
}
