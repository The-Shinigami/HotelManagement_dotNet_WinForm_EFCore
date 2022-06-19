using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Facture
    {   
        public int  Id { get; set; }
        public bool paye { get; set; }

        public List<Reservation> Reservations { get; set; }
        public List<Prestation> Prestations { get; set; }

       public Facture(bool paye)
        {
            paye = paye;
        }
        public Facture()
        {
        }


    }
}
