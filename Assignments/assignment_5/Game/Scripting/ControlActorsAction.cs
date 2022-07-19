using assignment_5.Game.Casting;
using assignment_5.Game.Services;
using System.Collections.Generic;

namespace assignment_5.Game.Scripting
{
    public class ControlActorsAction : Action
    {
        private KeyboardService keyboardService;
        private Point direction = new Point(0, -1 * Constants.CELL_SIZE);
        private Point direction2 = new Point(0, -1 * Constants.CELL_SIZE);


        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // Left
            if (keyboardService.IsKeyDown("a"))
            {
                direction = new Point(-Constants.CELL_SIZE, 0);
            }

            // Right
            if (keyboardService.IsKeyDown("d"))
            {
                direction = new Point(Constants.CELL_SIZE, 0);
            }

            // Up
            if (keyboardService.IsKeyDown("w"))
            {
                direction = new Point(0, -Constants.CELL_SIZE);
            }

            // Down
            if (keyboardService.IsKeyDown("s"))
            {
                direction = new Point(0, Constants.CELL_SIZE);
            }
            // Snake 2
            // Left
            if (keyboardService.IsKeyDown("j"))
            {
                direction2 = new Point(-Constants.CELL_SIZE, 0);
            }

            // Right
            if (keyboardService.IsKeyDown("l"))
            {
                direction2 = new Point(Constants.CELL_SIZE, 0);
            }

            // Up
            if (keyboardService.IsKeyDown("i"))
            {
                direction2 = new Point(0, -Constants.CELL_SIZE);
            }

            // Down
            if (keyboardService.IsKeyDown("k"))
            {
                direction2 = new Point(0, Constants.CELL_SIZE);
            }
            // Snake snake = (Snake)cast.GetFirstActor("snake");
            List<Actor> snakes = cast.GetActors("snake");
            Snake snake1 = (Snake) snakes[0];
            Snake snake2 = (Snake) snakes[1];
            snake1.TurnHead(direction);
            snake2.TurnHead(direction2);
        }
    }
}