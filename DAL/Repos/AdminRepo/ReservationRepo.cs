using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.AdminRepo
{
    internal class ReservationRepo : Repo, IRepo<Reservation, String, Reservation>
    {
        public Reservation Create(Reservation obj)
        {
            db.Reservations.Add(obj);
            if(db.SaveChanges()>0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Reservations.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Reservation> Read()
        {
            return db.Reservations.ToList();
        }

        public Reservation Read(string id)
        {
            return db.Reservations.Find(id);
        }

        public Reservation Update(Reservation obj)
        {
            var ex = Read(obj.ReservationID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
