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

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();

            DeleteProductResponseDto deleteProductResponseDto = new DeleteProductResponseDto();
            deleteProductResponseDto.Id = id;

            return Ok(deleteProductResponseDto);
        }

        [HttpPut]
        public IActionResult Put(UpdateProductRequestDto model)
        {
            var product = context.Products.Find(model.Id);

            if(product != null)
            {
                product.Name = model.Name;
                context.SaveChanges();

                UpdateProductResponseDto responseModel = new UpdateProductResponseDto();
                responseModel.Name = product.Name;
                responseModel.UnitPrice = product.UnitPrice;
                responseModel.UnitsInStock = product.UnitsInStock;
                responseModel.Id = product.Id;

                return Ok(responseModel);
            }
            else
            {
                return BadRequest();
            }
          
        }
    }
}
