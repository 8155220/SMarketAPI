﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMarketAPI.Models;

namespace SMarketAPI.Migrations
{
    [DbContext(typeof(SMarketContext))]
    [Migration("20181016060338_note-fixed-atribute")]
    partial class notefixedatribute
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SMarketAPI.Models.ContactUs", b =>
                {
                    b.Property<int>("ContactUsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<string>("Subject");

                    b.HasKey("ContactUsId");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("SMarketAPI.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<string>("Url");

                    b.Property<bool>("isMain");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("SMarketAPI.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("DeliveredTo");

                    b.Property<string>("NoteType");

                    b.Property<string>("Observation");

                    b.Property<string>("ReceivedBy");

                    b.Property<int>("Total");

                    b.HasKey("NoteId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("SMarketAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BuyPrice");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int>("ProductTypeId");

                    b.Property<string>("Provider");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("SellPrice");

                    b.Property<int>("UnitTypeId");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SMarketAPI.Models.ProductNoteDetail", b =>
                {
                    b.Property<int>("ProductNoteDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("NoteId");

                    b.Property<string>("NoteType");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("ReceivedBy");

                    b.Property<decimal>("UnitCost");

                    b.Property<string>("UnitType");

                    b.HasKey("ProductNoteDetailId");

                    b.HasIndex("NoteId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductNoteDetail");
                });

            modelBuilder.Entity("SMarketAPI.Models.ProductType", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ProductTypeId");

                    b.ToTable("ProductType");

                    b.HasData(
                        new { ProductTypeId = 1, Description = "Caucho", Name = "Increíble" },
                        new { ProductTypeId = 2, Description = "Metal", Name = "Genérica" },
                        new { ProductTypeId = 3, Description = "Plástico", Name = "Pequeño" },
                        new { ProductTypeId = 4, Description = "Caucho", Name = "Elegante" },
                        new { ProductTypeId = 5, Description = "Soft", Name = "Pequeño" },
                        new { ProductTypeId = 6, Description = "Fresco", Name = "Hecho a mano" },
                        new { ProductTypeId = 7, Description = "Plástico", Name = "Increíble" },
                        new { ProductTypeId = 8, Description = "Metal", Name = "Refinado" },
                        new { ProductTypeId = 9, Description = "Hormigón", Name = "Gorgeous" },
                        new { ProductTypeId = 10, Description = "Granito", Name = "Increíble" }
                    );
                });

            modelBuilder.Entity("SMarketAPI.Models.UnitType", b =>
                {
                    b.Property<int>("UnitTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Symbol");

                    b.HasKey("UnitTypeId");

                    b.ToTable("UnitType");

                    b.HasData(
                        new { UnitTypeId = 1, Description = "kilos", Symbol = "kg" },
                        new { UnitTypeId = 2, Description = "gramos", Symbol = "gr" },
                        new { UnitTypeId = 3, Description = "litros", Symbol = "lt" },
                        new { UnitTypeId = 4, Description = "mililitros", Symbol = "ml" }
                    );
                });

            modelBuilder.Entity("SMarketAPI.Models.Image", b =>
                {
                    b.HasOne("SMarketAPI.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SMarketAPI.Models.Product", b =>
                {
                    b.HasOne("SMarketAPI.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SMarketAPI.Models.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SMarketAPI.Models.ProductNoteDetail", b =>
                {
                    b.HasOne("SMarketAPI.Models.Note", "Note")
                        .WithMany()
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SMarketAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
