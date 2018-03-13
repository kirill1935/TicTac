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

        public void Tic(){
            Console.Write("Tic-");
            state = 2;
        }
        public void Tak(){
            Console.WriteLine("Tak");
            state = 1;
        }
    }
}
