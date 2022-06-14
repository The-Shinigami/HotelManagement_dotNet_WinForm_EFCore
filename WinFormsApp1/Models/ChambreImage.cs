using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class ChambreImage
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public int ChambreId { get; set; }
        public Chambre Chambre;
    }
}
