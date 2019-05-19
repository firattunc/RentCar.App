using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Business
{
    public class KiralamaBusiness : IDisposable
    {
        DataAccsess.EF.DatabaseContext db = new DataAccsess.EF.DatabaseContext();
        RentCar.DataAccsess.EF.Repository<Kiralama> repo_Kiralama = new DataAccsess.EF.Repository<Kiralama>();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<Kiralama> listele()
        {
            return repo_Kiralama.List();
        }
        public Kiralama SelectKiralamaById(int id)
        {
            return repo_Kiralama.Find(x => x.Id == id);
        }
        public Kiralama SelectKiralamaByMusteriId(int id)
        {
            return repo_Kiralama.Find(x => x.Musteri.Id == id);
        }
        public List<Kiralama> SelectAllKiralamaIstekleri()
        {
            return repo_Kiralama.List(x => x.Calisan == null);
        }
        public int InsertKiralama(Kiralama Kiralama)
        {
            return repo_Kiralama.Insert(Kiralama);
        }
        public Kiralama Update(int id, Kiralama Kiralama)
        {
            return repo_Kiralama.Update(id, Kiralama);

        }
        public int DeleteKiralama(int id)
        {
            return repo_Kiralama.Delete(id);
        }

    }
}