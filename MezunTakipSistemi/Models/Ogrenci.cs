using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MezunTakipSistemi.Models
{
    public class Ogrenci
    {
        [Key]
        public int ID { get; set; }
        public string OgrNo { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string SifreTekrari { get; set; }
        public string Bolum { get; set; }
        public string CepNo { get; set; }
        public bool CalismaDurumu { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string DogumYeri { get; set; }
        public string YasadigiYer { get; set; }
        public string MedeniDurum { get; set; }
        public string LinkedinAdres { get; set; }
        public string Adres { get; set; }
        //public string ImagePath { get; set; }
        //public string CV { get; set; }
        public int Rol { get; set; }
    }
}