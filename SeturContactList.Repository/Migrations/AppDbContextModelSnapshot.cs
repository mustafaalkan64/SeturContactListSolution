﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SeturContactList.Repository;

namespace SeturContactList.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SeturContactList.Core.Entities.PersonContacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Info")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Long")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonContacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "İzmir Çiğli",
                            City = "İzmir",
                            CreatedDate = new DateTime(2022, 2, 13, 1, 35, 16, 341, DateTimeKind.Local).AddTicks(9632),
                            Email = "mustafaalkan64@gmail.com",
                            Info = "Test Info",
                            Lat = 34m,
                            Long = 27m,
                            PersonId = 1,
                            Phone = "+905553332211",
                            Town = "Çiğli"
                        },
                        new
                        {
                            Id = 2,
                            Address = "İzmir Bornova",
                            City = "İzmir",
                            CreatedDate = new DateTime(2022, 2, 13, 1, 35, 16, 341, DateTimeKind.Local).AddTicks(9666),
                            Email = "mustafaalkan64@gmail.com",
                            Info = "Test Info",
                            Lat = 35m,
                            Long = 28m,
                            PersonId = 1,
                            Phone = "+905553332212",
                            Town = "Bornova"
                        },
                        new
                        {
                            Id = 3,
                            Address = "İzmir Çiğli",
                            City = "İzmir",
                            CreatedDate = new DateTime(2022, 2, 13, 1, 35, 16, 341, DateTimeKind.Local).AddTicks(9674),
                            Email = "mustafaalkan64@gmail.com",
                            Info = "Test Info",
                            Lat = 34m,
                            Long = 27m,
                            PersonId = 2,
                            Phone = "+905553332211",
                            Town = "Çiğli"
                        },
                        new
                        {
                            Id = 4,
                            Address = "İzmir Bornova",
                            City = "İzmir",
                            CreatedDate = new DateTime(2022, 2, 13, 1, 35, 16, 341, DateTimeKind.Local).AddTicks(9681),
                            Email = "mustafaalkan64@gmail.com",
                            Info = "Test Info",
                            Lat = 35m,
                            Long = 28m,
                            PersonId = 2,
                            Phone = "+905553332212",
                            Town = "Bornova"
                        });
                });

            modelBuilder.Entity("SeturContactList.Core.Entities.Persons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("UUID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Company = "TestCompany",
                            CreatedDate = new DateTime(2022, 2, 13, 1, 35, 16, 336, DateTimeKind.Local).AddTicks(8241),
                            Name = "Mustafa",
                            Surname = "Alkan",
                            UUID = new Guid("130da54c-45c0-4092-8f3b-147ed61c5d38")
                        },
                        new
                        {
                            Id = 2,
                            Company = "TestCompany1",
                            CreatedDate = new DateTime(2022, 2, 13, 1, 35, 16, 340, DateTimeKind.Local).AddTicks(7314),
                            Name = "Ahmet",
                            Surname = "Alkan",
                            UUID = new Guid("92f99b9f-910b-49e8-aa89-48cd610c96ea")
                        });
                });

            modelBuilder.Entity("SeturContactList.Core.Entities.Reports", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ReportStatus")
                        .HasColumnType("integer");

                    b.Property<Guid>("UUID")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("SeturContactList.Core.Entities.PersonContacts", b =>
                {
                    b.HasOne("SeturContactList.Core.Entities.Persons", "Person")
                        .WithMany("PersonContacts")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("SeturContactList.Core.Entities.Persons", b =>
                {
                    b.Navigation("PersonContacts");
                });
#pragma warning restore 612, 618
        }
    }
}
