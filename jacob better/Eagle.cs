using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Eagle:Bird
    {
        protected bool isStrong;

        public Eagle(string name, int age, bool isup, int calories, int flightHeight, int WingSize, bool isStrong)
            :base(name, age, isup, calories, flightHeight, WingSize)
        {
            this.isStrong = isStrong;
        }
        
        public bool GetIsStrong()
        {
            return isStrong;
        }
        public void SetIsStrong(bool isStrong)
        {
            this.isStrong = isStrong;
        }
    }
}
