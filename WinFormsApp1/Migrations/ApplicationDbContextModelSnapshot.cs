﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WinFormsApp1;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WinFormsApp1.Classement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("Coef")
                        .HasColumnType("real");

                    b.Property<int>("Etoile")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Classements");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Adresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Adresse");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("PrixJour")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Chambre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategorieId")
                        .HasColumnType("integer");

                    b.Property<int>("HotelId")
                        .HasColumnType("integer");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.HasIndex("HotelId");

                    b.ToTable("Chambres");
                });

            modelBuilder.Entity("WinFormsApp1.Models.ChambreImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ChambreId")
                        .HasColumnType("integer");

                    b.Property<string>("Src")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChambreId")
                        .IsUnique();

                    b.ToTable("ChambreImage");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("paye")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdresseId")
                        .HasColumnType("integer");

                    b.Property<int>("ClassementId")
                        .HasColumnType("integer");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AdresseId")
                        .IsUnique();

                    b.HasIndex("ClassementId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("WinFormsApp1.Models.HotelImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("HotelId")
                        .HasColumnType("integer");

                    b.Property<string>("Src")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelImage");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Prestation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FactureId")
                        .HasColumnType("integer");

                    b.Property<float>("Prix")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FactureId");

                    b.ToTable("Prestations");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ChambreId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FactureId")
                        .HasColumnType("integer");

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ChambreId");

                    b.HasIndex("FactureId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Code_postal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Chambre", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Categorie", "Categorie")
                        .WithMany("Chambres")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp1.Models.Hotel", "Hotel")
                        .WithMany("Chambres")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("WinFormsApp1.Models.ChambreImage", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Chambre", null)
                        .WithOne("ChambreImage")
                        .HasForeignKey("WinFormsApp1.Models.ChambreImage", "ChambreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WinFormsApp1.Models.Hotel", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Adresse", "Adresse")
                        .WithOne("Hotel")
                        .HasForeignKey("WinFormsApp1.Models.Hotel", "AdresseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp1.Classement", "Classement")
                        .WithMany("Hotels")
                        .HasForeignKey("ClassementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adresse");

                    b.Navigation("Classement");
                });

            modelBuilder.Entity("WinFormsApp1.Models.HotelImage", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Hotel", "Hotel")
                        .WithMany("HotelImages")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Prestation", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Facture", "Facture")
                        .WithMany("Prestations")
                        .HasForeignKey("FactureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facture");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Reservation", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Chambre", "Chambre")
                        .WithMany("Reservations")
                        .HasForeignKey("ChambreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp1.Models.Facture", "Facture")
                        .WithMany("Reservations")
                        .HasForeignKey("FactureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp1.Models.Utilisateur", "Utilisateur")
                        .WithMany("Reservation")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chambre");

                    b.Navigation("Facture");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("WinFormsApp1.Classement", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Adresse", b =>
                {
                    b.Navigation("Hotel")
                        .IsRequired();
                });

            modelBuilder.Entity("WinFormsApp1.Models.Categorie", b =>
                {
                    b.Navigation("Chambres");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Chambre", b =>
                {
                    b.Navigation("ChambreImage")
                        .IsRequired();

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Facture", b =>
                {
                    b.Navigation("Prestations");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Hotel", b =>
                {
                    b.Navigation("Chambres");

                    b.Navigation("HotelImages");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Utilisateur", b =>
                {
                    b.Navigation("Reservation");
                });
#pragma warning restore 612, 618
        }
    }
}
