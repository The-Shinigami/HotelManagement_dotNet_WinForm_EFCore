namespace WinFormsApp1.View
{
    partial class DetailsHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.hotelNom = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.numTel = new System.Windows.Forms.Label();
            this.numTelLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.footer = new WinFormsApp1.RoundPanel();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotelNom
            // 
            this.hotelNom.AutoSize = true;
            this.hotelNom.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hotelNom.Location = new System.Drawing.Point(329, 21);
            this.hotelNom.Name = "hotelNom";
            this.hotelNom.Size = new System.Drawing.Size(127, 54);
            this.hotelNom.TabIndex = 3;
            this.hotelNom.Text = "Hotel";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.ForeColor = System.Drawing.Color.White;
            this.adress.Location = new System.Drawing.Point(123, 17);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(38, 15);
            this.adress.TabIndex = 8;
            this.adress.Text = "label4";
            // 
            // numTel
            // 
            this.numTel.AutoSize = true;
            this.numTel.ForeColor = System.Drawing.Color.White;
            this.numTel.Location = new System.Drawing.Point(656, 17);
            this.numTel.Name = "numTel";
            this.numTel.Size = new System.Drawing.Size(38, 15);
            this.numTel.TabIndex = 7;
            this.numTel.Text = "label3";
            // 
            // numTelLabel
            // 
            this.numTelLabel.AutoSize = true;
            this.numTelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numTelLabel.ForeColor = System.Drawing.Color.White;
            this.numTelLabel.Location = new System.Drawing.Point(561, 17);
            this.numTelLabel.Name = "numTelLabel";
            this.numTelLabel.Size = new System.Drawing.Size(89, 15);
            this.numTelLabel.TabIndex = 6;
            this.numTelLabel.Text = "Numero de Tel";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdressLabel.ForeColor = System.Drawing.Color.White;
            this.AdressLabel.Location = new System.Drawing.Point(70, 17);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(47, 15);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Adress ";
            this.AdressLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.Gray;
            this.footer.BorderRadius = 5;
            this.footer.Controls.Add(this.AdressLabel);
            this.footer.Controls.Add(this.adress);
            this.footer.Controls.Add(this.numTelLabel);
            this.footer.Controls.Add(this.numTel);
            this.footer.Location = new System.Drawing.Point(12, 407);
            this.footer.Name = "footer";
            this.footer.ShadowColor = System.Drawing.Color.White;
            this.footer.ShadowSize = 0;
            this.footer.ShadowVariante = 0;
            this.footer.Size = new System.Drawing.Size(791, 43);
            this.footer.TabIndex = 5;
            // 
            // DetailsHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(815, 462);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.hotelNom);
            this.MaximumSize = new System.Drawing.Size(831, 501);
            this.MinimumSize = new System.Drawing.Size(831, 501);
            this.Name = "DetailsHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsHotel";
            this.Load += new System.EventHandler(this.DetailsHotel_Load);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        
        
        private Label hotelNom;
        private Label adress;
        private Label numTel;
        private Label numTelLabel;
        private Label AdressLabel;
        private RoundPanel footer;
    }
}