using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Entities
{
    [Table("Kullanici")]
    public class Kullanici : MyEntitiyBase, IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        [Required(ErrorMessage = "kullanıcı eksik")]
        [StringLength(50, MinimumLength = 3)]
        public string kullaniciAdi { get; set; }

        [Required(ErrorMessage = "sifre eksik")]
        [StringLength(50, MinimumLength = 3)]
        public string sifre { get; set; }

        [Required(ErrorMessage = "ad soyad eksik")]
        [StringLength(50, MinimumLength = 3)]
        public string adSoyad { get; set; }

        public int RoleId { get; set; }

        public virtual Role role { get; set; }

        [JsonIgnore]
        public virtual List<AracTakip> Musteri_aracTakip { get; set; }

        public Kullanici()
        {
            Musteri_aracTakip = new List<AracTakip>();
        }
    }
}
