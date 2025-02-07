using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino.Entities
{
    [Tabela("filmy")]
    public class Film
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public string gatunki { get; set; }
        public int dlugosc { get; set; }

        public Film(int id, string nazwa, string gatunki, int dlugosc)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.gatunki = gatunki;
            this.dlugosc = dlugosc;
        }


    }
}
