using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercitazione.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int DipendenteId { get; set; }
        public string Periodo { get; set; }
        public string Ammontare { get; set; }
        public string Tipo { get; set; } // Stipendio o acconto
    }
}