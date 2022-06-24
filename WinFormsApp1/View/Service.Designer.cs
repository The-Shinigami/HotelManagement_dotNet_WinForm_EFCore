namespace WinFormsApp1
{
    partial class Service
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.linkButton4 = new CustomControls.RJControls.LinkButton();
            this.linkButton3 = new CustomControls.RJControls.LinkButton();
            this.linkButton1 = new CustomControls.RJControls.LinkButton();
            this.sliderLabel = new WinFormsApp1.RoundLabel();
            this.sliderPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPic)).BeginInit();
            this.SuspendLayout();
            // 
            // linkButton4
            // 
            this.linkButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.linkButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.linkButton4.BorderColor = System.Drawing.Color.Black;
            this.linkButton4.BorderRadius = 0;
            this.linkButton4.BorderSize = 0;
            this.linkButton4.ButtomBorderSize = 3;
            this.linkButton4.FlatAppearance.BorderSize = 0;
            this.linkButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkButton4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkButton4.ForeColor = System.Drawing.Color.Black;
            this.linkButton4.Location = new System.Drawing.Point(138, 19);
            this.linkButton4.Name = "linkButton4";
            this.linkButton4.ShadowColor = System.Drawing.Color.Gray;
            this.linkButton4.ShadowSize = 0;
            this.linkButton4.Size = new System.Drawing.Size(101, 48);
            this.linkButton4.TabIndex = 7;
            this.linkButton4.Text = "Services";
            this.linkButton4.TextColor = System.Drawing.Color.Black;
            this.linkButton4.UseVisualStyleBackColor = false;
            // 
            // linkButton3
            // 
            this.linkButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.linkButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.linkButton3.BorderColor = System.Drawing.Color.Black;
            this.linkButton3.BorderRadius = 0;
            this.linkButton3.BorderSize = 0;
            this.linkButton3.ButtomBorderSize = 0;
            this.linkButton3.FlatAppearance.BorderSize = 0;
            this.linkButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkButton3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkButton3.ForeColor = System.Drawing.Color.Black;
            this.linkButton3.Location = new System.Drawing.Point(55, 23);
            this.linkButton3.Name = "linkButton3";
            this.linkButton3.ShadowColor = System.Drawing.Color.Gray;
            this.linkButton3.ShadowSize = 0;
            this.linkButton3.Size = new System.Drawing.Size(77, 44);
            this.linkButton3.TabIndex = 6;
            this.linkButton3.Text = "Home";
            this.linkButton3.TextColor = System.Drawing.Color.Black;
            this.linkButton3.UseVisualStyleBackColor = false;
            this.linkButton3.Click += new System.EventHandler(this.linkButton3_Click_1);
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
            this.linkButton1.Location = new System.Drawing.Point(690, 25);
            this.linkButton1.Name = "linkButton1";
            this.linkButton1.ShadowColor = System.Drawing.Color.DarkGray;
            this.linkButton1.ShadowSize = 3;
            this.linkButton1.Size = new System.Drawing.Size(98, 41);
            this.linkButton1.TabIndex = 4;
            this.linkButton1.Text = "Connexion";
            this.linkButton1.TextColor = System.Drawing.Color.Black;
            this.linkButton1.UseVisualStyleBackColor = false;
            this.linkButton1.Click += new System.EventHandler(this.linkButton1_Click_1);
            // 
            // sliderLabel
            // 
            this.sliderLabel.BackColor = System.Drawing.Color.White;
            this.sliderLabel.BorderRadius = 20;
            this.sliderLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sliderLabel.Location = new System.Drawing.Point(139, 261);
            this.sliderLabel.Name = "sliderLabel";
            this.sliderLabel.Size = new System.Drawing.Size(523, 137);
            this.sliderLabel.TabIndex = 8;
            this.sliderLabel.Text = "\r\nVariation of hotels from 4 to 3 stars \r\nIn all over the world , \r\nYour comfort " +
    "is our priority";
            this.sliderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sliderLabel.Click += new System.EventHandler(this.roundLabel1_Click);
            // 
            // sliderPic
            // 
            this.sliderPic.AccessibleName = "";
            this.sliderPic.Image = ((System.Drawing.Image)(resources.GetObject("sliderPic.Image")));
            this.sliderPic.Location = new System.Drawing.Point(253, 72);
            this.sliderPic.Name = "sliderPic";
            this.sliderPic.Size = new System.Drawing.Size(314, 204);
            this.sliderPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sliderPic.TabIndex = 9;
            this.sliderPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 5);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(361, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 5);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(467, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 5);
            this.label3.TabIndex = 13;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sliderLabel);
            this.Controls.Add(this.sliderPic);
            this.Controls.Add(this.linkButton4);
            this.Controls.Add(this.linkButton3);
            this.Controls.Add(this.linkButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.sliderPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.LinkButton linkButton4;
        private CustomControls.RJControls.LinkButton linkButton3;
        private CustomControls.RJControls.LinkButton linkButton1;
        private RoundLabel sliderLabel;
        private PictureBox sliderPic;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
    }
}