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
        public List<Chambre> getChambreById(int id)
        {
           return _context
                .Chambres
                .Include(chambre => chambre.ChambreImage)
                .Include(chambre => chambre.Categorie)
                .Include(chambre => chambre.Hotel)
                .Where(chambre => chambre.Id == id)
                .ToList();
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

        public void addUtilisateur(Utilisateur u)
        {
            this._context.Add(u);
            this._context.SaveChanges();

        }
        public void addChambre(Chambre c)
        {
            this._context.Add(c);
            this._context.SaveChanges();
        }
            public void updateUtilisateur(Utilisateur u)
        {
            this._context = new ApplicationDbContext();
            this._context.Entry(u).State = EntityState.Modified;
            this._context.SaveChanges();

        }
        public void updateReservation(Reservation r)
        {
            this._context = new ApplicationDbContext();
            this._context.Entry(r).State = EntityState.Modified;
            this._context.SaveChanges();

        }
        public void updateFacture(Facture f)
        {
            this._context = new ApplicationDbContext();
            this._context.Entry(f).State = EntityState.Modified;
            this._context.SaveChanges();

        }
        public void updateChambre(Chambre c)
        {
            this._context = new ApplicationDbContext();
            this._context.Entry(c).State = EntityState.Modified;
            this._context.SaveChanges();

        }
        public void updateChambreImage(ChambreImage ci)
        {
            this._context = new ApplicationDbContext();
            this._context.Entry(ci).State = EntityState.Modified;
            this._context.SaveChanges();

        }
       


        public bool isReserved(DateTime dateDebut, DateTime dateFin , Chambre c) {
            
            Console.WriteLine(this._context.Reservations);

            return this._context
                .Reservations
                .Where(r =>  r.ChambreId == c.Id 
                && ( ( 
                r.DateDebut <= dateDebut && dateDebut <= r.DateFin)  
                || (
                r.DateDebut <= dateFin  && dateFin <= r.DateFin))
                ).Count() > 0; 

        }
        public List<Reservation> getReservationByUtilisateurId(Utilisateur u)
        {
            return this._context.Reservations.Where(r => r.UtilisateurId == u.Id).ToList();

        }

        public List<Utilisateur> getUtilisateurs()
        {
            return this._context.Utilisateurs.ToList();

        }
        public List<Facture> getFactures()
        {
            return this._context
                .Factures
                 .Include(f => f.Reservations)
                .ThenInclude(r => r.Chambre)
                .Include(f => f.Reservations)
                .ThenInclude(r => r.Chambre)
                .ThenInclude(c => c.Categorie)
                .Include(f => f.Reservations)
                .ThenInclude(r => r.Chambre)
                .ThenInclude(c => c.Hotel)
                .ThenInclude(h => h.Classement)
                .Include(f => f.Prestations)
                .ToList();

        }
        public List<Categorie> getCategories()
        {
            return this._context.Categories.ToList();

        }
        public Hotel getHotelByNom(string nom)
        {
            this._context = new ApplicationDbContext();
            return this._context.Hotels.Where(h => h.Nom == nom).First();

        }

        public Categorie getCategorieByNom(string nom)
        {
            this._context = new ApplicationDbContext();
            return this._context.Categories.Where(c => c.Nom == nom).First();

        }
        public List<Reservation> getReservation()
        {
            return this._context.Reservations.ToList();

        }
        public List<Reservation> getReservationById(int id)
        {
            return this._context
                .Reservations
                .Where(r =>r.Id == id)
                .ToList();

        }
       
        
        public List<Utilisateur> getUtilisateurById(int id)
        {
            return this._context
                .Utilisateurs
                .Where(u => u.Id == id)
                .ToList();

        }
        public List<Facture> getFactureById(int id)
        {
            return this._context
                .Factures
                .Where(f => f.Id == id)
                .Include(f => f.Reservations)
                .ThenInclude(r => r.Chambre)
                .Include(f => f.Reservations)
                .ThenInclude(r => r.Chambre)
                .ThenInclude(c => c.Categorie)
                .Include(f => f.Reservations)
                .ThenInclude(r => r.Chambre)
                .ThenInclude(c => c.Hotel)
                .ThenInclude(h => h.Classement)
                .Include(f => f.Prestations)
                .ToList();

        }

        public double calculerReservationPrix(Reservation r)
        {
            return(r.Chambre.Categorie.PrixJour * ((r.DateFin - r.DateDebut).TotalDays) * r.Chambre.Hotel.Classement.Coef);
        }
        public double calculerPrestationPrix(Prestation p)
        {
            return p.Prix;
           }

        public Facture addFacture(Facture f)
        {
            this._context.Add(f);
           this._context.SaveChanges();

            return this._context.Factures.OrderBy(f => f.Id).Last();

        }
        public void addPrestaion(Prestation p)
        {
            this._context.Add(p);
            this._context.SaveChanges();

        }




        public void deleteUtilisateur(Utilisateur u)
        {
            this._context.Entry(u).State =  EntityState.Deleted;
            this._context.SaveChanges();
        }
        public void deleteChambre(Chambre c)
        {
            this._context.Entry(c).State = EntityState.Deleted;
            this._context.SaveChanges();
        }
        public void deleteReservation(Reservation r)
        {
            this._context.Entry(r).State = EntityState.Deleted;
            this._context.SaveChanges();
        }

        public Utilisateur login(Utilisateur utilisateur)
        {
          return  this._context
                .Utilisateurs
                .Where(u => u.Email == utilisateur.Email && u.Tel == utilisateur.Tel && u.Role == 0)
                .First();
        }
    }
}
