using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Hotel
    {
        
        public int Id { get; set; }
        public string Nom { get; set; }
        public string NumTel { get; set; }

        public int ClassementId { get; set; }
        public Classement Classement { get; set; }


        public int AdresseId { get; set; }
        public Adresse Adresse { get; set; }


        public List<HotelImage> HotelImages { get; set; }

        public List<Chambre> Chambres { get; set; }


    }
}
