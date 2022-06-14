using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Adresse
    {
        public int Id { get; set; }
        public string Ville { get; set; }
        public string Paye { get; set; }
        public string Details { get; set; }

        public Hotel Hotel { get; set; }

    }
}
