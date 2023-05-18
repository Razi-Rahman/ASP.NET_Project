using AutoMapper;
using BLL.DTOs.AdminDTOs;
using DAL.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AdminServices
{
    public class PackageService
    {
        public static List<PackageDTO> Get()
        {
            var data = DataAcessFactory.PackageData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PackageDTO>>(data);
            return mapped;
        }
        public static PackageDTO Get(string id)
        {
            var data = DataAcessFactory.PackageData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PackageDTO>(data);
            return mapped;
        }

        public static PackageDTO Insert(PackageDTO package)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PackageDTO, Package>();
            });
            var mapper = new Mapper(cfg);
            var packages = mapper.Map<Package>(package);
            DataAcessFactory.PackageData().Create(packages);
            return package;
        }
        public static PackageDTO Update(PackageDTO package)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PackageDTO, Package>();
            });
            var mapper = new Mapper(cfg);
            var packages = mapper.Map<Package>(package);
            DataAcessFactory.PackageData().Update(packages);
            return package;
        }
        public static bool Delete(string id)
        {
            var data = DataAcessFactory.PackageData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }
}
