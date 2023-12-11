﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OOO_Bank_NVA.DB;

namespace OOO_Bank_NVA.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231211184354_EditStringDataEnd")]
    partial class EditStringDataEnd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OOO_Bank_NVA.Models.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusBy")
                        .HasColumnType("int");

                    b.Property<Guid>("TovarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("TovarId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("OOO_Bank_NVA.Models.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CSCCode")
                        .HasColumnType("int")
                        .HasMaxLength(6);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("DateEnd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nomer")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Nomer")
                        .IsUnique()
                        .HasName("IX_Card_Nomer")
                        .HasFilter("DeletedAt is null");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("OOO_Bank_NVA.Models.DBBank", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique()
                        .HasName("IX_DBBank_Login")
                        .HasFilter("DeletedAt is null");

                    b.HasIndex("Status")
                        .HasName("IX_DBBank_Status")
                        .HasFilter("DeletedAt is null");

                    b.ToTable("DBBanks");
                });

            modelBuilder.Entity("OOO_Bank_NVA.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasName("IX_Person_Phone")
                        .HasFilter("DeletedAt is null");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("OOO_Bank_NVA.Models.Tovar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxCount")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasName("IX_Tovar_Title")
                        .HasFilter("DeletedAt is null");

                    b.ToTable("Tovars");
                });

            modelBuilder.Entity("OOO_Bank_NVA.Models.Basket", b =>
                {
                    b.HasOne("OOO_Bank_NVA.Models.Person", "Person")
                        .WithMany("Basket")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OOO_Bank_NVA.Models.Tovar", "Tovar")
                        .WithMany("Basket")
                        .HasForeignKey("TovarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
