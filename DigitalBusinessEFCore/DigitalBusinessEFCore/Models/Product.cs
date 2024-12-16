namespace DigitalBusinessEFCore.Models
{
    public class Product
    {
        public int Id { get; set; }  // Chave primária
        public required string Name { get; set; }
        public decimal Price { get; set; }
    }
}
