namespace PegasusWebAPITutorial.Models.DTO.Product
{
    public class UpdateProductResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
