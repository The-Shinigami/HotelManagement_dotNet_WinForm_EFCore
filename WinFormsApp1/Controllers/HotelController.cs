using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    internal class HotelController
    {
        ApplicationDbContext _context;
        List<Hotel> hotels;
        List<Chambre> chambres;
        List<Categorie> categories;

        public HotelController()
        {
            _context = new ApplicationDbContext();
        }
        public List<Hotel> getHotels()
        {
            this.hotels = _context
                .Hotels
                .Include(hotel => hotel.Classement)
                .Include(hotel => hotel.Adresse)
                .Include(hotel => hotel.HotelImages)
                .ToList();
            return this.hotels;
        }
        public List<Chambre> getChambres()
        {
            this.chambres = _context
                .Chambres
                .Include(chambre => chambre.ChambreImage)
                .Include(chambre => chambre.Categorie)
                .Include(chambre => chambre.Hotel)
                .ToList();
            return this.chambres;
        }
        public List<Chambre> getChambresByIdHotel(int id)
        {
            this.chambres = _context
                .Chambres
                .Include(chambre => chambre.ChambreImage)
                .Include(chambre => chambre.Categorie)
                .Include(chambre => chambre.Hotel)
                .Where(chambre => chambre.HotelId == id)
                .ToList();
            return this.chambres;
        }
         public List<Categorie> getCaregoriesByHotelId(int id)
        {
            this.categories = _context
                .Categories
                .Include(categorie => categorie.Chambres)
                .ThenInclude(chambre => chambre.Hotel)
                .Include(categorie => categorie.Chambres)
                .ThenInclude(chambre => chambre.ChambreImage)
                .Where(c => c.Chambres.Any(c => c.Hotel.Id == id))
                .ToList();

                  
            return this.categories;

            
        }

        public void addReservation(Reservation r)
        {
            this._context.Add(r);
            this._context.SaveChanges();

        }


        public bool isReserved(DateTime dateDebut, DateTime dateFin , Chambre c) {

            return this._context
                .Reservations
                .Where(r =>  r.ChambreId == c.Id && (r.DateFin > dateDebut || dateFin > r.DateDebut) ).Count() > 0; 
        }
    }
}
