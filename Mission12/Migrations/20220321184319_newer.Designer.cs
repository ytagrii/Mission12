﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission12.Models;

namespace Mission12.Migrations
{
    [DbContext(typeof(SignupContext))]
    [Migration("20220321184319_newer")]
    partial class newer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("Mission12.Models.Appointment", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SignupId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TourSlot")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookingId");

                    b.HasIndex("SignupId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            Date = new DateTime(2022, 3, 21, 12, 43, 18, 930, DateTimeKind.Local).AddTicks(5795),
                            TourSlot = 1
                        });
                });

            modelBuilder.Entity("Mission12.Models.Signup", b =>
                {
                    b.Property<int>("SignupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("SignupId");

                    b.ToTable("Signups");
                });

            modelBuilder.Entity("Mission12.Models.Appointment", b =>
                {
                    b.HasOne("Mission12.Models.Signup", "Signup")
                        .WithMany()
                        .HasForeignKey("SignupId");
                });
#pragma warning restore 612, 618
        }
    }
}