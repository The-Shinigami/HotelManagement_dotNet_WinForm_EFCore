using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.View
{
    public partial class Dashboard : Form
    {

        HotelController hotelController = new HotelController();
        List<RoundPanel> rows = new List<RoundPanel>();
        Object selectedRow = null;
        string searchedRow = null;
        OpenFileDialog dialogChambreImage = new OpenFileDialog();
        string chambreImagePath = "";
        string path = "";
        
        

        public Dashboard()
        {
            InitializeComponent();
            this.ajouterButton.MouseHover += (e,sender) => showAjouterButtonLabel(e,sender);
            this.ajouterButton.MouseLeave += (e, sender) => hideAjouterButtonLabel(e, sender);
            this.modifierButton.MouseHover += (e, sender) => showModifierButtonLabel(e, sender);
            this.modifierButton.MouseLeave += (e, sender) => hideModifierButtonLabel(e, sender);
            this.supprimerButton.MouseHover += (e, sender) => showSupprimerButtonLabel(e, sender);
            this.supprimerButton.MouseLeave += (e, sender) => hideSupprimerButtonLabel(e, sender);
            this.reservationButton.MouseHover += (e, sender) => showReservationButtonLabel(e, sender);
            this.reservationButton.MouseLeave += (e, sender) => hideReservationButtonLabel(e, sender);
            this.chercherButton.MouseHover += (e, sender) => showChercherButtonLabel(e, sender);
            this.chercherButton.MouseLeave += (e, sender) => hideChercherButtonLabel(e, sender);
            this.facturePrint.MouseHover += (e, sender) => showFacturePrintButtonLabel(e, sender);
            this.facturePrint.MouseLeave += (e, sender) => hideFacturePrintButtonLabel(e, sender);
            
            loadUtilisateursData();
        }
        public void showAjouterButtonLabel(object sender, EventArgs e)
        {
            this.ajouterLabel.Visible = true;
        }
        public void hideAjouterButtonLabel(object sender, EventArgs e)
        {
            this.ajouterLabel.Visible = false;
        }
        public void showChercherButtonLabel(object sender, EventArgs e)
        {
            this.chercherLabel.Visible = true;
        }
        public void hideChercherButtonLabel(object sender, EventArgs e)
        {
            this.chercherLabel.Visible = false;
        }
        public void showModifierButtonLabel(object sender, EventArgs e)
        {
            this.modifierLabel.Visible = true;
        }
        public void hideModifierButtonLabel(object sender, EventArgs e)
        {
            this.modifierLabel.Visible = false;
        }
        public void showSupprimerButtonLabel(object sender, EventArgs e)
        {
            this.supprimerLabel.Visible = true;
        }
        public void hideSupprimerButtonLabel(object sender, EventArgs e)
        {
            this.supprimerLabel.Visible = false;
        }
        public void showReservationButtonLabel(object sender, EventArgs e)
        {
            this.reservationLabel.Visible = true;
        }
        public void hideReservationButtonLabel(object sender, EventArgs e)
        {
            this.reservationLabel.Visible = false;
        }
        public void showFacturePrintButtonLabel(object sender, EventArgs e)
        {
            this.facturePrintLabel.Visible = true;
        }
        public void hideFacturePrintButtonLabel(object sender, EventArgs e)
        {
            this.facturePrintLabel.Visible = false;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void roundLabel1_Click(object sender, EventArgs e)
        {

        }

       
        
      
        private void ajouterLabel_Click(object sender, EventArgs e)
        {

        }

        private void modifierLabel_Click(object sender, EventArgs e)
        {

        }

       
        private void supprimerLabel_Click(object sender, EventArgs e)
        {

        }

        

        
     
        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pays_TextChanged(object sender, EventArgs e)
        {

        }

        private void adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ville_TextChanged(object sender, EventArgs e)
        {

        }

        private void villeLabel_Click(object sender, EventArgs e)
        {

        }

        private void payeLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresseLabel_Click(object sender, EventArgs e)
        {

        }

        private void prenomLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomLabel_Click(object sender, EventArgs e)
        {

        }

       

        private void chambreImage_Click(object sender, EventArgs e)
        {           
           
            if (this.dialogChambreImage.ShowDialog() == DialogResult.OK)
            {
                string path = Path.Combine(@"Images\");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                var fileName = System.IO.Path.GetFileName(this.dialogChambreImage.FileName);

                this.path = path + fileName;
                path = path +"\\"+ fileName;
                this.chambreImagePath = path;

              
            }
        }

        private void chambreSubmitButton_Click(object sender, EventArgs e)
        {
           
            if (this.selectedRow != null)
            {

                Chambre c = (Chambre)this.selectedRow;
                ChambreImage ci = new ChambreImage(this.chambreImagePath);
                ci.Id = c.ChambreImage.Id;
                ci.ChambreId = c.Id;
                this.hotelController.updateChambreImage(ci);
                Chambre chambre = new Chambre(this.chambreTel.Text, this.hotelController.getHotelByNom(this.chambreHotel.SelectedItem.ToString()), this.hotelController.getCategorieByNom(this.chambreCategorie.SelectedItem.ToString()),ci);
                chambre.Id = c.Id;
                this.hotelController.updateChambre(chambre);
                loadChambreData();
            }
            else
            {


                Hotel h = this.hotelController.getHotelByNom(this.chambreHotel.SelectedItem.ToString());
                Categorie c = this.hotelController.getCategorieByNom(this.chambreCategorie.SelectedItem.ToString());
                ChambreImage ci = new ChambreImage(this.chambreImagePath);
                Chambre chambre = new Chambre(this.chambreTel.Text, h, c,ci);
                File.Copy(this.dialogChambreImage.FileName, this.path,true);
                this.hotelController.addChambre(chambre);
                loadChambreData();

            }
            viderUtilisateurForm();
            viderChambreForm();

        }

        
       
        private void roundLabel2_Click(object sender, EventArgs e)
        {

        }

       
       
        
       
        //load data
        public void loadReservationsData(Utilisateur u)
        {
            this.searchForm.Visible = false;
            this.factureForm.Visible = false;
            List<Reservation> reservations = null;
            if (this.searchedRow == null)
            {
                reservations = this.hotelController.getReservation();
            }
            else
            {
                reservations = this.hotelController.getReservationById(Int16.Parse(this.searchedRow));
                if (reservations.Count == 0)
                {
                    MessageBox.Show("Aucune ligne ne correspond a votre recherche");
                    reservations = this.hotelController.getReservation();
                }
            }
            if (u == null)
            {
                reservations = this.hotelController.getReservation();
            }
            else
            {
                reservations = this.hotelController.getReservationByUtilisateurId(u);
            }

            this.reservationFactureId.Items.Clear();
            this.reservationChambreId.Items.Clear();
            this.reservationUtilisateurId.Items.Clear();

            this.hotelController.getUtilisateurs().ForEach(row => this.reservationUtilisateurId.Items.Add(row.Id));
            this.hotelController.getChambres().ForEach(row => this.reservationChambreId.Items.Add(row.Id));
            this.hotelController.getFactures().ForEach(row => this.reservationFactureId.Items.Add(row.Id));
            this.reservationForm.Visible = false;
            if (this.rows.Count != 0)
            {
                this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
                this.mainPanel.Controls.Remove(this.reservationButton);
                this.mainPanel.Controls.Add(this.supprimerButton);
            }


            this.ajouterLabel.Text = "Ajouter une reservation";
            this.supprimerLabel.Text = "Supprimer une reservation";
            this.modifierLabel.Text = "Modifier une reservation";
            this.chercherLabel.Text = "Chercher une reservation";
            int y = 0;
            foreach (Reservation r in reservations)
            {

                RoundPanel rowPanel;
                Label idLabel;
                Label dateDebutLabel;
                Label dateFinLabel;
                Label chambreIdLabel;
                Label utilisateurIdLabel;
                Label factureIdLabel;


                rowPanel = new WinFormsApp1.RoundPanel();
                idLabel = new System.Windows.Forms.Label();
                dateDebutLabel = new System.Windows.Forms.Label();
                dateFinLabel = new System.Windows.Forms.Label();
                chambreIdLabel = new System.Windows.Forms.Label();
                utilisateurIdLabel = new System.Windows.Forms.Label();
                factureIdLabel = new System.Windows.Forms.Label();

                rows.Add(rowPanel);

                ((System.ComponentModel.ISupportInitialize)(this.reservationButton)).BeginInit();
                rowPanel.SuspendLayout();
                this.mainPanel.Controls.Add(rowPanel);

                // 
                // rowPanel
                // 
                rowPanel.BackColor = System.Drawing.Color.White;
                rowPanel.BorderRadius = 20;
                rowPanel.Location = new System.Drawing.Point(45, 30 + y);
                rowPanel.Name = "rowPanel";
                rowPanel.ShadowColor = System.Drawing.Color.White;
                rowPanel.ShadowSize = 0;
                rowPanel.ShadowVariante = 0;
                rowPanel.Size = new System.Drawing.Size(374, 145);
                rowPanel.TabIndex = 3;
                rowPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                rowPanel.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.GraphicsUnit.Point);
                if (u == null)
                    rowPanel.Click += (s, e) => selectRowReservation(s, e, r, rowPanel);


                rowPanel.Controls.Add(idLabel);
                rowPanel.Controls.Add(dateDebutLabel);
                rowPanel.Controls.Add(dateFinLabel);
                rowPanel.Controls.Add(chambreIdLabel);
                rowPanel.Controls.Add(utilisateurIdLabel);
                rowPanel.Controls.Add(factureIdLabel);
                // 
                // columns
                // 
                int labelSizeY = 26;
                int labelLocationY = 18;

                idLabel.AutoSize = false;
                //  idLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                idLabel.Location = new System.Drawing.Point(0, 12);
                idLabel.Name = "column";
                idLabel.Size = new System.Drawing.Size(374, labelSizeY);
                idLabel.TabIndex = 0;
                idLabel.Text = "Id : " + r.Id;
                if (u == null)
                    idLabel.Click += (s, e) => selectRowReservation(s, e, r, rowPanel);
                idLabel.TextAlign = ContentAlignment.MiddleCenter;


                dateDebutLabel.AutoSize = false;
                // dateDebutLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                dateDebutLabel.Location = new System.Drawing.Point(0, 12 + labelLocationY);
                dateDebutLabel.Name = "column";
                dateDebutLabel.Size = new System.Drawing.Size(374, labelSizeY);
                dateDebutLabel.TabIndex = 0;
                dateDebutLabel.Text = "Date debut : " + r.DateDebut;
                if (u == null)
                    dateDebutLabel.Click += (s, e) => selectRowReservation(s, e, r, rowPanel);
                dateDebutLabel.TextAlign = ContentAlignment.MiddleCenter;


                dateFinLabel.AutoSize = false;
                //  dateFinLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                dateFinLabel.Location = new System.Drawing.Point(0, 12 + labelLocationY * 2);
                dateFinLabel.Name = "column";
                dateFinLabel.Size = new System.Drawing.Size(374, labelSizeY);
                dateFinLabel.TabIndex = 0;
                dateFinLabel.Text = "Date fin : " + r.DateFin;
                if (u == null)
                    dateFinLabel.Click += (s, e) => selectRowReservation(s, e, r, rowPanel);
                dateFinLabel.TextAlign = ContentAlignment.MiddleCenter;

                chambreIdLabel.AutoSize = false;
                //  chambreIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                chambreIdLabel.Location = new System.Drawing.Point(0, 12 + labelLocationY * 3);
                chambreIdLabel.Name = "column";
                chambreIdLabel.Size = new System.Drawing.Size(374, labelSizeY);
                chambreIdLabel.TabIndex = 0;
                chambreIdLabel.Text = "Chambre Id : " + r.ChambreId;
                if (u == null)
                    chambreIdLabel.Click += (s, e) => selectRowReservation(s, e, r, rowPanel);
                chambreIdLabel.TextAlign = ContentAlignment.MiddleCenter;

                utilisateurIdLabel.AutoSize = false;
                //  utilisateurIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                utilisateurIdLabel.Location = new System.Drawing.Point(0, 12 + labelLocationY * 4);
                utilisateurIdLabel.Name = "column";
                utilisateurIdLabel.Size = new System.Drawing.Size(374, labelSizeY);
                utilisateurIdLabel.TabIndex = 0;
                utilisateurIdLabel.Text = "Utilisateur Id : " + r.UtilisateurId;
                if (u == null)
                    utilisateurIdLabel.Click += (s, e) => selectRowReservation(s, e, r, rowPanel);
                utilisateurIdLabel.TextAlign = ContentAlignment.MiddleCenter;

                factureIdLabel.AutoSize = false;
                //   factureIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                factureIdLabel.Location = new System.Drawing.Point(0, 12 + labelLocationY * 5);
                factureIdLabel.Name = "column";
                factureIdLabel.Size = new System.Drawing.Size(374, labelSizeY);
                factureIdLabel.TabIndex = 0;
                factureIdLabel.Text = "Facture Id : " + r.FactureId;
                if (u == null)
                    factureIdLabel.Click += (s, e) => selectRowReservation(s, e, r, rowPanel);
                factureIdLabel.TextAlign = ContentAlignment.MiddleCenter;


                rowPanel.ResumeLayout(false);
                rowPanel.PerformLayout();

                y = y + rowPanel.Height + 20;

            }

            RoundPanel foot = new RoundPanel();
            foot.Size = new System.Drawing.Size(45, 40);
            foot.AutoSize = true;
            foot.Location = new System.Drawing.Point(36, y);

            this.rows.Add(foot);
            this.mainPanel.Controls.Add(foot);
        }

        public void loadUtilisateursData()
        {
            this.utilisateurForm.Visible = false;
            this.searchForm.Visible = false;
            this.factureForm.Visible = false;

            if (this.rows.Count != 0)
            {
                this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
                this.mainPanel.Controls.Add(this.reservationButton);
                this.mainPanel.Controls.Add(this.supprimerButton);
            }

            List<Utilisateur> utilisateurs = null;
            if (this.searchedRow != null)
            {
                utilisateurs = this.hotelController.getUtilisateurById(Int16.Parse(this.searchedRow));
                if (utilisateurs.Count == 0)
                {
                    MessageBox.Show("Aucune ligne ne correspond a votre recherche");
                    utilisateurs = this.hotelController.getUtilisateurs();
                }

            }
            else
            {
                utilisateurs = this.hotelController.getUtilisateurs();
            }

            this.ajouterLabel.Text = "Ajouter un utilisateur";
            this.supprimerLabel.Text = "Supprimer un utilisateur";
            this.modifierLabel.Text = "Modifier un utilisateur";
            this.chercherLabel.Text = "Chercher un utilisateur";
            int y = 0;
            foreach (Utilisateur u in utilisateurs)
            {

                RoundPanel rowPanel;
                Label idLabel;
                Label nomLabel;
                Label prenomLabel;
                Label adresseLabel;
                Label villeLabel;
                Label codePostalLabel;
                Label paysLabel;
                Label emailLabel;
                Label roleLabel;
                Label telLabel;


                rowPanel = new WinFormsApp1.RoundPanel();
                idLabel = new System.Windows.Forms.Label();
                nomLabel = new System.Windows.Forms.Label();
                prenomLabel = new System.Windows.Forms.Label();
                adresseLabel = new System.Windows.Forms.Label();
                villeLabel = new System.Windows.Forms.Label();
                codePostalLabel = new System.Windows.Forms.Label();
                paysLabel = new System.Windows.Forms.Label();
                emailLabel = new System.Windows.Forms.Label();
                roleLabel = new System.Windows.Forms.Label();
                telLabel = new System.Windows.Forms.Label();

                rows.Add(rowPanel);

                ((System.ComponentModel.ISupportInitialize)(this.reservationButton)).BeginInit();
                rowPanel.SuspendLayout();
                this.mainPanel.Controls.Add(rowPanel);

                // 
                // rowPanel
                // 
                rowPanel.BackColor = System.Drawing.Color.White;
                rowPanel.BorderRadius = 20;
                rowPanel.Location = new System.Drawing.Point(45, 30 + y);
                rowPanel.Name = "rowPanel";
                rowPanel.ShadowColor = System.Drawing.Color.White;
                rowPanel.ShadowSize = 0;
                rowPanel.ShadowVariante = 0;
                rowPanel.Size = new System.Drawing.Size(374, 220);
                rowPanel.TabIndex = 3;
                rowPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                rowPanel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                rowPanel.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.GraphicsUnit.Point);



                rowPanel.Controls.Add(idLabel);
                rowPanel.Controls.Add(nomLabel);
                rowPanel.Controls.Add(prenomLabel);
                rowPanel.Controls.Add(adresseLabel);
                rowPanel.Controls.Add(villeLabel);
                rowPanel.Controls.Add(codePostalLabel);
                rowPanel.Controls.Add(paysLabel);
                rowPanel.Controls.Add(emailLabel);
                rowPanel.Controls.Add(roleLabel);
                rowPanel.Controls.Add(telLabel);
                // 
                // columns
                // 
                int labelSizeY = 26;
                int labalLocationY = 18;
                idLabel.AutoSize = false;
                //  idLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                idLabel.Location = new System.Drawing.Point(0, 12);
                idLabel.Name = "column";
                idLabel.Size = new System.Drawing.Size(374, labelSizeY);
                idLabel.TabIndex = 0;
                idLabel.Text = "Id : " + u.Id;
                idLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                idLabel.TextAlign = ContentAlignment.MiddleCenter;
                //  idLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);



                nomLabel.AutoSize = false;
                //  nomLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                nomLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY);
                nomLabel.Name = "column";
                nomLabel.Size = new System.Drawing.Size(374, labelSizeY);
                nomLabel.TabIndex = 0;
                nomLabel.Text = "Nom : " + u.Nom;
                nomLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                nomLabel.TextAlign = ContentAlignment.MiddleCenter;
                //  nomLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);


                prenomLabel.AutoSize = false;
                //   prenomLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                prenomLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY * 2);
                prenomLabel.Name = "column";
                prenomLabel.Size = new System.Drawing.Size(374, labelSizeY);
                prenomLabel.TabIndex = 0;
                prenomLabel.Text = "Prenom : " + u.Prenom;
                prenomLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                prenomLabel.TextAlign = ContentAlignment.MiddleCenter;
                //  prenomLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);

                adresseLabel.AutoSize = false;
                //  adresseLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                adresseLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY * 3);
                adresseLabel.Name = "column";
                adresseLabel.Size = new System.Drawing.Size(374, labelSizeY);
                adresseLabel.TabIndex = 0;
                adresseLabel.Text = "Adresse : " + u.Adresse;
                adresseLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                adresseLabel.TextAlign = ContentAlignment.MiddleCenter;
                //   adresseLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);

                villeLabel.AutoSize = false;
                //  villeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                villeLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY * 4);
                villeLabel.Name = "column";
                villeLabel.Size = new System.Drawing.Size(374, labelSizeY);
                villeLabel.TabIndex = 0;
                villeLabel.Text = "Ville : " + u.Ville;
                villeLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                villeLabel.TextAlign = ContentAlignment.MiddleCenter;
                //   villeLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);

                codePostalLabel.AutoSize = false;
                //    codePostalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                codePostalLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY * 5);
                codePostalLabel.Name = "column";
                codePostalLabel.Size = new System.Drawing.Size(374, labelSizeY);
                codePostalLabel.TabIndex = 0;
                codePostalLabel.Text = "Code Postal : " + u.Code_postal;
                codePostalLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                codePostalLabel.TextAlign = ContentAlignment.MiddleCenter;
                //   codePostalLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);

                paysLabel.AutoSize = false;
                //      paysLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                paysLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY * 6);
                paysLabel.Name = "column";
                paysLabel.Size = new System.Drawing.Size(374, labelSizeY);
                paysLabel.TabIndex = 0;
                paysLabel.Text = "Pays : " + u.Pays;
                paysLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                paysLabel.TextAlign = ContentAlignment.MiddleCenter;
                //     paysLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);

                emailLabel.AutoSize = false;
                //     emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                emailLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY * 7);
                emailLabel.Name = "column";
                emailLabel.Size = new System.Drawing.Size(374, labelSizeY);
                emailLabel.TabIndex = 0;
                emailLabel.Text = "Email : " + u.Email;
                emailLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                emailLabel.TextAlign = ContentAlignment.MiddleCenter;
                //   emailLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);

                roleLabel.AutoSize = false;
                //    roleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                roleLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY * 8);
                roleLabel.Name = "column";
                roleLabel.Size = new System.Drawing.Size(374, labelSizeY);
                roleLabel.TabIndex = 0;
                roleLabel.Text = "Role : " + u.Role.ToString();
                roleLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                roleLabel.TextAlign = ContentAlignment.MiddleCenter;
                //   roleLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);

                telLabel.AutoSize = false;
                //     telLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                telLabel.Location = new System.Drawing.Point(0, 12 + labalLocationY * 9);
                telLabel.Name = "column";
                telLabel.Size = new System.Drawing.Size(374, labelSizeY);
                telLabel.TabIndex = 0;
                telLabel.Text = "Tel : " + u.Tel;
                telLabel.Click += (s, e) => selectRowUtilisateur(s, e, u, rowPanel);
                telLabel.TextAlign = ContentAlignment.MiddleCenter;
                //      telLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.GraphicsUnit.Point);




                rowPanel.ResumeLayout(false);
                rowPanel.PerformLayout();

                y = y + rowPanel.Height + 20;

            }

            RoundPanel foot = new RoundPanel();
            foot.Size = new System.Drawing.Size(45, 40);
            foot.AutoSize = true;
            foot.Location = new System.Drawing.Point(36, y);

            this.rows.Add(foot);
            this.mainPanel.Controls.Add(foot);
            this.searchedRow = null;
        }
        public void loadChambreData()

        {
            this.chambreHotel.Items.Clear();
            this.chambreCategorie.Items.Clear();
            this.searchForm.Visible = false;
            this.factureForm.Visible = false;

            this.hotelController.getHotels().ForEach(hotel => this.chambreHotel.Items.Add(hotel.Nom));
            this.hotelController.getCategories().ForEach(categorie => this.chambreCategorie.Items.Add(categorie.Nom));
            this.chambreForm.Visible = false;

            this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
            this.mainPanel.Controls.Remove(this.reservationButton);
            this.mainPanel.Controls.Add(this.supprimerButton);

            List<Chambre> chambres = null;
            if (this.searchedRow == null)
            {
                chambres = this.hotelController.getChambres();
            }
            else
            {
                chambres = this.hotelController.getChambreById(Int16.Parse(this.searchedRow));
                if (chambres.Count == 0)
                {
                    MessageBox.Show("Aucune ligne ne correspond a votre recherche");
                    chambres = this.hotelController.getChambres();
                }
            }

            this.ajouterLabel.Text = "Ajouter une chambre";
            this.supprimerLabel.Text = "Supprimer une chambre";
            this.modifierLabel.Text = "Modifier une chambre";
            this.chercherLabel.Text = "Chercher une chambre";

            int y = 0;
            foreach (Chambre c in chambres)
            {

                RoundPanel rowPanel;
                Label idLabel;
                Label telLabel;
                Label hotelLabel;
                Label categorieLabel;
                RoundPicture chambreImageBox;


                rowPanel = new WinFormsApp1.RoundPanel();
                idLabel = new System.Windows.Forms.Label();
                hotelLabel = new System.Windows.Forms.Label();
                categorieLabel = new System.Windows.Forms.Label();
                telLabel = new System.Windows.Forms.Label();
                chambreImageBox = new RoundPicture();


                rows.Add(rowPanel);

                ((System.ComponentModel.ISupportInitialize)(this.reservationButton)).BeginInit();
                rowPanel.SuspendLayout();
                this.mainPanel.Controls.Add(rowPanel);

                // 
                // rowPanel
                // 
                rowPanel.BackColor = System.Drawing.Color.White;
                rowPanel.BorderRadius = 20;
                rowPanel.Location = new System.Drawing.Point(45, 30 + y);
                rowPanel.Name = "rowPanel";
                rowPanel.ShadowColor = System.Drawing.Color.White;
                rowPanel.ShadowSize = 0;
                rowPanel.ShadowVariante = 0;
                rowPanel.Size = new System.Drawing.Size(374, 130);
                rowPanel.TabIndex = 3;
                rowPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                rowPanel.Click += (s, e) => selectRowChambre(s, e, c, rowPanel);
                rowPanel.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.GraphicsUnit.Point);

                rowPanel.Controls.Add(idLabel);
                rowPanel.Controls.Add(hotelLabel);
                rowPanel.Controls.Add(categorieLabel);
                rowPanel.Controls.Add(telLabel);
                rowPanel.Controls.Add(chambreImageBox);
                // 
                // columns
                // 
                int labelSizeY = 22;
                int labelLocationY = 23;

                chambreImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                chambreImageBox.TabIndex = 4;
                chambreImageBox.BackColor = System.Drawing.Color.White;
                chambreImageBox.Size = new System.Drawing.Size(180, 128);
                chambreImageBox.BorderRadius = 20;
                chambreImageBox.Location = new System.Drawing.Point(200, 0);
                chambreImageBox.ImageLocation = c.ChambreImage.Src;
                chambreImageBox.Click += (s, e) => selectRowChambre(s, e, c, rowPanel);


                idLabel.AutoSize = true;
                // idLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                idLabel.Location = new System.Drawing.Point(36, 10);
                idLabel.Name = "column";
                idLabel.Size = new System.Drawing.Size(45, labelSizeY);
                idLabel.TabIndex = 0;
                idLabel.Text = "Id : " + c.Id;
                idLabel.Click += (s, e) => selectRowChambre(s, e, c, rowPanel);

                hotelLabel.AutoSize = true;
                //  hotelLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                hotelLabel.Location = new System.Drawing.Point(36, 10 + labelLocationY);
                hotelLabel.Name = "column";
                hotelLabel.Size = new System.Drawing.Size(45, labelSizeY);
                hotelLabel.TabIndex = 0;
                hotelLabel.Text = "Hotel : " + c.Hotel.Nom;
                hotelLabel.Click += (s, e) => selectRowChambre(s, e, c, rowPanel);

                categorieLabel.AutoSize = true;
                //  categorieLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                categorieLabel.Location = new System.Drawing.Point(36, 10 + labelLocationY * 2);
                categorieLabel.Name = "column";
                categorieLabel.Size = new System.Drawing.Size(45, labelSizeY);
                categorieLabel.TabIndex = 0;
                categorieLabel.Text = "Categorie: " + c.Categorie.Nom;
                categorieLabel.Click += (s, e) => selectRowChambre(s, e, c, rowPanel);

                telLabel.AutoSize = true;
                //   telLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                telLabel.Location = new System.Drawing.Point(36, 10 + labelLocationY * 3);
                telLabel.Name = "column";
                telLabel.Size = new System.Drawing.Size(45, labelSizeY);
                telLabel.TabIndex = 0;
                telLabel.Text = "Tel : " + c.NumTel;
                telLabel.Click += (s, e) => selectRowChambre(s, e, c, rowPanel);




                rowPanel.ResumeLayout(false);
                rowPanel.PerformLayout();

                y = y + rowPanel.Height + 20;

            }

            RoundPanel foot = new RoundPanel();
            foot.Size = new System.Drawing.Size(45, 40);
            foot.AutoSize = true;
            foot.Location = new System.Drawing.Point(36, y);

            this.rows.Add(foot);
            this.mainPanel.Controls.Add(foot);



            this.selectedRow = null;
        }
        public void loadFacturesData()

        {
            this.searchForm.Visible = false;
            this.chambreForm.Visible = false;
            this.utilisateurForm.Visible = false;
            this.factureForm.Visible = false;

            this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
            this.mainPanel.Controls.Remove(this.reservationButton);
            this.mainPanel.Controls.Remove(this.supprimerButton);

            List<Facture> factures = null;
            if (this.searchedRow == null)
            {
                factures = this.hotelController.getFactures();
            }
            else
            {
                factures = this.hotelController.getFactureById(Int16.Parse(this.searchedRow));
                if (factures.Count == 0)
                {
                    MessageBox.Show("Aucune ligne ne correspond a votre recherche");
                    factures = this.hotelController.getFactures();
                }
            }

            this.ajouterLabel.Text = "Ajouter une facture";
            this.modifierLabel.Text = "Modifier une facture";
            this.chercherLabel.Text = "Chercher une facture";

            int y = 0;
            foreach (Facture f in factures)
            {

                RoundPanel rowPanel;
                Label idLabel;
                Label payeLabel;
                


                rowPanel = new WinFormsApp1.RoundPanel();
                idLabel = new System.Windows.Forms.Label();
                payeLabel = new System.Windows.Forms.Label();
               

                rows.Add(rowPanel);

                ((System.ComponentModel.ISupportInitialize)(this.reservationButton)).BeginInit();
                rowPanel.SuspendLayout();
                this.mainPanel.Controls.Add(rowPanel);

                // 
                // rowPanel
                // 
                rowPanel.BackColor = System.Drawing.Color.White;
                rowPanel.AutoScroll = true;
                rowPanel.BorderRadius = 20;
                rowPanel.Location = new System.Drawing.Point(45, 30 + y);
                rowPanel.Name = "rowPanel";
                rowPanel.ShadowColor = System.Drawing.Color.White;
                rowPanel.ShadowSize = 0;
                rowPanel.ShadowVariante = 0;
                rowPanel.Size = new System.Drawing.Size(374, 130);
                rowPanel.TabIndex = 3;
                rowPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                rowPanel.Click += (s, e) => selectRowFacture(s, e, f, rowPanel);
                rowPanel.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.GraphicsUnit.Point);

                rowPanel.Controls.Add(idLabel);
                rowPanel.Controls.Add(payeLabel);
              
                // 
                // columns
                // 
                int labelSizeY = 22;
                int labelLocationY = 23;


                idLabel.AutoSize = true;
                idLabel.Location = new System.Drawing.Point(36, 10);
                idLabel.Name = "column";
                idLabel.Size = new System.Drawing.Size(45, labelSizeY);
                idLabel.TabIndex = 0;
                idLabel.Text = "Id : " + f.Id;
                idLabel.Click += (s, e) => selectRowFacture(s, e, f, rowPanel);

                payeLabel.AutoSize = true;
                payeLabel.Location = new System.Drawing.Point(36, 10 + labelLocationY);
                payeLabel.Name = "column";
                payeLabel.Size = new System.Drawing.Size(45, labelSizeY);
                payeLabel.TabIndex = 0;
                payeLabel.Text = "paye : " + f.paye;
                payeLabel.Click += (s, e) => selectRowFacture(s, e, f, rowPanel);

                int reservationY = 0; 
                double totalPrix  = 0;
                int totalPrixLavelY = 0;
                for(int i = 0;i < f.Reservations.Count;i++)
                {
                    Reservation r = f.Reservations[i];
                    Label reservationLabel;

                    reservationLabel = new System.Windows.Forms.Label();

                    rowPanel.Controls.Add(reservationLabel);

                    reservationLabel.AutoSize = true;
                    reservationLabel.Location = new System.Drawing.Point(36, 10 + (labelLocationY * (2+i)));
                    reservationLabel.Name = "column";
                    reservationLabel.Size = new System.Drawing.Size(45, labelSizeY);
                    reservationLabel.TabIndex = 0;
                    reservationLabel.Text = "Reservation Id : " + r.Id + " \t\t Prix : " + this.hotelController.calculerReservationPrix(r)+"DH";
                    reservationLabel.Click += (s, e) => selectRowFacture(s, e, f, rowPanel);

                    reservationY +=  (labelLocationY * (2 + i));
                    totalPrix += this.hotelController.calculerReservationPrix(r);
                    totalPrixLavelY = reservationY;

                }
                if (reservationY == 0)
                    reservationY = 63;
                for (int i = 0; i < f.Prestations.Count; i++)
                {
                   Prestation p = f.Prestations[i];
                   Label prestationLabel;

                    prestationLabel = new System.Windows.Forms.Label();

                   rowPanel.Controls.Add(prestationLabel);

                    prestationLabel.AutoSize = true;
                    prestationLabel.Location = new System.Drawing.Point(36, reservationY + (labelLocationY * i));
                    prestationLabel.Name = "column";
                    prestationLabel.Size = new System.Drawing.Size(45, labelSizeY);
                    prestationLabel.TabIndex = 0;
                    prestationLabel.Text = "Prestation Id : " + p.Id + " \t\t Prix : " + this.hotelController.calculerPrestationPrix(p) + "DH";
                    prestationLabel.Click += (s, e) => selectRowFacture(s, e, f, rowPanel);

                    totalPrix += this.hotelController.calculerPrestationPrix(p);
                    totalPrixLavelY = reservationY + (labelLocationY * i);

                }
                Label totalPrixLabel;

                totalPrixLabel = new System.Windows.Forms.Label();

                rowPanel.Controls.Add(totalPrixLabel);

                totalPrixLabel.AutoSize = true;
                totalPrixLabel.Location = new System.Drawing.Point(36, 60+totalPrixLavelY);
                totalPrixLabel.Name = "column";
                totalPrixLabel.Size = new System.Drawing.Size(45, labelSizeY);
                totalPrixLabel.TabIndex = 0;
                totalPrixLabel.Text = "Prix total : "+ totalPrix + "DH";
                totalPrixLabel.Click += (s, e) => selectRowFacture(s, e, f, rowPanel);

                rowPanel.ResumeLayout(false);
                rowPanel.PerformLayout();

                y = y + rowPanel.Height + 20;

            }

            RoundPanel foot = new RoundPanel();
            foot.Size = new System.Drawing.Size(45, 40);
            foot.AutoSize = true;
            foot.Location = new System.Drawing.Point(36, y);

            this.rows.Add(foot);
            this.mainPanel.Controls.Add(foot);
            this.selectedRow = null;
        }
        //clean forms 
        public void viderUtilisateurForm()
        {
            this.nom.Text = "";
            this.prenom.Text = "";
            this.adresse.Text = "";
            this.pays.Text = "";
            this.ville.Text = "";
            this.codePostal.Text = "";
            this.email.Text = "";
            this.tel.Text = "";
            this.role.SelectedText = "";
            this.role.Text = "";
        }
        public void viderChambreForm()
        {
            this.chambreTel.Text = "";
            this.chambreHotel.SelectedItem = "";
            this.chambreHotel.Text = "";
            this.chambreCategorie.Text = "";
            this.chambreCategorie.SelectedItem = "";
            this.chambreHotel.Text = "";
            this.chambreCategorie.Text = "";
            this.chambreImagePath = "";

        }
        public void viderReservationsForm()
        {
            this.reservationDatedebut.Value = DateTime.Now;
            this.reservationDateFin.Value = DateTime.Now;
            this.reservationUtilisateurId.SelectedItem = "";
            this.reservationChambreId.SelectedItem = "";
            this.reservationFactureId.SelectedItem = "";
            this.reservationUtilisateurId.Text = "";
            this.reservationChambreId.Text = "";
            this.reservationFactureId.Text = "";

        }
        public void viderFactureForm()
        {
            this.factureType.Text = "";
            this.facturePrix.Text = "";
            this.factureDate.Value = DateTime.Now;

        }

        //select row
        public void selectRowReservation(object s, EventArgs e, Reservation r, RoundPanel p)
        {

            if (p.BackColor == Color.White)
            {
                this.rows.ForEach(row => row.BackColor = Color.White);
                this.rows.Last().BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
                p.BackColor = Color.LightGray;
                this.selectedRow = (Reservation)r;
            }
            else
            {
                p.BackColor = Color.White;
                this.selectedRow = null;
            }
        }
        public void selectRowChambre(Object s, EventArgs e, Chambre c, RoundPanel p)
        {

            if (p.BackColor == Color.White)
            {
                this.rows.ForEach(row => row.BackColor = Color.White);
                this.rows.Last().BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
                p.BackColor = Color.LightGray;
                this.selectedRow = (Chambre)c;
            }
            else
            {
                p.BackColor = Color.White;
                this.selectedRow = null;
            }

        }
        public void selectRowUtilisateur(object s, EventArgs e, Utilisateur u, RoundPanel p)
        {

            if (p.BackColor == Color.White)
            {
                this.rows.ForEach(row => row.BackColor = Color.White);
                this.rows.Last().BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));


                p.BackColor = Color.LightGray;
                this.selectedRow = (Utilisateur)u;
            }
            else
            {
                p.BackColor = Color.White;
                this.selectedRow = null;
            }
        }
        public void selectRowFacture(object s, EventArgs e, Facture f, RoundPanel p)
        {

            if (p.BackColor == Color.White)
            {
                this.rows.ForEach(row => row.BackColor = Color.White);
                this.rows.Last().BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));


                p.BackColor = Color.LightGray;
                this.selectedRow = (Facture)f;
            }
            else
            {
                p.BackColor = Color.White;
                this.selectedRow = null;
            }
        }

        //side navbar
        private void utilisateursButton_Click(object sender, EventArgs e)
        {
            this.utilisateursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122))))); ;
            this.utilisateursIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122))))); ;

            this.chambresButton.BackColor = Color.White;
            this.chambresIcon.BackColor = Color.White;
            this.reservationsButton.BackColor = Color.White;
            this.ureservationsIcon.BackColor = Color.White;
            this.facturesButton.BackColor = Color.White;
            this.facturesIcon.BackColor = Color.White;

            this.utilisateurForm.Visible = false;
            this.searchForm.Visible = false;
            this.chambreForm.Visible = false;
            this.reservationForm.Visible = false;
            this.facturePrint.Visible = false;

            loadUtilisateursData();
            this.selectedRow = null;
        }
        private void reservationsButton_Click(object sender, EventArgs e)
        {
            this.utilisateurForm.Visible = false;
            this.chambreForm.Visible = false;
            this.reservationForm.Visible = false;
            this.searchForm.Visible = false;
            this.facturePrint.Visible = false;

            this.facturesButton.BackColor = Color.White;
            this.facturesIcon.BackColor = Color.White;

            this.reservationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122))))); ;
            this.ureservationsIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122))))); ;

            this.chambresButton.BackColor = Color.White;
            this.chambresIcon.BackColor = Color.White;
            this.utilisateursButton.BackColor = Color.White;
            this.utilisateursIcon.BackColor = Color.White;

            if (this.rows.Count != 0)
            {
                this.rows.ForEach(row => this.mainPanel.Controls.Remove(row));
            }


            loadReservationsData(null);
            viderReservationsForm();
        }
        private void chambresButton_Click(object sender, EventArgs e)
        {
            this.utilisateurForm.Visible = false;
            this.chambreForm.Visible = false;
            this.reservationForm.Visible = false;
            this.searchForm.Visible = false;
            this.facturePrint.Visible = false;

            this.facturesButton.BackColor = Color.White;
            this.facturesIcon.BackColor = Color.White;

            this.utilisateursButton.BackColor = Color.White;
            this.utilisateursIcon.BackColor = Color.White;
            this.reservationsButton.BackColor = Color.White;
            this.ureservationsIcon.BackColor = Color.White;

            this.chambresButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122))))); ;
            this.chambresIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122))))); ;

            loadChambreData();
            viderUtilisateurForm();
        }
        private void facturesButton_Click(object sender, EventArgs e)
        {
            this.utilisateurForm.Visible = false;
            this.chambreForm.Visible = false;
            this.reservationForm.Visible = false;
            this.searchForm.Visible = false;
           this.factureForm.Visible = false;

            this.facturePrint.Visible = true;
            this.facturePrintLabel.BringToFront();
            this.facturePrint.Location = new System.Drawing.Point(526, 118);
            this.facturePrintLabel.Location = new System.Drawing.Point(434, 136);

            this.utilisateursButton.BackColor = Color.White;
            this.utilisateursIcon.BackColor = Color.White;
            this.reservationsButton.BackColor = Color.White;
            this.ureservationsIcon.BackColor = Color.White;
            this.chambresButton.BackColor = Color.White;
            this.chambresIcon.BackColor = Color.White;

            this.facturesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122))))); ;
            this.facturesIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122))))); ;

            loadFacturesData();
            viderFactureForm();
        }


        //operations (cud)
        private void reservationButton_Click(object sender, EventArgs e)
        {
            if (this.selectedRow != null)
            {
                loadReservationsData((Utilisateur)this.selectedRow);
            }
            else
            {
                MessageBox.Show("selectionner une ligne");
            }
        }
        private void chercherButton_Click(object sender, EventArgs e)
        {
            this.searchForm.Visible = true;
            this.utilisateurForm.Visible = false;
            this.reservationForm.Visible = false;
            this.chambreForm.Visible = false;

            this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));



        }
        private void supprimerButton_Click(object sender, EventArgs e)
        {
            viderUtilisateurForm();
            viderChambreForm();
            this.searchForm.Visible = false;
            if (this.selectedRow != null)
            {

                if (this.selectedRow.GetType().Name.ToString() == "Utilisateur")
                {
                    this.hotelController.deleteUtilisateur((Utilisateur)this.selectedRow);
                    loadUtilisateursData();
                }
                if (this.selectedRow.GetType().Name.ToString() == "Chambre")
                {
                    this.hotelController.deleteChambre((Chambre)this.selectedRow);
                    loadChambreData();
                }
                if (this.selectedRow.GetType().Name.ToString() == "Reservation")
                {
                    this.hotelController.deleteReservation((Reservation)this.selectedRow);
                    loadReservationsData(null);
                }
            }
            else
            {
                MessageBox.Show("Selectionner une ligne");
            }




        }
        private void ajouterButton_Click(object sender, EventArgs e)
        {

            viderUtilisateurForm();
            viderChambreForm();
            viderReservationsForm();
            this.searchForm.Visible = false;

            if (this.ajouterLabel.Text == "Ajouter un utilisateur")
            {
                this.submitButton.Text = "Valider";
                this.utilisateurForm.Visible = true;
                this.utilisateurForm.SendToBack();
                if (this.rows.Count != 0)
                {
                    this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
                    this.mainPanel.Controls.Add(this.reservationButton);
                }
            }
            if (this.ajouterLabel.Text == "Ajouter une chambre")
            {
                this.chambreSubmitButton.Text = "Valider";
                this.chambreForm.Visible = true;
                this.utilisateurForm.SendToBack();
                if (this.rows.Count != 0)
                {
                    this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
                }
            }
            if (this.ajouterLabel.Text == "Ajouter une reservation")
            {
                this.reservationSubmitButton.Text = "Valider";
                this.reservationForm.Visible = true;
                this.reservationForm.SendToBack();
                if (this.rows.Count != 0)
                {
                    this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
                }
            }
            if (this.ajouterLabel.Text == "Ajouter une facture")
            {
                if (this.rows.Count != 0)
                {
                    this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
                }
                Facture f = new Facture();

                MessageBox.Show("Une nouvelle facture a étes creé avec Id = " + this.hotelController.addFacture(f));

            }
            this.selectedRow = null;
        }
        private void modifierButton_Click(object sender, EventArgs e)
        {
            this.searchForm.Visible = false;
            if (this.selectedRow != null)
            {
                if (this.rows.Count != 0)
                {
                    this.rows.ForEach((row) => this.mainPanel.Controls.Remove(row));
                }
                if (this.modifierLabel.Text == "Modifier un utilisateur")
                {
                    this.submitButton.Text = "Modifier";
                    this.utilisateurForm.Visible = true;
                    this.utilisateurForm.SendToBack();

                    this.mainPanel.Controls.Add(this.reservationButton);


                    Utilisateur u = (Utilisateur)this.selectedRow;

                    this.nom.Text = u.Nom;
                    this.prenom.Text = u.Prenom;
                    this.adresse.Text = u.Adresse;
                    this.pays.Text = u.Pays;
                    this.ville.Text = u.Ville;
                    this.codePostal.Text = u.Code_postal;
                    this.email.Text = u.Email;
                    this.tel.Text = u.Tel;
                    this.role.SelectedText = u.Role == 0 ? "admin" : "client";


                }
                if (this.modifierLabel.Text == "Modifier une chambre")
                {
                    this.chambreSubmitButton.Text = "Modifier";
                    this.chambreForm.Visible = true;
                    this.chambreForm.SendToBack();



                    Chambre c = (Chambre)this.selectedRow;

                    this.chambreTel.Text = c.NumTel;
                    this.chambreHotel.SelectedItem = c.Hotel.Nom;
                    this.chambreCategorie.SelectedItem = c.Categorie.Nom;
                    this.chambreImagePath = c.ChambreImage.Src;



                }
                if (this.modifierLabel.Text == "Modifier une reservation")
                {
                    this.chambreSubmitButton.Text = "Modifier";
                    this.reservationForm.Visible = true;
                    this.reservationForm.SendToBack();



                    Reservation r = (Reservation)this.selectedRow;

                    this.reservationDatedebut.Value = r.DateDebut;
                    this.reservationDateFin.Value = r.DateFin;
                    this.reservationUtilisateurId.SelectedItem = r.UtilisateurId;
                    this.reservationChambreId.SelectedItem = r.ChambreId;
                    this.reservationFactureId.SelectedItem = r.FactureId;

                }
                if (this.modifierLabel.Text == "Modifier une facture")
                {
                    this.factureForm.Visible = true;
                    this.factureForm.SendToBack();



                    Facture f = (Facture)this.selectedRow;

                    this.facturePaye.Checked = f.paye;

                }

            }
            else
            {
                MessageBox.Show("selectioner une ligne");
            }
        }

        //operations submit
        private void chercherSubmitButton_Click(object sender, EventArgs e)
        {
            this.searchedRow = this.chercherId.Text;
            if (this.chercherLabel.Text == "Chercher un utilisateur")
            {
                loadUtilisateursData();
            }
            if (this.chercherLabel.Text == "Chercher une chambre")
            {

                loadChambreData();
            }
            if (this.chercherLabel.Text == "Chercher une reservation")
            {
                loadReservationsData(null);
            }
            if (this.chercherLabel.Text == "Chercher une facture")
            {

                loadFacturesData();
            }
            this.chercherId.Text = "";
            this.searchedRow = null;
        }
        private void reservationSubmitButton_Click(object sender, EventArgs e)
        {


            if (this.selectedRow != null)
            {

                DateTime dateDebut = DateTime.SpecifyKind(this.reservationDatedebut.Value, DateTimeKind.Utc);
                DateTime dateFin = DateTime.SpecifyKind(this.reservationDateFin.Value, DateTimeKind.Utc);
                Chambre chambre = this.hotelController.getChambreById(Int16.Parse(this.reservationUtilisateurId.SelectedItem.ToString()))[0];
                if (!this.hotelController.isReserved(dateDebut, dateFin, chambre))

                {
                    Reservation r = (Reservation)this.selectedRow;
                    Reservation reservation = new Reservation(dateDebut, dateFin, Int16.Parse(this.reservationUtilisateurId.SelectedItem.ToString()), Int16.Parse(this.reservationChambreId.SelectedItem.ToString()), Int16.Parse(this.reservationFactureId.SelectedItem.ToString()));
                    reservation.Id = r.Id;
                    this.hotelController.updateReservation(reservation);
                    loadReservationsData(null);
                }
                else
                {
                    MessageBox.Show("La chambre n'est libre dans l'interval du temps demandé");
                }
            }
            else
            {
                DateTime dateDebut = DateTime.SpecifyKind(this.reservationDatedebut.Value, DateTimeKind.Utc);
                DateTime dateFin = DateTime.SpecifyKind(this.reservationDateFin.Value, DateTimeKind.Utc);
                Chambre chambre = this.hotelController.getChambreById(Int16.Parse(this.reservationUtilisateurId.SelectedItem.ToString()))[0];
                if (!this.hotelController.isReserved(dateDebut, dateFin, chambre))

                {
                    Reservation reservation = new Reservation(dateDebut, dateFin, Int16.Parse(this.reservationUtilisateurId.SelectedItem.ToString()), Int16.Parse(this.reservationChambreId.SelectedItem.ToString()), Int16.Parse(this.reservationFactureId.SelectedItem.ToString()));
                    this.hotelController.addReservation(reservation);
                    loadReservationsData(null);
                }
                else
                {
                    MessageBox.Show("La chambre n'est libre dans l'interval du temps demandé");
                }

            }
            viderReservationsForm();

        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            int role = 1;
            if (this.role.SelectedText == "admin")
            {
                role = 0;
            }

            if (this.selectedRow != null)
            {

                Utilisateur u = (Utilisateur)this.selectedRow;
                Utilisateur utilisateur = new Utilisateur(this.nom.Text, this.prenom.Text, this.adresse.Text, this.pays.Text, this.ville.Text, this.codePostal.Text, this.email.Text, this.tel.Text, role);
                utilisateur.Id = u.Id;
                this.hotelController.updateUtilisateur(utilisateur);
                loadUtilisateursData();
            }
            else
            {

                Utilisateur utilisateur = new Utilisateur(this.nom.Text, this.prenom.Text, this.adresse.Text, this.pays.Text, this.ville.Text, this.codePostal.Text, this.email.Text, this.tel.Text, role);
                this.hotelController.addUtilisateur(utilisateur);
                loadUtilisateursData();

            }
            viderUtilisateurForm();

        }

        private void factureSubmitButton_Click(object sender, EventArgs e)
        {

            if (this.selectedRow != null)
            {

                       
                Facture facture = new Facture();
                Facture f = (Facture)this.selectedRow;

                facture.Id = f.Id;
                facture.paye = this.facturePaye.Checked;
                this.hotelController.updateFacture(facture);
                if (this.facturePrix.Text != "" && this.factureType.Text != "")
                {
                    DateTime date = DateTime.SpecifyKind(this.factureDate.Value, DateTimeKind.Utc);
                    Prestation prestation = new Prestation();
                    prestation.Date = date;
                    prestation.Prix = Int16.Parse(this.facturePrix.Text);
                    prestation.Type = this.factureType.Text;
                    prestation.FactureId = f.Id;

                    this.hotelController.addPrestaion(prestation);
                }
                loadFacturesData();
               
            }
           
            viderFactureForm();
        }

        private void facturePrint_Click(object sender, EventArgs e)
        {
            if (this.selectedRow != null)
            {
                FactureTicket ft = new FactureTicket((Facture)this.selectedRow);
                ft.Show();
            }
            else
            {
                MessageBox.Show("Selectionner une Facture");
            }
        }
    }


}
