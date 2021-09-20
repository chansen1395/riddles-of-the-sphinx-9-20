using System;

namespace Sphinx.Riddles
{
  public class Riddle
  {
    public string RiddleBody { get; set; }
    public string RiddleAnswer { get; set; }

    public Riddle(string riddleBody, string riddleAnswer)
    {
      RiddleBody = riddleBody;
      RiddleAnswer = riddleAnswer;
    }
  }

  public class Score
  {
    public int RiddleScore { get; set; }
    public Score(int score)
    {
      RiddleScore += score;
    }

    public int addScore(int score) 
    {
      RiddleScore +=score;
      return RiddleScore;
    }
  }

  static class RandomExtensions
{
    public static void Shuffle<T> (this Random rng, T[] array)
    {
        int n = array.Length;
        while (n > 1) 
        {
            int k = rng.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
}
}