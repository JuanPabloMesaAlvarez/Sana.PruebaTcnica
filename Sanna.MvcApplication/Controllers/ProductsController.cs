using Sanna.Application.Services.Contracts;
using Sanna.Domain.Products;
using System.Web.Mvc;

namespace Sanna.MvcApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsServices service;

        public ProductsController(IProductsServices service)
        {
            this.service = service;
        }

        // GET: Products
        public ActionResult Index()
        {
            if (TempData["InMemory"] == null)
            {
                TempData["InMemory"] = false;
            }
            TempData.Keep();
            service.InMemory = bool.Parse(TempData["InMemory"].ToString());
            return View(service.GetProducts());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                TempData.Keep();
                service.InMemory = bool.Parse(TempData["InMemory"].ToString());
                service.CreateProduct(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(product);
            }
        }

        public ActionResult ChangeMode(bool memory)
        {
            service.InMemory = memory;
            TempData["InMemory"] = memory;
            TempData.Keep();
            return RedirectToAction("Index");
        }
    }
}