using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentas
{
    class Pazymis
    {
        public int[] p = new int[100];

        public Pazymis(int[] p)
        {
            this.p = p;
        }

        public Pazymis()
        {

        }

        public int[] GetPazymis()
        {
            return p;
        }
    }
}
