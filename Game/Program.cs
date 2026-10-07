using System;
using System.Diagnostics;

namespace MyProject
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter any Key to play the game: ");
                Console.WriteLine("press Esc to exit the application");
                Console.WriteLine();

                ConsoleKeyInfo svar2 = Console.ReadKey();
                
                if(svar2.Key != ConsoleKey.Escape)
                {
                    
                    Random dice1 = new Random();
                    Random dice2 = new Random();
                    int Dice1 = dice1.Next(1, 7);
                    int Dice2 = dice1.Next(1, 7);
                    
                    List<int> numbers = new List<int> { Dice1, Dice2};
                    int DiceSum = numbers.Sum();
                    
                    if(DiceSum == 12)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Du kastade dina två tärningar och fick: {DiceSum}");
                        Console.WriteLine();
                        Console.WriteLine("Grattis du vann!");
                        Environment.Exit(0);
                    }
                    else                        
                    {  
                        Console.WriteLine();
                        Console.WriteLine($"Du fick: {DiceSum}");
                        Console.WriteLine();
                        Console.WriteLine("Så du förlorade try again!");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
