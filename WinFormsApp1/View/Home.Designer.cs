namespace WinFormsApp1
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.linkButton1 = new CustomControls.RJControls.LinkButton();
            this.linkButton3 = new CustomControls.RJControls.LinkButton();
            this.linkButton4 = new CustomControls.RJControls.LinkButton();
            this.linkButton5 = new CustomControls.RJControls.LinkButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPicture1 = new WinFormsApp1.RoundPicture();
            this.roundPanel1 = new WinFormsApp1.RoundPanel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture1)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkButton1
            // 
            this.linkButton1.BackColor = System.Drawing.Color.White;
            this.linkButton1.BackgroundColor = System.Drawing.Color.White;
            this.linkButton1.BorderColor = System.Drawing.Color.White;
            this.linkButton1.BorderRadius = 20;
            this.linkButton1.BorderSize = 0;
            this.linkButton1.ButtomBorderSize = 2;
            this.linkButton1.FlatAppearance.BorderSize = 0;
            this.linkButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkButton1.ForeColor = System.Drawing.Color.Black;
            this.linkButton1.Location = new System.Drawing.Point(690, 24);
            this.linkButton1.Name = "linkButton1";
            this.linkButton1.ShadowColor = System.Drawing.Color.DarkGray;
            this.linkButton1.ShadowSize = 3;
            this.linkButton1.Size = new System.Drawing.Size(85, 41);
            this.linkButton1.TabIndex = 0;
            this.linkButton1.Text = "Login";
            this.linkButton1.TextColor = System.Drawing.Color.Black;
            this.linkButton1.UseVisualStyleBackColor = false;
            this.linkButton1.Click += new System.EventHandler(this.linkButton1_Click);
            // 
            // linkButton3
            // 
            this.linkButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.linkButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.linkButton3.BorderColor = System.Drawing.Color.Black;
            this.linkButton3.BorderRadius = 0;
            this.linkButton3.BorderSize = 0;
            this.linkButton3.ButtomBorderSize = 3;
            this.linkButton3.FlatAppearance.BorderSize = 0;
            this.linkButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkButton3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkButton3.ForeColor = System.Drawing.Color.Black;
            this.linkButton3.Location = new System.Drawing.Point(55, 22);
            this.linkButton3.Name = "linkButton3";
            this.linkButton3.ShadowColor = System.Drawing.Color.Gray;
            this.linkButton3.ShadowSize = 0;
            this.linkButton3.Size = new System.Drawing.Size(77, 44);
            this.linkButton3.TabIndex = 2;
            this.linkButton3.Text = "Home";
            this.linkButton3.TextColor = System.Drawing.Color.Black;
            this.linkButton3.UseVisualStyleBackColor = false;
            this.linkButton3.Click += new System.EventHandler(this.linkButton3_Click);
            // 
            // linkButton4
            // 
            this.linkButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.linkButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.linkButton4.BorderColor = System.Drawing.Color.Black;
            this.linkButton4.BorderRadius = 0;
            this.linkButton4.BorderSize = 0;
            this.linkButton4.ButtomBorderSize = 0;
            this.linkButton4.FlatAppearance.BorderSize = 0;
            this.linkButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkButton4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkButton4.ForeColor = System.Drawing.Color.Black;
            this.linkButton4.Location = new System.Drawing.Point(138, 18);
            this.linkButton4.Name = "linkButton4";
            this.linkButton4.ShadowColor = System.Drawing.Color.Gray;
            this.linkButton4.ShadowSize = 0;
            this.linkButton4.Size = new System.Drawing.Size(101, 48);
            this.linkButton4.TabIndex = 3;
            this.linkButton4.Text = "Services";
            this.linkButton4.TextColor = System.Drawing.Color.Black;
            this.linkButton4.UseVisualStyleBackColor = false;
            this.linkButton4.Click += new System.EventHandler(this.linkButton4_Click);
            // 
            // linkButton5
            // 
            this.linkButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122)))));
            this.linkButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(169)))), ((int)(((byte)(122)))));
            this.linkButton5.BorderColor = System.Drawing.Color.White;
            this.linkButton5.BorderRadius = 20;
            this.linkButton5.BorderSize = 0;
            this.linkButton5.ButtomBorderSize = 2;
            this.linkButton5.FlatAppearance.BorderSize = 0;
            this.linkButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkButton5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkButton5.ForeColor = System.Drawing.Color.White;
            this.linkButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkButton5.Location = new System.Drawing.Point(60, 165);
            this.linkButton5.Name = "linkButton5";
            this.linkButton5.ShadowColor = System.Drawing.Color.Gainsboro;
            this.linkButton5.ShadowSize = 3;
            this.linkButton5.Size = new System.Drawing.Size(223, 40);
            this.linkButton5.TabIndex = 6;
            this.linkButton5.Text = "BOOK A ROOM NOW";
            this.linkButton5.TextColor = System.Drawing.Color.White;
            this.linkButton5.UseVisualStyleBackColor = false;
            this.linkButton5.Click += new System.EventHandler(this.linkButton5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(60, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 125);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME TO \r\nOUR\r\n HOTEL SERIES \r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundPicture1
            // 
            this.roundPicture1.BorderRadius = 20;
            this.roundPicture1.Image = ((System.Drawing.Image)(resources.GetObject("roundPicture1.Image")));
            this.roundPicture1.Location = new System.Drawing.Point(12, 111);
            this.roundPicture1.Name = "roundPicture1";
            this.roundPicture1.Size = new System.Drawing.Size(420, 297);
            this.roundPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicture1.TabIndex = 9;
            this.roundPicture1.TabStop = false;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.White;
            this.roundPanel1.BorderRadius = 20;
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.linkButton5);
            this.roundPanel1.Controls.Add(this.pictureBox2);
            this.roundPanel1.Location = new System.Drawing.Point(450, 111);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.ShadowColor = System.Drawing.Color.White;
            this.roundPanel1.ShadowSize = 0;
            this.roundPanel1.ShadowVariante = 0;
            this.roundPanel1.Size = new System.Drawing.Size(338, 297);
            this.roundPanel1.TabIndex = 10;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.roundPicture1);
            this.Controls.Add(this.linkButton4);
            this.Controls.Add(this.linkButton3);
            this.Controls.Add(this.linkButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture1)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.LinkButton linkButton1;
        private CustomControls.RJControls.LinkButton linkButton3;
        private CustomControls.RJControls.LinkButton linkButton4;
        private CustomControls.RJControls.LinkButton linkButton5;
        private PictureBox pictureBox2;
        private Label label1;
        private RoundPicture roundPicture1;
        private RoundPanel roundPanel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private SaveFileDialog saveFileDialog;
    }
}