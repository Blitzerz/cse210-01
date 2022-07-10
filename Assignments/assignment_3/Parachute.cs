using System;

public class Parachute
{

  private int wrongGusses;

  // Constructor that initializes the wrongGuesses variable to zero.
  public Parachute()
  {
    wrongGusses = 0;
  }
  
  // Method that increments the number of wrong guesses made by one.
  public void addWrongGuesses()
  {
    wrongGusses++;
  }
  
  // Method that returns how many wrong guesses have been made.
  public int getWrongGuesses()
  {
    return wrongGusses;
  }



}



