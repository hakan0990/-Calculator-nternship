﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hesapMakinesi.Data;

#nullable disable

namespace hesapMakinesi.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240625134347_mignew")]
    partial class mignew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hesapMakinesi.Model.Result", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numerusordo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numerusordo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sonucdeğeri")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
