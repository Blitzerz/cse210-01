using assignment_5.Game.Casting;
using assignment_5.Game.Directing;
using assignment_5.Game.Scripting;
using assignment_5.Game.Services;


namespace assignment_5.Game
{
    /// <summary>
    /// Start the program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        static void Main(string[] args)
        {
            // Create the cast.
            Cast cast = new Cast();
            Color colorG = new Color(0, 255, 0);
            Color colorR = new Color(0, 0, 255);
            cast.AddActor("food", new Food());
            cast.AddActor("snake", new Snake(200, colorG));
            cast.AddActor("score", new Score());
            cast.AddActor("snake", new Snake(605, colorR));
            

            // Create the services.
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // Create the script.
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // Start the game.
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}