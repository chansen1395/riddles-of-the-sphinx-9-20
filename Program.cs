using System;
using System.Collections.Generic;
using Sphinx.Riddles;

namespace Sphinx
{
  public class Program
  {
    public static void Main()
    {
      Riddle riddleOne = new Riddle("What has to be broken before you use it?", "egg");
      Riddle riddleTwo = new Riddle("I'm tall when I'm young and I'm short when I'm old. What am I?", "candle");
      Riddle riddleThree = new Riddle("What is full of holes but still holds water?", "sponge");

      Score playerScore = new Score(0);
      var array = new int[] {0, 1, 2};
      var rng = new Random();
      rng.Shuffle(array);
      rng.Shuffle(array);

    
      List<Riddle> ManyRiddles = new List<Riddle>() {riddleOne, riddleTwo, riddleThree};
      
      foreach (int j in array)
        {
        Console.WriteLine(ManyRiddles[j].RiddleAnswer);
        }
        foreach (int j in array)
        {
          Console.WriteLine("What is the answer to this riddle? " + ManyRiddles[j].RiddleBody);
          string userAnswer = Console.ReadLine();
          
          if (userAnswer.ToLower().Contains(ManyRiddles[j].RiddleAnswer)) 
          {
            Console.WriteLine("Correct! The answer was " + ManyRiddles[j].RiddleAnswer);
            playerScore.addScore(1);
          }
          else 
          {
            Console.WriteLine("Wrong! Try again");
          }
        }
      Console.WriteLine("Total Correct Answers: " + playerScore.RiddleScore);
    }
  }
}