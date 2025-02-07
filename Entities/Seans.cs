using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino.Entities
{
    [Tabela("seanse")]
    public class Seans
    {
        public int id { get; set; }
        public int film { get; set; }
        public int? lokalizacja { get; set; }
        public int sala { get; set; }
        public DateOnly data { get; set; }
        public TimeOnly godzina { get; set; }
        public string typ { get; set; }
        public string jezyk { get; set; }
        public Miejsca miejsca { get; set; }

        public Seans()
        {

        }

        public Seans(int id, int film, int sala, DateOnly data, TimeOnly godzina, string typ, string jezyk)
        {
            this.id = id;
            this.film = film;
            this.sala = sala;
            this.data = data;
            this.godzina = godzina;
            this.typ = typ;
            this.jezyk = jezyk;
        }

        public Seans(int id, int film, int lokalizacja,int sala, DateOnly data, TimeOnly godzina, string typ, string jezyk)
        {
            this.id = id;
            this.film = film;
            this.lokalizacja = lokalizacja;
            this.sala = sala;
            this.data = data;
            this.godzina = godzina;
            this.typ = typ;
            this.jezyk = jezyk;
        }
        public Seans(int id, int film, int sala, DateOnly data, TimeOnly godzina, string typ, string jezyk, Miejsca miejsca)
        {
            this.id = id;
            this.film = film;
            this.sala = sala;
            this.data = data;
            this.godzina = godzina;
            this.typ = typ;
            this.jezyk = jezyk;
            this.miejsca = miejsca;
        }

        public Seans(int id, int film, int lokalizacja, int sala, DateOnly data, TimeOnly godzina, string typ, string jezyk, Miejsca miejsca)
        {
            this.id = id;
            this.film = film;
            this.lokalizacja = lokalizacja;
            this.sala = sala;
            this.data = data;
            this.godzina = godzina;
            this.typ = typ;
            this.jezyk = jezyk;
            this.miejsca = miejsca;
        }
    }
}
