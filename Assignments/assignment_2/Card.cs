using System;    

// Card class that directs the program.    
public class Card
{
    // Declare and initialize private variables to be used in
    // the program.
    private static Random randomGenerator = new Random();
    private int currentCard = randomGenerator.Next(1, 14);
    private int nextCard = randomGenerator.Next(1, 14);
    private bool isPlaying = true;

    // Card constructor to call methods and start the game.
    // Two new instances of the Player class are created to
    // retrieve the points for the player.
    public Card() {
        
        Player points = new Player(300, 100, 75);
        int score = points.getScore();
        int correct = points.getCorrect();
        int incorrect = points.getIncorrect();
        
        while (isPlaying) {
            displayCard();
            string inputs = getInputs();
            int newScore = doUpdates(inputs, score, correct, incorrect, isPlaying);
            showOutputs(newScore);
            currentCard = randomGenerator.Next(1, 14);
            nextCard = randomGenerator.Next(1, 14);

            Player newPoints = new Player(newScore, correct, incorrect);
            score = newPoints.getScore();
            correct = newPoints.getCorrect();
            incorrect = newPoints.getIncorrect();
            Console.WriteLine();
        }
    }

    // Method to display the random current card. Nothing is returned.
    public void displayCard() {
        Console.WriteLine($"The card is: {currentCard}");
    }

    // Method that prompts the player to guess if the
    // next card is higher or lower. A string is returned.
    private string getInputs() {
        Console.Write("Higher or lower? [h/l] ");
        string userGuess = Console.ReadLine();
        return userGuess;
    }

    // Method to update the player's score based on if their guesses are
    // correct or incorrect. The game ends if the player's points reaches
    // zero. An int is returned.
    private int doUpdates(string userGuess, int score, int correct, int incorrect, bool isPlaying) {
        Console.WriteLine($"The next card was: {nextCard}");
        
        if ((userGuess.ToLower() == "h" && nextCard >= currentCard) || (userGuess.ToLower() == "l" && nextCard <= currentCard)) {
            score += correct;
        }
        else if ((userGuess.ToLower() == "h" && nextCard <= currentCard) || (userGuess.ToLower() == "l" && nextCard >= currentCard)) {
            score -= incorrect;
            
            if (score <= 0) {
                score = 0;
                isPlaying = false; }
                
                if (isPlaying == false) {
                    Console.WriteLine($"Your score is: {score}");
                    Console.WriteLine("You guessed wrong and reached zero points. Game over.");
                    Environment.Exit(0);
            }
        }
        return score;
    }

    // Method to display the player's score and prompt them to play again.
    // Nothing is returned.
    private void showOutputs(int newScore) {
        Console.WriteLine($"Your score is: {newScore}");
        Console.Write("Play again? [y/n] ");
        string keepPlaying = Console.ReadLine();

        if (keepPlaying.ToLower() == "y") {
            isPlaying = true;
        }
        else if (keepPlaying.ToLower() == "n") {
            Environment.Exit(0);
        }
    }
}