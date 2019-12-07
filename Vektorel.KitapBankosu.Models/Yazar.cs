﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.KitapBankosu.Models
{
    public class Yazar
    {
        public int YazarId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTar { get; set; }
        public DateTime OlumTarih { get; set; }
    }
}
