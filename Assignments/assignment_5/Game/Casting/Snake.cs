using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment_5.Game.Casting
{

    public class Snake : Actor
    {
        private List<Actor> segments = new List<Actor>();
        Color colorY = Constants.WHITE;

        /// <summary>
        /// Constructs a new instance of a Snake.
        /// </summary>
        public Snake(int x, Color color)
        {
            PrepareBody(x);
            colorY = color;
        }

        /// <summary>
        /// Gets the snake's body segments.
        /// </summary>
        public List<Actor> GetBody()
        {
            return new List<Actor>(segments.Skip(1).ToArray());
        }

        /// <summary>
        /// Gets the snake's head segment.
        /// </summary>
        public Actor GetHead()
        {
            return segments[0];
        }

        /// <summary>
        /// Gets the snake's segments (including the head).
        /// </summary>
        public List<Actor> GetSegments()
        {
            return segments;
        }

        /// <summary>
        /// Grows the snake's tail by the given number of segments.
        /// </summary>
        public void GrowTail(int numberOfSegments)
        {
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor tail = segments.Last<Actor>();
                Point velocity = tail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = tail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("#");
                segment.SetColor(colorY);
                segments.Add(segment);
            }
        }

        /// <inheritdoc/>
        public override void MoveNext()
        {
            foreach (Actor segment in segments)
            {
                segment.MoveNext();
            }

            for (int i = segments.Count - 1; i > 0; i--)
            {
                Actor trailing = segments[i];
                Actor previous = segments[i - 1];
                Point velocity = previous.GetVelocity();
                trailing.SetVelocity(velocity);
            }
            GrowTail(1);

        }

        /// <summary>
        /// Turns the head of the snake in the given direction.
        /// </summary>
        public void TurnHead(Point direction)
        {
            segments[0].SetVelocity(direction);
        }

        /// <summary>
        /// Prepares the snake body for moving.
        /// </summary>
        private void PrepareBody(int x)
        {
            // int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;

            for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            {
                Point position = new Point(x , y - i * Constants.CELL_SIZE);
                Point velocity = new Point(0, 1 * Constants.CELL_SIZE);
                string text = i == 0 ? "8" : "#";
                Color color = i == 0 ? Constants.YELLOW : colorY;

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText(text);
                segment.SetColor(color);
                segments.Add(segment);
            }
        }
    }
}