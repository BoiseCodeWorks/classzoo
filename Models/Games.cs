

using System;

namespace classzoo.Models
{
    class Games
    {
        public bool Playing { get; set; } = true;
        public void NumberGuess()
        {
            int secretNumber = new Random().Next(1, 10);
            while (Playing)
            {
                Console.Write("Guess a Number: ");
                string strGuess = Console.ReadLine();
                if (Int32.TryParse(strGuess, out int guess))
                {
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("WIN!");
                        return;
                    }
                    if (guess > secretNumber)
                    {
                        Console.WriteLine("Its lower Dummy!");
                    }
                    else
                    {
                        Console.WriteLine("That's Way too low, you Bozo!");
                    }
                }
            }
        }
    }
}