using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercitazione.Models
{
    public class FakeDB
    {
        public static List<Dipendente> Dipendenti = new List<Dipendente>();
        public static List<Pagamento> Pagamenti = new List<Pagamento>();
    }
}