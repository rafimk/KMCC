﻿// <auto-generated />
using System;
using MMS.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MMS.Infrastructure.EF.Migrations
{
    [DbContext(typeof(MMSDbContext))]
    [Migration("20220612055909_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("MMS")
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MMS.Domain.Entities.Memberships.Membership", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("AddressInIndia")
                        .HasColumnType("text");

                    b.Property<string>("AlternativeContactNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<Guid>("AreaId")
                        .HasColumnType("uuid");

                    b.Property<int>("BloodGroup")
                        .HasColumnType("integer");

                    b.Property<double>("CollectedAmount")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTimeOffset>("EmiratesIdExpiry")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("EmiratesIdFrontPage")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("EmiratesIdLastPage")
                        .HasColumnType("uuid");

                    b.Property<string>("EmiratesIdNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("HouseName")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsKMCCWelfareScheme")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMemberOfAnyIndianRegisteredOrganization")
                        .HasColumnType("boolean");

                    b.Property<Guid>("MandalamId")
                        .HasColumnType("uuid");

                    b.Property<string>("MembershipId")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTimeOffset>("PassportExpiry")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("PassportFrontPage")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PassportLastPage")
                        .HasColumnType("uuid");

                    b.Property<string>("PassportNumber")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<Guid?>("Photo")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProfessionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("QualificationId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("MandalamId");

                    b.HasIndex("ProfessionId");

                    b.HasIndex("QualificationId");

                    b.ToTable("Memberships", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Memberships.MembershipPeriod", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("RegistrationUntil")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("MembershipPeriods", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Memberships.Professions.Profession", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Professions", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Memberships.Qualifications.Qualification", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Qualifications", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Nationalities.Area", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Prefix")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<Guid>("StateId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Areas", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Nationalities.District", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Districts", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Nationalities.Mandalam", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DistrictId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Mandalams", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Nationalities.Panchayat", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("MandalamId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MandalamId");

                    b.ToTable("Panchayats", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Nationalities.State", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("States", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("AlternativeContactNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", "MMS");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Memberships.Membership", b =>
                {
                    b.HasOne("MMS.Domain.Entities.Nationalities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMS.Domain.Entities.Nationalities.Mandalam", "Mandalam")
                        .WithMany()
                        .HasForeignKey("MandalamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMS.Domain.Entities.Memberships.Professions.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMS.Domain.Entities.Memberships.Qualifications.Qualification", "Qualification")
                        .WithMany()
                        .HasForeignKey("QualificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Mandalam");

                    b.Navigation("Profession");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Nationalities.Area", b =>
                {
                    b.HasOne("MMS.Domain.Entities.Nationalities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Nationalities.Mandalam", b =>
                {
                    b.HasOne("MMS.Domain.Entities.Nationalities.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("MMS.Domain.Entities.Nationalities.Panchayat", b =>
                {
                    b.HasOne("MMS.Domain.Entities.Nationalities.Mandalam", "Mandalam")
                        .WithMany()
                        .HasForeignKey("MandalamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mandalam");
                });
#pragma warning restore 612, 618
        }
    }
}
