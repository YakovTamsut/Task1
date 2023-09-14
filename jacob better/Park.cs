using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Park
    {
        protected Animals[] arr;
        protected int current;

        public Park()
        {
            this.arr = new Animals[1000];
            this.current = 0;
        }
        public void AddAnimal(Animals animal)
        {
            if (current < 1000)
            {
                this.arr[current + 1] = animal;
                current++;
            }
            else
            {
                Console.WriteLine("full cant add");
            }
        }
        public List<Animals> IsAdultToref()
        {
            List<Animals> list = new List<Animals>();
            for (int i = 0; i < this.arr.length; i++)
            {
                if (arr[i]!=null)
                {
                    if (arr[i].GetSup() && arr[i].GetAge()>10)
                    {
                        list.Add(arr[i]);
                    }
                }
            }
            return list;
        }
        public int CountReptileToref()
        {
            int count = 0
            for (int i = 0; i < this.arr.length; i++)
            {
                if (arr[i] != null)
                {
                    if (arr[i].IsSup() && arr[i] is Reptile)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

    }
}
