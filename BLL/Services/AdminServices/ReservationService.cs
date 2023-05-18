using AutoMapper;
using BLL.DTOs.AdminDTOs;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.TravellerServices
{
    public class ReservationService
    {
        public static List<ReservationDTO> Get()
        {
            var data = DataAcessFactory.ReservationDatas().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReservationDTO>>(data);
            return mapped;
        }
        public static ReservationDTO Get(string id)
        {
            var data = DataAcessFactory.ReservationDatas().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReservationDTO>(data);
            return mapped;
        }
        public static ReservationDTO Insert (ReservationDTO reservation)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReservationDTO, Reservation>();
            });
            var mapper = new Mapper(cfg);
            var reservations = mapper.Map<Reservation>(reservation);
            DataAcessFactory.ReservationDatas().Create(reservations);
            return reservation;
        }
        public static ReservationDTO Update(ReservationDTO reservation)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReservationDTO, Reservation>();
            });
            var mapper = new Mapper(cfg);
            var reservations = mapper.Map<Reservation>(reservation);
            DataAcessFactory.ReservationDatas().Update(reservations);
            return reservation;
        }
    }
}
