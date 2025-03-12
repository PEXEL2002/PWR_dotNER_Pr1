using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWR_dotNER_Pr1{
    class Item {
        private int id;
        public int Id{
            get { return this.id; }
        }
        private int weight;
        public int Weight{
            get { return this.Weight; }
        }
        private int price;
        public int Price{
            get { return this.price; }
        }
        private float ratio;
        public float Ratio{
            get { return this.ratio; }
        }
        public Item(int id, int seed){
            Random random = new Random(seed);
            this.id = id;
            this.weight = random.Next(10);
            this.price = random.Next(10);
        }
        void toString(){
            Console.WriteLine($"id: {this.id} weight: {this.weight} price: {this.price} price to weight ratio : {this.ratio}");
        }
    }
}
