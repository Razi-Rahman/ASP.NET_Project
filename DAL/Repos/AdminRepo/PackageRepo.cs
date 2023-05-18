using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.AdminRepo
{
    internal class PackageRepo : Repo, IRepo<Package, string, Package>
    {
        public Package Create(Package obj)
        {
            db.Packages.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Packages.Remove(ex);
            return db.SaveChanges() > 0; 
        }

        public List<Package> Read()
        {
            return db.Packages.ToList();
        }

        public Package Read(string id)
        {
            return db.Packages.Find(id);
        }

        public Package Update(Package obj)
        {
            var ex = Read(obj.PackageID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
