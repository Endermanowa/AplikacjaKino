using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace AplikacjaKino.Entities
{
    public class Miejsca
    {
        public int rzedy { get; set; }
        public int kolumny {  get; set; }
        public List<bool> miejsca { get; set;}

        public Miejsca() { }

        public Miejsca(int rzedy, int kolumny, List<bool> miejsca)
        {
            this.rzedy = rzedy;
            this.kolumny = kolumny;
            this.miejsca = miejsca;
        }

        public string getMiejsce(int rząd, int kolumna)
        {
            char literaRzędu = (char)('A' + rząd - 1);

            return $"{literaRzędu}{kolumna}";
        }
    }
}
