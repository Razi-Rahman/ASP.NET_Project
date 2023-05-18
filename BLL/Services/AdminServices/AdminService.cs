using AutoMapper;
using BLL.DTOs.AdminDTOs;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AdminServices
{
    public class AdminService
    {
        public static List<AdminDTO>Get()
        {
            var data = DataAcessFactory.AdminData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;
        }
        public static AdminDTO Get(int id)
        {
            var data = DataAcessFactory.AdminData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;
        }
        public static AdminDTO Insert(AdminDTO admin)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<AdminDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var users = mapper.Map<User>(admin);
            users.UserType = "Admin";
            DataAcessFactory.UserData().Create(users);
            var admins = mapper.Map<Admin>(admin);
            DataAcessFactory.AdminData().Create(admins);
            return admin;
        }
        public static AdminDTO Update (AdminDTO admin) 
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(cfg);
            var admins = mapper.Map<Admin>(admin);
            DataAcessFactory.AdminData().Update(admins);
            return admin;
        }
        public static bool Delete (int id)
        {
            var data = DataAcessFactory.AdminData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
        
    }
}
