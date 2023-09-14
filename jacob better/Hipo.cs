using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Hipo:Mammal
    {
        protected int fatPrecentage;

        public Hipo(string name, int age, bool isup, int calories, int milkCal, int birthMonth, int fatPrecentage)
            : base(name, age, isup, calories, milkCal, birthMonth)
        {
            this.fatPrecentage = fatPrecentage;
        }

        public int GetFatPrecentage()
        {
            return this.fatPrecentage;
        }
        public void SetFatPrecentage(int fatPrecentage)
        {
            this.fatPrecentage = fatPrecentage;
        }
    }
}
