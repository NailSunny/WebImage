﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebImage.DB;

#nullable disable

namespace WebImage.Migrations
{
    [DbContext(typeof(DBImage))]
    [Migration("20241122095435_pop")]
    partial class pop
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebImage.Model.Image", b =>
                {
                    b.Property<int>("Id_image")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_image"));

                    b.Property<DateTime>("Create_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Entity_Id")
                        .HasColumnType("int");

                    b.Property<string>("Entity_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("File_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_image");

                    b.ToTable("Image");
                });
#pragma warning restore 612, 618
        }
    }
}
