using System;
using classzoo.Models;

namespace classzoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Tiger khan = new Tiger();
            // Lion simba = new Lion(10, "Simba", khan);
            // khan.Name = "KHAN!!!";
            // khan.Food = "Brain Slug";

            // System.Console.WriteLine(simba.Age);
            // simba.Birthday();
            // System.Console.WriteLine(simba.Age);

            // System.Console.WriteLine(khan.Eat("Brain Slug"));
            // System.Console.WriteLine(khan.Eat("Veggies"));

            //create a class called Games
            //one of the games is called NumberGuess (Method)
            //players can guess a random number between 1-10
            //they will be told to guess higher or lower until right

            Games g = new Games();
            bool playing = true;
            while (playing)
            {
                g.NumberGuess();
                System.Console.WriteLine("Again?");
                ConsoleKeyInfo choice = Console.ReadKey();
                if (choice.KeyChar == 'n')
                {
                    playing = false;
                }
            }


        }
    }
}
