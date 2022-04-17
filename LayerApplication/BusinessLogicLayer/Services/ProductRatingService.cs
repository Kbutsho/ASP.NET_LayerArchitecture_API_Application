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
    public class ProductRatingService
    {
        public static List<ProductRatingModel> ProductRatingList()
        {
            var config = new MapperConfiguration(c => { c.CreateMap<ProductRating, ProductRatingModel>(); });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductRatingModel>>(DataAccessFactory.ProductRatingDataAccess().Get());

            return data;
        }
    }
}
