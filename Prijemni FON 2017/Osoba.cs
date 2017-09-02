using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijemni_FON_2017
{
    public class Osoba
    {

      protected  string ime;
        protected string prezime;
        public  string jmbg;



        public Osoba(string ime,
        string prezime,
        string jmbg  )
        {

            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;


        }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
    }
}
