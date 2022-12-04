﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221204200711_migo")]
    partial class migo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EntitiesLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReaTaskId")
                        .HasColumnType("int");

                    b.Property<int?>("ReaTaskId1")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ReaTaskId1");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntitiesLayer.Concrete.ReaTask", b =>
                {
                    b.Property<int>("ReaTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ReaTaskId");

                    b.ToTable("ReaTasks");
                });

            modelBuilder.Entity("EntitiesLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntitiesLayer.Concrete.ReaTask", "ReaTask")
                        .WithMany()
                        .HasForeignKey("ReaTaskId1");

                    b.Navigation("ReaTask");
                });
#pragma warning restore 612, 618
        }
    }
}
