using Microsoft.AspNetCore.Mvc;
using PegasusWebAPITutorial.Models.DTO.Product;
using PegasusWebAPITutorial.Models.ORM;

namespace PegasusWebAPITutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        PegasusContext context;
        public ProductController()
        {
            context = new PegasusContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<GetAllProductsResponseDTO> model = context.Products.Select(x => new GetAllProductsResponseDTO
            {
                Id= x.Id,
                Name= x.Name,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                TaxPrice = x.UnitPrice * 0.2M
            }).ToList();

            return Ok(model);


        }

        [HttpPost]
        public IActionResult Create(CreateProductRequestDto model)
        {
            Product product = new Product();
            product.Name = model.Name;
            product.UnitPrice = model.UnitPrice;
            product.UnitsInStock = model.UnitsInStock;

            context.Products.Add(product);
            context.SaveChanges();

            CreateProductResponsetDto responsetDto = new CreateProductResponsetDto();
            responsetDto.Name = product.Name;
            responsetDto.UnitPrice = product.UnitPrice;
            responsetDto.UnitsInStock = product.UnitsInStock;
            responsetDto.Id = product.Id;

            return Ok(responsetDto);
        }
    }
}
