﻿// <auto-generated />
using System;
using MILILAssesment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MILILAssesment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240118043523_UpdatePRBookInfo")]
    partial class UpdatePRBookInfo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MILILAssesment.Models.Entities.PRBookInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Archive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EntryWSIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IssuedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("IssuedQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Locked")
                        .HasColumnType("bit");

                    b.Property<string>("OfficeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReqBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReqDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReqNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ReqQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReqbyTierCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateEntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateWSIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tblPRBookInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
