namespace assignment_5.Game.Casting
{

    public class Point
    {
        private int x = 0;
        private int y = 0;

        /// <summary>
        /// Constructs a new instance of Point using the given x and y values.
        /// </summary>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Adds the given point to this one by summing the x and y values.
        /// </summary>
        public Point Add(Point other)
        {
            int x = this.x + other.GetX();
            int y = this.y + other.GetY();
            return new Point(x, y);
        }

        /// <summary>
        /// Whether or not this Point is equal to the given one.
        /// </summary>
        public bool Equals(Point other)
        {
            return this.x == other.GetX() && this.y == other.GetY();
        }

        /// <summary>
        /// Gets the value of the x coordinate.
        /// </summary>
        public int GetX()
        {
            return x;
        }

        /// <summary>
        /// Gets the value of the y coordinate.
        /// </summary>
        public int GetY()
        {
            return y;
        }

        /// <summary>
        /// Reverses the point by inverting both x and y values.
        /// </summary>
        public Point Reverse()
        {
            int x = this.x * -1;
            int y = this.y * -1;
            return new Point(x, y);
        }
        
        /// <summary>
        /// Scales the point by multiplying the x and y values by the provided factor.
        /// </summary>
        public Point Scale(int factor)
        {
            int x = this.x * factor;
            int y = this.y * factor;
            return new Point(x, y);
        }
    }
}