using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._2
{
    class Human : Player
    {

        public Human(string name) : base (name) {
        }
        public override Roshambo GenerateNextRoshambo()
        {
            this.Roshambo = UI.GetRoshamboFromUser(Name);

            return this.Roshambo;
        }
    }
}
