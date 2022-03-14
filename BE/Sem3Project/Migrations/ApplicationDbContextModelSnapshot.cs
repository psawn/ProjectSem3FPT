﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sem3Project.Data;

namespace Sem3Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Sem3Project.Models.HomeInsurance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HomeCharacteristic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HomePolicyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("LandOwnershipId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReceiptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HomePolicyId");

                    b.HasIndex("ReceiptId");

                    b.HasIndex("UserId");

                    b.ToTable("HomeInsurances");
                });

            modelBuilder.Entity("Sem3Project.Models.HomePolicy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountPaid")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsReleased")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomePolicies");
                });

            modelBuilder.Entity("Sem3Project.Models.Hospital", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("Sem3Project.Models.LifeInsurance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirtsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LifePolicyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReceiptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Relationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LifePolicyId");

                    b.HasIndex("ReceiptId");

                    b.HasIndex("UserId");

                    b.ToTable("LifeInsurances");
                });

            modelBuilder.Entity("Sem3Project.Models.LifePolicy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountPaid")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsReleased")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonClaim")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LifePolicies");
                });

            modelBuilder.Entity("Sem3Project.Models.MedicalInsurance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirtsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HospitalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MedicalPolicyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReceiptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Relationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.HasIndex("MedicalPolicyId");

                    b.HasIndex("ReceiptId");

                    b.HasIndex("UserId");

                    b.ToTable("MedicalInsurances");
                });

            modelBuilder.Entity("Sem3Project.Models.MedicalPolicy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountPaid")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsReleased")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalPolicies");
                });

            modelBuilder.Entity("Sem3Project.Models.Receipt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InsuranceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InsuranceType")
                        .HasColumnType("int");

                    b.Property<int>("MinimumPayment")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerifiedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("Sem3Project.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirtsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Sem3Project.Models.VehicleInsurance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChassisNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EngineNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReceiptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("VehiclePolicyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReceiptId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehiclePolicyId");

                    b.ToTable("VehicleInsurances");
                });

            modelBuilder.Entity("Sem3Project.Models.VehiclePolicy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountPaid")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsReleased")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonClaim")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleClaim")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VehiclePolicies");
                });

            modelBuilder.Entity("Sem3Project.Models.HomeInsurance", b =>
                {
                    b.HasOne("Sem3Project.Models.HomePolicy", "HomePolicy")
                        .WithMany()
                        .HasForeignKey("HomePolicyId");

                    b.HasOne("Sem3Project.Models.Receipt", "Receipt")
                        .WithMany()
                        .HasForeignKey("ReceiptId");

                    b.HasOne("Sem3Project.Models.User", "User")
                        .WithMany("HomeInsurances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HomePolicy");

                    b.Navigation("Receipt");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sem3Project.Models.LifeInsurance", b =>
                {
                    b.HasOne("Sem3Project.Models.LifePolicy", "LifePolicy")
                        .WithMany()
                        .HasForeignKey("LifePolicyId");

                    b.HasOne("Sem3Project.Models.Receipt", "Receipt")
                        .WithMany()
                        .HasForeignKey("ReceiptId");

                    b.HasOne("Sem3Project.Models.User", "User")
                        .WithMany("LifeInsurances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LifePolicy");

                    b.Navigation("Receipt");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sem3Project.Models.MedicalInsurance", b =>
                {
                    b.HasOne("Sem3Project.Models.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalId");

                    b.HasOne("Sem3Project.Models.MedicalPolicy", "MedicalPolicy")
                        .WithMany()
                        .HasForeignKey("MedicalPolicyId");

                    b.HasOne("Sem3Project.Models.Receipt", "Receipt")
                        .WithMany()
                        .HasForeignKey("ReceiptId");

                    b.HasOne("Sem3Project.Models.User", "User")
                        .WithMany("MedicalInsurances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");

                    b.Navigation("MedicalPolicy");

                    b.Navigation("Receipt");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sem3Project.Models.VehicleInsurance", b =>
                {
                    b.HasOne("Sem3Project.Models.Receipt", "Receipt")
                        .WithMany()
                        .HasForeignKey("ReceiptId");

                    b.HasOne("Sem3Project.Models.User", "User")
                        .WithMany("VehicleInsurances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sem3Project.Models.VehiclePolicy", "VehiclePolicy")
                        .WithMany()
                        .HasForeignKey("VehiclePolicyId");

                    b.Navigation("Receipt");

                    b.Navigation("User");

                    b.Navigation("VehiclePolicy");
                });

            modelBuilder.Entity("Sem3Project.Models.User", b =>
                {
                    b.Navigation("HomeInsurances");

                    b.Navigation("LifeInsurances");

                    b.Navigation("MedicalInsurances");

                    b.Navigation("VehicleInsurances");
                });
#pragma warning restore 612, 618
        }
    }
}
