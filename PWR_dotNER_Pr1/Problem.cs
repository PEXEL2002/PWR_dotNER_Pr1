using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWR_dotNER_Pr1
{
    class Problem
    {
        private List<Item> items = new List<Item>();
        private int n;
        public Problem(int n, int seed)
        {
            Random random = new Random(seed);
            this.n = n;
            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(i, random));
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += items[i].ToString() + "\n";
            }
            return result;
        }

        public string Solver(int capacity)
        {
            string result = "Moje przedmioty: ";
            int actualCapacity = 0;
            int actualPrice = 0;
            items.Sort((x, y) => y.Ratio.CompareTo(x.Ratio));
            for (int i = 0; i < this.n; i++)
            {
                if (actualCapacity >= capacity) break;
                else
                {
                    result += $"{items[i].Id} ";
                    actualCapacity += items[i].Weight;
                    actualPrice += items[i].Price;
                }
            }
            result += $"\n waga plecaka: {actualCapacity}\n cena plecaka: {actualPrice}";
            return result;
        }
    }
}
