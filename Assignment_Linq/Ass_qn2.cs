using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Linq
{
    class Player
    {
        public Player(string name, string country)
        {
            Name = name;
            Country = country;
        }
        public string Name { get; set; }
        public string Country { get; set; }
    }
    internal class Ass_qn2
    {
     static void Main()
        {
            {
                List<Player> list = new List<Player>()
            {
                new Player("player1", "Argentina"),
                new Player("player2", "India"),
            };
                List<Player> list1 = new List<Player>()
            {
                new Player("player3", "India"),
                new Player("player4", "US"),
            };
                var RESULT = from l1 in list
                             from L2 in list1
                             where l1.Country != L2.Country
                             select new { op = l1.Name, op1 = L2.Name };
                foreach (var p in RESULT)

                    Console.WriteLine($"{p.op}*{p.op1}");

            }

        }
    }
}
