﻿// <auto-generated />
using FixPeriodPain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FixPeriodPain.Migrations
{
    [DbContext(typeof(FixPeriodPainContext))]
    partial class FixPeriodPainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("FixPeriodPain.Models.EmailSignup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("emailAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("EmailSignup");
                });
#pragma warning restore 612, 618
        }
    }
}
