using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Reptile:Animals,IReptile
    {
        protected double tailength;

        public Reptile(string name, int age, bool isup, int calories, double tailength)
            :base(name,age,isup,calories)
        {
            this.tailength = tailength;
        }

        public void Crawl()
        {
            Console.WriteLine("crawl");
        }

        public void Defend()
        {
            Console.WriteLine("defend");
        }

        public void Heat()
        {
            Console.WriteLine("heat");
        }
        public double GetTailength()
        {
            return this.tailength;
        }
        public void SetTailength(double tailength)
        {
            this.tailength=tailength;
        }
        public override string ToString()
        {
            return base.ToString() + $",{tailength}";
        }


    }
}
