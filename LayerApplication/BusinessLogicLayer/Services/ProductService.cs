﻿using System;
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
    public class ProductService
    {
        public static List<ProductModel> ProductList()
        {
            var config = new MapperConfiguration(c => { c.CreateMap<Product, ProductModel>(); });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().Get());

            return data;
        }

        public static List<ProductModel> SellerProducts(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().GetByUserId(id));
            return data;
        }
        // update
        // delete

    }
}
