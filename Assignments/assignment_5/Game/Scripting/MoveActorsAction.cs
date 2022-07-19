using System.Collections.Generic;
using assignment_5.Game.Casting;
using assignment_5.Game.Services;


namespace assignment_5.Game.Scripting
{
    public class MoveActorsAction : Action
    {
        /// <summary>
        /// Constructs a new instance of MoveActorsAction.
        /// </summary>
        public MoveActorsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            List<Actor> actors = cast.GetAllActors();
            foreach (Actor actor in actors)
            {
                actor.MoveNext();
            }
        }
    }
}