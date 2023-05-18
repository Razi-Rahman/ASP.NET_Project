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
    public class AuthenticateService
    {
        public static TokenDTO Authenticate(string username, string password)
        {
            var res = DataAcessFactory.AuthData().Authenticate(username, password);
            if(res)
            {
                var token = new Token();
                token.Username = username;
                token.CreatedAt= DateTime.Now;
                token.TKey= Guid.NewGuid().ToString();
                var ret = DataAcessFactory.TokenData().Create(token);
                if(ret!= null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    var mapped = mapper.Map<TokenDTO>(ret);
                    return mapped;
                }
            }
            return null;
        }
        public static bool IsTokenValid(string tkey)
        {
            var exToken = DataAcessFactory.TokenData().Read(tkey);
            if(exToken!=null && exToken.Expired==null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout (string tkey)
        {
            var exToken = DataAcessFactory.TokenData().Read(tkey);
            exToken.Expired= DateTime.Now;
            var res = DataAcessFactory.TokenData().Update(exToken);
            if(res!=null)
            {
                return true;
            }
            return false;
        }
        public static bool IsAdmin(string tkey)
        {
            var extk = DataAcessFactory.TokenData().Read(tkey);
            if(IsTokenValid(tkey)&&extk.User.UserType.Equals("Admin"))
            {
                return true;
            }
            return false;
        }
        public static bool IsCustomer(string tkey)
        {
            var extk = DataAcessFactory.TokenData().Read(tkey);
            if(IsTokenValid(tkey)&&extk.User.UserType.Equals("Traveller"))
            {
                return true;
            }
            return false;
        }
    }
}
