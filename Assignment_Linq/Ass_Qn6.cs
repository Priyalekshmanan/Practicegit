using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Linq
{
    class Items
    {
        public string item_name { get; set; }
        public int price { get; set; }
        public Items(string item, int prc)
        {
            item_name = item;
            price = prc;
        }


    }
    class TotalPrice
    {
        public int Order_id { get; set; }
        public string item_name { get; set; }
        public DateTime Orderdate { get; set; }
        public double totalprice { get; set; }


        public TotalPrice(int id, string item, DateTime dt, double totalprice)

        {
            Order_id = id;
            item_name = item;
            Orderdate = dt;
            this.totalprice = totalprice;

        }
    }
    internal class Ass_Qn6
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

            var result = from s in orders
                             join e in items
                             on s.item_name equals e.item_name
                             let i = s.Quantity * e.Price
                             select new TotalPrice(s.Order_id, s.item_name, s.Orderdate,i);
                var res1 = from t in result
                           orderby t.Orderdate
                           group t by t.Orderdate.Month;


                foreach (var item in res1)
                {
                    Console.WriteLine($"month={item.Key}");
                    foreach (var order in item)
                    {
                        Console.WriteLine($"orderId={order.Order_id},Iteam name={order.item_name},,OrderDate={order.Orderdate},totalprice={order.totalprice}");
                    }
                }


            }

        }
    }

