using Microsoft.AspNetCore.Mvc;
using ProjectBusinessLogicLayer.Abstract;
using ProjectBusinessLogicLayer.DTOs;

namespace ProjectMVC.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }   

        public async Task<IActionResult> GetProduct()
        {
            var products = await _productService.GetAllProduct();
            return Json(products);
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct([FromRoute] int? id= null)
        {
            if (id is not null)
            {
                var product = await _productService.GetProductByIdAsync(id.Value);
                return View(product);
            }

            return View(new ProductAddDto());
        }


        [HttpPost]
        public async Task< IActionResult> AddProduct([FromBody] ProductAddDto product)
        {

            if (ModelState.IsValid)
            {
                await _productService.AddProduct(product);
                return Json(new { message = "Product was added successfully!" });

            }

            return View(product);




        }

        [HttpGet]
        public async Task<IActionResult> RemoveProduct([FromRoute] int id)
        {
            await _productService.Remove(id);
            return Json(new { message = "Product was deleted successfully!" });
        }
    }
}
