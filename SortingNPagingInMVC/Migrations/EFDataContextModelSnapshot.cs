﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SortingNPagingInMVC.Data;

namespace SortingNPagingInMVC.Migrations
{
    [DbContext(typeof(EFDataContext))]
    partial class EFDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SortingNPagingInMVC.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("NVarchar(20)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department", "dbo");
                });

            modelBuilder.Entity("SortingNPagingInMVC.Models.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DesignationCode")
                        .IsRequired()
                        .HasColumnType("NVarchar(20)");

                    b.Property<string>("DesignationName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("DesignationId");

                    b.ToTable("Designation", "dbo");
                });

            modelBuilder.Entity("SortingNPagingInMVC.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("NVarchar(100)");

                    b.Property<string>("City")
                        .HasColumnType("NVarchar(100)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DateTime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasColumnType("NVarchar(20)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("NVarchar(100)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("DateTime2");

                    b.Property<decimal>("Salary")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<string>("State")
                        .HasColumnType("NVarchar(100)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("NVarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DesignationId");

                    b.ToTable("Employee", "dbo");
                });

            modelBuilder.Entity("SortingNPagingInMVC.Models.Employee", b =>
                {
                    b.HasOne("SortingNPagingInMVC.Models.Department", "DepartmentInfo")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SortingNPagingInMVC.Models.Designation", "DesignationInfo")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentInfo");

                    b.Navigation("DesignationInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
