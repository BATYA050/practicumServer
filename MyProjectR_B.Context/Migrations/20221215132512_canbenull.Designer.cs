﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyProjectR_B.Context;

#nullable disable

namespace MyProjectR_B.Context.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221215132512_canbenull")]
    partial class canbenull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyProjectR_B.Repositories.Entities.AddLocations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("InvitedAdvertismentId")
                        .HasColumnType("int");

                    b.Property<int>("PageNum")
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvitedAdvertismentId");

                    b.ToTable("AddLocations");
                });

            modelBuilder.Entity("MyProjectR_B.Repositories.Entities.AdvertismentSize", b =>
                {
                    b.Property<int>("AdvertismentSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvertismentSizeId"), 1L, 1);

                    b.Property<int>("Lenth")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("AdvertismentSizeId");

                    b.ToTable("AdvertismentSize");
                });

            modelBuilder.Entity("MyProjectR_B.Repositories.Entities.FontSize", b =>
                {
                    b.Property<int>("FontSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FontSizeId"), 1L, 1);

                    b.Property<int>("MaxSize")
                        .HasColumnType("int");

                    b.Property<int>("MinSize")
                        .HasColumnType("int");

                    b.HasKey("FontSizeId");

                    b.ToTable("FontSize");
                });

            modelBuilder.Entity("MyProjectR_B.Repositories.Entities.InvitedAdvertisment", b =>
                {
                    b.Property<int>("InvitedAdvertismentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvitedAdvertismentId"), 1L, 1);

                    b.Property<int>("AdvertismentSizeId")
                        .HasColumnType("int");

                    b.Property<int>("FontSizeId")
                        .HasColumnType("int");

                    b.Property<int>("PageTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("InvitedAdvertismentId");

                    b.HasIndex("AdvertismentSizeId");

                    b.HasIndex("FontSizeId");

                    b.HasIndex("UserId");

                    b.ToTable("InvitedAdvertisment");
                });

            modelBuilder.Entity("MyProjectR_B.Repositories.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("PhoneUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MyProjectR_B.Repositories.Entities.AddLocations", b =>
                {
                    b.HasOne("MyProjectR_B.Repositories.Entities.InvitedAdvertisment", "InvitedAdvertisment")
                        .WithMany()
                        .HasForeignKey("InvitedAdvertismentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InvitedAdvertisment");
                });

            modelBuilder.Entity("MyProjectR_B.Repositories.Entities.InvitedAdvertisment", b =>
                {
                    b.HasOne("MyProjectR_B.Repositories.Entities.AdvertismentSize", "AdvertismentSize")
                        .WithMany()
                        .HasForeignKey("AdvertismentSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyProjectR_B.Repositories.Entities.FontSize", "FontSize")
                        .WithMany()
                        .HasForeignKey("FontSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyProjectR_B.Repositories.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdvertismentSize");

                    b.Navigation("FontSize");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
