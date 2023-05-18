using AutoMapper;
using BLL.DTOs.TravellerDTOs;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.TravellerServices
{
    public class PaymentService
    {
        public static List<PaymentDTO> Get()
        {
            var data = DataAcessFactory.PaymentDatas().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PaymentDTO>>(data);
            return mapped;
        }
        public static PaymentDTO Get(int id)
        {
            var data = DataAcessFactory.PaymentDatas().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PaymentDTO>(data);
            return mapped;
        }
        public static PaymentDTO Insert(PaymentDTO payment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(cfg);
            var payments = mapper.Map<Payment>(payment);
            DataAcessFactory.PaymentDatas().Create(payments);
            return payment;
        }
        public static PaymentDTO Update(PaymentDTO payment) 
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentDTO, Payment>();
            });
            var mapper = new Mapper(cfg);
            var payments = mapper.Map<Payment>(payment);
            DataAcessFactory.PaymentDatas().Update(payments);
            return payment;
        }
    }
}
