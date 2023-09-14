using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Mammal:Animals
    {
        protected int milkCal;
        protected int birthMonth;
        public Mammal(string name, int age, bool isup, int calories, int milkCal, int birthMonth)
            :base(name, age, isup,calories)
        {
            this.milkCal = milkCal;
            this.birthMonth = birthMonth;
        }
        public int GetMilkCal()
        {
            return this.milkCal;
        }
        public int GetBirthMonth()
        {
            return this.birthMonth;
        }
        public void SetMilCal(int milkCal)
        {
            this.milkCal = milkCal;
        }
        public void SetBirthMonth(int birthMonth)
        {
            this.birthMonth = birthMonth;
        }
        public override string ToString()
        {
            return base.ToString() + $", {milkCal}, {birthMonth}";
        }

        public new int Eat()
        {
            return base.Eat() + milkCal;
        }
    }
}
