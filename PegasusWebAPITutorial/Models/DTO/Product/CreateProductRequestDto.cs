namespace PegasusWebAPITutorial.Models.DTO.Product
{
    public class CreateProductRequestDto
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
