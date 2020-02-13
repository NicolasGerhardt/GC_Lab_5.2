using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._2
{
     class Rando : Player
    {
        private Random rand;

        public Rando(string name) : base(name)
        {
            rand = new Random();
        }

        public override Roshambo GenerateNextRoshambo()
        {
            string[] RPSList = Enum.GetNames(typeof(Roshambo));
            int randChoice = rand.Next(RPSList.Length);
            this.Roshambo = (Roshambo)randChoice;
            return this.Roshambo;
        }
    }
}
