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

      // finds all the products dedicated to category1 

      var productsInCategory1 =  from product in products
                                 where product.Category == Categories.Category1
                                 select product;
      
      foreach (var product in productsInCategory1)
      {
         Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
      }


      // finds the max price between products

      // var maxPriceProduct = products.OrderByDescending(p => p.Price).First(); 
      // Console.WriteLine($"Maximum price among the products: {maxPriceProduct.Name}: {maxPriceProduct.Price}"); 

      var maxPriceProduct =   (from product in products
                              orderby product.Price descending
                              select product).First();
      Console.WriteLine($"Maximum price among the products: {maxPriceProduct.Name}: {maxPriceProduct.Price}"); 

      

      // Total price of all products in the list

      // var productsTotalPrice = products.Sum(p => p.Price);
      // Console.WriteLine($"Total price of all products is: {productsTotalPrice}");

      var productsTotalPrice =   (from product in products
                                 select product.Price).Sum(); 

      // group by category
      var productsGroupByCategory = from c in products
                                    group c by c.Category;
      
      foreach (var cat in productsGroupByCategory)
      {
         Console.WriteLine($"Grouped by {cat.Key}:");

         foreach (Product c in cat)
         {
            Console.WriteLine($"Product name: {c.Name}");
         }
      }

      // to get the average ampunt of all prices 
      var averageProductsPrice = products.Average(p => p.Price);
      Console.WriteLine($"The Average price of all products: {averageProductsPrice}");

      // get total price of the list and devide by list length 

      var averageProductsPrice2 = productsTotalPrice / products.Count;
      Console.WriteLine(averageProductsPrice2);

   }

}