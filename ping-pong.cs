using System;

namespace Game.Modals {

  public class Game
  {
    static void Main()
    {
      Console.WriteLine("Enter a number, and I will return a range with some hidden additions!");
      string stringNumber = Console.ReadLine();
      int userInput = int.Parse(stringNumber);
      // int[] range = {};

      for (int number = 1; number <= userInput; number ++)
      {
        if (number % 3 == 0 && number % 5 == 0 )
        {
          Console.WriteLine("ping-pong");
        } 
        else if (number % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        else if (number % 5 == 0)
        {
          Console.WriteLine("pong");
        }
        else
        {
          Console.WriteLine(number);
        }
      }
    }
  }

}