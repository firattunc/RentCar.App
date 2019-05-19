using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Business
{
    public class KullaniciBusiness : IDisposable
    {
        DataAccsess.EF.DatabaseContext db = new DataAccsess.EF.DatabaseContext();
        RentCar.DataAccsess.EF.Repository<Kullanici> repo_Kullanici = new DataAccsess.EF.Repository<Kullanici>();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<Kullanici> listele()
        {
            return repo_Kullanici.List();
        }
        public Kullanici SelectKullaniciById(int id)
        {
            return repo_Kullanici.Find(x => x.Id == id);
        }
        public List<Kullanici> SelectAllKullaniciByRoleId(int roleId)
        {
            return repo_Kullanici.List(x => x.RoleId == roleId);
        }
        public int InsertKullanici(Kullanici Kullanici)
        {
            return repo_Kullanici.Insert(Kullanici);
        }
        public Kullanici Update(int id, Kullanici Kullanici)
        {
            return repo_Kullanici.Update(id, Kullanici);

        }
        public int DeleteKullanici(int id)
        {
            return repo_Kullanici.Delete(id);
        }

    }
}