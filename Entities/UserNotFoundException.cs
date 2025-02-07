using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKino.Entities
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException()
            : base("Nie znaleziono użytkownika!") { }

        public UserNotFoundException(string message)
            : base(message) { }

        public UserNotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }
}
