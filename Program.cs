using System;

namespace Новая_папка
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
      bool won = false;
      int number  = random.Next(1, 10);
      Console.WriteLine("Guess the number");
      while (won == false)
      {
      string input = Console.ReadLine();
      int guess = Int32.Parse(input);
      if (guess == number)
      {
        Console.WriteLine("You got it");
        won = true;
      }
      else if (guess < number)
      {Console.WriteLine("Try higher");}
      else {Console.WriteLine("Try lower");}
    }
        }
    }
}
