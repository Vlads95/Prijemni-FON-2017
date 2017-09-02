using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijemni_FON_2017
{
   public class Ranglista
    {


        int godina;
        List<Kandidat> spisakKandidata;
        public Ranglista(int godina )
        {
            this.Godina = godina;
            SpisakKandidata = new List<Kandidat>();
        }

        public int Godina { get => godina; set => godina = value; }
        public List<Kandidat> SpisakKandidata { get => spisakKandidata; set => spisakKandidata = value; }
    }
}
