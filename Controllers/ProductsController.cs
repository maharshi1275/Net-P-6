
using Product_Catelog.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Product_Catelog.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> P_ALL = GetProductData();

            return View("Products", P_ALL);
        }

        // GET: Products/Details/101
        public ActionResult Details(int id)
        {
            List<Product> P_ALL = GetProductData();

            Product p1 = P_ALL.FirstOrDefault(x => x.ProductId == id);

            if (p1 == null)
            {
                return HttpNotFound();
            }

            return View("View", p1);
        }

        private List<Product> GetProductData()
        {
            List<Product> pTemp = new List<Product>();

            Product p1 = new Product();
            Product p2 = new Product();
            Product p3 = new Product();

            p1.ProductId = 101;
            p1.ProductName = "Nike Air Max";
            p1.ProductPrice = 12999;
            p1.ProductCategory = "Shoes";
            p1.ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=800";

            p2.ProductId = 102;
            p2.ProductName = "Sony WH-1000XM5";
            p2.ProductPrice = 29990;
            p2.ProductCategory = "Headphones";
            p2.ImageUrl = "https://images.unsplash.com/photo-1546435770-a3e426bf472b?w=800";

            p3.ProductId = 103;
            p3.ProductName = "Canon EOS R50";
            p3.ProductPrice = 69990;
            p3.ProductCategory = "Camera";
            p3.ImageUrl = "https://images.unsplash.com/photo-1516035069371-29a1b244cc32?w=800";

            pTemp.Add(p1);
            pTemp.Add(p2);
            pTemp.Add(p3);

            return pTemp;
        }
    }
}
