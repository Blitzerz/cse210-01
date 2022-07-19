namespace assignment_4.Game.Casting
{
    public class Artifact : Actor
    {
        private string message = "";

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public Artifact()
        {
        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        public string GetMessage()
        {
            return message;
        }

        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        public void SetMessage(string message)
        {
            this.message = message;
        }
    }
}