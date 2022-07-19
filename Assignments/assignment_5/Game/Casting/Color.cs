using System.Collections.Generic;


namespace assignment_5.Game.Casting
{
    public class Color
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;

        /// <summary>
        /// Constructs a new instance of Color using the given red, green and blue values.
        /// </summary>
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        /// <summary>
        /// Gets the color's alpha value.
        /// </summary>
        public int GetAlpha()
        {
            return alpha;
        }

        /// <summary>
        /// Gets the color's blue value.
        /// </summary>
        public int GetBlue()
        {
            return blue;
        }

        /// <summary>
        /// Gets the color's green value.
        /// </summary>
        public int GetGreen()
        {
            return green;
        }

        /// <summary>
        /// Gets the color's red value.
        /// </summary>
        public int GetRed()
        {
            return red;
        }

    }
}