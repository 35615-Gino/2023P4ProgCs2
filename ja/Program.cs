using System;

namespace ja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Lisa heeft psychologische hulp nodig waarbij ze het uit moet maken met Peter om soep te gaan eten waarbij ze water groen gaat eten geel zwart maakt en gras kaas is";

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Lisa get help");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
            Console.ResetColor();

            foreach (char words in text)
            {
                Console.Write(words);
                Thread.Sleep(100);
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ReadLine();
            Console.ResetColor();
        }


        internal void Soup ()
        {
        }
    }
}