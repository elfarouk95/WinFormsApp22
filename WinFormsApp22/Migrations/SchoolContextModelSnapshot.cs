﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp22.db;

namespace WinFormsApp22.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("WinFormsApp22.db.RegForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegStudentEmail")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RegStudentEmail");

                    b.ToTable("regForms");
                });

            modelBuilder.Entity("WinFormsApp22.db.Student", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Gpa")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("studenst");
                });

            modelBuilder.Entity("WinFormsApp22.db.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RegFormId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RegFormId");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("WinFormsApp22.db.RegForm", b =>
                {
                    b.HasOne("WinFormsApp22.db.Student", "RegStudent")
                        .WithMany()
                        .HasForeignKey("RegStudentEmail");

                    b.Navigation("RegStudent");
                });

            modelBuilder.Entity("WinFormsApp22.db.Subject", b =>
                {
                    b.HasOne("WinFormsApp22.db.RegForm", null)
                        .WithMany("RegSubjects")
                        .HasForeignKey("RegFormId");
                });

            modelBuilder.Entity("WinFormsApp22.db.RegForm", b =>
                {
                    b.Navigation("RegSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
