using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Linq
{
    class Order
    {
        public int Order_id { get; set; }
        public string item_name { get; set; }
        public DateTime Orderdate { get; set; }
        public int Quantity { get; set; }

        public Order(int id,string Name, DateTime orderdate,int quantity)
        {
            Order_id = id;
            item_name = Name;
            Orderdate = orderdate;
            Quantity = quantity;

        }
    }

        internal class Ass_qn3
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order (1,"box",DateTime.Parse("2/23/2000"),10),
                new Order (2,"shoes",DateTime.Parse("6/23/2000"),20),
                new Order (3,"crocs",DateTime.Parse("7/23/2000"),30)

            };
            var orderedByDateAndQuantity = orders.OrderByDescending(o => o.Orderdate).ThenByDescending(o => o.Quantity);
            foreach(var order in orderedByDateAndQuantity)
            {
                Console.WriteLine($"Orderid:{order.Order_id}, item_name:{order.item_name},Orderdate:{order.Orderdate},Quantity:{order.Quantity}");
            }

        }
    }
}
