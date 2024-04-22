using BharatCrafted.Data;
using BharatCrafted.Models;
using Microsoft.EntityFrameworkCore;


namespace ShoppingCart.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(ApplicationDbContext context)
        {
            context.Database.Migrate();

            if (!context.prods.Any())
            {
                Category Metallic = new Category { Name = "Metallic", Slug = "Metallic" };
                Category Wooden = new Category { Name = "Wooden", Slug = "Wooden" };

                context.prods.AddRange(
                        new Prod
                        {
                            Name = "Dancing lady",
                            Slug = "Dancing lady",
                            Description = "Metallic dancing lady",
                            Price = 12.99M,
                            Category = Metallic,
                            Image = "shi.png"
                        },
                        new Prod
                        {
                            Name = "Saur",
                            Slug = "Saur",
                            Description = "Classical saur",
                            Price = 12.99M,
                            Category = Wooden,
                            Image = "saur.png"
                        },
                        new Prod
                        {
                            Name = "Shi",
                            Slug = "Shi",
                            Description = "Ancient Shi",
                            Price = 12.99M,
                            Category = Metallic,
                            Image = "shi.png"
                        },
                        new Prod
                        {
                            Name = "Dancing lady",
                            Slug = "Dancing lady",
                            Description = "Metallic dancing lady",
                            Price = 12.99M,
                            Category = Metallic,
                            Image = "saur.png"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}