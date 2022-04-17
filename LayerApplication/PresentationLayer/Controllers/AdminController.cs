using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BusinessLogicLayer.Entities;
using BusinessLogicLayer.Services;
using PresentationLayer.Auth;

namespace PresentationLayer.Controllers
{
    [EnableCors("*", "*", "*")]
 
    public class AdminController : ApiController
    {

        // Seller operation
        [customAuth]
        [Route("api/sellerList")]
        [HttpGet]
        public List<UserModel> Seller()
        {
            return UserService.SellerList();
        }

        [customAuth]
        [Route("api/seller/add")]
        [HttpPost]
        public void AddSeller(UserModel e)
        {
            UserService.Add(e);
        }


        [customAuth]
        [Route("api/seller/edit")]
        [HttpPost]
        public void EditSeller(UserModel e)
        {
            UserService.Edit(e);
        }


        [customAuth]
        [Route("api/seller/delete/{id}")]
        [HttpDelete]
        public void DeleteSeller(int id)
        {
            UserService.Delete(id);
        }



        // Customer operation
        [customAuth]
        [Route("api/customerList")]
        [HttpGet]
        public List<UserModel> Customer()
        {
            return UserService.CustomerList();
        }


        [customAuth]
        [Route("api/customer/add")]
        [HttpPost]

        public void AddCustomer(UserModel e)
        {
            UserService.Add(e);
        }

        [customAuth]
        [Route("api/customer/edit")]
        [HttpPost]
        public void EditCustomer(UserModel e)
        {
            UserService.Edit(e);
        }

        [customAuth]
        [Route("api/customer/delete/{id}")]
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            UserService.Delete(id);
        }

        // Delivery boy operations
        [customAuth]
        [Route("api/deliveryBoyList")]
        [HttpGet]
        public List<UserModel> DeliveryBoy()
        {
            return UserService.DeliveryBoyList();
        }

        [customAuth]

        [Route("api/deliveryBoy/add")]
        [HttpPost]

        public void AddDeliveryBoy(UserModel e)
        {
            UserService.Add(e);
        }


        [customAuth]
        [Route("api/deliveryBoy/edit")]
        [HttpPost]
        public void EditDeliveryBoy(UserModel e)
        {
            UserService.Edit(e);
        }

        [customAuth]
        [Route("api/deliveryBoy/delete/{id}")]
        [HttpDelete]
        public void DeleteDeliveryBoy(int id)
        {
            UserService.Delete(id);
        }


        // All user operation

        [customAuth]
        [HttpGet]
        [Route("api/user/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var st = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }


        // seller Product Operation 
        [customAuth]
        [Route("api/productList")]
        [HttpGet]
        public List<ProductModel> Products()
        {
            return ProductService.ProductList();
        }


        [customAuth]
        [Route("api/seller/{id}/products")]
        [HttpGet]
        public List<ProductModel> SellerProducts(int id)
        {
            return ProductService.SellerProducts(id);
        }

        // customer order operation

        [customAuth]
        [Route("api/orderList")]
        [HttpGet]
        public List<OrderModel> Orders()
        {
            return OrderService.OrderList();
        }


        [customAuth]
        [Route("api/customer/{id}/orders")]
        [HttpGet]
        public List<OrderModel> CustomerOrders(int id)
        {
            return OrderService.CustomerOrders(id);
        }

        // Delivery boys Deliveries operation

        [customAuth]
        [Route("api/deliveryList")]
        [HttpGet]
        public List<DeliveryModel> Deliveries()
        {
            return DeliveryService.DeliveryList();
        }


        [customAuth]
        [Route("api/deliveryBoy/{id}/deliveries")]
        [HttpGet]
        public List<DeliveryModel> DeliveryBoyDeliveries(int id)
        {
            return DeliveryService.DeliveryBoyDeliveries(id);
        }


        [customAuth]
        [Route("api/categoryList")]
        [HttpGet]
        public List<CategoryModel> Categories()
        {
            return CategoryService.CategoryList();
        }

        [customAuth]
        [Route("api/category/add")]
        [HttpPost]

        public void AddCategory(CategoryModel e)
        {
            CategoryService.Add(e);
        }

        [customAuth]
        [Route("api/category/edit")]
        [HttpPost]
        public void EditCategory(CategoryModel e)
        {
            CategoryService.Edit(e);
        }
        [customAuth]
        [Route("api/category/delete/{id}")]
        [HttpDelete]

        public void DeleteCategory(int id)
        {
            CategoryService.Delete(id);
        }


        // Registration
        [Route("api/registration")]
        [HttpPost]
        public void Registration(UserModel e)
        {
            UserService.Add(e);
        }


    }
}
