using AutoMapper;
using BLL.DTOs.TravellerDTOs;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.TravellerServices
{
    public class TravellerService
    {
        public static List<TravellerDTO> Get()
        {
            var data = DataAcessFactory.TravellerDatas().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Traveller, TravellerDTO>();
            });
            var mapper = new Mapper (cfg);
            var mapped = mapper.Map<List<TravellerDTO>>(data);
            return mapped;
        }

        public static TravellerDTO Get(string id)
        {
            var data = DataAcessFactory.TravellerDatas().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Traveller, TravellerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TravellerDTO>(data);
            return mapped;
        }
        public static TravellerDTO Insert(TravellerDTO traveller)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TravellerDTO, Traveller>();
            });
            var mapper = new Mapper(cfg);
            var travellers = mapper.Map<Traveller>(traveller);
            DataAcessFactory.TravellerDatas().Create(travellers);
            return traveller;
        }
        public static bool Delete (string username)
        {
            var data = DataAcessFactory.TravellerDatas().Delete(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Traveller, TravellerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
        public static TravellerDTO Update (TravellerDTO traveller)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TravellerDTO, Traveller>();
            });
            var mapper = new Mapper(cfg);
            var travellers = mapper.Map<Traveller>(traveller);
            DataAcessFactory.TravellerDatas().Update(travellers);
            return traveller;
        }
        public static ReservationDTO Reservation(string username)
        {
            var data = DataAcessFactory.ReservationDatas().Read(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Traveller, ReservationDTO>();
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReservationDTO>(data);
            return mapped;
        }

        public static bool ReservationDelete(string username)
        {
            var data = DataAcessFactory.ReservationDatas().Delete(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Traveller, TravellerDTO>();
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
        
    }
}
