﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Domain.Entities
{
    public class Musteri : BaseEntity
    {
        public Musteri()
        {
            Fisler = new HashSet<Fis>();
        }
        public string AdSoyad { get; set; }
        public string Unvan { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string EPosta { get; set; }
        public ICollection<Fis> Fisler { get; set; }

    }
}
