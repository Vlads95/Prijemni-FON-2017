using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijemni_FON_2017
{

    public enum Rezultat { Tacan, Netacan, Neutralan, Negativan }
    public class Odgovor
    {

        int redniBrOdgovora;
        Rezultat rezultat;

        public Odgovor(
            int redniBrOdgovora,
        Rezultat rezultat )
        {
            this.redniBrOdgovora = redniBrOdgovora;
            this.rezultat = rezultat;
        }

        public int RedniBrOdgovora { get => redniBrOdgovora; set => redniBrOdgovora = value; }
        public Rezultat Rezultat { get => rezultat; set => rezultat = value; }
    }
}
