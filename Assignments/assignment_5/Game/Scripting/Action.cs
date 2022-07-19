using assignment_5.Game.Casting;


namespace assignment_5.Game.Scripting
{
    public interface Action
    {
        /// <summary>
        /// Executes something that is important in the game. This method should be overriden by 
        /// derived classes.
        /// </summary>
        void Execute(Cast cast, Script script);
    }
}