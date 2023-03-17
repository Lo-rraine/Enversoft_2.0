using Enversoft.Models;
using Microsoft.EntityFrameworkCore;

namespace Enversoft.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            Suppliers = Set<Supplier>();
        }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier()
                {
                    Code = 234,
                    Name = "Eskom Holdings Limited",
                    TelelphoneNo = "0860037566"
                },
                new Supplier()
                {
                    Code = 939,
                    Name = "Focus Rooms (Pty) Ltd",
                    TelelphoneNo = "0820776910"
                },
                new Supplier()
                {
                    Code = 34,
                    Name = "GSM Electro",
                    TelelphoneNo = "0128110069"
                },
                new Supplier()
                {
                    Code = 1264,
                    Name = "Jody and Herman Investments CC",
                    TelelphoneNo = "0118864227"
                },
                new Supplier()
                {
                    Code = 5667,
                    Name = "Johan Le Roux Ingenieurswerke",
                    TelelphoneNo = "0233423390"
                },
                new Supplier()
                {
                    Code = 667,
                    Name = "L. J. Ross t/a Petite Cafe'",
                    TelelphoneNo = "0117868101"
                },
                new Supplier()
                {
                    Code = 45,
                    Name = "L.A Auto Center  CC t/a LA Body Works",
                    TelelphoneNo = "0219488412"
                },
                new Supplier()
                {
                    Code = 1351,
                    Name = "LG Tow-In CC",
                    TelelphoneNo = "0828044026"
                },
                new Supplier()
                {
                    Code = 1352,
                    Name = "LM Greyling t/a The Electric Advertiser",
                    TelelphoneNo = "0119545972"
                },
                new Supplier()
                {
                    Code = 1437,
                    Name = "M.H Cloete Enterprises (Pty) Ltd  t/a  Rola Motors",
                    TelelphoneNo = "0218418300"
                },
                new Supplier()
                {
                    Code = 67,
                    Name = "M.M Hydraulics CC",
                    TelelphoneNo = "0114256578"
                },
                new Supplier()
                {
                    Code = 1980,
                    Name = "Phulo Human Capital (Pty) Ltd",
                    TelelphoneNo = "0114755934"
                },
                new Supplier()
                {
                    Code = 345,
                    Name = "Picaro 115 CC t/a H2O CT Services",
                    TelelphoneNo = "0216745710"
                },
                new Supplier()
                {
                    Code = 2279,
                    Name = "Safetygrip CC",
                    TelelphoneNo = "0117086660"
                },
                new Supplier()
                {
                    Code = 876,
                    Name = "Safic (Pty) Ltd",
                    TelelphoneNo = "0114064000"
                },
                new Supplier()
                {
                    Code = 2549,
                    Name = "The Financial Planning Institute Of Southern Africa",
                    TelelphoneNo = "0861000374"
                },

                new Supplier()
                {
                    Code = 935,
                    Name = "The Fitment Zone  CC",
                    TelelphoneNo = "0118234181"
                },
                new Supplier()
                {
                    Code = 2693,
                    Name = "Turnweld Engineering CC",
                    TelelphoneNo = "0115468790"
                },
                new Supplier()
                {
                    Code = 6,
                    Name = "Tutuka Motor Holdings Pty Ltd t/a Tutuka Motor Lab",
                    TelelphoneNo = "0117044324"
                },
                new Supplier()
                {
                    Code = 134,
                    Name = "WP Exhaust Brake & Clutch t/a In Focus Fleet Services",
                    TelelphoneNo = "0219055028"
                },
                new Supplier()
                {
                    Code = 3277,
                    Name = "WP Sekuriteit",
                    TelelphoneNo = "0233421732"
                },
                new Supplier()
                {
                    Code = 53,
                    Name = "Brietta Trading (Pty) Ltd",
                    TelelphoneNo = "0115526000"
                },
                new Supplier()
                {
                    Code = 392,
                    Name = "C.N. Braam t/a CNB Electrical Services",
                    TelelphoneNo = "0832835399"
                },

                new Supplier()
                {
                    Code = 625,
                    Name = "Creative Crew (Pty) Ltd",
                    TelelphoneNo = "0120040218"
                });

        }
    }
}

