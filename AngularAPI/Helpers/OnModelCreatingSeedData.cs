using AngularAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Helpers
{
    public static class OnModelCreatingSeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBrand>().HasData(
                new ProductBrand
                {
                    Id = 1,
                    Name = "Angular",
                },
                new ProductBrand
                {
                    Id = 2,
                    Name = "NetCore",
                },
                new ProductBrand
                {
                    Id = 3,
                    Name = "VS Code",
                },
                new ProductBrand
                {
                    Id = 4,
                    Name = "React",

                },
                new ProductBrand
                {
                    Id = 5,
                    Name = "Typescript",
                },
                new ProductBrand
                {
                    Id = 6,
                    Name = "Redis",
                }
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory
                {
                    Id = 1,
                    Name = "Boards",
                },
                new ProductCategory
                {
                    Id = 2,
                    Name = "Hats",
                },
                 new ProductCategory
                 {
                     Id = 3,
                     Name = "Boots",
                 },
                new ProductCategory
                {
                    Id = 4,
                    Name = "Gloves",
                }
                );
            modelBuilder.Entity<Product>().HasData(
             new Product
             {
                 Id = 1,
                 Name = "Angular Speedster Board 2000",
                 Dsecription = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                 Price = 200,
                 PictureUrl = "images/products/sb-ang1.png",
                 ProductCategoryId = 1,
                 ProductBrandId = 1
             },
             new Product
             {
                 Id = 2,
                 Name = "Green Angular Board 3000",
                 Dsecription = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                 Price = 150,
                 PictureUrl = "images/products/sb-ang2.png",
                 ProductCategoryId = 1,
                 ProductBrandId = 1
             },
             new Product
             {
                 Id = 3,
                 Name = "Core Board Speed Rush 3",
                 Dsecription = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                 Price = 180,
                 PictureUrl = "images/products/sb-core1.png",
                 ProductCategoryId = 1,
                 ProductBrandId = 2
             },
             new Product
             {
                 Id = 4,
                 Name = "Net Core Super Board",
                 Dsecription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                 Price = 300,
                 PictureUrl = "images/products/sb-core2.png",
                 ProductCategoryId = 1,
                 ProductBrandId = 2
             },
             new Product
             {
                 Id = 5,
                 Name = "React Board Super Whizzy Fast",
                 Dsecription = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                 Price = 250,
                 PictureUrl = "images/products/sb-react1.png",
                 ProductCategoryId = 1,
                 ProductBrandId = 4
             },
             new Product
             {
                 Id = 6,
                 Name = "Typescript Entry Board",
                 Dsecription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                 Price = 120,
                 PictureUrl = "images/products/sb-ts1.png",
                 ProductCategoryId = 1,
                 ProductBrandId = 5
             },
             new Product
             {
                 Id = 7,
                 Name = "Core Blue Hat",
                 Dsecription = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                 Price = 10,
                 PictureUrl = "images/products/hat-core1.png",
                 ProductCategoryId = 2,
                 ProductBrandId = 2
             },
             new Product
             {
                 Id = 8,
                 Name = "Green React Woolen Hat",
                 Dsecription = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                 Price = 8,
                 PictureUrl = "images/products/hat-react1.png",
                 ProductCategoryId = 2,
                 ProductBrandId = 4
             },
             new Product
             {
                 Id = 9,
                 Name = "Purple React Woolen Hat",
                 Dsecription = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                 Price = 15,
                 PictureUrl = "images/products/hat-react2.png",
                 ProductCategoryId = 2,
                 ProductBrandId = 4
             },
             new Product
             {
                 Id = 10,
                 Name = "Blue Code Gloves",
                 Dsecription = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                 Price = 18,
                 PictureUrl = "images/products/glove-code1.png",
                 ProductCategoryId = 4,
                 ProductBrandId = 3
             },
             new Product
             {
                 Id = 11,
                 Name = "Green Code Gloves",
                 Dsecription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                 Price = 15,
                 PictureUrl = "images/products/glove-code2.png",
                 ProductCategoryId = 4,
                 ProductBrandId = 3
             },
             new Product
             {
                 Id = 12,
                 Name = "Purple React Gloves",
                 Dsecription = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa.",
                 Price = 16,
                 PictureUrl = "images/products/glove-react1.png",
                 ProductCategoryId = 4,
                 ProductBrandId = 4
             },
             new Product
             {
                 Id = 13,
                 Name = "Green React Gloves",
                 Dsecription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                 Price = 14,
                 PictureUrl = "images/products/glove-react2.png",
                 ProductCategoryId = 4,
                 ProductBrandId = 4
             },
             new Product
             {
                 Id = 14,
                 Name = "Redis Red Boots",
                 Dsecription = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                 Price = 250,
                 PictureUrl = "images/products/boot-redis1.png",
                 ProductCategoryId = 3,
                 ProductBrandId = 6
             },
             new Product
             {
                 Id = 15,
                 Name = "Core Red Boots",
                 Dsecription = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                 Price = Convert.ToDecimal(189.99),
                 PictureUrl = "images/products/boot-core2.png",
                 ProductCategoryId = 3,
                 ProductBrandId = 2
             },
             new Product
             {
                 Id = 16,
                 Name = "Core Purple Boots",
                 Dsecription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                 Price = Convert.ToDecimal(199.99),
                 PictureUrl = "images/products/boot-core1.png",
                 ProductCategoryId = 3,
                 ProductBrandId = 2
             },
             new Product
             {
                 Id = 17,
                 Name = "Angular Purple Boots",
                 Dsecription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                 Price = 150,
                 PictureUrl = "images/products/boot-ang2.png",
                 ProductCategoryId = 3,
                 ProductBrandId = 1
             },
             new Product
             {
                 Id = 18,
                 Name = "Angular Blue Boots",
                 Dsecription = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                 Price = 180,
                 PictureUrl = "images/products/boot-ang1.png",
                 ProductCategoryId = 3,
                 ProductBrandId = 1
             },
              new Product
              {
                  Id = 19,
                  Name = "Omar",
                  Dsecription = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                  Price = 180,
                  PictureUrl = "images/products/boot-ang1.png",
                  ProductCategoryId = 3,
                  ProductBrandId = 1
              }

             );
        }
    }



}
