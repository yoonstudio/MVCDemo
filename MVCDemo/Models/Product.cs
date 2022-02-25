using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Product
    {
        private int productID;
        private string category;
        private string name;
        private string description;
        private int price;

        public int ProductID { get; set; }
        public string Category { get { return category; } set { category = value; } }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priced { get { return productID + price; } set { productID = value; } }
    }
}