﻿// <auto-generated />
using System;
using AppOrmEntity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppOrmEntity.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241108230825_AddShoppingCartAndUpdates")]
    partial class AddShoppingCartAndUpdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("AppOrmEntity.Models.Book", b =>
                {
                    b.Property<int>("IdBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("IdBook");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("AppOrmEntity.Models.Sage", b =>
                {
                    b.Property<int>("IdSage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdSage");

                    b.ToTable("Sages");
                });

            modelBuilder.Entity("AppOrmEntity.Models.SageBook", b =>
                {
                    b.Property<int>("IdSageBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookIdBook")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdBook")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdSage")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SageIdSage")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdSageBook");

                    b.HasIndex("BookIdBook");

                    b.HasIndex("SageIdSage");

                    b.ToTable("SageBooks");
                });

            modelBuilder.Entity("AppOrmEntity.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("CartItem", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookIdBook")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookId");

                    b.HasIndex("BookIdBook");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin",
                            Role = "Admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("AppOrmEntity.Models.SageBook", b =>
                {
                    b.HasOne("AppOrmEntity.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookIdBook")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppOrmEntity.Models.Sage", "Sage")
                        .WithMany()
                        .HasForeignKey("SageIdSage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Sage");
                });

            modelBuilder.Entity("CartItem", b =>
                {
                    b.HasOne("AppOrmEntity.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookIdBook")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppOrmEntity.Models.ShoppingCart", null)
                        .WithMany("Items")
                        .HasForeignKey("ShoppingCartId");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("AppOrmEntity.Models.ShoppingCart", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}