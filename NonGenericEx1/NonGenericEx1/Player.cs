using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericEx1
{
    public class Player
    {
        private int runs;
        private string name;

        public Player(int runs,string name)
        {
            this.runs = runs;
            this.name = name;
            
        }

        public override string ToString()
        {
            return $"Name={name},Runs={runs}";
        }


        public class Team : IEnumerable
        {
            Player[] player;
            public Team()
            {
                player = new Player[3];
                player[0] = new Player(70, "Rohit");
                player[1] = new Player(50, "Virat");
                player[2] = new Player(35, "Dhoni");
            }

            public IEnumerator GetEnumerator()
            {
                return player.GetEnumerator();
            }
        }

        static void Main(string[] args)
        {
            Team india = new Team();
            foreach (Player p in india)
            {
                Console.WriteLine(p);
            }

        }

    }
}
