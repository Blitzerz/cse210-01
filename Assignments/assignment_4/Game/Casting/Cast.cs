using System.Collections.Generic;


namespace assignment_4.Game.Casting
{

    public class Cast
    {
        private Dictionary<string, List<Actor>> actors = new Dictionary<string, List<Actor>>();

        /// <summary>
        /// Constructs a new instance of Cast.
        /// </summary>
        public Cast()
        {
        }

        /// <summary>
        /// Adds the given actor to the given group.
        /// </summary>
        public void AddActor(string group, Actor actor)
        {
            if (!actors.ContainsKey(group))
            {
                actors[group] = new List<Actor>();
            }

            if (!actors[group].Contains(actor))
            {
                actors[group].Add(actor);
            }
        }

        /// <summary>
        /// Gets the actors in the given group. Returns an empty list if there aren't any.
        /// </summary>
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (actors.ContainsKey(group))
            {
                results.AddRange(actors[group]);
            }
            return results;
        }

        /// <summary>
        /// Gets all the actors in the cast.
        /// </summary>
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        /// <summary>
        /// Gets the first actor in the given group.
        /// </summary>
        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (actors.ContainsKey(group))
            {
                if (actors[group].Count > 0)
                {
                    result = actors[group][0];
                }
            }
            return result;
        }

        /// <summary>
        /// Removes the given actor from the given group.
        /// </summary>
        public void RemoveActor(string group, Actor actor)
        {
            if (actors.ContainsKey(group))
            {
                actors[group].Remove(actor);
            }
        }

    }
}