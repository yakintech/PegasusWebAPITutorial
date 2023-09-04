namespace PegasusWebAPITutorial.Models.ORM
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
    }
}
