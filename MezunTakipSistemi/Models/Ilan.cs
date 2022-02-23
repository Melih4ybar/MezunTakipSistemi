using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MezunTakipSistemi.Models
{
    public class Ilan
    {
        [Key]
        public int ID { get; set; }
        public string IlanBaslik { get; set; }
        public string IlanTanimi { get; set; }
        public string Sektor { get; set; }
        public string Pozisyon { get; set; }
        public DateTime SonBasvuruTarihi { get; set; }
        public virtual Firma Firma { get; set; }

    }
}