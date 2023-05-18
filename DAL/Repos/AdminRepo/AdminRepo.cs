using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.AdminRepo
{
    internal class AdminRepo : Repo, IRepo<Admin,int, Admin>
    {

        public Admin Create(Admin obj)
        {
            db.Admins.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Admins.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Admins.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Admin> Read()
        {
            return db.Admins.ToList();
        }

        public Admin Read(string id)
        {
            return db.Admins.Find(id);
        }

        public Admin Read(int id)
        {
            return db.Admins.Find(id);
        }

        public Admin Update(Admin obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if(db.SaveChanges()>0) return obj;
            return null;
        }
    }
}
