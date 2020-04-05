using System;
using System.Collections.Generic;
namespace Lab3
{
    public class Product
    {
        private string name;
        private int price;
        private string brand;
        private string description;
        private int stock;

        public Product(string name,int price, string brand,string description, int stock)
        {
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.description = description;
            this.stock = stock;
        }

        public string Name
        {
            get { return name; }
        }

        public int Price
        {
            get { return price; }

        }
        public string Brand
        {
            get { return brand; }
            
        }

        public string Description
        {
            get { return description; }
            
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }

        }


    }
}
