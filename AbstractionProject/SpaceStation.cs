using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionProject
{
    public abstract class SpaceStation
    {
        public abstract void FireLaser();
    }

    public class DeathStar : SpaceStation
    {
        public override void FireLaser()
        {
            Console.WriteLine("Pew Pew");
        }
    }
}
