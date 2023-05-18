using DAL.Interfaces;
using DAL.Model;
using DAL.Repos;
using DAL.Repos.AdminRepo;
using DAL.Repos.TravellerRepo;
using DAL.Repos.TravellerRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAcessFactory
    {
        //Admin
        public static IRepo<Admin, int, Admin> AdminData()
        {
            return new AdminRepo();
        }
        public static IRepo<Package, string, Package> PackageData()
        {
            return new PackageRepo();
        }
        public static IRepo<Reservation, string, Reservation> ReservationData()
        {
            return new ReservationRepo();
        }
        public static IRepo<Review, string, Review> ReviewData()
        {
            return new ReviewRepo();
        }
        public static IRepo<Traveller, string, Traveller> TravellerData()
        {
            return new TravellerRepo();
        }

        //Traveller
        public static IRepo<Traveller, string, Traveller> TravellerDatas()
        {
            return new TravellerRepos();
        }
        public static IRepo<Review, string, Review> ReviewDatas()
        {
            return new ReviewRepos();
        }
        public static IRepo<Payment,int, Payment> PaymentDatas()
        {
            return new PaymentRepos();
        }
        public static IRepo<Reservation, string, Reservation>ReservationDatas()
        {
            return new ReservationRepos();
        }
        //Authentication
        public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Token,string, Token> TokenData()
        {
            return new TokenRepo();
        }
        
        
    }
}
