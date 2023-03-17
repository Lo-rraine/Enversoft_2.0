﻿// <auto-generated />
using Enversoft.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Enversoft.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230317082357_tableSeeding")]
    partial class tableSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Enversoft.Models.Supplier", b =>
                {
                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelelphoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Code = 234,
                            Name = "Eskom Holdings Limited",
                            TelelphoneNo = "0860037566"
                        },
                        new
                        {
                            Code = 939,
                            Name = "Focus Rooms (Pty) Ltd",
                            TelelphoneNo = "0820776910"
                        },
                        new
                        {
                            Code = 34,
                            Name = "GSM Electro",
                            TelelphoneNo = "0128110069"
                        },
                        new
                        {
                            Code = 1264,
                            Name = "Jody and Herman Investments CC",
                            TelelphoneNo = "0118864227"
                        },
                        new
                        {
                            Code = 5667,
                            Name = "Johan Le Roux Ingenieurswerke",
                            TelelphoneNo = "0233423390"
                        },
                        new
                        {
                            Code = 667,
                            Name = "L. J. Ross t/a Petite Cafe'",
                            TelelphoneNo = "0117868101"
                        },
                        new
                        {
                            Code = 45,
                            Name = "L.A Auto Center  CC t/a LA Body Works",
                            TelelphoneNo = "0219488412"
                        },
                        new
                        {
                            Code = 1351,
                            Name = "LG Tow-In CC",
                            TelelphoneNo = "0828044026"
                        },
                        new
                        {
                            Code = 1352,
                            Name = "LM Greyling t/a The Electric Advertiser",
                            TelelphoneNo = "0119545972"
                        },
                        new
                        {
                            Code = 1437,
                            Name = "M.H Cloete Enterprises (Pty) Ltd  t/a  Rola Motors",
                            TelelphoneNo = "0218418300"
                        },
                        new
                        {
                            Code = 67,
                            Name = "M.M Hydraulics CC",
                            TelelphoneNo = "0114256578"
                        },
                        new
                        {
                            Code = 1980,
                            Name = "Phulo Human Capital (Pty) Ltd",
                            TelelphoneNo = "0114755934"
                        },
                        new
                        {
                            Code = 345,
                            Name = "Picaro 115 CC t/a H2O CT Services",
                            TelelphoneNo = "0216745710"
                        },
                        new
                        {
                            Code = 2279,
                            Name = "Safetygrip CC",
                            TelelphoneNo = "0117086660"
                        },
                        new
                        {
                            Code = 876,
                            Name = "Safic (Pty) Ltd",
                            TelelphoneNo = "0114064000"
                        },
                        new
                        {
                            Code = 2549,
                            Name = "The Financial Planning Institute Of Southern Africa",
                            TelelphoneNo = "0861000374"
                        },
                        new
                        {
                            Code = 935,
                            Name = "The Fitment Zone  CC",
                            TelelphoneNo = "0118234181"
                        },
                        new
                        {
                            Code = 2693,
                            Name = "Turnweld Engineering CC",
                            TelelphoneNo = "0115468790"
                        },
                        new
                        {
                            Code = 6,
                            Name = "Tutuka Motor Holdings Pty Ltd t/a Tutuka Motor Lab",
                            TelelphoneNo = "0117044324"
                        },
                        new
                        {
                            Code = 134,
                            Name = "WP Exhaust Brake & Clutch t/a In Focus Fleet Services",
                            TelelphoneNo = "0219055028"
                        },
                        new
                        {
                            Code = 3277,
                            Name = "WP Sekuriteit",
                            TelelphoneNo = "0233421732"
                        },
                        new
                        {
                            Code = 53,
                            Name = "Brietta Trading (Pty) Ltd",
                            TelelphoneNo = "0115526000"
                        },
                        new
                        {
                            Code = 392,
                            Name = "C.N. Braam t/a CNB Electrical Services",
                            TelelphoneNo = "0832835399"
                        },
                        new
                        {
                            Code = 625,
                            Name = "Creative Crew (Pty) Ltd",
                            TelelphoneNo = "0120040218"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
