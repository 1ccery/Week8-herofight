using System;

namespace FunctionArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            string[] foods = { "Burger", "Chiken Wings", "french fries", "salad", "chicken nuget" };
            string[] drinks = { "coca-cola", "fanta", "sprite", "still water" };

            // DispalyRandomFromArray(foods);
            //DispalyRandomFromArray(drinks);
            string randomfoods = PickRandomFromArray(foods);
            string randomdrinks = PickRandomFromArray(drinks);

            Console.WriteLine($"Computer picked {randomfoods} and {randomdrinks}.");

        }
       
        
        private static string PickRandomFromArray(string[] somearray)
        {
            Random rnd = new Random();
            int randomtext = rnd.Next(0, somearray.Length);
                string RandomElement = somearray[randomtext];

            return RandomElement;
        }
        private static void DispalyRandomFromArray(string[] somearray)
        {
            Random rnd = new Random();
            int randomtext = rnd.Next(0, somearray.Length);
            Console.WriteLine($"computer has choosen {somearray[randomtext]}");

        }
    
    
    }
}
