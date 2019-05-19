using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Business
{
    public class SirketBusiness : IDisposable
    {
        DataAccsess.EF.DatabaseContext db = new DataAccsess.EF.DatabaseContext();
        RentCar.DataAccsess.EF.Repository<Sirket> repo_Sirket = new DataAccsess.EF.Repository<Sirket>();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<Sirket> listele()
        {
            return repo_Sirket.List();
        }
        public Sirket SelectSirketById(int id)
        {
            return repo_Sirket.Find(x => x.Id == id);
        }
        public List<Sirket> SelectSirketsBySirketName(string SirketName)
        {
            return repo_Sirket.List(x => x.sirketAdi == SirketName);
        }
        public int InsertSirket(Sirket Sirket)
        {
            return repo_Sirket.Insert(Sirket);
        }
        public Sirket Update(int id, Sirket Sirket)
        {
            return repo_Sirket.Update(id, Sirket);

        }
        public int DeleteSirket(int id)
        {
            return repo_Sirket.Delete(id);
        }

    }
}