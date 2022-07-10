using System;

public class Director
{
    
    // Initialize necessary variables.
    private Parachute parachute;
    private IO io;
    private Word word;
    private string currentWord;
    private string guess;
    private string currentWordState;

    /// <summary>
    /// Constructor that creates instances of the Parachute,
    /// IO, and Word class as well as creates two new variables.
    /// </summary>
    public Director()
    {
        parachute = new Parachute();
        io = new IO();
        word = new Word();
        currentWord = word.GetNextWord();
        currentWordState = "";
    }
    
    /// <summary>
    /// Start the game.
    /// </summary>
    public void startGame()
    {
        while (parachute.getWrongGuesses() < 4)
        {
            // Display basic information to player.
            io.DisplayJumper(parachute.getWrongGuesses(), 4);
            io.DisplayCurrentWord(currentWordState);
            
            // Get the player's guess.
            guess = io.JumperGuess();
            
            // Compare guess against the current word.
            string guessed = word.CompareWords(guess);
            
            // Apply the consequence based on the results of the guess comparison.
            if (currentWordState == guessed)
                parachute.addWrongGuesses();
            else
                currentWordState = guessed;

            // Win condition.
            if (currentWordState == currentWord)
            {
                Console.WriteLine("You Win!");
                return;
            }
        }
        
        // Loss condition.
        io.DisplayJumper(parachute.getWrongGuesses(), 4);
        Console.WriteLine("You Lose!");
    }
}