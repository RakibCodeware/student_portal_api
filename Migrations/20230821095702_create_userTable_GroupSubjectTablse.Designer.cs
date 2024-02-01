﻿// <auto-generated />
using System;
using EduPortalAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EduPortalAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230821095702_create_userTable_GroupSubjectTablse")]
    partial class create_userTable_GroupSubjectTablse
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EduPortalAPI.Models.StudentGroupSubjectDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("MSStatus")
                        .HasColumnType("bit");

                    b.Property<long>("SgsId")
                        .HasColumnType("bigint");

                    b.Property<long>("SubId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SgsId");

                    b.ToTable("StudentGroupSubjectDetailsTemp");
                });

            modelBuilder.Entity("EduPortalAPI.Models.StudentGroupSubjectInfo", b =>
                {
                    b.Property<long>("SgsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SgsId"));

                    b.Property<DateTime>("ApprovedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("AprovedBy")
                        .HasColumnType("bigint");

                    b.Property<int>("BatchID")
                        .HasColumnType("int");

                    b.Property<short>("ClassID")
                        .HasColumnType("smallint");

                    b.Property<short>("ClsGrpID")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("StudentId")
                        .HasColumnType("bigint");

                    b.HasKey("SgsId");

                    b.ToTable("StudentGroupSubjectInfoTemp");
                });

            modelBuilder.Entity("EduPortalAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("UsersForPortal");
                });

            modelBuilder.Entity("EduPortalAPI.Models.StudentGroupSubjectDetails", b =>
                {
                    b.HasOne("EduPortalAPI.Models.StudentGroupSubjectInfo", "StudentGroupSubjectInfo")
                        .WithMany("Subjects")
                        .HasForeignKey("SgsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentGroupSubjectInfo");
                });

            modelBuilder.Entity("EduPortalAPI.Models.StudentGroupSubjectInfo", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
