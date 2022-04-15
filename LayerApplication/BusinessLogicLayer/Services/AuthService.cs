using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogicLayer.Entities;
using DataAccessLayer;
using DataAccessLayer.Database;

namespace BusinessLogicLayer.Services
{
    public class AuthService
    {
        public static TokenModel Authenticate(UserModel user)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();
                c.CreateMap<TokenModel, Token>();
                c.CreateMap<Token, TokenModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(user);

            var result = DataAccessFactory.AuthDataAccess().Authenticate(data);
            var token = mapper.Map<TokenModel>(result);
            return token;
        }

        public static bool IsAuthenticate(string token)
        {
            var rs = DataAccessFactory.AuthDataAccess().IsAuthenticated(token);
            return rs;
        }
        public static void Logout(TokenModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg =>
                cfg.CreateMap<TokenModel, Token>())).Map<Token>(e);
            DataAccessFactory.AuthDataAccess().Logout(data);
        }
    }
}
