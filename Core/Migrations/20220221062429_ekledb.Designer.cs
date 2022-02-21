﻿// <auto-generated />
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220221062429_ekledb")]
    partial class ekledb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Models.Entity.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FilmAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FilmTurId")
                        .HasColumnType("int");

                    b.HasKey("FilmId");

                    b.HasIndex("FilmTurId");

                    b.ToTable("Filmler");
                });

            modelBuilder.Entity("Core.Models.Entity.FilmTur", b =>
                {
                    b.Property<int>("FilmTurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TurAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmTurId");

                    b.ToTable("FilmTurleri");
                });

            modelBuilder.Entity("Core.Models.Entity.Film", b =>
                {
                    b.HasOne("Core.Models.Entity.FilmTur", "FilmTur")
                        .WithMany("Filmler")
                        .HasForeignKey("FilmTurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilmTur");
                });

            modelBuilder.Entity("Core.Models.Entity.FilmTur", b =>
                {
                    b.Navigation("Filmler");
                });
#pragma warning restore 612, 618
        }
    }
}
