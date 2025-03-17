using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject1"), InternalsVisibleTo("App")]
namespace PWR_dotNER_Pr1
{
    class Problem
    {
        private List<Item> items = new List<Item>();
        public List<Item> Items 
        {
            get { return items; }
        }
        private int n;
        public Problem()
        {
            this.n = 0;
        }
        public Problem(int n, int seed)
        {
            Random random = new Random(seed);
            this.n = n;
            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(i, random));
            }
        }
        public void ItemAdd(int w, int p)
        {
            items.Add(new Item(this.n, w, p));
            this.n++;
        }
        public override string ToString()
        {
            string result = "";
            foreach (var item in items)
            {
                result += item.ToString() + Environment.NewLine;
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
                if (actualCapacity + item.Weight <= capacity)
                {
                    result += $"{item.Id} ";
                    actualCapacity += item.Weight;
                    actualPrice += item.Price;
                }
                else
                    break; 
            }
            result += Environment.NewLine + $"Waga plecaka: {actualCapacity}"+ Environment.NewLine + $"Cena plecaka: {actualPrice}";
            return result;
        }
    }
}
