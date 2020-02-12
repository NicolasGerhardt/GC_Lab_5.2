using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._2
{
    abstract class Player
    {
        private string name;
        private Roshambo roshambo;

        protected Player(string name)
        {
            Name = name;
        }

        public string Name { get => name; protected set => name = value; }
        public Roshambo Roshambo { get => roshambo; protected set => roshambo = value; }
        protected abstract Roshambo GenerateNextRoshambo();
    }
}
