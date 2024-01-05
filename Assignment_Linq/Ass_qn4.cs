using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_Linq
{
    class Orders
    {
        public int Order_id { get; set; }
        public string item_name { get; set; }
        public DateTime Orderdate { get; set; }
        public int Quantity { get; set; }

        public Orders(int id, string Name, DateTime orderdate, int quantity)
        {
            Order_id = id;
            item_name = Name;
            Orderdate = orderdate;
            Quantity = quantity;

        }
    }
    internal class Ass_qn4
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order (1,"box",DateTime.Parse("2/23/2000"),10),
                new Order (2,"shoes",DateTime.Parse("6/23/2000"),20),
                new Order (3,"crocs",DateTime.Parse("7/23/2000"),30)

            };
            var orderedByMonth = orders.OrderByDescending(o => o.Orderdate).GroupBy(o  => o.Orderdate.Month);
            foreach (var item in orderedByMonth)
            {
                Console.WriteLine($"Month:{item.Key}");

                foreach (var ord in item)
                {
                    Console.WriteLine($"Orderid:{ord.Order_id}, item_name:{ord.item_name},Orderdate:{ord.Orderdate},Quantity:{ord.Quantity}");
                }
            }
        }
    }
}
