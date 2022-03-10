﻿// <auto-generated />
using HR_Registeration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HR_Registeration.Migrations
{
    [DbContext(typeof(HRDatabaseContext))]
    partial class HRDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HR_Registeration.Models.AnalysisLab", b =>
                {
                    b.Property<int>("Analysis_Lab_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Analysis_Lab_Address")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Analysis_Lab_Name")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.HasKey("Analysis_Lab_ID");

                    b.ToTable("AnalysisLab", "dbo");
                });

            modelBuilder.Entity("HR_Registeration.Models.RaysLab", b =>
                {
                    b.Property<int>("Rays_Lab_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Rays_Lab_Address")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Rays_Lab_Name")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.HasKey("Rays_Lab_ID");

                    b.ToTable("RaysLab", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
