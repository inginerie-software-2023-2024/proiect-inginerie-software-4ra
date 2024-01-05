﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Traveling_Platform.Data;

#nullable disable

namespace Traveling_Platform.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230421225706_Mi")]
    partial class Mi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationUserHotel", b =>
                {
                    b.Property<int>("Hotelsid_hotel")
                        .HasColumnType("int");

                    b.Property<string>("ReceptionistsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Hotelsid_hotel", "ReceptionistsId");

                    b.HasIndex("ReceptionistsId");

                    b.ToTable("ApplicationUserHotel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Traveling_Platform.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsManager")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsReceptionist")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("id_hotel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Traveling_Platform.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Checkin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Checkout")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Hotelid_hotel")
                        .HasColumnType("int");

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<int>("IdRoom")
                        .HasColumnType("int");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("Hotelid_hotel");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Traveling_Platform.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Countrytag")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("stateTag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Countrytag");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Country", b =>
                {
                    b.Property<string>("tag")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("commonName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("officialName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("tag");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Hotel", b =>
                {
                    b.Property<int>("id_hotel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_hotel"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_city")
                        .HasColumnType("int");

                    b.Property<string>("id_manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_hotel");

                    b.HasIndex("CityId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Hotelid_hotel")
                        .HasColumnType("int");

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Hotelid_hotel");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("Hotelid_hotel")
                        .HasColumnType("int");

                    b.Property<string>("IdClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdSender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_hotel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("Hotelid_hotel");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Hotelid_hotel")
                        .HasColumnType("int");

                    b.Property<string>("IdClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("Hotelid_hotel");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BunkBedsNumber")
                        .HasColumnType("int");

                    b.Property<int>("DoubleBedsNumber")
                        .HasColumnType("int");

                    b.Property<bool>("HasBalcony")
                        .HasColumnType("bit");

                    b.Property<bool>("HasBathroom")
                        .HasColumnType("bit");

                    b.Property<bool>("HasCookingEquipment")
                        .HasColumnType("bit");

                    b.Property<int?>("Hotelid_hotel")
                        .HasColumnType("int");

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricePerNight")
                        .HasColumnType("int");

                    b.Property<int>("SingleBedsNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Hotelid_hotel");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ApplicationUserHotel", b =>
                {
                    b.HasOne("Traveling_Platform.Models.Hotel", null)
                        .WithMany()
                        .HasForeignKey("Hotelsid_hotel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveling_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("ReceptionistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Traveling_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Traveling_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveling_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Traveling_Platform.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Traveling_Platform.Models.Booking", b =>
                {
                    b.HasOne("Traveling_Platform.Models.ApplicationUser", null)
                        .WithMany("Bookings")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Traveling_Platform.Models.Hotel", null)
                        .WithMany("Bookings")
                        .HasForeignKey("Hotelid_hotel");
                });

            modelBuilder.Entity("Traveling_Platform.Models.City", b =>
                {
                    b.HasOne("Traveling_Platform.Models.Country", null)
                        .WithMany("Cities")
                        .HasForeignKey("Countrytag");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Hotel", b =>
                {
                    b.HasOne("Traveling_Platform.Models.City", null)
                        .WithMany("Hotels")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Image", b =>
                {
                    b.HasOne("Traveling_Platform.Models.Hotel", "Hotel")
                        .WithMany("Images")
                        .HasForeignKey("Hotelid_hotel");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Message", b =>
                {
                    b.HasOne("Traveling_Platform.Models.ApplicationUser", null)
                        .WithMany("Messages")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Traveling_Platform.Models.Hotel", null)
                        .WithMany("Messages")
                        .HasForeignKey("Hotelid_hotel");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Review", b =>
                {
                    b.HasOne("Traveling_Platform.Models.ApplicationUser", null)
                        .WithMany("Reviews")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Traveling_Platform.Models.Hotel", null)
                        .WithMany("Reviews")
                        .HasForeignKey("Hotelid_hotel");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Room", b =>
                {
                    b.HasOne("Traveling_Platform.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("Hotelid_hotel");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Traveling_Platform.Models.ApplicationUser", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Messages");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Traveling_Platform.Models.City", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Traveling_Platform.Models.Hotel", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Images");

                    b.Navigation("Messages");

                    b.Navigation("Reviews");

                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
