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
            get { return this.Weight; }
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
            this.ratio = Convert.ToDouble(this.weight) / Convert.ToDouble(this.price);
        }
        public override string ToString()
        {
            return $"id: {this.id} weight: {this.weight} price: {this.price} price-to-weight-ratio : {this.ratio}";
        }
    }
}
