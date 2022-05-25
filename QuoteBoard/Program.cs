public class Program{
    static void Main() {
        Source s = new Source("The Living Christ");
        System.Console.WriteLine(s.getName());

        Quote q = new Quote("Paul", "God hath not given us the spirit of fear;", new Source("2 Timothy 1:7"));
        Console.WriteLine(q.GetQuote());

        Board b = new Board();
        Console.WriteLine(b);
    }
}