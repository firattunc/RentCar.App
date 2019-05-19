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
    [Table("Sirket")]
    [JsonObject(IsReference = true)]
    public class Sirket :MyEntitiyBase ,IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        
        [Required(ErrorMessage = "şirket adı eksik")]
        [StringLength(50, MinimumLength = 3)]
        public string sirketAdi { get; set; }

        [Required(ErrorMessage = "Şirket Adresi eksik")]
        [StringLength(50, MinimumLength = 3)]      
        public string sirketAdresi { get; set; }

        [JsonIgnore]
        public virtual List<Arac> Araclar { get; set; }

        public Sirket()
        {
            Araclar = new List<Arac>();
        }
    }
}
