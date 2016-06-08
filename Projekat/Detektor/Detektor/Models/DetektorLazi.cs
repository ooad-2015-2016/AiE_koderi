using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detektor.Models
{
    class DetektorLazi
    {
        public int id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public List<Ispitivac> BazaIspitivaca;
        public List<Korisnik> BazaKorisnika;
        public List<Pitanja> pitanja;
    }
}
