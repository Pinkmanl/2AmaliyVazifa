using System;
namespace kalkulyator
{
    class Kalkulyator
    {
        static void Main()
        {
            Console.WriteLine("bu Kalkulyator dasturi");
            Console.WriteLine("1-sonni kiriting");
            int namber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("amalni kiriting");
            string symbol = Console.ReadLine() ?? "";

            Console.WriteLine("2-sonni kiriting");
            int namber2 = Convert.ToInt32(Console.ReadLine());
            int result = symbol switch
            {
                "+" => namber1 + namber2,
                "-" => namber1 - namber2,
                "*" => namber1 * namber2,
                "/" => namber1 / namber2,

            };
            Console.WriteLine("Natija = " +result);
        }
    }
}

