using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Categorie
    {

        public int Id { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public float PrixJour { get; set; }


        public List<Chambre> Chambres { get; set; }

    }
}
