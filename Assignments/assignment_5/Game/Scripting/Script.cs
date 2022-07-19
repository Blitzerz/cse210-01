using System.Collections.Generic;


namespace assignment_5.Game.Scripting
{
    public class Script
    {
        private Dictionary<string, List<Action>> actions = new Dictionary<string, List<Action>>();

        /// <summary>
        /// Constructs a new instance of Script.
        /// </summary>
        public Script()
        {
        }

        /// <summary>
        /// Adds the given action to the given group.
        /// </summary>
        public void AddAction(string group, Action action)
        {
            if (!actions.ContainsKey(group))
            {
                actions[group] = new List<Action>();
            }

            if (!actions[group].Contains(action))
            {
                actions[group].Add(action);
            }
        }

        /// <summary>
        /// Gets the actions in the given group. Returns an empty list if there aren't any.
        /// </summary>
        public List<Action> GetActions(string group)
        {
            List<Action> results = new List<Action>();
            if (actions.ContainsKey(group))
            {
                results.AddRange(actions[group]);
            }
            return results;
        }

        /// <summary>
        /// Removes the given action from the given group.
        /// </summary>
        public void RemoveActor(string group, Action action)
        {
            if (actions.ContainsKey(group))
            {
                actions[group].Remove(action);
            }
        }

    }
}