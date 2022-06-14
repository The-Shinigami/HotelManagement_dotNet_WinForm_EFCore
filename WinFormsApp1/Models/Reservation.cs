using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Reservation
    {
        public Reservation(DateTime dateDebut,DateTime dateFin,Utilisateur utilisateur,int chambreId,Facture facture)
        {
            this.DateDebut = dateDebut;
            this.DateFin = dateFin; 
            this.Utilisateur = utilisateur;
            this.ChambreId = chambreId;
            this.Facture = facture;
        }
        public Reservation()
        {

        }
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int ChambreId { get; set; }
        public Chambre Chambre { get; set; }


        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public int FactureId { get; set; }
        public Facture Facture { get; set; }


    }
}
