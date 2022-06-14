using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using n = Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UsersForm : Form
    {


        /* static string cnx_str = "User ID=postgres;Password=root;Host=localhost;Port=5432;Database=postgres;";
n.NpgsqlConnection cnx = new n.NpgsqlConnection(cnx_str);
n.NpgsqlCommand cmd ;
n.NpgsqlDataAdapter ada;
DataTable dt;*/
        public UsersForm()
        {
            InitializeComponent();
            /* cmd = new n.NpgsqlCommand("SELECT * FROM public.users", cnx);
             ada = new n.NpgsqlDataAdapter(cmd);
             dt = new DataTable();
             ada.Fill(dt);
             grd.DataSource = dt;*/
           /* ApplicationDbContext db = new ApplicationDbContext();*/

            /*   grd.DataSource = db.Hotels.ToList();*/
           
            /*MessageBox.Show();*/
            

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
        {
           /* ApplicationDbContext db = new ApplicationDbContext();
            int id = db.Hotels.Include(hotel => hotel.Classement).First().Classement.Class;*/

            ApplicationDbContext db = new ApplicationDbContext();
            List<Hotel> hotels = new List<Hotel>() ;
            hotels = db.Hotels
                .Include(hotel => hotel.Classement)
                .ToList();
            int y = 52;
            foreach(Hotel hotel in hotels)

            {
               y = y + 50;
                Label id;
               id = new System.Windows.Forms.Label();
               id.AutoSize = true;
               id.Location = new System.Drawing.Point(99, y);
               id.Name = "id" + hotel.Id.ToString();
               id.Size = new System.Drawing.Size(17, 15);
               id.TabIndex = 2;
               id.Text = hotel.Id.ToString();
                Controls.Add(id);

                Label nom;
                nom = new System.Windows.Forms.Label();
                nom.AutoSize = true;
                nom.Location = new System.Drawing.Point(178, y);
                nom.Name = "nom" + hotel.Id.ToString();
                nom.Size = new System.Drawing.Size(17, 15);
                nom.TabIndex = 2;
                nom.Text = hotel.Nom; 
                Controls.Add(nom);

                Label stars;
                stars = new System.Windows.Forms.Label();
                stars.AutoSize = true;
                stars.Location = new System.Drawing.Point(252, y);
                stars.Name = "etoile" + hotel.Id.ToString();
                stars.Size = new System.Drawing.Size(17, 15);
                stars.TabIndex = 2;
                stars.Text = hotel.Classement.Etoile.ToString();
                Controls.Add(stars);

            }
            /* MessageBox.Show(id.ToString());*/
            /*grd.DataSource = db.Hotels.Where(m => m.ClassementId == 1);*/

            /*     dt = new DataTable();
                 ada.Fill(dt);
                 grd.DataSource = dt;*/
        }
    }
}
