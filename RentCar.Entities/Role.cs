using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RentCar.Entities
{
    [Table("Role")]
    public class Role:MyEntitiyBase,IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        [StringLength(25)]
        public string RoleAd  { get; set; }

        [JsonIgnore]
        public virtual List<Kullanici> Kullanicilar { get; set; }

        public Role()
        {
            Kullanicilar = new List<Kullanici>();
        }
    }
}
