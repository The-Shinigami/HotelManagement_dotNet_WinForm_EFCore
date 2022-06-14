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

        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Prestation> Prestations { get; set; }


    }
}
