using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nSelect an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                new BreathingActivity().Run();
            }
            else if (option == "2")
            {
                new ReflectionActivity().Run();
            }
            else if (option == "3")
            {
                new ListingActivity().Run();
            }
            else if (option == "4")
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid option.");
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
    }
}
