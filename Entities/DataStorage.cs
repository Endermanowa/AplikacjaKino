using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino.Entities
{
    public static class DataStorage
    {
        public static List<Film> Filmy { get; set; } = new List<Film>();
        public static List<Lokalizacja> Lokalizacje { get; set; } = new List<Lokalizacja>();
        public static List<Rezerwacja> Rezerwacje { get; set; } = new List<Rezerwacja>();
        public static List<Sala> Sale { get; set; } = new List<Sala>();
        public static List<Seans> Seanse { get; set; } = new List<Seans>();
        public static List<Użytkownik> Użytkownicy { get; set; } = new List<Użytkownik>();
    }
}
