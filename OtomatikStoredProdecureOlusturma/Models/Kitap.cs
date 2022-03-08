using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomatikStoredProdecureOlusturma.Models
{
    [Table("Kitap")]
    public class Kitap
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50),Required]
        public string KitapAd { get; set; }
        public string Aciklama { get; set; }
        public DateTime YayinTarihi { get; set; }
    }
}