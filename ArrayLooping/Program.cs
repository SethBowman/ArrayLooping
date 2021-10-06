using System;
using System.Collections.Generic;

namespace ArrayLooping
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Foreach loop:");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("=========");

            Console.WriteLine("For loop:");

            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine("======");

            Console.WriteLine("Using a list and looping:");

            var words = new List<string>() { "word", "wordd", "worddd" };
            words.Add("blah");

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("======");

            Console.Write("Give me a number: ");

            
            string answer = Console.ReadLine();

            bool canParse = int.TryParse(answer, out var newNum);

            while(!canParse)
            {
                Console.Write("Please enter a valid number: ");
                answer = Console.ReadLine();
                canParse = int.TryParse(answer, out newNum);
            }

            



            



        }
    }
}
