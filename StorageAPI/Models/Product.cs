namespace StorageAPI.Models
{
    public class Product
    {
        int Id { get; set; }
        public string Name { get; set; }
        int Price { get; set; }
        string Category;
        string Shelf { get; set; }
        int Count {  get; set; }
        string Description { get; set; }

    }
}
