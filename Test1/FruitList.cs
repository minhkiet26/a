using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class FruitList : List<Fruit>
    {
        public void Create()
        {
            do
            {
                string fruit_id = Utils.GetString("Input ID: ");
                string fruit_name = Utils.GetString("Input Name: ");
                int price = Utils.GetInteger("Input Price: ");
                int quantity = Utils.GetInteger("Input Quantity: ");
                string origin = Utils.GetString("Input Origin: ");
                if (!Utils.Confirm("Do u want to continue"))
                {
                    Add(new Fruit(fruit_id, fruit_name, price, quantity, origin)); 
                }
            } while (Utils.Confirm("Do u want to continue"));
            Console.WriteLine("Adding successfully");
        }

    }
}
