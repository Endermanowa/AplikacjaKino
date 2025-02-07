using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino.Entities
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TabelaAttribute : Attribute
    {
        public string Nazwa { get; }

        public TabelaAttribute(string nazwa)
        {
            Nazwa = nazwa;
        }
    }
}
