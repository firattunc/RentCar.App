using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Business
{
    public class AracTakipBusiness : IDisposable
    {         
        RentCar.DataAccsess.EF.Repository<AracTakip> repo_AracTakip = new DataAccsess.EF.Repository<AracTakip>();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<AracTakip> listele()
        {
            return repo_AracTakip.List();
        }
        public AracTakip SelectAracTakipById(int id)
        {
            return repo_AracTakip.Find(x => x.Id == id);
        }
        public List<AracTakip> SelectAracTakiplerByGunlukKm(int gunlukKmSiniri)
        {
            return repo_AracTakip.List(x => x.gunlukKm> gunlukKmSiniri);
        }
        public List<AracTakip> SelectAracTakiplerByMusteriId(int musteriId)
        {
            return repo_AracTakip.List(x => x.Musteri.Id == musteriId);
        }
        public int InsertAracTakip(AracTakip AracTakip)
        {
            return repo_AracTakip.Insert(AracTakip);
        }
        public AracTakip Update(int id, AracTakip AracTakip)
        {
            return repo_AracTakip.Update(id, AracTakip);

        }
        public int DeleteAracTakip(int id)
        {
            return repo_AracTakip.Delete(id);
        }

    }
}