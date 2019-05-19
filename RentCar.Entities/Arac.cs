using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace RentCar.Entities
{
    [Table("Arac")]
    public class Arac:MyEntitiyBase, IDisposable
    {

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
       
        [Required(ErrorMessage = "Ad eksik")]
        public string aracAdi { get; set; }

        [Required(ErrorMessage = "Fiyat eksik")]
        public int gunlukFiyat { get; set; }

        [Required(ErrorMessage = "km eksik")]
        public int anlikKm { get; set; }

        public bool aracDurum { get; set; }


               
        public virtual Sirket Sirket { get; set; }
        [JsonIgnore]
        public virtual List<Kiralama> Kiralama { get; set; }
        [JsonIgnore]
        public virtual List<AracTakip> Arac_aracTakip { get; set; }

        public Arac()
        {
            Kiralama = new List<Kiralama>();
            Arac_aracTakip = new List<AracTakip>();
        }
    }
}
