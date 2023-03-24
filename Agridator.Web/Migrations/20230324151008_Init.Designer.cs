﻿// <auto-generated />
using System;
using Agridator.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Agridator.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230324151008_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Agridator.Web.Data.Entities.Culture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CatId")
                        .HasColumnType("integer");

                    b.Property<int>("Cultureode")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.ToTable("Cultures");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.CultureCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("CultureCategories");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.Fertilizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Fertilizers");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.PlantProtectionProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ActiveSubstances")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WNr")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PlantProtectionProducts");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.TypeOfWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("TypeOfWorks");
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.UsageType", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Code"));

                    b.Property<int>("BffQi")
                        .HasColumnType("integer");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("Overlaying")
                        .HasColumnType("integer");

                    b.Property<int>("SpezialCulture")
                        .HasColumnType("integer");

                    b.Property<int?>("ValidFromYear")
                        .HasColumnType("integer");

                    b.Property<int?>("ValidToYear")
                        .HasColumnType("integer");

                    b.HasKey("Code");

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
                                .HasColumnType("integer");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

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
                                .HasColumnType("integer");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

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
                                .HasColumnType("integer");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.HasKey("FertilizerId");

                            b1.ToTable("Fertilizers");

                            b1.WithOwner()
                                .HasForeignKey("FertilizerId");
                        });

                    b.Navigation("Description")
                        .IsRequired();
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.TypeOfWork", b =>
                {
                    b.OwnsOne("Agridator.Web.Data.Entities.LocalizedStringSet", "Title", b1 =>
                        {
                            b1.Property<int>("TypeOfWorkId")
                                .HasColumnType("integer");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.HasKey("TypeOfWorkId");

                            b1.ToTable("TypeOfWorks");

                            b1.WithOwner()
                                .HasForeignKey("TypeOfWorkId");
                        });

                    b.Navigation("Title")
                        .IsRequired();
                });

            modelBuilder.Entity("Agridator.Web.Data.Entities.UsageType", b =>
                {
                    b.OwnsOne("Agridator.Web.Data.Entities.LocalizedStringSet", "Nutzung", b1 =>
                        {
                            b1.Property<int>("UsageTypeCode")
                                .HasColumnType("integer");

                            b1.Property<string>("De")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("Fr")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.Property<string>("It")
                                .HasMaxLength(8000)
                                .HasColumnType("character varying(8000)");

                            b1.HasKey("UsageTypeCode");

                            b1.ToTable("UsageTypes");

                            b1.WithOwner()
                                .HasForeignKey("UsageTypeCode");
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