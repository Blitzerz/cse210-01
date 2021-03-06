using System;
using System.Collections.Generic;
using System.Data;
using assignment_5.Game.Casting;
using assignment_5.Game.Services;


namespace assignment_5.Game.Scripting
{
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false)
            {
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        private void HandleSegmentCollisions(Cast cast)
        {
            List<Actor> snakes = cast.GetActors("snake");
            Snake snake1 = (Snake) snakes[0];
            Snake snake2 = (Snake) snakes[1];
            Actor head = snake1.GetHead();
            List<Actor> body = snake1.GetBody();
            Actor head2 = snake2.GetHead();
            List<Actor> body2 = snake2.GetBody();

            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head.GetPosition()))
                {
                    isGameOver = true;

                }
            }
            foreach (Actor segment2 in body2)
            {
                if (segment2.GetPosition().Equals(head2.GetPosition()))
                {
                    isGameOver = true;

                }
            }
            
            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head2.GetPosition()))
                {
                    isGameOver = true;

                }
            }
            foreach (Actor segment2 in body2)
            {
                if (segment2.GetPosition().Equals(head.GetPosition()))
                {
                    isGameOver = true;

                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver == true)
            {
            List<Actor> snakes = cast.GetActors("snake");
            Snake snake1 = (Snake) snakes[0];
            Snake snake2 = (Snake) snakes[1];
            List<Actor> segments = snake1.GetSegments();
            List<Actor> segments2 = snake2.GetSegments();

                // Create a "game over" message.
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // Make everything white.
                foreach (Actor segment in segments)
                {
                    segment.SetColor(Constants.WHITE);
                    snake1.SetColor(Constants.WHITE);
                }

                foreach (Actor segment2 in segments2)
                {
                    segment2.SetColor(Constants.WHITE);
                    snake2.SetColor(Constants.WHITE);
                }
                
            }
        }

    }
}