using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MountainMobileMechanic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MountainMobileMechanic.Data.Configuration
{
    internal class AppointmentEntityTypeConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("Appointments");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName)
                .HasColumnType("Text")
                .HasColumnName("FirstName")
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasColumnType("Text")
                .HasColumnName("LastName")
                .HasMaxLength(35)
                .IsRequired();
        }
    }
}
