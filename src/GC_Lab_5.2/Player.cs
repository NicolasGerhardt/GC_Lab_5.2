using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._2
{
    abstract class Player
    {
        private string name;
        private Roshambo roshambo;

        public Player(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }
        public Roshambo Roshambo { get => roshambo; protected set => roshambo = value; }
        /// <summary>
        /// Gets a new value for the players current Roshambo choice. 
        /// </summary>
        /// <returns>Returns the final Roshambo setting</returns>
        public abstract Roshambo GenerateNextRoshambo();
        public override string ToString()
        {
            return Name;
        }
    }
}
