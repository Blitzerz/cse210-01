using System;

public class Word
{
    private List<string> words = new List<string>();
    private List<string> alreadyGuessed = new List<string>();
    public int currentWord;
    public string chosenWord;
    private bool currentGuessedLetter;
    
    public Word()
    {
        words.Add("blubber");
        words.Add("sausage");
        words.Add("pencil");
        words.Add("cloud");
        words.Add("moon");
        words.Add("water");
        words.Add("computer");
        words.Add("school");
        words.Add("network");
        words.Add("hammer");
        words.Add("walking");
        words.Add("violently");
        words.Add("mediocre");
        words.Add("literature");
        words.Add("chair");
        words.Add("two");
        words.Add("window");
        words.Add("cords");
        words.Add("musical");
        words.Add("zebra");
        words.Add("xylophone");
        words.Add("penguin");
        words.Add("home");
        words.Add("dog");
        words.Add("final");
        words.Add("ink");
        words.Add("teacher");
        words.Add("fun");
        words.Add("website");
        words.Add("banana");
        words.Add("uncle");
        words.Add("softly");
        words.Add("mega");
        words.Add("ten");
        words.Add("awesome");
        words.Add("attatch");
        words.Add("blue");
        words.Add("internet");
        words.Add("bottle");
        words.Add("tight");
        words.Add("zone");
        words.Add("tomato");
        words.Add("prison");
        words.Add("hydro");
        words.Add("cleaning");
        words.Add("television");
        words.Add("send");
        words.Add("frog");
        words.Add("cup");
        words.Add("book");
        words.Add("zooming");
        words.Add("falling");
        words.Add("evily");
        words.Add("gamer");
        words.Add("lid");
        words.Add("juice");
        words.Add("moniter");
        words.Add("captain");
        words.Add("bonding");
        words.Add("loudly");
        words.Add("thudding");
        words.Add("guitar");
        words.Add("shaving");
        words.Add("hair");
        words.Add("soccer");
        words.Add("water");
        words.Add("racket");
        words.Add("table");
        words.Add("late");
        words.Add("media");
        words.Add("desktop");
        words.Add("flipper");
        words.Add("club");
        words.Add("flying");
        words.Add("smooth");
        words.Add("monster");
        words.Add("purple");
        words.Add("guardian");
        words.Add("bold");
        words.Add("hyperlink");
        words.Add("presentation");
        words.Add("world");
        words.Add("national");
        words.Add("comment");
        words.Add("element");
        words.Add("magic");
        words.Add("lion");
        words.Add("sand");
        words.Add("crust");
        words.Add("toast");
        words.Add("jam");
        words.Add("hunter");
        words.Add("forest");
        words.Add("foraging");
        words.Add("silently");
        words.Add("tawesomated");
        words.Add("joshing");
        words.Add("pong");

            chosenWord = "null";
    }
    
    public string GetNextWord(){
        Random random = new Random();
        int currentword = random.Next(0,(words.Count -1));
        chosenWord = words[currentword];
        return chosenWord;
    }
 
    public string CompareWords(string guess){
        string wordCurrentState = "";
        // Goes through each of the letters in the chosen word.
        foreach (var word in chosenWord){
            currentGuessedLetter = false;
            // Goes through each of the different letters that the user has already guessed.
            foreach (var guessed in alreadyGuessed){
                if (Convert.ToString(guessed) == Convert.ToString(word)){
                    wordCurrentState = wordCurrentState + guessed;
                    currentGuessedLetter = true;
                }
            }
            // If you have guessed the chosen letter it will be printed out on the screen
            // and added to a list of guessed words.
            if (guess.Equals(Convert.ToString(word)) && currentGuessedLetter == false){
                wordCurrentState = wordCurrentState + word;
                alreadyGuessed.Add(Convert.ToString(word));
                currentGuessedLetter = true;
                }
            // If there's a space in the chosen word, a space will be added to the chosen word.
            if(string.IsNullOrWhiteSpace(Convert.ToString(word))){
                wordCurrentState = wordCurrentState + " ";
            }
            else if ("\'".Equals(Convert.ToString(word)) && currentGuessedLetter == false){
                wordCurrentState = wordCurrentState + word;
                alreadyGuessed.Add(Convert.ToString(word));
                currentGuessedLetter = true;
                }
            else if ("-".Equals(Convert.ToString(word)) && currentGuessedLetter == false){
                wordCurrentState = wordCurrentState + word;
                alreadyGuessed.Add(Convert.ToString(word));
                currentGuessedLetter = true;
                }
            else if (",".Equals(Convert.ToString(word)) && currentGuessedLetter == false){
                wordCurrentState = wordCurrentState + word;
                alreadyGuessed.Add(Convert.ToString(word));
                currentGuessedLetter = true;
                } 
            else if (currentGuessedLetter == false){
                wordCurrentState = wordCurrentState + "";

            }
        }
        return wordCurrentState;
        }
    }