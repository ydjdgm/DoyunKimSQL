using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyunKimSQL
{
    internal class Schueler
    {
        public int SchuelerID { get; set; }
        public string? Vorname { get; set; }
        public string?   Nachname { get; set; }
        public string? Email { get; set; }
        public int KlasseID { get; set; }
    }
}
