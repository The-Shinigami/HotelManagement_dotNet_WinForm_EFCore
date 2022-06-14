using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Prestation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string Type { get; set; }

        public float Prix { get; set; }

        public int FactureId { get; set; }
        public Facture Facture { get; set; }


    }
}
