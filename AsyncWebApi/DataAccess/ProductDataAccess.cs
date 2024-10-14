using System.Collections.Generic;
using System.Threading;

namespace AsyncWebApi.DataAccess
{
    public class ProductDataAccess
    {

        public static IEnumerable<Product> GetProducts()
        {
            Thread.Sleep(5000);
            return new List<Product> {
                new Product() {Name="Apple", Description="Red and delicious", Price = 0.5m},
                new Product() {Name="MacBook Air", Description="Sleek and fast", Price = 20000},
                new Product() {Name="Bagel", Description="Yummy!", Price = 1.2m},
                new Product() {Name="Spa session", Description="2 hours at Minay Spa Resort", Price = 110},
                new Product() {Name="Screwdriver set", Description="25 different screwdrivers, all sizes", Price = 25.5m},
            };
        }
    }
}