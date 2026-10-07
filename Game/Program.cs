using System;
using System.Diagnostics;

namespace MyProject
{
    class Program
    {
        // This is your entry point
        static void Main()
        {
            Random dice1 = new Random();
        Random dice2 = new Random();
        int Dice1 = dice1.Next(1, 6);
        int Dice2 = dice1.Next(1, 6);
        List<int> numbers = new List<int> { Dice1, Dice2};
        int DiceSum = numbers.Sum();

        Console.WriteLine($"{DiceSum}");
        if(DiceSum == 12)
        {
            Console.WriteLine(" dina dice's var lika med 12");
        }
        else
        {
            Console.WriteLine(" du komm in på else aka dina dice sum va inte 12");
        }
        }
    }
}
