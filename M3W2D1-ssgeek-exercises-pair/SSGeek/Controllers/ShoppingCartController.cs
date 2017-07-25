using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSGeek.Models;
using SSGeek.DAL;

namespace SSGeek.Controllers
{
    public class ShoppingCartController : Controller
    {
        //public ActionResult Index()
        //{
        //    RedirectToAction("Products");
        //}

        public ActionResult Products()
        {
            List<Product> productList = new List<Product>();
            ProductSqlDAL productDal = new ProductSqlDAL();
            productList = productDal.GetProducts();
            return View("Products", productList);
        }

        public ActionResult Detail(int id)
        {
            ProductSqlDAL productDal = new ProductSqlDAL();
            Product product = productDal.GetProduct(id);
            ShoppingCartItem item = new ShoppingCartItem();
            item.Product = product;
            return View("Detail", item);
        }

        public ActionResult Product(int id)
        {
            ProductSqlDAL productDal = new ProductSqlDAL();
            Product product = productDal.GetProduct(id);
            ShoppingCartItem item = new ShoppingCartItem();
            item.Product = product;
            return View("ProductDetail", item);
        }

        [HttpPost]
        public ActionResult AddItem(ShoppingCartItem item)
        {
            ProductSqlDAL productDal = new ProductSqlDAL();
            Product product = productDal.GetProduct(item.ProductId);
            item.Product = product;
            List<ShoppingCartItem> shoppingCart = Session["ShoppingCart"] as List<ShoppingCartItem>;

            if (shoppingCart == null)
            {
                shoppingCart = new List<ShoppingCartItem>();
                shoppingCart.Add(item);
            }
            else
            {
                int count = 0;
                foreach(ShoppingCartItem thing in shoppingCart)
                {
                    if (thing.Product.ProductId == item.Product.ProductId)
                    {
                        count += 1;
                        thing.Quantity += item.Quantity;
                        break;
                    }
                }
                if( count != 1)
                {
                    shoppingCart.Add(item);
                }
                
            }
            Session["ShoppingCart"] = shoppingCart;

            List<Product> productList = new List<Product>();
            productList = productDal.GetProducts();

            return View("Products", productList);
        }

        public ActionResult ViewCart()
        {
            List<ShoppingCartItem> shoppingCart = Session["ShoppingCart"] as List<ShoppingCartItem>;

            return View("ViewCart", shoppingCart);
        }

    }
}