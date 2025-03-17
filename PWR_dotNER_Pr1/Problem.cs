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
            foreach (var item in items)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }

        public string Solver(int capacity)
        {
            string result = "Moje przedmioty: ";
            int actualCapacity = 0;
            int actualPrice = 0;

            items.Sort((x, y) => y.Ratio.CompareTo(x.Ratio));

            foreach (var item in items)
            {
                if (actualCapacity + item.Weight > capacity) break;

                result += $"{item.Id} ";
                actualCapacity += item.Weight;
                actualPrice += item.Price;
            }

            result += $"\nWaga plecaka: {actualCapacity}\nCena plecaka: {actualPrice}";
            return result;
        }
    }
}
