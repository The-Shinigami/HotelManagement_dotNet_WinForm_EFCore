﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class HotelImage
    {
        public int Id { get; set; }     
        public string Src { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
