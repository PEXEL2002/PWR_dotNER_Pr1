using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWR_dotNER_Pr1
{
    class Item
    {
        private int id;
        public int Id
        {
            get { return this.id; }
        }
        private int weight;
        public int Weight
        {
            get { return this.weight; }
        }
        private int price;
        public int Price
        {
            get { return this.price; }
        }
        private double ratio;
        public double Ratio
        {
            get { return this.ratio; }
        }
        public Item(int id, Random random)
        {
            this.id = id;
            this.weight = random.Next(1, 10);
            this.price = random.Next(1, 10);
            this.ratio = (double)price / weight;
        }
        public override string ToString()
        {
            return $"ID: {id}, Waga: {weight}, Cena: {price}, Stosunek cena/waga: {ratio:F2}";
        }
    }
}
