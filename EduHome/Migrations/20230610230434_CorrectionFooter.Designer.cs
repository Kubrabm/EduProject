﻿// <auto-generated />
using System;
using EduHome.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EduHome.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230610230434_CorrectionFooter")]
    partial class CorrectionFooter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.Footer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Footer");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.GetInTouch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FooterId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.ToTable("GetInTouch");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FooterId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.ToTable("Information");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FooterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.ToTable("SocialMedia");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.UsefulLinks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FooterId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FooterId");

                    b.ToTable("UsefulLinks");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.GetInTouch", b =>
                {
                    b.HasOne("EduHome.DataAccessLayer.Entity.Footer", null)
                        .WithMany("GetInTouch")
                        .HasForeignKey("FooterId");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.Information", b =>
                {
                    b.HasOne("EduHome.DataAccessLayer.Entity.Footer", "Footer")
                        .WithMany("Information")
                        .HasForeignKey("FooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Footer");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.SocialMedia", b =>
                {
                    b.HasOne("EduHome.DataAccessLayer.Entity.Footer", "Footer")
                        .WithMany("SocialMedia")
                        .HasForeignKey("FooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Footer");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.UsefulLinks", b =>
                {
                    b.HasOne("EduHome.DataAccessLayer.Entity.Footer", "Footer")
                        .WithMany("UsefulLinks")
                        .HasForeignKey("FooterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Footer");
                });

            modelBuilder.Entity("EduHome.DataAccessLayer.Entity.Footer", b =>
                {
                    b.Navigation("GetInTouch");

                    b.Navigation("Information");

                    b.Navigation("SocialMedia");

                    b.Navigation("UsefulLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
