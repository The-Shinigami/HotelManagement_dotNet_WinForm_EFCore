using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
               "Host=localhost;Database=postgres;Username=postgres;Password=root");

       

    }

    public class User
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string  adresse { get; set; }
        public string ville { get; set; }
        public string code_postal { get; set; }
        public string pays { get; set; }
        public string email { get; set; }

    }
}
