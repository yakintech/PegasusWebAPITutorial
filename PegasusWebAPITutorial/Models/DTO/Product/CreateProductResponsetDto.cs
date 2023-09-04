namespace PegasusWebAPITutorial.Models.DTO.Product
{
    public class CreateProductResponsetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
}
