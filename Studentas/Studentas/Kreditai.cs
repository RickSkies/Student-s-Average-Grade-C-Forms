using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentas
{
    class Kreditai
    {
        public int[] k = new int[100];

        public Kreditai(int[] k)
        {
            this.k = k;
        }

        public Kreditai()
        {

        }

        public int[] GetKreditai()
        {
            return k;
        }
    }
}
