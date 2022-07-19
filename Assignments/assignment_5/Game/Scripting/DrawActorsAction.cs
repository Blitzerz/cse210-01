using System.Collections.Generic;
using assignment_5.Game.Casting;
using assignment_5.Game.Services;


namespace assignment_5.Game.Scripting
{
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            List<Actor> snakes = cast.GetActors("snake");
            Snake snake1 = (Snake) snakes[0];
            Snake snake2 = (Snake) snakes[1];
            List<Actor> segments = snake1.GetSegments();
            List<Actor> segments2 = snake2.GetSegments();
            Actor score = cast.GetFirstActor("score");
            // Actor food = cast.GetFirstActor("food");
            List<Actor> messages = cast.GetActors("messages");
            
            videoService.ClearBuffer();
            videoService.DrawActors(segments);
            videoService.DrawActors(segments2);
            videoService.DrawActor(score);
            // videoService.DrawActor(food);
            videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }
}