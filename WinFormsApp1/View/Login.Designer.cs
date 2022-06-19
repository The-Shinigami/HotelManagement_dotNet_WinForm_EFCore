namespace WinFormsApp1.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.roundPanel1 = new WinFormsApp1.RoundPanel();
            this.submitButton = new CustomControls.RJControls.LinkButton();
            this.email = new CustomControls.MBControls.TextArea();
            this.password = new CustomControls.MBControls.TextArea();
            this.telLabel = new WinFormsApp1.RoundLabel();
            this.emailLabel = new WinFormsApp1.RoundLabel();
            this.roundPicture1 = new WinFormsApp1.RoundPicture();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.White;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.Controls.Add(this.submitButton);
            this.roundPanel1.Controls.Add(this.email);
            this.roundPanel1.Controls.Add(this.password);
            this.roundPanel1.Controls.Add(this.telLabel);
            this.roundPanel1.Controls.Add(this.emailLabel);
            this.roundPanel1.Location = new System.Drawing.Point(425, 87);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.ShadowColor = System.Drawing.Color.White;
            this.roundPanel1.ShadowSize = 0;
            this.roundPanel1.ShadowVariante = 0;
            this.roundPanel1.Size = new System.Drawing.Size(334, 283);
            this.roundPanel1.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122)))));
            this.submitButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122)))));
            this.submitButton.BorderColor = System.Drawing.Color.Gray;
            this.submitButton.BorderRadius = 20;
            this.submitButton.BorderSize = 0;
            this.submitButton.ButtomBorderSize = 2;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.submitButton.Location = new System.Drawing.Point(53, 194);
            this.submitButton.Name = "submitButton";
            this.submitButton.ShadowColor = System.Drawing.Color.Gray;
            this.submitButton.ShadowSize = 2;
            this.submitButton.Size = new System.Drawing.Size(241, 41);
            this.submitButton.TabIndex = 23;
            this.submitButton.Text = "Valider";
            this.submitButton.TextColor = System.Drawing.Color.FloralWhite;
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.CausesValidation = false;
            this.email.Location = new System.Drawing.Point(172, 68);
            this.email.MaximumSize = new System.Drawing.Size(141, 25);
            this.email.MinimumSize = new System.Drawing.Size(141, 25);
            this.email.Name = "email";
            this.email.PlaceholderText = "Entrer Votre Email";
            this.email.Size = new System.Drawing.Size(141, 25);
            this.email.TabIndex = 19;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.CausesValidation = false;
            this.password.Location = new System.Drawing.Point(172, 126);
            this.password.MaximumSize = new System.Drawing.Size(141, 25);
            this.password.MinimumSize = new System.Drawing.Size(141, 25);
            this.password.Name = "password";
            this.password.PlaceholderText = "Entrer Votre Password";
            this.password.Size = new System.Drawing.Size(141, 25);
            this.password.TabIndex = 20;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telLabel
            // 
            this.telLabel.BorderRadius = 20;
            this.telLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telLabel.Location = new System.Drawing.Point(33, 126);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(100, 23);
            this.telLabel.TabIndex = 21;
            this.telLabel.Text = "Password";
            this.telLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.BorderRadius = 20;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(33, 68);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundPicture1
            // 
            this.roundPicture1.BorderRadius = 20;
            this.roundPicture1.Image = ((System.Drawing.Image)(resources.GetObject("roundPicture1.Image")));
            this.roundPicture1.Location = new System.Drawing.Point(38, 87);
            this.roundPicture1.Name = "roundPicture1";
            this.roundPicture1.Size = new System.Drawing.Size(356, 283);
            this.roundPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicture1.TabIndex = 1;
            this.roundPicture1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundPicture1);
            this.Controls.Add(this.roundPanel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
        private RoundPicture roundPicture1;
        private CustomControls.MBControls.TextArea email;
        private CustomControls.MBControls.TextArea password;
        private RoundLabel telLabel;
        private RoundLabel emailLabel;
        private CustomControls.RJControls.LinkButton submitButton;
    }
}