using Charlee.Models;
using Charlee.Contexts;
using System.Diagnostics;

namespace Charlee
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            // Look for any students.
            if (context.Products.Any())
            {
                Product? p = context.Products.Find(1);
                if (p != null)
                    Console.WriteLine("ID: {0}, Brand: {1}, Model: {2}, Price {3}", p.ID, p.Brand, p.Model, p.Price);
                else
                    Console.WriteLine("null");
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                new Product{Brand="Adidas", Model="TRX 2090", Price=23.90M},
                new Product{Brand="Nike", Model="P8", Price=209.1M},
                new Product{Brand="MSI", Model="GamerPC", Price=1190M}
            };

            context.Products.AddRange(products);
            context.SaveChanges();
            Console.WriteLine("Added " + products.Length + " products");
        }
    }
}