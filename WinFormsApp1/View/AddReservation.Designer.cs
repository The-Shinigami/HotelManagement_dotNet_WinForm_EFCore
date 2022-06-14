namespace WinFormsApp1.View
{
    partial class AddReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundPanel1 = new WinFormsApp1.RoundPanel();
            this.ville = new CustomControls.MBControls.TextArea();
            this.pays = new CustomControls.MBControls.TextArea();
            this.adresse = new CustomControls.MBControls.TextArea();
            this.prenom = new CustomControls.MBControls.TextArea();
            this.nom = new CustomControls.MBControls.TextArea();
            this.villeLabel = new WinFormsApp1.RoundLabel();
            this.payeLabel = new WinFormsApp1.RoundLabel();
            this.adresseLabel = new WinFormsApp1.RoundLabel();
            this.prenomLabel = new WinFormsApp1.RoundLabel();
            this.nomLabel = new WinFormsApp1.RoundLabel();
            this.codePostal = new CustomControls.MBControls.TextArea();
            this.codePostalLabel = new WinFormsApp1.RoundLabel();
            this.roundPanel2 = new WinFormsApp1.RoundPanel();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.email = new CustomControls.MBControls.TextArea();
            this.tel = new CustomControls.MBControls.TextArea();
            this.dateFinLabel = new WinFormsApp1.RoundLabel();
            this.dateDebutLabel = new WinFormsApp1.RoundLabel();
            this.emailLabel = new WinFormsApp1.RoundLabel();
            this.telLabel = new WinFormsApp1.RoundLabel();
            this.submitButton = new CustomControls.RJControls.LinkButton();
            this.roundPanel1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.White;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.Controls.Add(this.ville);
            this.roundPanel1.Controls.Add(this.pays);
            this.roundPanel1.Controls.Add(this.adresse);
            this.roundPanel1.Controls.Add(this.prenom);
            this.roundPanel1.Controls.Add(this.nom);
            this.roundPanel1.Controls.Add(this.villeLabel);
            this.roundPanel1.Controls.Add(this.payeLabel);
            this.roundPanel1.Controls.Add(this.adresseLabel);
            this.roundPanel1.Controls.Add(this.prenomLabel);
            this.roundPanel1.Controls.Add(this.nomLabel);
            this.roundPanel1.Location = new System.Drawing.Point(46, 104);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.ShadowColor = System.Drawing.Color.White;
            this.roundPanel1.ShadowSize = 0;
            this.roundPanel1.ShadowVariante = 0;
            this.roundPanel1.Size = new System.Drawing.Size(359, 268);
            this.roundPanel1.TabIndex = 0;
            // 
            // ville
            // 
            this.ville.BackColor = System.Drawing.Color.LightGray;
            this.ville.CausesValidation = false;
            this.ville.Location = new System.Drawing.Point(168, 215);
            this.ville.MaximumSize = new System.Drawing.Size(141, 25);
            this.ville.MinimumSize = new System.Drawing.Size(141, 25);
            this.ville.Name = "ville";
            this.ville.PlaceholderText = "Entrer Votre Ville";
            this.ville.Size = new System.Drawing.Size(141, 25);
            this.ville.TabIndex = 15;
            this.ville.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pays
            // 
            this.pays.BackColor = System.Drawing.Color.LightGray;
            this.pays.CausesValidation = false;
            this.pays.Location = new System.Drawing.Point(168, 174);
            this.pays.MaximumSize = new System.Drawing.Size(141, 25);
            this.pays.MinimumSize = new System.Drawing.Size(141, 25);
            this.pays.Name = "pays";
            this.pays.PlaceholderText = "Entrer Votre Pays";
            this.pays.Size = new System.Drawing.Size(141, 25);
            this.pays.TabIndex = 14;
            this.pays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adresse
            // 
            this.adresse.BackColor = System.Drawing.Color.LightGray;
            this.adresse.CausesValidation = false;
            this.adresse.Location = new System.Drawing.Point(168, 132);
            this.adresse.MaximumSize = new System.Drawing.Size(141, 25);
            this.adresse.MinimumSize = new System.Drawing.Size(141, 25);
            this.adresse.Name = "adresse";
            this.adresse.PlaceholderText = "Entrer Votre Adresse";
            this.adresse.Size = new System.Drawing.Size(141, 25);
            this.adresse.TabIndex = 13;
            this.adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.Color.LightGray;
            this.prenom.CausesValidation = false;
            this.prenom.Location = new System.Drawing.Point(168, 89);
            this.prenom.MaximumSize = new System.Drawing.Size(141, 25);
            this.prenom.MinimumSize = new System.Drawing.Size(141, 25);
            this.prenom.Name = "prenom";
            this.prenom.PlaceholderText = "Entrer Votre Prenom";
            this.prenom.Size = new System.Drawing.Size(141, 25);
            this.prenom.TabIndex = 12;
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.LightGray;
            this.nom.CausesValidation = false;
            this.nom.Location = new System.Drawing.Point(168, 45);
            this.nom.MaximumSize = new System.Drawing.Size(141, 25);
            this.nom.MinimumSize = new System.Drawing.Size(141, 25);
            this.nom.Name = "nom";
            this.nom.PlaceholderText = "Entrer Votre Nom";
            this.nom.Size = new System.Drawing.Size(141, 25);
            this.nom.TabIndex = 11;
            this.nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nom.TextChanged += new System.EventHandler(this.textArea1_TextChanged);
            // 
            // villeLabel
            // 
            this.villeLabel.BorderRadius = 20;
            this.villeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.villeLabel.Location = new System.Drawing.Point(47, 213);
            this.villeLabel.Name = "villeLabel";
            this.villeLabel.Size = new System.Drawing.Size(100, 23);
            this.villeLabel.TabIndex = 9;
            this.villeLabel.Text = "Ville";
            this.villeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payeLabel
            // 
            this.payeLabel.BorderRadius = 20;
            this.payeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payeLabel.Location = new System.Drawing.Point(47, 172);
            this.payeLabel.Name = "payeLabel";
            this.payeLabel.Size = new System.Drawing.Size(100, 23);
            this.payeLabel.TabIndex = 8;
            this.payeLabel.Text = "Pays";
            this.payeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.payeLabel.Click += new System.EventHandler(this.roundLabel3_Click);
            // 
            // adresseLabel
            // 
            this.adresseLabel.BorderRadius = 20;
            this.adresseLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adresseLabel.Location = new System.Drawing.Point(47, 130);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(100, 23);
            this.adresseLabel.TabIndex = 7;
            this.adresseLabel.Text = "Adresse";
            this.adresseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prenomLabel
            // 
            this.prenomLabel.BorderRadius = 20;
            this.prenomLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenomLabel.Location = new System.Drawing.Point(47, 87);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(100, 23);
            this.prenomLabel.TabIndex = 6;
            this.prenomLabel.Text = "Prenom";
            this.prenomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomLabel
            // 
            this.nomLabel.BorderRadius = 20;
            this.nomLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomLabel.Location = new System.Drawing.Point(47, 43);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(100, 23);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom";
            this.nomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codePostal
            // 
            this.codePostal.BackColor = System.Drawing.Color.White;
            this.codePostal.CausesValidation = false;
            this.codePostal.Location = new System.Drawing.Point(153, 43);
            this.codePostal.MaximumSize = new System.Drawing.Size(141, 25);
            this.codePostal.MinimumSize = new System.Drawing.Size(141, 25);
            this.codePostal.Name = "codePostal";
            this.codePostal.PlaceholderText = "Entrer Votre Code Postal";
            this.codePostal.Size = new System.Drawing.Size(141, 25);
            this.codePostal.TabIndex = 16;
            this.codePostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.BorderRadius = 20;
            this.codePostalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codePostalLabel.Location = new System.Drawing.Point(13, 47);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(100, 23);
            this.codePostalLabel.TabIndex = 10;
            this.codePostalLabel.Text = "Code Postal";
            this.codePostalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundPanel2.BorderRadius = 20;
            this.roundPanel2.Controls.Add(this.codePostal);
            this.roundPanel2.Controls.Add(this.dateFin);
            this.roundPanel2.Controls.Add(this.dateDebut);
            this.roundPanel2.Controls.Add(this.email);
            this.roundPanel2.Controls.Add(this.tel);
            this.roundPanel2.Controls.Add(this.codePostalLabel);
            this.roundPanel2.Controls.Add(this.dateFinLabel);
            this.roundPanel2.Controls.Add(this.dateDebutLabel);
            this.roundPanel2.Controls.Add(this.emailLabel);
            this.roundPanel2.Controls.Add(this.telLabel);
            this.roundPanel2.Location = new System.Drawing.Point(436, 104);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.ShadowColor = System.Drawing.Color.White;
            this.roundPanel2.ShadowSize = 0;
            this.roundPanel2.ShadowVariante = 0;
            this.roundPanel2.Size = new System.Drawing.Size(334, 268);
            this.roundPanel2.TabIndex = 1;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(119, 217);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(200, 23);
            this.dateFin.TabIndex = 22;
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(119, 176);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(200, 23);
            this.dateDebut.TabIndex = 21;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.CausesValidation = false;
            this.email.Location = new System.Drawing.Point(153, 128);
            this.email.MaximumSize = new System.Drawing.Size(141, 25);
            this.email.MinimumSize = new System.Drawing.Size(141, 25);
            this.email.Name = "email";
            this.email.PlaceholderText = "Entrer Votre Email";
            this.email.Size = new System.Drawing.Size(141, 25);
            this.email.TabIndex = 17;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.White;
            this.tel.CausesValidation = false;
            this.tel.Location = new System.Drawing.Point(153, 87);
            this.tel.MaximumSize = new System.Drawing.Size(141, 25);
            this.tel.MinimumSize = new System.Drawing.Size(141, 25);
            this.tel.Name = "tel";
            this.tel.PlaceholderText = "Entrer Votre Num Tel";
            this.tel.Size = new System.Drawing.Size(141, 25);
            this.tel.TabIndex = 17;
            this.tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateFinLabel
            // 
            this.dateFinLabel.BorderRadius = 20;
            this.dateFinLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateFinLabel.Location = new System.Drawing.Point(13, 217);
            this.dateFinLabel.Name = "dateFinLabel";
            this.dateFinLabel.Size = new System.Drawing.Size(100, 23);
            this.dateFinLabel.TabIndex = 20;
            this.dateFinLabel.Text = "Date Fin";
            this.dateFinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateDebutLabel
            // 
            this.dateDebutLabel.BorderRadius = 20;
            this.dateDebutLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateDebutLabel.Location = new System.Drawing.Point(13, 174);
            this.dateDebutLabel.Name = "dateDebutLabel";
            this.dateDebutLabel.Size = new System.Drawing.Size(100, 23);
            this.dateDebutLabel.TabIndex = 19;
            this.dateDebutLabel.Text = "Date Debut";
            this.dateDebutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.BorderRadius = 20;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(13, 134);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telLabel
            // 
            this.telLabel.BorderRadius = 20;
            this.telLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telLabel.Location = new System.Drawing.Point(13, 87);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(100, 23);
            this.telLabel.TabIndex = 17;
            this.telLabel.Text = "Tel";
            this.telLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.submitButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.submitButton.BorderColor = System.Drawing.Color.White;
            this.submitButton.BorderRadius = 20;
            this.submitButton.BorderSize = 0;
            this.submitButton.ButtomBorderSize = 0;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(341, 398);
            this.submitButton.Name = "submitButton";
            this.submitButton.ShadowColor = System.Drawing.Color.Gray;
            this.submitButton.ShadowSize = 2;
            this.submitButton.Size = new System.Drawing.Size(816, 489);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Valider";
            this.submitButton.TextColor = System.Drawing.Color.White;
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Name = "AddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReservation";
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
        private RoundLabel payeLabel;
        private RoundLabel adresseLabel;
        private RoundLabel prenomLabel;
        private RoundLabel nomLabel;
        private RoundPanel roundPanel2;
        private RoundLabel codePostalLabel;
        private RoundLabel villeLabel;
        private CustomControls.MBControls.TextArea nom;
        private CustomControls.MBControls.TextArea codePostal;
        private CustomControls.MBControls.TextArea ville;
        private CustomControls.MBControls.TextArea pays;
        private CustomControls.MBControls.TextArea adresse;
        private CustomControls.MBControls.TextArea prenom;
        private DateTimePicker dateFin;
        private DateTimePicker dateDebut;
        private CustomControls.MBControls.TextArea email;
        private CustomControls.MBControls.TextArea tel;
        private RoundLabel dateFinLabel;
        private RoundLabel dateDebutLabel;
        private RoundLabel emailLabel;
        private RoundLabel telLabel;
        private CustomControls.RJControls.LinkButton submitButton;
    }
}