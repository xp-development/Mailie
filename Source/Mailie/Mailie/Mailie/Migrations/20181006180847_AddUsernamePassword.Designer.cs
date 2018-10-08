﻿// <auto-generated />
using System;
using Mailie.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mailie.Migrations
{
    [DbContext(typeof(MailieDbContext))]
    [Migration("20181006180847_AddUsernamePassword")]
    partial class AddUsernamePassword
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Mailie.DataAccessLayer.MailAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<string>("Host");

                    b.Property<DateTime>("LastModifiedDateTime");

                    b.Property<string>("Password");

                    b.Property<int>("Port");

                    b.Property<int>("SecureSocketOptions");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("MailAccounts");
                });

            modelBuilder.Entity("Mailie.DataAccessLayer.MailAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<DateTime>("LastModifiedDateTime");

                    b.Property<int>("MailContactId");

                    b.HasKey("Id");

                    b.HasIndex("MailContactId");

                    b.ToTable("MailAddress");
                });

            modelBuilder.Entity("Mailie.DataAccessLayer.MailContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<DateTime>("LastModifiedDateTime");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MailContact");
                });

            modelBuilder.Entity("Mailie.DataAccessLayer.MailAddress", b =>
                {
                    b.HasOne("Mailie.DataAccessLayer.MailContact", "MailContact")
                        .WithMany("MailAddresses")
                        .HasForeignKey("MailContactId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}