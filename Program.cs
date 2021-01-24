using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input some random characters");
            var characters = Console.ReadLine();
            string newString = string.Empty;
            var counter = 1;
            foreach (char a in characters)
            {
                for (int i = 0; i < counter; i++)
                {
                    newString += a;
                }
                newString += "*";
                counter++;
            }
            Console.WriteLine($"The new string {newString.TrimEnd('*')}");
        }
    }
}
