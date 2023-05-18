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
    public class ReviewService
    {
        public static List<ReviewDTO> Get()
        {
            var data = DataAcessFactory.ReviewDatas().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReviewDTO>>(data);
            return mapped;
        }
        public static ReviewDTO Get(string id)
        {
            var data = DataAcessFactory.ReviewDatas().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReviewDTO>(data);
            return mapped;
        }
        public static ReviewDTO Insert (ReviewDTO review)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);
            var reviews = mapper.Map<Review>(review);
            DataAcessFactory.ReviewDatas().Create(reviews);
            return review;
        }
        public static ReviewDTO Update (ReviewDTO review)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);
            var reviews = mapper.Map<Review>(review);
            DataAcessFactory.ReviewDatas().Update(reviews);
            return review;
        }
        public static bool DeleteReview (string id)
        {
            var res = DataAcessFactory.ReviewDatas().Delete(id);
            return res;
        }
    }
}
