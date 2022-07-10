using System;

public class IO
{

   private List<string> jumperImage;

   // Constructor that creates a new list to display the jumper
   // image and calls the createJumperImage method.
   public IO()
   {
      jumperImage = new List<string>();
      createJumperImage();
   }

   /*
   Summary: Creates the list that will display the jumper.
   */
   public void createJumperImage()
   {
      jumperImage.Add(" ___ ");
      jumperImage.Add("/___\\");
      jumperImage.Add("\\   /");
      jumperImage.Add(" \\ /");
      jumperImage.Add("  0  ");
      jumperImage.Add(" /|\\ ");
      jumperImage.Add(" / \\ ");
   }

   /*
   Summary: Chooses which jumper to display.
   Param: (int wrongGuesses) The number of incorrect guesses
   | (int correctWord) the length of the correct word.
   */
   public void DisplayJumper(int wrongGuesses, int correctWord)
   {
      if (wrongGuesses == correctWord)
      {
         DeadJumper();
      }
      else
      {
         AliveJumper(wrongGuesses);
      }
   }

   /*
   Summary: Displays the jumper when guesses remain.
   Param: (int wrongGuesses) The number of incorrect guesses.
   */
   public void AliveJumper(int wrongGuesses)
   {
      for (int i = wrongGuesses; i < jumperImage.Count; i++)
      {
         Console.WriteLine(jumperImage[i]);
      }
      Console.Write("\n");
      Console.WriteLine("^^^^^^^");
   }

   /*
   Summary: Displays the jumper when no guesses remain.
   */
   public void DeadJumper()
   {
      Console.WriteLine("  x  ");
      Console.WriteLine(" /|\\ ");
      Console.WriteLine(" / \\ ");
      Console.Write("\n");
      Console.WriteLine("^^^^^^^");
   }

   /*
   Summary: Displays the current state of the word to the user.
   Param: (string word) The current state of the guessed word.
   */
   public void DisplayCurrentWord(string word)
   {
      Console.WriteLine(word);
   }

   /*
   Summary: Prompts the user to guess a letter.
   Return: (string) Returns a single letter.
   */
   public string JumperGuess()
   {
      Console.Write("Guess a letter [a-z]: ");
      string guess = Console.ReadLine();
      return guess;
   }
}