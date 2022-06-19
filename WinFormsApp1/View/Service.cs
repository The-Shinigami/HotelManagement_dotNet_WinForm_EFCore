using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.View;

namespace WinFormsApp1
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkButton5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkButton4_Click(object sender, EventArgs e)
        {

        }

        private void linkButton3_Click(object sender, EventArgs e)
        {

        }

        private void linkButton2_Click(object sender, EventArgs e)
        {

        }

        private void linkButton1_Click(object sender, EventArgs e)
        {

        }

        private void linkButton3_Click_1(object sender, EventArgs e)
        {
            var m = new Home();
            m.Show();
            this.Hide();
        }

        private void roundLabel1_Click(object sender, EventArgs e)
        {

        }
        private int imageNumber = 2;
        private void LoadNextImage()
        {
            if (imageNumber == 4)
                   { imageNumber = 1; }

        sliderPic.ImageLocation = string.Format(@"Images\{0}.png", imageNumber);

            if(imageNumber == 1)
            {
                sliderLabel.Text = "\nVariation of hotels from 4 to 3 stars \n In all over the world , \nYour comfort is our priority";
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Gray;
                label3.BackColor = Color.Gray;

            }
            if (imageNumber == 2)
            {
                sliderLabel.Text = "\nPools, Playgrounds for children , \n Your entertainment is fondamenta";
                label2.BackColor = Color.Black;
                label1.BackColor = Color.Gray;
                label3.BackColor = Color.Gray;
            }

            if (imageNumber == 3)
            {
                sliderLabel.Text = "\nMenus from different cultures , \nFood is life";
                label3.BackColor = Color.Black;
                label1.BackColor = Color.Gray;
                label2.BackColor = Color.Gray;
            }

            imageNumber++;
}


    private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void linkButton1_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
