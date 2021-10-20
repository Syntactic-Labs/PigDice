using System;

namespace PigDice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pd = new PigDice();
            var score = pd.RunToHighScore(750);
            var highest = 0;
            if (score > highest)
            {
                highest = score;
                
            }

            Console.WriteLine($"{score}");


        }
    }
}
