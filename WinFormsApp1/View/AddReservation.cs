using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.View
{
    public partial class AddReservation : Form
    {

        private Categorie c;
        private HotelController hotelController = new HotelController();
        public AddReservation(Categorie c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void roundLabel3_Click(object sender, EventArgs e)
        {

        }

        private void textArea1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur(this.nom.Text,this.prenom.Text,this.adresse.Text,this.pays.Text,this.ville.Text,this.codePostal.Text,this.email.Text,this.tel.Text,1);
           
            Facture facture = new Facture();
            ApplicationDbContext _context = new ApplicationDbContext();
           
            bool success = false;
            foreach(Chambre chambre in c.Chambres)
            {
                DateTime dateDebut = DateTime.SpecifyKind(this.dateDebut.Value, DateTimeKind.Utc);
                DateTime dateFin = DateTime.SpecifyKind(this.dateFin.Value, DateTimeKind.Utc);
              
                if (!this.hotelController.isReserved(DateTime.SpecifyKind(this.dateDebut.Value, DateTimeKind.Utc), DateTime.SpecifyKind(this.dateFin.Value, DateTimeKind.Utc), chambre))
                {
                    Reservation reservation = new Reservation(DateTime.SpecifyKind(this.dateDebut.Value, DateTimeKind.Utc), DateTime.SpecifyKind(this.dateFin.Value, DateTimeKind.Utc), utilisateur, chambre.Id, facture);
                    this.hotelController.addReservation(reservation);

                    success = true;
                    break;

                }
            }

            if (success)
            {
                MessageBox.Show("Vote reservation a bien été enregistrer");
                this.nom.Text = "";
                this.prenom.Text = "";
                this.adresse.Text = "";
                this.pays.Text = "";
                this.ville.Text = "";
                this.codePostal.Text = "";
                this.email.Text = "";
                this.tel.Text = "";
                this.dateDebut.Value = DateTime.Now;
                this.dateFin.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Aucune chambre n'est libre dans l'interval du temps demandé");
            }
           

              
        }
    }
}
