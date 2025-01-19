using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Fruit
    {
        private string fruit_name, fruit_id;
        private int price;
        private int quantity;
        private string origin;

        public Fruit(string fruit_id, string fruit_name, int price, int quantity, string origin)
        {
            Fruit_Id = fruit_id;
            Fruit_Name = fruit_name;
            this.price = price;
            this.quantity = quantity;
            Origin = origin;
        }
        public string Fruit_Id { get; set; }
        public string Fruit_Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Origin { get; set; }
        public string ToString()
        {
            return string.Format("|%-10s|%-11s|%-3d|", fruit_name, quantity, price);
        }
    }
}
