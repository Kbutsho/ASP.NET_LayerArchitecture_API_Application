using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogicLayer.Entities;
using DataAccessLayer.Database;
using DataAccessLayer.Repos;

namespace BusinessLogicLayer.Services
{
    public class UserService
    {
        public static List<UserModel> AdminList()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserModel>>(UserRepo.Get());

            var admin = (from b in data
                where b.Role.Equals("Admin")
                select b).ToList();
            return admin;
        }
        public static List<UserModel> SellerList()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserModel>>(UserRepo.Get());

            var seller = (from b in data
                where b.Role.Equals("Seller")
                select b).ToList();
            return seller;
        }
        public static List<UserModel> CustomerList()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserModel>>(UserRepo.Get());

            var customer = (from b in data
                where b.Role.Equals("Customer")
                select b).ToList();
            return customer;
        }
        public static List<UserModel> DeliveryBoyList()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserModel>>(UserRepo.Get());

            var deliveryBoy = (from b in data
                where b.Role.Equals("Delivery-Boy")
                select b).ToList();
            return deliveryBoy;
        }

        public static UserModel Get(int id)
        {
            var st = UserRepo.Get(id);
            return new UserModel()
            {
                Id = st.Id,
                Name = st.Name,
                Email = st.Email,
                Address = st.Address,
                Role = st.Role,
            };
        }
    }
}
