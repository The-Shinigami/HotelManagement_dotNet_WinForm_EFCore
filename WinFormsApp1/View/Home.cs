using WinFormsApp1.View;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Drawing.Printing;
using WinFormsApp1.Elements;
using System.Drawing.Imaging;
using System.Text;

namespace WinFormsApp1
{
    public partial class Home : Form
        {
        
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void linkButton4_Click(object sender, EventArgs e)
        {
            var m = new Service();
            m.Show();
           this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkButton5_Click(object sender, EventArgs e)
        {
            var k = new Hotels();
            k.Show();
        }

        private void linkButton2_Click(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkButton1_Click(object sender, EventArgs e)
        {
           Login l = new Login();
            l.Show();
        }

      

       
    }
}