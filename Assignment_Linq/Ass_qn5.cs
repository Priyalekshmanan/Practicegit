using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Linq
{
    class Order_1
    {
        public int Order_id { get; set; }
        public string item_name { get; set; }
        public DateTime Orderdate { get; set; }
        public int Quantity { get; set; }

        public Order_1(int id, string Name, DateTime orderdate, int quantity)
        {
            Order_id = id;
            item_name = Name;
            Orderdate = orderdate;
            Quantity = quantity;

        }
    }
    class Item
    {
        public string item_name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            item_name = name;
            Price = price;
        }
    }
    class Orderitem
    {
        private double price;

        public int Order_id { get; set; }
        public string item_name { get; set; }
        public DateTime Orderdate { get; set; }
        public double total_price {  get; set; }
        public Orderitem(int id,string name, double price,DateTime orderdate,double total)
        {
            Order_id = id;
            item_name = name;
            Orderdate = orderdate;
            total_price = total;
        
        
        
        }

        public Orderitem(int order_id, string item_name, DateTime orderdate, double price)
        {
            Order_id = order_id;
            this.item_name = item_name;
            Orderdate = orderdate;
            this.price = price;
        }
    }
    internal class Ass_qn5
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new Order(1,"box",DateTime.Parse("2/23/2000"),10),
                new Order (2,"shoes",DateTime.Parse("6/23/2000"),20),
                new Order (3,"crocs",DateTime.Parse("7/23/2000"),30)

            };
            List<Item> items = new List<Item>()
            {
            new Item("shoes",1200),
            new Item("pencil",50),
            new Item("crocs",2000)
            };
            var RESULT = from s in orders
                         join e in items
                         on s.item_name equals e.item_name
                         //select new Orderitem(s.Order_id, s.item_name, s.Orderdate,e.Price);
                         select new { id = s.Order_id, name = s.item_name, dt = s.Orderdate, price = (s.Quantity * e.Price) };
            //fetch student with enrollment course using join
            foreach (var item in RESULT)
            {
                Console.WriteLine($"ID:{item.id} Name :{item.name} Orderdate :{item.dt} totalPrice:{item.price}");
            }
            var orderedByMonth = orders.OrderByDescending(o => o.Orderdate).GroupBy(o => o.Orderdate.Month);

            
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
