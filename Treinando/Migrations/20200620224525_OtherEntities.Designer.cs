﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Treinando.Data;

namespace Treinando.Migrations
{
    [DbContext(typeof(TreinandoContext))]
    [Migration("20200620224525_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Treinando.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Treinando.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Treinando.Models.SalesRecord", b =>
                {
                    b.Property<int>("SalesRecordId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<int>("CompanyId");

                    b.Property<double>("Price");

                    b.Property<DateTime>("SaleDate");

                    b.HasKey("SalesRecordId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CompanyId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("Treinando.Models.Company", b =>
                {
                    b.HasOne("Treinando.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Treinando.Models.SalesRecord", b =>
                {
                    b.HasOne("Treinando.Models.Client", "Client")
                        .WithMany("SalesRecords")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Treinando.Models.Company", "Company")
                        .WithMany("SalesRecords")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
