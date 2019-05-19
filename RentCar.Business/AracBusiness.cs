using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Business
{
    public class AracBusiness : IDisposable
    {
        DataAccsess.EF.DatabaseContext db = new DataAccsess.EF.DatabaseContext();
        RentCar.DataAccsess.EF.Repository<Arac> repo_Arac = new DataAccsess.EF.Repository<Arac>();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public void DBOlustur()
        {
            db.Role.ToList();
        }
        public List<Arac> listele()
        {
            return repo_Arac.List();
        }
        public Arac SelectAracById(int id)
        {
            return repo_Arac.Find(x => x.Id == id);
        }
        public List<Arac> SelectAraclarBySirketId(int sirketId)
        {
            return repo_Arac.List(x => x.Sirket.Id == sirketId);
        }
        public int InsertArac(Arac Arac)
        {
            return repo_Arac.Insert(Arac);
        }
        public Arac Update(int id, Arac Arac)
        {
            return repo_Arac.Update(id, Arac);

        }
        public int DeleteArac(int id)
        {
            return repo_Arac.Delete(id);
        }

    }
}