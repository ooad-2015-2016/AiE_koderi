using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Detektor.Models
{

    class DefaultPodaci
    {
int br = 1;
        
        //public static object BazaIspitivaca { get; private set; }

        public static void Initialize(DetektorLaziDbContext context)
        {
            if (!context.tabela.Any())
            {
                context.tabela.AddRange(
            new Ispitivac()
            {
                ImePrezime = "Semir Salkic",
                Password = "10121995",
            }
                );
            }
                context.SaveChanges();
            

        }
    }

}
    

