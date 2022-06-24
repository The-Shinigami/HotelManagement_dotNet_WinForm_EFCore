using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Elements;
using WinFormsApp1.Models;

namespace WinFormsApp1.View
{
    public partial class FactureTicket : Form
    {
        Facture facture;
        HotelController hotelController = new HotelController();
        ScreenCapture capScreen = new ScreenCapture();

        public FactureTicket(Facture f)
        {
            InitializeComponent();
            this.facture = f;

        }
        public FactureTicket()
        {
            InitializeComponent();

        }

        private void FactureTicket_Load(object sender, EventArgs e)
        {

            this.dateFacture.Text = DateTime.Now.ToString();
                // 
                // columns
                // 
            double totalPrix = 0;
                for (int i = 0; i < facture.Reservations.Count; i++)
                {
                Reservation r = facture.Reservations[i];
                Label hotelLabel ;
                Label chambreCategorieLabel;
                Label prixLabel;
                Label dateDebutLabel;
                Label dateFinLabel;

                hotelLabel = new System.Windows.Forms.Label();
                    hotelLabel.AutoSize = false;
                    hotelLabel.Location = new System.Drawing.Point(55,151+(36*i));
                    hotelLabel.Name = "column";
                    hotelLabel.Size = new System.Drawing.Size(111, 31);
                    hotelLabel.TabIndex = 0;
                    hotelLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    hotelLabel.TextAlign = ContentAlignment.MiddleCenter;
                    hotelLabel.Text = r.Chambre.Hotel.Nom;

                chambreCategorieLabel = new System.Windows.Forms.Label();
                chambreCategorieLabel.AutoSize = false;
                chambreCategorieLabel.Location = new System.Drawing.Point(172, 151 + (36 * i));
                chambreCategorieLabel.Name = "column";
                chambreCategorieLabel.Size = new System.Drawing.Size(172, 31);
                chambreCategorieLabel.TabIndex = 0;
                chambreCategorieLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                chambreCategorieLabel.TextAlign = ContentAlignment.MiddleCenter;
                chambreCategorieLabel.Text =  r.Chambre.Categorie.Nom;

                prixLabel = new System.Windows.Forms.Label();
                prixLabel.AutoSize = false;
                prixLabel.Location = new System.Drawing.Point(350, 151 + (36 * i));
                prixLabel.Name = "column";
                prixLabel.Size = new System.Drawing.Size(111, 31);
                prixLabel.TabIndex = 0;
                prixLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                prixLabel.TextAlign = ContentAlignment.MiddleCenter;
                prixLabel.Text = this.hotelController.calculerReservationPrix(r).ToString();

                dateDebutLabel = new System.Windows.Forms.Label();
                dateDebutLabel.AutoSize = false;
                dateDebutLabel.Location = new System.Drawing.Point(467, 151 + (36 * i));
                dateDebutLabel.Name = "column";
                dateDebutLabel.Size = new System.Drawing.Size(119, 31);
                dateDebutLabel.TabIndex = 0;
                dateDebutLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                dateDebutLabel.TextAlign = ContentAlignment.MiddleCenter;
                dateDebutLabel.Text = r.DateDebut.ToString();


                dateFinLabel = new System.Windows.Forms.Label();
                dateFinLabel.AutoSize = false;
                dateFinLabel.Location = new System.Drawing.Point(592, 151 + (36 * i));
                dateFinLabel.Name = "column";
                dateFinLabel.Size = new System.Drawing.Size(119, 31);
                dateFinLabel.TabIndex = 0;
                dateFinLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                dateFinLabel.TextAlign = ContentAlignment.MiddleCenter;
                dateFinLabel.Text = r.DateFin.ToString();


                totalPrix += this.hotelController.calculerReservationPrix(r);
               

                this.Controls.Add(hotelLabel);
                this.Controls.Add(dateDebutLabel);
                this.Controls.Add(dateFinLabel);
                this.Controls.Add(chambreCategorieLabel);
                this.Controls.Add(prixLabel);

                }

            for (int i = 0; i < facture.Prestations.Count; i++)
            {
                Prestation p = facture.Prestations[i];
                Label typeLabel;
                Label prixLabel;

                typeLabel = new System.Windows.Forms.Label();
                typeLabel.AutoSize = false;
                typeLabel.Location = new System.Drawing.Point(55, 313+(36*i));
                typeLabel.Name = "column";
                typeLabel.Size = new System.Drawing.Size(111, 31);
                typeLabel.TabIndex = 0;
                typeLabel.Text = p.Type;
                typeLabel.TextAlign = ContentAlignment.MiddleCenter;
                typeLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                prixLabel = new System.Windows.Forms.Label();
                prixLabel.AutoSize = false;
                prixLabel.Location = new System.Drawing.Point(172, 313 + (36 * i));
                prixLabel.Name = "column";
                prixLabel.Size = new System.Drawing.Size(111, 31);
                prixLabel.TabIndex = 0;
                prixLabel.Text = p.Prix.ToString();
                prixLabel.TextAlign = ContentAlignment.MiddleCenter;
                prixLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                this.Controls.Add(typeLabel);
                this.Controls.Add(prixLabel);

                totalPrix += this.hotelController.calculerPrestationPrix(p);
                

            }

           this.totalPrix.Text = totalPrix.ToString() + "Dh";


         
          

        }

        private void captureScreen(string path)
        {
            try
            {

                capScreen.CaptureAndSave
                (path, CaptureMode.Screen, ImageFormat.Png);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.save.Visible = false;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image|*.png";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                DateTime now = DateTime.Now;
                while (DateTime.Now.Subtract(now).Seconds < 5)
                {

                    captureScreen(saveFileDialog.FileName);
                }

            }
        }
    }
    
}
