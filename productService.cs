public class ProductService
{
    private List<Product> _products;

    public ProductService(List<Product> products)
    {
        _products = products;
    }

    public IEnumerable<Product> GetProductsByCategory(Categories category)
    {
        return from product in _products
               where product.Category == category
               select product;
    }

    public Product GetMaxPriceProduct()
    {
        return (from product in _products
                orderby product.Price descending
                select product).First();
    }

    public decimal GetTotalPrice()
    {
        return (from product in _products
                select product.Price).Sum();
    }

    public double GetAveragePrice()
    {
        return (double) (from product in _products
                        select product.Price).Average();
    }

    public IEnumerable<IGrouping<Categories, Product>> GetProductsGroupedByCategory()
    {
        return from product in _products
               group product by product.Category;
    }
}
