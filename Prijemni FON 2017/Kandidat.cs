using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijemni_FON_2017
{

    public enum Predmeti { Matematika, OpštaInformisanost}
    public class Kandidat:Osoba
    {

        string prijava;
        string imeSrednje;
       public List<Odgovor> spisakOdgovora;
        Osoba liceZaUpis;
        Osoba dezurni;
        Predmeti oblast
            ;

        public Kandidat(string prijava, string imeSrednje , Osoba liceZaUpis, Osoba dezurni,Predmeti oblast, string ime,
        string prezime,
        string jmbg):base(ime,prezime,jmbg)
        {
            this.Prijava = prijava;
            this.ImeSrednje = imeSrednje;
            this.LiceZaUpis = liceZaUpis;
            this.Dezurni = dezurni;
            this.Oblast = oblast;
            SpisakOdgovora = new List<Odgovor>();



        }

        public string Prijava { get => prijava; set => prijava = value; }
        public string ImeSrednje { get => imeSrednje; set => imeSrednje = value; }
        public List<Odgovor> SpisakOdgovora { get => spisakOdgovora; set => spisakOdgovora = value; }
        public Osoba LiceZaUpis { get => liceZaUpis; set => liceZaUpis = value; }
        public Osoba Dezurni { get => dezurni; set => dezurni = value; }
        public Predmeti Oblast { get => oblast; set => oblast = value; }
    }
}
