﻿// <auto-generated />
using System;
using DB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DB.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210628203114_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<double>("Age")
                        .HasColumnType("float");

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("ClimatZone")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<int>("DietType")
                        .HasColumnType("int");

                    b.Property<int>("EnclosureNumber")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<bool>("NeedsRelocation")
                        .HasColumnType("bit");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<int?>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("MedicalRecordId");

                    b.HasIndex("MenuId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("DB.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("DB.Models.Illness", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEnded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsolationRequired")
                        .HasColumnType("bit");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Illnesses");
                });

            modelBuilder.Entity("DB.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("MenuId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("DB.Models.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateExpectingChildren")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ExpectingChildren")
                        .HasColumnType("bit");

                    b.Property<bool>("Fertility")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("DB.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("DB.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("DB.Models.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TradeType")
                        .HasColumnType("int");

                    b.Property<string>("ZooName")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("DB.Models.Vaccination", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<int>("Vaccine")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("Vaccinations");
                });

            modelBuilder.Entity("DB.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<float>("Age")
                        .HasColumnType("real");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<int>("Occupation")
                        .HasColumnType("int");

                    b.Property<decimal>("Payrate")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("DB.Models.Animal", b =>
                {
                    b.HasOne("DB.Models.Animal", null)
                        .WithMany("Children")
                        .HasForeignKey("AnimalId");

                    b.HasOne("DB.Models.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId");

                    b.HasOne("DB.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");

                    b.HasOne("DB.Models.Worker", null)
                        .WithMany("Animals")
                        .HasForeignKey("WorkerId");

                    b.Navigation("MedicalRecord");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("DB.Models.Food", b =>
                {
                    b.HasOne("DB.Models.Supplier", null)
                        .WithMany("Food")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("DB.Models.Illness", b =>
                {
                    b.HasOne("DB.Models.MedicalRecord", null)
                        .WithMany("Illnesses")
                        .HasForeignKey("MedicalRecordId");
                });

            modelBuilder.Entity("DB.Models.Meal", b =>
                {
                    b.HasOne("DB.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.HasOne("DB.Models.Menu", null)
                        .WithMany("Meals")
                        .HasForeignKey("MenuId");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("DB.Models.Trade", b =>
                {
                    b.HasOne("DB.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("DB.Models.Vaccination", b =>
                {
                    b.HasOne("DB.Models.MedicalRecord", null)
                        .WithMany("Vaccinations")
                        .HasForeignKey("MedicalRecordId");
                });

            modelBuilder.Entity("DB.Models.Animal", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("DB.Models.MedicalRecord", b =>
                {
                    b.Navigation("Illnesses");

                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("DB.Models.Menu", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("DB.Models.Supplier", b =>
                {
                    b.Navigation("Food");
                });

            modelBuilder.Entity("DB.Models.Worker", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}