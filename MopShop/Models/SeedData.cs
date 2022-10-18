using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MopShop.Data;
using System;
using System.Linq;

namespace MopShop.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MopShopContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MopShopContext>>()))
            {
                // Look for any movies.
                if (context.Mops.Any())
                {
                    return;   // DB has been seeded
                }

                context.Mops.AddRange(
                    new Mops
                    {
                        Name = "Moptastic Spin",
                        Type = "Wet",
                        CleaningPurpose = "Spills, Stains",
                        TypeOfSurface = "Hard Floors",
                        Material= "String",
                        Price= 30.99M,
                        CustomerRating = 6,
                        ProductImage= "Mop1.jpeg"
                    },

                    new Mops
                    {
                        Name = "Moptastic String",
                        Type = "Wet",
                        CleaningPurpose = "Spills, Stains, Dirt",
                        TypeOfSurface = "Hard Floors, Tile, Marble",
                        Material = "String",
                        Price = 13.99M,
                        CustomerRating = 3,
                        ProductImage = "Mop2.jpg"
                    },

                    new Mops
                    {
                        Name = "Moptastic Strip",
                        Type = "Wet, Dry",
                        CleaningPurpose = "Dust, Spills, Stains, Dirt",
                        TypeOfSurface = "Hard Floors, Tile, Marble",
                        Material = "Fabric",
                        Price = 10.99M,
                        CustomerRating = 4,
                        ProductImage = "Mop3.jpg"
                    },

                    new Mops
                    {
                        Name = "Moptastic Steam",
                        Type = "Steam",
                        CleaningPurpose = "Spills, Stains, Dirt",
                        TypeOfSurface = "Hard Floors, Carpets, Tiled Walls, Surfaces",
                        Material = "Electric",
                        Price = 90.99M,
                        CustomerRating = 9,
                        ProductImage = "Mop4.jpg"
                    },

                    new Mops
                    {
                        Name = "Moptastic Static",
                        Type = "Dry",
                        CleaningPurpose = "Dust, Debris",
                        TypeOfSurface = "Floors, Surfaces, Blinds, Ceilings",
                        Material = "Microfiber",
                        Price = 9.99M,
                        CustomerRating = 4,
                        ProductImage = "Mop5.jpg"
                    },

                    new Mops
                    {
                        Name = "Moptastic Microfiber",
                        Type = "Wet, Dry",
                        CleaningPurpose = "Spills, Stains, Dirt, Dust",
                        TypeOfSurface = "Hard Floors",
                        Material = "Microfiber",
                        Price = 14.99M,
                        CustomerRating = 5,
                        ProductImage = "Mop6.jpg"
                    },

                    new Mops
                    {
                        Name = "Moptastic Flat",
                        Type = "Wet, Dry",
                        CleaningPurpose = "Stains, Dust, Dirt",
                        TypeOfSurface = "Hard Floors, Vinyl, Hardwood",
                        Material = "Microfiber",
                        Price = 16.99M,
                        CustomerRating = 2,
                        ProductImage = "Mop7.jpg"
                    },

                    new Mops
                    {
                        Name = "Moptastic Sponge",
                        Type = "Wet",
                        CleaningPurpose = "Spills, Stains",
                        TypeOfSurface = "Hard Floors Tile Laminate",
                        Material = "Sponge",
                        Price = 7.99M,
                        CustomerRating = 3,
                        ProductImage = "Mop8.jpg"
                    },

                    new Mops
                    {
                        Name = "Moptastic Dust",
                        Type = "Dry",
                        CleaningPurpose = "Dust Trash",
                        TypeOfSurface = "Hard Floors",
                        Material = "Microfiber",
                        Price = 9.99M,
                        CustomerRating = 7,
                        ProductImage = "Mop9.jpg"
                    },

                    new Mops
                    {
                        Name = "Moptastic Brush",
                        Type = "Dry Wet",
                        CleaningPurpose = "Stains Spills",
                        TypeOfSurface = "Hard Floors Carpets Indoor Outdoor",
                        Material = "Bristles",
                        Price = 8.99M,
                        CustomerRating = 6,
                        ProductImage = "Mop10.jpg"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}

// Reference for Mop Images and Data: 
// https://ohsospotless.com/types-of-mops/ 