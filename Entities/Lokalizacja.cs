using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino.Entities
{
    [Tabela("lokalizacje")]
    public class Lokalizacja
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public string miejscowosc { get; set; }
        public string adres { get; set; }

        public Lokalizacja(int id, string nazwa, string miejscowosc, string adres)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.miejscowosc = miejscowosc;
            this.adres = adres;
        }
    }
}
