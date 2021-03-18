using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // sql actions
using Microsoft.Extensions.DependencyInjection; //extenstion
using DDACLocalFarmerProduce.Data; //data link

namespace DDACLocalFarmerProduce.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DDACProductContext(
                serviceProvider.GetRequiredService<DbContextOptions<DDACProductContext>>()))
            {
                //check table kosong?
                if (context.Product.Any())
                {
                    return; //no do sht
                }
                context.Product.AddRange(
                    new Product
                    {
                        ProductName = "Blue Apple",
                        ProductHarvestDate = DateTime.Parse("2020-2-12"),
                        Price = 16.29M,
                        Quantity = 3,
                        Description = "A bag of apples with 3 inside"
                    },
                    new Product
                    {
                        ProductName = "Green Banana",
                        ProductHarvestDate = DateTime.Parse("2019-2-12"),
                        Price = 20.29M,
                        Quantity = 2,
                        Description = "Mai lei gan, Mai lei gan"
                    }
                );
                context.SaveChanges();
            }

        }
    }
}
