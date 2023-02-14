﻿// <auto-generated />
using System;
using LessonsBotDbProvider.ModelsDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LessonsBotDbProvider.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230214133908_v3")]
    partial class v3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.CachedCabs", b =>
                {
                    b.Property<string>("IdCab")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("CachedCabs");
                });

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.CachedGroup", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("currator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("CachedGroups");
                });

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.CachedTeacher", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("CachedTeachers");
                });
#pragma warning restore 612, 618
        }
    }
}
