using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MezunTakipSistemi.Models
{
    public class Firma
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string SifreTekrari { get; set; }
        public string CepNo { get; set; }
        public string Adres { get; set; }
        public string KurumTuru { get; set; }
        public string Sektör { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string YetkiliTC { get; set; }
        public string YetkiliUnvan { get; set; }
        public string YetkiliAdi { get; set; }
        public int Rol { get; set; }

        public virtual ICollection<Ilan> Ilanlar { get; set; }
    }
}