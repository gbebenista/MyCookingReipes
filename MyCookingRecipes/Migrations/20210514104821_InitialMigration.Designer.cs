﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCookingRecipes;

namespace MyCookingRecipes.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210514104821_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyCookingRecipes.DataWybraniaPrzepisu", b =>
                {
                    b.Property<int>("DataWybraniaPrzepisuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataWybrania")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPrzepisu")
                        .HasColumnType("int");

                    b.Property<int?>("PrzepisyId")
                        .HasColumnType("int");

                    b.HasKey("DataWybraniaPrzepisuId");

                    b.HasIndex("PrzepisyId");

                    b.ToTable("DataWybraniaPrzepisow");
                });

            modelBuilder.Entity("MyCookingRecipes.KrokiPrzygotowaniaPrzepisu", b =>
                {
                    b.Property<int>("KrokiPrzygotowaniaPrzepisuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPrzepisu")
                        .HasColumnType("int");

                    b.Property<int>("KolejnoscWPrzepisie")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrzepisyId")
                        .HasColumnType("int");

                    b.HasKey("KrokiPrzygotowaniaPrzepisuId");

                    b.HasIndex("PrzepisyId");

                    b.ToTable("KrokiPrzygotowaniaPrzepisow");
                });

            modelBuilder.Entity("MyCookingRecipes.Przepisy", b =>
                {
                    b.Property<int>("PrzepisyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CzasPrzygotowania")
                        .HasColumnType("int");

                    b.Property<int?>("IloscPorcji")
                        .HasColumnType("int");

                    b.Property<string>("NazwaPotrawy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrzepisyId");

                    b.ToTable("Przepisy");
                });

            modelBuilder.Entity("MyCookingRecipes.RodzajIlosciSkladnika", b =>
                {
                    b.Property<int>("RodzajIlosciSkladnikaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Liczebność")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RodzajIlosciSkladnikaId");

                    b.ToTable("RodzajIlosciSkladnikow");
                });

            modelBuilder.Entity("MyCookingRecipes.SkladnikWPrzepisie", b =>
                {
                    b.Property<int>("SkladnikWPrzepisieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPrzepisu")
                        .HasColumnType("int");

                    b.Property<int>("IdSkladnika")
                        .HasColumnType("int");

                    b.Property<decimal>("Ilosc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PrzepisyId")
                        .HasColumnType("int");

                    b.Property<int?>("SkladnikiId")
                        .HasColumnType("int");

                    b.HasKey("SkladnikWPrzepisieId");

                    b.HasIndex("PrzepisyId");

                    b.HasIndex("SkladnikiId");

                    b.ToTable("SkladnikiWPrzepisach");
                });

            modelBuilder.Entity("MyCookingRecipes.Skladniki", b =>
                {
                    b.Property<int>("SkladnikiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdRodzajuIlosciSkladnika")
                        .HasColumnType("int");

                    b.Property<string>("NazwaSkladnika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RodzajIlosciSkladnikaId")
                        .HasColumnType("int");

                    b.HasKey("SkladnikiId");

                    b.HasIndex("RodzajIlosciSkladnikaId");

                    b.ToTable("Skladniki");
                });

            modelBuilder.Entity("MyCookingRecipes.Ulubione", b =>
                {
                    b.Property<int>("UlubioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CzySystemDodal")
                        .HasColumnType("bit");

                    b.Property<int>("IdPrzepisu")
                        .HasColumnType("int");

                    b.Property<int?>("PrzepisyId")
                        .HasColumnType("int");

                    b.HasKey("UlubioneId");

                    b.HasIndex("PrzepisyId");

                    b.ToTable("Ulubione");
                });

            modelBuilder.Entity("MyCookingRecipes.DataWybraniaPrzepisu", b =>
                {
                    b.HasOne("MyCookingRecipes.Przepisy", "Przepisy")
                        .WithMany("DataWybraniaPrzepisow")
                        .HasForeignKey("PrzepisyId");
                });

            modelBuilder.Entity("MyCookingRecipes.KrokiPrzygotowaniaPrzepisu", b =>
                {
                    b.HasOne("MyCookingRecipes.Przepisy", "Przepisy")
                        .WithMany("KrokiPrzygotowaniaPrzepisow")
                        .HasForeignKey("PrzepisyId");
                });

            modelBuilder.Entity("MyCookingRecipes.SkladnikWPrzepisie", b =>
                {
                    b.HasOne("MyCookingRecipes.Przepisy", "Przepis")
                        .WithMany("SkladnikiWPrzepisie")
                        .HasForeignKey("PrzepisyId");

                    b.HasOne("MyCookingRecipes.Skladniki", "Skladnik")
                        .WithMany("SkladnikiWPrzepisie")
                        .HasForeignKey("SkladnikiId");
                });

            modelBuilder.Entity("MyCookingRecipes.Skladniki", b =>
                {
                    b.HasOne("MyCookingRecipes.RodzajIlosciSkladnika", "RodzajIlosciSkladnika")
                        .WithMany("Skladnik")
                        .HasForeignKey("RodzajIlosciSkladnikaId");
                });

            modelBuilder.Entity("MyCookingRecipes.Ulubione", b =>
                {
                    b.HasOne("MyCookingRecipes.Przepisy", "Przepis")
                        .WithMany("Ulubione")
                        .HasForeignKey("PrzepisyId");
                });
#pragma warning restore 612, 618
        }
    }
}
