namespace PegasusWebAPITutorial.Models.DTO.Product
{
    public class GetAllProductsResponseDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock{ get; set; }
        public decimal TaxPrice { get; set; }
    }
}
