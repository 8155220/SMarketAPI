using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMarketAPI.Models;
using Bogus;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMarketAPI.Models
{
    public class SMarketContext : DbContext
    {
        public SMarketContext(DbContextOptions<SMarketContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Product>()
                .Property(p => p.Created)
                .HasDefaultValueSql("getdate()");
            
        /*modelBuilder.Entity<Product>()
                .HasMany(p => p.Images)
                .WithOne(img => img.Product);

        modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductType); */

            /*modelBuilder.Entity<Product>()
                .HasOne(p => p.PrincipalImage)
                .WithOne(i => i.Product);*/


            /*modelBuilder.Entity<Product>()
                .HasOne(p => p.UnitType)
                .WithOne(e => e);*/

            /* modelBuilder.Entity<ProductType>().HasData(
             new { FName = "Bebida Lacteos", Description = "Description  1" },
             new { Name = "Bebida Alcohol", Description = "Description 1" });
             */
            //int i = 1;
            //var faker = new Faker();
            // modelBuilder.Entity<ProductType>().

            fakeProductTypes(modelBuilder);
            fakeUnitTypes(modelBuilder);
            //fakeProduct(modelBuilder);

        }

        public DbSet<SMarketAPI.Models.Image> Image { get; set; }

        public DbSet<SMarketAPI.Models.ProductType> ProductType { get; set; }

        public DbSet<SMarketAPI.Models.UnitType> UnitType { get; set; }

        public void fakeProductTypes(ModelBuilder modelBuilder)
        {
            var id = 1;
            var testProductType = new Faker<ProductType>("es_MX")
                .StrictMode(false)
                .RuleFor(pt => pt.ProductTypeId, f => id++)
                .RuleFor(pt => pt.Name, f => f.Commerce.ProductAdjective())
                .RuleFor(pt => pt.Description, f => f.Commerce.ProductMaterial())
                //.Ignore(pt => pt.Products);
                ;
            var productType = testProductType.Generate(10);

            productType.ForEach(x => modelBuilder.Entity<ProductType>().HasData(
                new ProductType
                {
                    ProductTypeId = x.ProductTypeId,
                    Name = x.Name,
                    Description = x.Description
                }));
            //productType.ForEach(x => x.Products);

            //Console.WriteLine(JsonConvert.SerializeObject(productType, Formatting.Indented)); //Super improtante LIsta->Json
                                                                                              //productType.ForEach(x => Console.WriteLine(x.ToString()));


            //modelBuilder.Entity<ProductType>().HasData(productType);
        }
        public void fakeUnitTypes(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UnitType>().HasData(
                new UnitType
                {
                    UnitTypeId = 1,
                    Symbol="kg",
                    Description = "kilos"
                }, new UnitType
                {
                    UnitTypeId = 2,
                    Symbol = "gr",
                    Description = "gramos"
                }, new UnitType
                {
                    UnitTypeId = 3,
                    Symbol = "lt",
                    Description = "litros"
                }, new UnitType
                {
                    UnitTypeId = 4,
                    Symbol = "ml",
                    Description = "mililitros"
                }
                );
        }
        public void fakeProduct(ModelBuilder modelBuilder)
        {
            var id = 1;
            var testProduct = new Faker<Product>("es_MX")
                .StrictMode(false)
                .RuleFor(pt => pt.ProductId, f => id++)
                .RuleFor(pt => pt.Name, f => f.Commerce.ProductName())
                .RuleFor(pt => pt.SellPrice, f => f.Finance.Amount())
                .RuleFor(pt => pt.BuyPrice, f => f.Finance.Amount())
                .RuleFor(pt => pt.ExpirationDate, f => f.Date.Future())
                .RuleFor(pt => pt.Description, f => f.Lorem.Sentence())
                .RuleFor(pt => pt.Created, f => f.Date.Past())
                .RuleFor(pt => pt.Image, f => f.Internet.Avatar())
                ;
            var product = testProduct.Generate(5);

            product.ForEach(x => modelBuilder.Entity<Product>().HasData(
                new
                {
                    ProductId = x.ProductId,
                    Name = x.Name,
                    SellPrice=x.SellPrice,
                    BuyPrice=x.BuyPrice,
                    ExpirationDate=x.ExpirationDate,
                    Description = x.Description,
                    Image=x.Image,
                    ProductTypeId=new Faker().Random.Number(1,10),
                    UnitTypeId= new Faker().Random.Number(1, 4)
                }));
            //productType.ForEach(x => x.Products);

           // Console.WriteLine(JsonConvert.SerializeObject(productType, Formatting.Indented)); //Super improtante LIsta->Json
                                                                                              //productType.ForEach(x => Console.WriteLine(x.ToString()));


            //modelBuilder.Entity<ProductType>().HasData(productType);
        }
        public DbSet<SMarketAPI.Models.ContactUs> ContactUs { get; set; }


    }
}
