using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Cow:Mammal
    {
        protected int hamlatot;

        public Cow(string name, int age, bool isup, int calories, int milkCal, int birthMonth, int hamlatot)
            :base(name, age, isup, calories, milkCal, birthMonth)
        {
            this.hamlatot = hamlatot;
        }

        public int GetHamlatot()
        {
            return this.hamlatot;
        }
        public void SetHamlatot(int hamlatot)
        {
            this.hamlatot=hamlatot;
        }


        public new int Eat()
        {
            return base.Eat()/4;
        } 
    }
}
