using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Models
{
    public class Chambre
    {
        public int Id { get; set; }
        public string NumTel{ get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }

        public List <Reservation> Reservations { get; set; }
        public ChambreImage ChambreImage { get; set; }

        public Chambre() { }
        public Chambre(string NumTel,Hotel hotel,Categorie categorie,ChambreImage ci)
        {
            this.NumTel = NumTel;
            this.HotelId = hotel.Id;
            this.CategorieId = categorie.Id;
            this.ChambreImage = ci;


        }

       
    }
}
