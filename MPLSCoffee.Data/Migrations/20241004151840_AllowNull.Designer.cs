﻿// <auto-generated />
using System;
using MPLSCoffee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MPLSCoffee.Data.Migrations
{
    [DbContext(typeof(CoffeeShopContext))]
    [Migration("20241004151840_AllowNull")]
    partial class AllowNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MPLSCoffee.Data.Models.CoffeeShop", b =>
                {
                    b.Property<string>("PlaceId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double?>("Rating")
                        .HasColumnType("double");

                    b.Property<int?>("UserRatingsTotal")
                        .HasColumnType("int");

                    b.HasKey("PlaceId");

                    b.ToTable("CoffeeShops");
                });

            modelBuilder.Entity("MPLSCoffee.Data.Models.CoffeeShopHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("CloseTime")
                        .HasColumnType("time(6)");

                    b.Property<string>("CoffeeShopPlaceId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("OpenTime")
                        .HasColumnType("time(6)");

                    b.HasKey("Id");

                    b.HasIndex("CoffeeShopPlaceId");

                    b.ToTable("CoffeeShopHours");
                });

            modelBuilder.Entity("MPLSCoffee.Data.Models.CoffeeShopHours", b =>
                {
                    b.HasOne("MPLSCoffee.Data.Models.CoffeeShop", "CoffeeShop")
                        .WithMany("Hours")
                        .HasForeignKey("CoffeeShopPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeShop");
                });

            modelBuilder.Entity("MPLSCoffee.Data.Models.CoffeeShop", b =>
                {
                    b.Navigation("Hours");
                });
#pragma warning restore 612, 618
        }
    }
}
