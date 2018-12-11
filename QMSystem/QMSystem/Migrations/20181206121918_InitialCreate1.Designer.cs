﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QMSystem.Models;

namespace QMSystem.Migrations
{
    [DbContext(typeof(DocumentContext))]
    [Migration("20181206121918_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QMSystem.Models.Documents", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anmerkungen");

                    b.Property<string>("Betreff");

                    b.Property<string>("DocumentName");

                    b.Property<string>("DocumentPath");

                    b.Property<int>("Freigabe");

                    b.Property<DateTime>("RequestDate");

                    b.Property<string>("UserName");

                    b.HasKey("DocumentId");

                    b.ToTable("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}