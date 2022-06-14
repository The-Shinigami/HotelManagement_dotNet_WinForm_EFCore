using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public class ApplicationDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql(
              "Host=localhost;Database=GestionHotel;Username=postgres;Password=root");
      

       public DbSet<Classement> Classements { get; set; }
       public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Chambre> Chambres { get; set; }

        public DbSet<Categorie> Categories { get; set; }

        public DbSet<Facture> Factures { get; set; }
        public DbSet<Reservation> Reservations { get; set; }



    }
}
