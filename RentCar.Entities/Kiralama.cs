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
    [Table("Kiralama")]
    public class Kiralama : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime kiralamaTarihi { get; set; }

        public decimal odenecekTutar { get; set; }


        public virtual Kullanici Calisan { get; set; }
        
        public virtual Kullanici Musteri { get; set; }
        
        public virtual Arac Arac { get; set; }

    }
}
