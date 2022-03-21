﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission12.Models;

namespace Mission12.Migrations
{
    [DbContext(typeof(SignupContext))]
    partial class SignupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            Date = new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 0
                        },
                        new
                        {
                            BookingId = 2,
                            Date = new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 1
                        },
                        new
                        {
                            BookingId = 3,
                            Date = new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 2
                        },
                        new
                        {
                            BookingId = 4,
                            Date = new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 3
                        },
                        new
                        {
                            BookingId = 5,
                            Date = new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 4
                        },
                        new
                        {
                            BookingId = 6,
                            Date = new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 5
                        },
                        new
                        {
                            BookingId = 7,
                            Date = new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 6
                        },
                        new
                        {
                            BookingId = 8,
                            Date = new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 7
                        },
                        new
                        {
                            BookingId = 9,
                            Date = new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 8
                        },
                        new
                        {
                            BookingId = 10,
                            Date = new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 9
                        },
                        new
                        {
                            BookingId = 11,
                            Date = new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 10
                        },
                        new
                        {
                            BookingId = 12,
                            Date = new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 11
                        },
                        new
                        {
                            BookingId = 13,
                            Date = new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TourSlot = 12
                        });
                });

            modelBuilder.Entity("Mission12.Models.Signup", b =>
                {
                    b.Property<int>("SignupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookingId")
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

                    b.HasIndex("BookingId");

                    b.ToTable("Signups");
                });

            modelBuilder.Entity("Mission12.Models.Signup", b =>
                {
                    b.HasOne("Mission12.Models.Appointment", "appointment")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
