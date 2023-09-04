namespace PegasusWebAPITutorial.Models.ORM
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
}
