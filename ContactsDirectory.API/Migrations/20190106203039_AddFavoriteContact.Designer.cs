﻿// <auto-generated />
using System;
using ContactsDirectory.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactsDirectory.API.Migrations
{
    [DbContext(typeof(ContactsDirectoryContext))]
    [Migration("20190106203039_AddFavoriteContact")]
    partial class AddFavoriteContact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("ContactsDirectory.Core.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar")
                        .HasMaxLength(200);

                    b.Property<string>("Department")
                        .HasMaxLength(100);

                    b.Property<bool>("Favorite");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ContactsDirectory.Core.Date", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ContactId");

                    b.Property<DateTime>("DateValue");

                    b.Property<string>("Label")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Dates");
                });

            modelBuilder.Entity("ContactsDirectory.Core.Slot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ContactId");

                    b.Property<string>("CustomSlotType")
                        .HasMaxLength(100);

                    b.Property<int>("Type")
                        .HasMaxLength(100);

                    b.Property<string>("Value")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("ContactsDirectory.Core.Date", b =>
                {
                    b.HasOne("ContactsDirectory.Core.Contact", "Contact")
                        .WithMany("Dates")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContactsDirectory.Core.Slot", b =>
                {
                    b.HasOne("ContactsDirectory.Core.Contact", "Contact")
                        .WithMany("Slots")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
