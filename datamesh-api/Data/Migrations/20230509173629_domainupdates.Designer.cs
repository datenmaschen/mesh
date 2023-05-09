﻿// <auto-generated />
using System;
using Datamesh.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace datamesh.Data.Migrations
{
    [DbContext(typeof(DatameshContext))]
    [Migration("20230509173629_domainupdates")]
    partial class domainupdates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Datamesh.Models.DataDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DevOpsProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(43)
                        .HasColumnType("nvarchar(43)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAbbrevationLong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAbbreviationShort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubscriptionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataDomainSet", (string)null);
                });

            modelBuilder.Entity("Datamesh.Models.Dataproduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdGroupContributor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApiUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CatalogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DataDomainId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeputyOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(43)
                        .HasColumnType("nvarchar(43)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(43)
                        .HasColumnType("nvarchar(43)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RefreshInHour")
                        .HasColumnType("int");

                    b.Property<int>("ServiceLevelObjectiveStability")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UsageRestrictions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DataDomainId");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("DataproductSet", (string)null);
                });

            modelBuilder.Entity("Datamesh.Models.Dataproduct", b =>
                {
                    b.HasOne("Datamesh.Models.DataDomain", "DataDomain")
                        .WithMany("Dataproducts")
                        .HasForeignKey("DataDomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataDomain");
                });

            modelBuilder.Entity("Datamesh.Models.DataDomain", b =>
                {
                    b.Navigation("Dataproducts");
                });
#pragma warning restore 612, 618
        }
    }
}
