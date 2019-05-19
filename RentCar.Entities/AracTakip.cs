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
    [Table("AracTakip")]
    public class AracTakip : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int gunlukKm { get; set; }

        public DateTime tarih { get; set; }

        
        public virtual Kullanici Musteri { get; set; }
        
        public virtual Arac Arac { get; set; }

    }
}
