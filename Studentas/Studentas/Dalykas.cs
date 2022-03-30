using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentas
{
    class Dalykas
    {
        public string d;
        public int nd;

        public Dalykas(string d, int nd)
        {
            this.d = d;
            this.nd = nd;
        }

        public Dalykas()
        {

        }

        public string GetDalykas()
        {
            return d;
        }
        
        public int GetDalykuKiekis()
        {
            return nd;
        }
    }
}
