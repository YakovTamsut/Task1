using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jacob_better
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Moshe", "Pinhas", "Leon", "Moshiko","Igor","Muhamad","Srulik","Rabi","Ahmed"};
            Random rnd = new Random();


            Mammal[] arrMammal =
            {
                new Mammal(names[rnd.Next(1,6)], rnd.Next(1,120), false, rnd.Next(500,5000),rnd.Next(500,5000),rnd.Next(1,30)),
                new Cow(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(500,5000),rnd.Next(1,30), 12),
                new Mammal(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(500,5000),rnd.Next(1,30)),
                new Mammal(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(500,5000), rnd.Next(1,30)),
                new Mammal(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(500,5000), rnd.Next(1,30)),
            };
            foreach (Animals item in arrMammal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Reptile[] arrReptile =
            {
                new Reptile(names[rnd.Next(1,6)], rnd.Next(1,120), false, rnd.Next(500,5000),rnd.Next(30,200)),
                new Snake(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(30,200), true),
                new Reptile(names[rnd.Next(1,6)], rnd.Next(1,120), false, rnd.Next(500,5000),rnd.Next(30,200)),
                new Reptile(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(30,200)),
                new Reptile(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(30,200)),
            };
            foreach (Animals item in arrReptile)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Animals[] arrAnimals =
            {
                new Animals(names[rnd.Next(1,6)], rnd.Next(1,120), false, rnd.Next(500,5000)),
                new Mammal(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(500,5000),rnd.Next(1,30)),
                new Hipo(names[rnd.Next(1,6)], rnd.Next(1,120), false, rnd.Next(500,5000),rnd.Next(500,5000),rnd.Next(1,12),rnd.Next(40,80)),
                new Hipo(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000),rnd.Next(500,5000),rnd.Next(1,12),rnd.Next(40,80)),
                new Animals(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000)),
                new Reptile(names[rnd.Next(1,6)], rnd.Next(1,120), false, rnd.Next(500,5000),rnd.Next(30,200)),
                new Animals(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000)),
                new Animals(names[rnd.Next(1,6)], rnd.Next(1,120), true, rnd.Next(500,5000)),
            };
            foreach (Animals item in arrAnimals)
            {
                Console.WriteLine(item);
            }
            Bird moshe = new Bird(names[rnd.Next(1, 6)], rnd.Next(1, 120), false, rnd.Next(500, 5000), 5, 5);
            moshe.Dance();
            Console.WriteLine(FattestHipo(arrAnimals));
            

        }
        public static int CountCalories(Animals[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count += arr[i].Eat();
            }
            return count;
        }
        public static int CountMammals(Animals[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Mammal)
                {
                    count++;
                }
            }
            return count;
        }
        public static void StartDance(Animals[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Snake)
                {
                    ((Snake)arr[i]).Dance();
                }
                if (arr[i] is Bird)
                {
                    ((Bird)arr[i]).Dance();
                }
            }
        }
        public static string FattestHipo(Animals[] arr)
        {
            int max = 0;
            string name = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Hipo)
                {
                    if (((Hipo)arr[i]).GetFatPrecentage() > max)
                    {
                        max = ((Hipo)arr[i]).GetFatPrecentage();
                        name = arr[i].GetName();
                    }
                }
            }
            return name;
        }


    }
}
