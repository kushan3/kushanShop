using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kushanShop.Data;


namespace KushanShop.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new kushanShopContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<kushanShopContext>>()))
            {
                // Look for any movies.
                if (context.Shop.Any())
                {
                    return;   // DB has been seeded
                }

                context.Shop.AddRange(
                  new Shop
                  {
                     Type ="Shorts",
                     Size = "Small",
                     Color ="Black",
                     Price = 5.5M,
                     Rating= 5
                  }, new Shop
                  {
                      Type = "Shorts",
                      Size = "Large",
                      Color = "Yellow",
                      Price = 8.5M,
                      Rating = 4
                  }, new Shop
                  {
                      Type = "Shorts",
                      Size = "Small",
                      Color = "Brown",
                      Price = 3.8M,
                      Rating = 3
                  }, new Shop
                  {
                      Type = "Stampted plastic",
                      Size = "Medium",
                      Color = "Black",
                      Price = 5.5M,
                      Rating = 5
                  }, new Shop
                  {
                      Type = "Shorts",
                      Size = "Medium",
                      Color = "Black",
                      Price = 4.5M,
                      Rating = 3
                  }, new Shop
                  {
                      Type = "Stamped metal",
                      Size = "Large",
                      Color = "Black",
                      Price = 4.5M,
                      Rating = 3
                  }, new Shop
                  {
                      Type = "Shorts",
                      Size = "Large",
                      Color = "Red",
                      Price = 4.5M,
                      Rating = 2
                  }, new Shop
                  {
                      Type = "Coil",
                      Size = "Large",
                      Color = "Orange",
                      Price = 5.6M,
                      Rating = 5
                  }, new Shop
                  {
                      Type = "stamped metal",
                      Size = "Small",
                      Color = "Green",
                      Price = 5.5M,
                      Rating = 4
                  }, new Shop
                  {
                      Type = "Stampted plastic",
                      Size = "Large",
                      Color = "Blue",
                      Price = 4.5M,
                      Rating = 5
                  }

                );
                context.SaveChanges();
            }
        }
    }
}
