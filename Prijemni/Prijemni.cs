using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prijemni_FON_2017;

namespace Prijemni
{
    class Prijemni
    {

        DateTime datum;
        List<Ranglista> skupListi;

        public Prijemni(DateTime datum)
        {
            this.datum = datum;
            skupListi = new List<Ranglista>();

        }

        public DateTime Datum { get => datum; set => datum = value; }
        public List<Ranglista> SkupListi { get => skupListi; set => skupListi = value; }

        static void Main(string[] args)
        {
        }
    }
}
