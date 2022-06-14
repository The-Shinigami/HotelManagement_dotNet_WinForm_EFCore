using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Utilisateur
    {
        public Utilisateur()
        {}
       public  Utilisateur(string nom,string prenom,string adresse,string pays,string ville ,string code_postal,string tel,string email, int role)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.Pays = pays;
            this.Ville = ville;
            this.Code_postal = code_postal;
            this.Tel = tel;
            this.Email = email;
            if (role == 0)
                this.Role = Role.admin;
            else
                this.Role = Role.client;
        }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Code_postal { get; set; }
        public string Pays { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }

        public ICollection<Reservation> Reservation { get; set; }

    }
public enum Role { admin = 0, client = 1 }

}
