using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX_VALUE;
            int MIN_VALUE;
            var rand = new Random();
            int GENERATED_VALUE;
          
            Console.WriteLine("Input a Maximum Number.");
            string response = Console.ReadLine();
            if (int.TryParse(response, out MAX_VALUE) == false)
            {
                do
                {
                    Console.WriteLine("This is an invalid input, please try again.");
                    response = Console.ReadLine();

                }
                while (int.TryParse(response, out MAX_VALUE) == false);

            }
            Console.WriteLine("Input a Minimum number");
            response = Console.ReadLine();
            if (int.TryParse(response, out MIN_VALUE) == false)
            {
                do
                {
                    Console.WriteLine("This is an invalid input, please try again.");
                    response = Console.ReadLine();

                }
                while (int.TryParse(response, out MIN_VALUE) == false);
            }

            while (MIN_VALUE >= MAX_VALUE)
            {
                Console.WriteLine("Input a Minimum number less than the Maximum number");
                response = Console.ReadLine();
                if (int.TryParse(response, out MIN_VALUE) == false)
                {
                    do
                    {
                        Console.WriteLine("This is an invalid input, please try again.");
                        response = Console.ReadLine();

                    }
                    while (int.TryParse(response, out MIN_VALUE) == false);
                }
            }

            int randNum_1 = rand.Next(MIN_VALUE, MAX_VALUE+1);
            GENERATED_VALUE = randNum_1;


            Console.WriteLine("Guess what the random number is.");
            response = Console.ReadLine();
            if (response == GENERATED_VALUE.ToString())
            {
                Console.WriteLine("You guessed correctly!");
            }
            while (GENERATED_VALUE.ToString() != response)
            {
                Console.WriteLine("You guessed incorrectly. Try again");
                response = Console.ReadLine();
                
                if (response == GENERATED_VALUE.ToString())
                {
                    Console.WriteLine("You guessed correctly!");
                }
            }
            
        }
    }
}
