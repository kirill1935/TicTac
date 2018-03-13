using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{
    class Resource
    {
        private int state = 1;

        public int getState() { return state; }

        public void Tuc()
        {
            Console.WriteLine("Tuc");
            state = 1;
        }

        public void Tic(){
            Console.Write("Tic-");
            state = 2;
        }
        public void Tak(){
            Console.Write("Tak-");
            state = 3;
        }
    }
}
