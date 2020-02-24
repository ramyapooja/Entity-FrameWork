﻿// <auto-generated />
using System;
using EFPractice.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFPractice.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFPractice.Models.Item", b =>
                {
                    b.Property<int>("item_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("item_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("item_price")
                        .HasColumnType("int");

                    b.HasKey("item_id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("EFPractice.Models.Order", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("delivery_date")
                        .HasColumnType("Date");

                    b.Property<int?>("item_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("order_date")
                        .HasColumnType("Date");

                    b.HasKey("order_id");

                    b.HasIndex("item_id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("EFPractice.Models.Order", b =>
                {
                    b.HasOne("EFPractice.Models.Item", "Item")
                        .WithMany("Orders")
                        .HasForeignKey("item_id");
                });
#pragma warning restore 612, 618
        }
    }
}
