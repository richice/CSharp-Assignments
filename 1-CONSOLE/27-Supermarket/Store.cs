using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Supermarket
{
    class Store
    {
        public string   Name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public int Count
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }

        public Store(string name, int count, string ID, double price)
        {
            this.ID = ID;
            this.Count = count;
            this.Name = name;
            this.Price = price;
        }
    }
}
