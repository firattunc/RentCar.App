using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Business
{
    public class RoleBusiness : IDisposable
    {
        DataAccsess.EF.DatabaseContext db = new DataAccsess.EF.DatabaseContext();
        RentCar.DataAccsess.EF.Repository<Role> repo_role = new DataAccsess.EF.Repository<Role>();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<Role> listele()
        {
            return repo_role.List();
        }
        public Role SelectRoleById(int id)
        {
            return repo_role.Find(x => x.Id == id);
        }
        public List<Role> SelectRolesByRoleName(string roleName)
        {
            return repo_role.List(x => x.RoleAd == roleName);
        }
        public int InsertRole(Role role)
        {
            return repo_role.Insert(role);
        }
        public Role Update(int id, Role role)
        {
            return repo_role.Update(id, role);

        }
        public int DeleteRole(int id)
        {
            return repo_role.Delete(id);
        }

    }
}