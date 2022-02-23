using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MezunTakipSistemi.Models
{
    public class Etkinlik
    {
        [Key]
        public int ID { get; set; }
        public string EtkinlikAdi { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
    }
}