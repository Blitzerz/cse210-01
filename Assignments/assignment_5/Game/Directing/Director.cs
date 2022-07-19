using System.Collections.Generic;
using assignment_5.Game.Casting;
using assignment_5.Game.Scripting;
using assignment_5.Game.Services;


namespace assignment_5.Game.Directing
{

    public class Director
    {
        private VideoService videoService = null;

        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        public Director(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast and script.
        /// </summary>
        public void StartGame(Cast cast, Script script)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                ExecuteActions("input", cast, script);
                ExecuteActions("update", cast, script);
                ExecuteActions("output", cast, script);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Calls execute for each action in the given group.
        /// </summary>
        private void ExecuteActions(string group, Cast cast, Script script)
        {
            List<Action> actions = script.GetActions(group);
            foreach(Action action in actions)
            {
                action.Execute(cast, script);
            }
        }
    }
}