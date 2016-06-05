using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detektor.Models
{
    enum Pol { Musko,Zensko};
    class Korisnik
    {
        
        public string Username { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Pol pol { get; set; }
        Referenciranje Ref { get; set; }
    }
}
