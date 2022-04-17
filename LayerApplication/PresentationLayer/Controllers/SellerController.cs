using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogicLayer.Entities;
using BusinessLogicLayer.Services;
using PresentationLayer.Auth;

namespace PresentationLayer.Controllers
{
    public class SellerController : ApiController
    {
        [customAuth]
        [Route("api/product/add")]
        [HttpPost]

        public void AddProduct(ProductModel e)
        {
            ProductService.Add(e);
        }
        /*
        [Route("api/seller/{id}/products")]
        [HttpGet]
        public List<ProductModel> SellerProducts(int id)
        {
            return ProductService.SellerProducts(id);
        }
        */
        [customAuth]
        [Route("api/product/edit")]
        [HttpPost]
        public void EditProduct(ProductModel e)
        {
            ProductService.Edit(e);
        }

        [customAuth]
        [Route("api/seller/orders/{id}")]
        [HttpGet]
        public List<OrderModel> CustomerOrders(int id)
        {
            return OrderService.CustomerOrders(id);
        }
        [customAuth]
        [Route("api/product/delete/{id}")]
        [HttpDelete]
        public void DeleteProduct(int id)
        {
            ProductService.Delete(id);
        }

        [customAuth]
        [Route("api/productRatings")]
        [HttpGet]
        public List<ProductRatingModel> ProductRating()
        {
            return ProductRatingService.ProductRatingList();
        }
    }
}
