using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Crocodile:Reptile
    {
        protected bool isTeeth;

        public Crocodile(string name, int age, bool isup, int calories, double tailength, bool isTeeth)
            : base(name, age, isup, calories, tailength)
        {
            this.isTeeth = isTeeth;
        }
        public bool GetIsTeeth()
        {
            return this.isTeeth;
        }
        public void SetIsTheeth(bool isTeeth)
        {
            this.isTeeth = isTeeth;
        }
    }
}
