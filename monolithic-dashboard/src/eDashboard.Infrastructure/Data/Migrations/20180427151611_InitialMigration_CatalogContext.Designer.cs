﻿// <auto-generated />
using eDashboard.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace eDashboard.Infrastructure.Data.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20180427151611_InitialMigration_CatalogContext")]
    partial class InitialMigration_CatalogContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eShopDashboard.Core.Entities.CatalogItem", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("AvailableStock");

                    b.Property<int>("CatalogBrandId");

                    b.Property<int>("CatalogTypeId");

                    b.Property<string>("Description");

                    b.Property<int>("MaxStockThreshold");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("OnReorder");

                    b.Property<string>("PictureFileName");

                    b.Property<string>("PictureUri");

                    b.Property<decimal>("Price");

                    b.Property<int>("RestockThreshold");

                    b.Property<string>("Tags")
                        .HasMaxLength(4000);

                    b.HasKey("Id");

                    b.ToTable("CatalogItems","Catalog");
                });
#pragma warning restore 612, 618
        }
    }
}
