using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Linq
{
    class Orderss
    {
        public int Order_id { get; set; }
        public string item_name { get; set; }
        public DateTime Orderdate { get; set; }
        public int Quantity { get; set; }

        public Orderss(int id, string Name, DateTime orderdate, int quantity)
        {
            Order_id = id;
            item_name = Name;
            Orderdate = orderdate;
            Quantity = quantity;

        }
    }
    internal class Ass_Qn7
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order(1,"box",DateTime.Parse("2/23/2000"),10),
                new Order (2,"shoes",DateTime.Parse("6/23/2000"),20),
                new Order (3,"crocs",DateTime.Parse("7/23/2000"),30),
                new Order (4,"shooters",DateTime.Parse("1/23/2000"),0)

            };
            var result = from s in orders
                         where s.Quantity > 0
                         select s;
            foreach (var item in result)
            {
                Console.WriteLine(item.Quantity);
            }
            var result1 = from s1 in orders
                        orderby s1.item_name
                         select s1;
            foreach (var item in result1)
            {
                Console.WriteLine(item.item_name);
            }
            var result2= from s3 in orders
                         where s3.Orderdate.Month > 6
                         select s3;
            foreach (var item in result2)
            {
                Console.WriteLine(item.Orderdate);
            }
        }
    }
}
