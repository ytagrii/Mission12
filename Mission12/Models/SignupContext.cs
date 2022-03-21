using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class SignupContext : DbContext
    {
        public SignupContext()
        {
        }

        public SignupContext(DbContextOptions<SignupContext> options)
            : base(options)
        {
        }

        public DbSet<Signup> Signups { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
            new Appointment
            {
                BookingId = 1,
                Date = DateTime.Parse("Mar 23, 2022 08:00:00"),
                TourSlot = 0
            },
                new Appointment
                {
                    BookingId = 2,
                    Date = DateTime.Parse("Mar 23, 2022 09:00:00"),
                    TourSlot = 1
                },
                new Appointment
                {
                    BookingId = 3,
                    Date = DateTime.Parse("Mar 23, 2022 10:00:00"),
                    TourSlot = 2
                },
                new Appointment
                {
                    BookingId = 4,
                    Date = DateTime.Parse("Mar 23, 2022 11:00:00"),
                    TourSlot = 3
                },
                new Appointment
                {
                    BookingId = 5,
                    Date = DateTime.Parse("Mar 23, 2022 12:00:00"),
                    TourSlot = 4
                },
                new Appointment
                {
                    BookingId = 6,
                    Date = DateTime.Parse("Mar 23, 2022 13:00:00"),
                    TourSlot = 5
                },
                new Appointment
                {
                    BookingId = 7,
                    Date = DateTime.Parse("Mar 23, 2022 14:00:00"),
                    TourSlot = 6
                },
                new Appointment
                {
                    BookingId = 8,
                    Date = DateTime.Parse("Mar 23, 2022 15:00:00"),
                    TourSlot = 7
                },
                new Appointment
                {
                    BookingId = 9,
                    Date = DateTime.Parse("Mar 23, 2022 16:00:00"),
                    TourSlot = 8
                },
                new Appointment
                {
                    BookingId = 10,
                    Date = DateTime.Parse("Mar 23, 2022 17:00:00"),
                    TourSlot = 9
                },
                new Appointment
                {
                    BookingId = 11,
                    Date = DateTime.Parse("Mar 23, 2022 18:00:00"),
                    TourSlot = 10
                },
                new Appointment
                {
                    BookingId = 12,
                    Date = DateTime.Parse("Mar 23, 2022 19:00:00"),
                    TourSlot = 11
                },
                new Appointment
                {
                    BookingId = 13,
                    Date = DateTime.Parse("Mar 23, 2022 20:00:00"),
                    TourSlot = 12
                }
            );
        }
    }
}
