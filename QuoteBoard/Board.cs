public class Board {
    List<Quote> quotes = new List<Quote>();

    public Board() {
        StartBoard();
    }

    public void NicePrint(string item) {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("----------------------------------------------");
    }

    public void ShowQuotes() {
        foreach(Quote quote in quotes){
            NicePrint(quote.GetQuote());
        }
    }

    public void AddQuote(Quote quote){
        quotes.Add(quote);
    }

    public void getRandomQuote(){
        var random = new Random();
        var rNum = random.Next(0, quotes.Count);
        NicePrint(quotes[rNum].GetQuote());
    }
    
    public void FindQuotesByAuthor(string author){
        foreach(Quote quote in quotes){
            if(quote.HasAuthor(author)){
                NicePrint(quote.GetQuote());
            }
        }
    }

    public void StartBoard(){
        string response = "";
        string[] options= {"A","S","Q","F","R"};
        while(response != "Q"){
            while(options.Contains(response)==false){
                Console.Write("What do you want to do?\n[A]dd quote:\n[S]how quotes\n[Q]uit\n[F]ind Quotes by Author\n[R]andom Quote\n");
                response = Console.ReadLine().ToUpper(); 
            }
            switch(response){
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Console.Write("Please enter your quote: ");
                    string quote = Console.ReadLine();
                    Console.Write("Please enter your author: ");
                    string author = Console.ReadLine();
                    Console.Write("Please enter your source: ");
                    string source = Console.ReadLine();

                    AddQuote(new Quote(author,quote,new Source(source)));
                    break;
                case "S":
                    ShowQuotes();
                    break;
                case "F":
                    Console.Write("Please enter your author: ");
                    author = Console.ReadLine();
                    FindQuotesByAuthor(author); 
                    break;               
                case "R":
                    getRandomQuote();
                    break;
            }
            response = "";
        }
    }
}