using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
   static void Main(string[] args)
   {
      var products = new List<Product>
      {
         new Product( 1, "Product A", Categories.Category1, 100 ),
         new Product( 2, "Product B", Categories.Category1, 150 ),
         new Product( 3, "Product C", Categories.Category2, 120 ),
         new Product( 4, "Product D", Categories.Category3, 200 ),
         new Product( 5, "Product E", Categories.Category1, 80 )
      };

      var productService = new ProductService(products);

      // get all the products in category1
      var category1Products = productService.GetProductsByCategory(Categories.Category1);
      Console.WriteLine("1. Category 1 Products:");
      foreach (var product in category1Products)
      {
         Console.WriteLine($"   Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
      }

      // getting the max price among all products
      var maxPriceProduct = productService.GetMaxPriceProduct();
      Console.WriteLine($"\n2. Max Price Product: {maxPriceProduct.Name} - Price: {maxPriceProduct.Price}");

      // gets the total price of all products
      var totalPrice = productService.GetTotalPrice();
      Console.WriteLine($"\n3. Total Price of all products: {totalPrice}");

      //  average of total price
      var averagePrice = productService.GetAveragePrice();
      Console.WriteLine($"\n4. Average Price: {averagePrice}");

      // Group products by their category
      var groupedProducts = productService.GetProductsGroupedByCategory();
      Console.WriteLine("\n5. Grouped Products by Category:");
      foreach (var group in groupedProducts)
      {
         Console.WriteLine($"Category: {group.Key}");
         foreach (var product in group)
         {
               Console.WriteLine($"    {product.Name}");
         }
      }
   }

}