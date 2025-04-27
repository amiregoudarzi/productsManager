public class Product 
{
  public int Id { get; set; }           
  public string Name { get; set; }
  public Categories Category { get; set; }
  public decimal Price { get; set; }


  public Product(int id, string name, Categories category, decimal price)
    {
        Id = id;
        Name = name;
        Category = category;
        Price = price;
    }
}