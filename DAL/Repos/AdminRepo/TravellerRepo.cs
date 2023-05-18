using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.AdminRepo
{
    internal class TravellerRepo : Repo, IRepo<Traveller, string, Traveller>
    {
        public Traveller Create(Traveller obj)
        {
            db.Travellers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Travellers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Traveller> Read()
        {
            return db.Travellers.ToList();
        }

        public Traveller Read(string id)
        {
            return db.Travellers.Find(id);
        }

        public Traveller Update(Traveller obj)
        {
            var ex = Read(obj.TId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
