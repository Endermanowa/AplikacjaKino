using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino.Entities
{
    [Tabela("sale")]
    public class Sala
    {
        public int id { get; set; }
        public int lokalizacja { get; set; }
        public string numer { get; set; }
        public int liczbaMiejsc { get; set; }
        public Miejsca miejsca { get; set; }

        public Sala(int id, int lokalizacja, string numer, int liczbaMiejsc)
        {
            this.id = id;
            this.lokalizacja = lokalizacja;
            this.numer = numer;
            this.liczbaMiejsc = liczbaMiejsc;
        }

        public Sala(int id, int lokalizacja, string numer, int liczbaMiejsc, Miejsca miejsca)
        {
            this.id = id;
            this.lokalizacja = lokalizacja;
            this.numer = numer;
            this.liczbaMiejsc = liczbaMiejsc;
            this.miejsca = miejsca;
        }
    }
}
