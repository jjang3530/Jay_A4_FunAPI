﻿// <auto-generated />
using System;
using Jay_A4_FunAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jay_A4_FunAPI.Migrations
{
    [DbContext(typeof(FunContext))]
    partial class FunContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Jay_A4_FunAPI.Models.FunModel", b =>
                {
                    b.Property<int>("FunId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GifImageLink");

                    b.Property<string>("Joke");

                    b.Property<DateTime>("SaveDate");

                    b.HasKey("FunId");

                    b.ToTable("FunModel");
                });
#pragma warning restore 612, 618
        }
    }
}
