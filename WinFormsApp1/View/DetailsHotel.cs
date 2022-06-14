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
    public partial class DetailsHotel : Form
    {
        HotelController hotelController = new HotelController();
        Hotel hotel;
        List<Categorie> categories = new List<Categorie>();
        public DetailsHotel(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();

        }
        

        private void DetailsHotel_Load(object sender, EventArgs e)
        {
            this.hotelNom.Text = "Hotel "+ hotel.Nom; 
            this.categories = hotelController.getCaregoriesByHotelId(this.hotel.Id);
            int footerY = 0;
            if(this.categories.Count % 3 == 0)
            {
                for (int i = 0; this.categories.Count/3 > i; i=i+3)
                {
         createCard(this.categories[i],0,250*i);
         createCard(this.categories[i+1],250,250*i);
         createCard(this.categories[i+2], 500, 250 * i);
                    if (i == ((this.categories.Count ) / 2) - 1)
                    {
                        footerY = 300 * i ;
                    }
                }
            }
            else
            {
                for (int i = 0; (this.categories.Count-1) / 3 > i; i=i+3)
                {
                    createCard(this.categories[i], 0, 250 * i);
                    createCard(this.categories[i+1], 250, 250 * i);
                    createCard(this.categories[i+2], 500, 250 * i);
                    if (i == ((this.categories.Count - 1) / 2) - 1)
                    {
                        createCard(this.categories[i+3], 0, 250 * (i + 1));
                        footerY = 300 * (i + 2);
                    }
                }
            }
            this.footer.Location = new System.Drawing.Point(3, footerY) ;
            this.adress.Text = this.hotel.Adresse.Details.ToString() ;
            this.numTel.Text = this.hotel.NumTel.ToString() ;
            
            /*  if (this.categories.Count != 0)
              {
                  data.DataSource = this.categories;
                  this.categorieCategorie.Text = this.categories[1].Nom;
                  this.categorieChambreVide.Text = this.categories[1].Chambres.Count().ToString();
              }*/

        }

        public void ceateCategoriesCards()
        {

        }
        int countImages = 0;

        public void slideImage()
        {
         /*   if (this.categories.Count != 0)

            {
                if (countImages == categories[1].Chambres.Count)
                { countImages = 0; }

                this.categorieImage.ImageLocation = categories[1].Chambres[countImages].ChambreImage.Src;

                countImages++;
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.slideImage();
        }


        public RoundPanel createCard(Categorie c ,int x , int y)
        {

             RoundPanel categorieCard;
             categorieCard = new WinFormsApp1.RoundPanel();
            //image
            RoundPicture categorieImage;
            categorieImage = createImage(c);
            //categorie label
            Label categorieCategorieLabel;
            categorieCategorieLabel = createCategorieLabel();
            //categorie
            Label categorieCategorie;
            categorieCategorie = createCategorie(c);
            //chambre vide label
            Label categorieChambreVideLabel;
            categorieChambreVideLabel = createChambreVideLabel();
            //chambre vide
            Label categorieChambreVide;
            categorieChambreVide = createChambreVide(c);
            //button
            CustomControls.RJControls.LinkButton categorieButton;
            categorieButton = createButton(c);
            //timer 
             System.Windows.Forms.Timer timer;
            timer = createTimer();


        categorieCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(categorieImage)).BeginInit();
            // categorieCard
            // 
            categorieCard.BackColor = Color.White;
            categorieCard.BorderRadius = 20;
            categorieCard.Controls.Add(categorieButton);
            categorieCard.Controls.Add(categorieImage);
            categorieCard.Controls.Add(categorieChambreVide);
            categorieCard.Controls.Add(categorieChambreVideLabel);
            categorieCard.Controls.Add(categorieCategorie);
            categorieCard.Controls.Add(categorieCategorieLabel);
            categorieCard.Location = new System.Drawing.Point(50+x, 86+y);
            categorieCard.Name = "categorieCard"; 
            categorieCard.ShadowColor = Color.White;
            categorieCard.ShadowSize = 20;
            categorieCard.ShadowVariante = 0;
            categorieCard.Size = new System.Drawing.Size(200, 215);
            categorieCard.TabIndex = 2;


            this.Controls.Add(categorieCard);
           categorieCard.ResumeLayout(false);
           categorieCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(categorieImage)).EndInit();

            return categorieCard;
        }

        public RoundPicture createImage(Categorie c)
        {
            RoundPicture categorieImage;
            categorieImage = new WinFormsApp1.RoundPicture();
            // 
            // categorieImage
            // 
            categorieImage.BorderRadius = 20;
            if(c.Chambres.Count != 0)
            categorieImage.ImageLocation = c.Chambres[0].ChambreImage.Src;
            categorieImage.Location = new System.Drawing.Point(0, 0);
            categorieImage.Name = "categorieImage";
            categorieImage.Size = new System.Drawing.Size(200, 122);
            categorieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            categorieImage.TabIndex = 0;
            categorieImage.TabStop = false;

            return categorieImage;

        }

        public Label createCategorieLabel()
        {
             Label categorieCategorieLabel;
            categorieCategorieLabel = new System.Windows.Forms.Label();
            // 
            // categorieCategorieLabel
            // 
            categorieCategorieLabel.AutoSize = true;
            categorieCategorieLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            categorieCategorieLabel.Location = new System.Drawing.Point(22, 125);
            categorieCategorieLabel.Name = "categorieCategorieLabel";
            categorieCategorieLabel.Size = new System.Drawing.Size(75, 19);
            categorieCategorieLabel.TabIndex = 1;
            categorieCategorieLabel.Text = "Catégorie";
            categorieCategorieLabel.Click += new System.EventHandler(categorieCategorieLabel_Click);
            return categorieCategorieLabel;
        }

        public Label createCategorie(Categorie c) {
        Label categorieCategorie;
            categorieCategorie = new System.Windows.Forms.Label();
            // 
            // categorieCategorie
            // 
            categorieCategorie.AutoSize = true;
            categorieCategorie.Location = new System.Drawing.Point(122, 127);
            categorieCategorie.Name = "categorieCategorie";
            categorieCategorie.Size = new System.Drawing.Size(58, 15);
            categorieCategorie.TabIndex = 2;
            categorieCategorie.Text = c.Nom;
            return categorieCategorie;

    }

        public Label createChambreVideLabel()
        {
            Label categorieChambreVideLabel;
            categorieChambreVideLabel = new System.Windows.Forms.Label();
            // 
            // categorieChambreVideLabel
            // 
            categorieChambreVideLabel.AutoSize = true;
            categorieChambreVideLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            categorieChambreVideLabel.Location = new System.Drawing.Point(22, 144);
            categorieChambreVideLabel.Name = "categorieChambreVideLabel";
            categorieChambreVideLabel.Size = new System.Drawing.Size(104, 19);
            categorieChambreVideLabel.TabIndex = 3;
            categorieChambreVideLabel.Text = "N° Chambres";
            return categorieChambreVideLabel;
    }

        public Label createChambreVide(Categorie c)
        {
            Label categorieChambreVide;
            categorieChambreVide = new System.Windows.Forms.Label();
            // 
            // categorieChambreVide
            // 
            categorieChambreVide.AutoSize = true;
            categorieChambreVide.Location = new System.Drawing.Point(132, 146);
            categorieChambreVide.Name = "categorieChambreVide";
            categorieChambreVide.Size = new System.Drawing.Size(38, 15);
            categorieChambreVide.TabIndex = 4;
            categorieChambreVide.Text = c.Chambres.Count.ToString();

            return categorieChambreVide;

    }

        public CustomControls.RJControls.LinkButton createButton(Categorie c)
        {
            CustomControls.RJControls.LinkButton categorieButton;
           categorieButton = new CustomControls.RJControls.LinkButton();
            // 
            // categorieButton
            // 
            categorieButton.BackColor = Color.Gray;
            categorieButton.BackgroundColor = Color.Gray;
            categorieButton.BorderColor = System.Drawing.Color.White;
            categorieButton.BorderRadius = 10;
            categorieButton.BorderSize = 0;
            categorieButton.ButtomBorderSize = 0;
            categorieButton.FlatAppearance.BorderSize = 0;
            categorieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            categorieButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            categorieButton.ForeColor = System.Drawing.Color.White;
            categorieButton.Location = new System.Drawing.Point(48, 166);
            categorieButton.Name = "categorieButton";
            categorieButton.ShadowColor = System.Drawing.Color.Gray;
            categorieButton.ShadowSize = 2;
            categorieButton.Size = new System.Drawing.Size(112, 30);
            categorieButton.TabIndex = 5;
            categorieButton.Text = "Book now ...";
            categorieButton.TextColor = System.Drawing.Color.White;
            categorieButton.UseVisualStyleBackColor = false;
           
                /* categorieButton.Click +=  new System.EventHandler(this.linkButton1_Click);*/
                categorieButton.Click += (e, args) => linkButton1_Click(e, args, c);
            return categorieButton;

    }

        public System.Windows.Forms.Timer createTimer()
        {
            System.Windows.Forms.Timer timer;
            timer = new System.Windows.Forms.Timer();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 500;
            timer.Tick += new System.EventHandler(timer1_Tick);
            return timer;
    }
    private void categorieCategorieLabel_Click(object sender, EventArgs e)
        {

        }

        private void categorieImage_Click(object sender, EventArgs e)
        {

        }

        private void linkButton1_Click(object sender, EventArgs e, Categorie c)
        {
            
            AddReservation a = new AddReservation(c);
            a.Show();
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

   
    }
}
