﻿// <auto-generated />
using System;
using Agridator.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agridator.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230324080919_AdditionalEntities")]
    partial class AdditionalEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Agridator.Web.Data.Entities.Culture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CatId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cultureode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.ToTable("Cultures");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.CultureCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CultureCategories");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.Fertilizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Fertilizers");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.PlantProtectionProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ActiveSubstances")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WNr")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PlantProtectionProducts");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.TypeOfWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title_de")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title_fr")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title_it")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypeOfWorks");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.UsageType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("BffQi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Overlaying")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SpezialCulture")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ValidFromYear")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ValidToYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("UsageTypes");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.Culture", b =>
                {
                    b.HasOne("Agridator.Web.Data.Entities.CultureCategory", "Category")
                        .WithMany("Cultures")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Agridator.Web.Data.Entities.LocalizedStringSet", "Description", b1 =>
                        {
                            b1.Property<int>("CultureId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.HasKey("CultureId");

                            b1.ToTable("Cultures");

                            b1.WithOwner()
                                .HasForeignKey("CultureId");
                        });

                    b.Navigation("Category");

                    b.Navigation("Description")
                        .IsRequired();
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.CultureCategory", b =>
                {
                    b.OwnsOne("Agridator.Web.Data.Entities.LocalizedStringSet", "Description", b1 =>
                        {
                            b1.Property<int>("CultureCategoryId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.HasKey("CultureCategoryId");

                            b1.ToTable("CultureCategories");

                            b1.WithOwner()
                                .HasForeignKey("CultureCategoryId");
                        });

                    b.Navigation("Description")
                        .IsRequired();
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.Fertilizer", b =>
                {
                    b.OwnsOne("Agridator.Web.Data.Entities.LocalizedStringSet", "Description", b1 =>
                        {
                            b1.Property<int>("FertilizerId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.HasKey("FertilizerId");

                            b1.ToTable("Fertilizers");

                            b1.WithOwner()
                                .HasForeignKey("FertilizerId");
                        });

                    b.Navigation("Description")
                        .IsRequired();
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.UsageType", b =>
                {
                    b.OwnsOne("Agridator.Web.Data.Entities.LocalizedStringSet", "Nutzung", b1 =>
                        {
                            b1.Property<Guid>("UsageTypeId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("TEXT");

                            b1.HasKey("UsageTypeId");

                            b1.ToTable("UsageTypes");

                            b1.WithOwner()
                                .HasForeignKey("UsageTypeId");
                        });

                    b.Navigation("Nutzung")
                        .IsRequired();
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.CultureCategory", b =>
                {
                    b.Navigation("Cultures");
                });
#pragma warning restore 612, 618
        }
    }
}
