using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._2
{
     class Rocky : Player
    {
        public Rocky(string name) : base(name) 
        {
            this.Roshambo = Roshambo.Rock;
        }

        public override Roshambo GenerateNextRoshambo()
        {
            return this.Roshambo;
        }
    }
}
