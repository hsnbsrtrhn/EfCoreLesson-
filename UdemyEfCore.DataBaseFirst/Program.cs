using Microsoft.EntityFrameworkCore;
using UdemyEfCore.Data.DAL;

class Program
{
    static void Main(string[] args)
    {
        // Build the configuration
        DbContextInitializer.Build();

        using (var context = new AppDbContext())
        {
            var products = context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}

