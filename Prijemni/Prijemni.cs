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



        /*2) Napravi metodu koja vraca redne brojeve zadataka na kojima je na testu iz matematike vise od 90% 
         * kandidata odgovorilo netacno
         3) Vrati broj vukovaca koji su polagali 2 testa na prijemnom
         
             */


// 1) Napravi metodu koja obradjuje odgovore odredjenog kandidata(znaci da nekog Kandidata prosledjujes u parametru) i ako je taj kandidat :
//a.polagao samo test iz mate, njegov tacan odgovor vredi 1 poen, neutralan 0 poena, netacan -0.5 a negativan -1 poen
//b.polagao samo test iz opsteInf, njegov tacan odg vredi 1 poen, neutralan i netacan 0 poena, a negativan -1 poen
//Ako je kandidat polagao i test iz matematike i iz opste informisanosti rezultate sa svakog od testova vrednovati kao polovinu ukupnih rezultata, pa ih posle sabrati
//(meni je metoda vracala double jer je to ukupan broj poena koje je kandidat ostvario na prijemnom i ovu prvu metodu sam koristila posle u zadatku u nekim drugim metodama)



            public double obradaOdgovora(Kandidat k)
        {
            double poeni = 0;

            foreach (Odgovor o in k.spisakOdgovora)
            {
                switch (k.Oblast)
                {
                    case Predmeti.Matematika:
                        switch (o.Rezultat)
                        {
                            case Rezultat.Tacan:
                                poeni += 1;
                                break;
                            case Rezultat.Netacan:
                                poeni -= 0.5;
                                break;
                            case Rezultat.Neutralan:
                                poeni += 0;
                                break;
                            case Rezultat.Negativan:
                                poeni -= 1;
                                break;
                            default:
                                break;
                        }



                        break;
                    case Predmeti.OpštaInformisanost:
                        switch (o.Rezultat)
                        {
                            case Rezultat.Tacan:
                                poeni += 1;
                                break;
                            case Rezultat.Netacan:
                                poeni += 0;
                                break;
                            case Rezultat.Neutralan:
                                poeni += 0;
                                break;
                            case Rezultat.Negativan:
                                poeni -= 1;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                } 
            }

            return poeni;
        }


        //5) Napravi metodu koja vraca broj maloletnih lica koje je polagalo prijemni

            public int brMaloletnih()
        {

            int br = 0;

            foreach (Ranglista r in skupListi)
            {
                foreach (Kandidat k in r.SpisakKandidata)
                {
                    

                    if (k.jmbg.ToCharArray()[5]=='0' || k.jmbg.ToCharArray()[5] == '9' && k.jmbg.ToCharArray()[6] == '9')
                    {
                        br++;
                    }
                }

            }

            return br;

        }


        //3) Vrati broj vukovaca koji su polagali 2 testa na prijemnom

            public int brVukovaca()
        {
            int br = 0;




            return br;

        }

        static void Main(string[] args)
        {
        }
    }
}
