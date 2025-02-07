using AplikacjaKino.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino
{
    [Tabela("rezerwacje")]
    public class Rezerwacja
    {
        public int id { get; set; }
        public int użytkownik { get; set; }
        public int seans { get; set; }
        public int liczbaBiletów { get; set; }
        public List<string> miejsca { get; set; }


        public Rezerwacja()
        {

        }

        public Rezerwacja(int id, int użytkownik, int seans, int liczbaBiletów, List<string> miejsca)
        {
            this.id = id;
            this.użytkownik = użytkownik;
            this.seans = seans;
            this.liczbaBiletów = liczbaBiletów;
            this.miejsca = miejsca;
        }

        public string miejscaToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in miejsca)
            {
                sb.Append(s);
                sb.Append(", ");
            }

            sb.Remove(sb.Length - 2, 2);

            return sb.ToString();
        }
    }
}
