﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Siniflar
{
    public class FaturaKalem
    {
        [Key]
        public int FaturaKalemid { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFİyat { get; set; }
        public decimal Tutar { get; set; }
        //sadece bir tane faturası olabilir
        public int Faturaid { get; set; }
        public virtual Faturalar Faturalar { get; set; }
    }
}