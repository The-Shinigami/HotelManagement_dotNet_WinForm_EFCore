using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public class Classement
    {
        
        public int Id { get; set; }
        public int Etoile { get; set; }
        public float Coef { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
}
}
