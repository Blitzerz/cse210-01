// Player class that holds the attributes of a player to be used
// in the game.
public class Player
{

         private int score;

         private int correct;

         private int incorrect;

         // Player constructor that assigns the Player attributes to
         // the parameter variables when the constructor is called.
         public Player(int score, int correct, int incorrect) {
         
         this.score = score;
         this.correct = correct;
         this.incorrect = incorrect;
    
        }

        // Method that returns the score attribute.
        public int getScore() {
            return score;
        }

        // Method that returns the correct attribute.
        public int getCorrect() {
            return correct;
        }

        // Method that returns the incorrect attribute.
        public int getIncorrect() {
            return incorrect;
        }

}