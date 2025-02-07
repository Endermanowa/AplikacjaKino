using AplikacjaKino.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino
{
    [Tabela("uzytkownicy")]
    public class Użytkownik
    {
        public int id { get; set; }
        public String imie { get; set; }
        public String nazwisko { get; set; }
        public String numerTelefonu { get; set; }
        public bool admin { get; set; }

        public Użytkownik() 
        {
            
        }

        public Użytkownik(string imie, string nazwisko, string numerTelefonu)
        {
            this.id = 1;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerTelefonu = numerTelefonu;
            admin = false;
        }

        public Użytkownik(int id, string imie, string nazwisko, string numerTelefonu, bool admin)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerTelefonu = numerTelefonu;
            this.admin = admin;
        }
    }
}
