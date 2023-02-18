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
    [Migration("20230218114029_v5")]
    partial class v5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.Bot", b =>
                {
                    b.Property<Guid>("IdBot")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Timer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdBot");

                    b.ToTable("Bots");
                });

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
                    b.Property<Guid>("IdGroupGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int?>("currator")
                        .HasColumnType("INTEGER");

                    b.Property<int>("id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdGroupGuid");

                    b.ToTable("CachedGroups");
                });

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.CachedTeacher", b =>
                {
                    b.Property<Guid>("IdTeacherGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdTeacherGuid");

                    b.ToTable("CachedTeachers");
                });

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.ChatTask", b =>
                {
                    b.Property<Guid>("IdTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BotIdBot")
                        .HasColumnType("TEXT");

                    b.Property<long>("IdChat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdTask");

                    b.HasIndex("BotIdBot");

                    b.ToTable("ChatTask");
                });

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.WordBook", b =>
                {
                    b.Property<Guid>("IdWord")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Questions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdWord");

                    b.ToTable("WordBooks");
                });

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.ChatTask", b =>
                {
                    b.HasOne("LessonsBotDbProvider.ModelsDb.Bot", null)
                        .WithMany("ChatTasks")
                        .HasForeignKey("BotIdBot");
                });

            modelBuilder.Entity("LessonsBotDbProvider.ModelsDb.Bot", b =>
                {
                    b.Navigation("ChatTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
