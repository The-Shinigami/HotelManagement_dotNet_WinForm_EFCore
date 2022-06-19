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
    public partial class Login : Form
    {
        HotelController hotelController = new HotelController();
        public Login()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Utilisateur u = new Utilisateur();
            u.Email = this.password.Text;
            u.Tel = this.email.Text;

            Utilisateur utilisateur = null;
           utilisateur = this.hotelController.login(u);

            if(utilisateur == null)
            {
                MessageBox.Show("Verifier vos données");
            }
            else
            {
                Dashboard d = new Dashboard();
                d.Show();
            }

        }
    }
}
