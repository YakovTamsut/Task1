using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Animals
    {
        protected string name;
        protected int age;
        protected bool isup;
        protected int calories;

        public Animals(string name, int age, bool isup, int calories) 
        {
            this.name = name;
            this.age = age;
            this.isup = isup;
            this.calories = calories;
        }

        public string GetName()
        {
            return this.name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public bool Isup()
        {
            return this.isup;
        }
        public int GetCalories()
        {
            return this.calories;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetIsup(bool isup)
        {
            this.isup = isup;
        }
        public void SetCalories(int calories)
        {
            this.calories = calories;
        }

        public override string ToString()
        {
            return $"{name}, {age}, {isup}, {calories}";
        }

        public int Eat()
        {
            return this.calories*3;
        }

    }
}
