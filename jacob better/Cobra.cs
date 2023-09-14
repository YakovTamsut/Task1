using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Cobra:Snake
    {
        protected int speed;

        public Cobra(string name, int age, bool isup, int calories, double tailength, bool venomous, int speed)
            : base(name, age, isup, calories, tailength, venomous)
        {
            this.speed = speed;
        }
        public int Getspeed()
        {
            return this.speed;
        }
        public void Setspeed(int speed)
        {
            this.speed = speed;
        }
    }
}
