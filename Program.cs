using System;

namespace MenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Symulacja Mistrzostw Świata w Katarze");
            Console.WriteLine("2. Symulacja meczu");
            Console.WriteLine("3. Dodaj drużynę");
            Console.WriteLine("4. Wyjście");

            // Prompt user to select an option
            Console.Write("Co chcesz zrobić?: ");
            int wybor = Convert.ToInt32(Console.ReadLine());

            // Handle user's selection
            switch (wybor)
            {
                case 1:
                    // Code to execute for option 1
                    Console.WriteLine("Wybrałeś symulację Mistrzostw Świata.");
                    break;
                case 2:
                    // Code to execute for option 2
                    Console.WriteLine("Wybrałeś symulację pojedynczego meczu.");
                    break;
                case 3:
                    // Code to execute for option 3
                    Console.WriteLine("Wprowadź dane o drużynie:");
                    break;
                case 4:
                    // Code to execute for option 4
                    Console.WriteLine("Wyjście");
                    break;
                default:
                    // Code to execute if the user enters an invalid option
                    Console.WriteLine("Niewłaściwe dane");
                    break;
            }
        }
    }
}


