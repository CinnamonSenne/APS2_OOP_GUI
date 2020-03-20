using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobbelspel
{
    class Dobbelsteen
    {
        static Random random = new Random();
        public int Gooi()
        {
            return random.Next(1, 7);
        }
    }
}
