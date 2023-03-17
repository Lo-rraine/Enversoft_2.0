using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Enversoft.Migrations
{
    public partial class tableSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelelphoneNo",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Code", "Name", "TelelphoneNo" },
                values: new object[,]
                {
                    { 6, "Tutuka Motor Holdings Pty Ltd t/a Tutuka Motor Lab", "0117044324" },
                    { 34, "GSM Electro", "0128110069" },
                    { 45, "L.A Auto Center  CC t/a LA Body Works", "0219488412" },
                    { 53, "Brietta Trading (Pty) Ltd", "0115526000" },
                    { 67, "M.M Hydraulics CC", "0114256578" },
                    { 134, "WP Exhaust Brake & Clutch t/a In Focus Fleet Services", "0219055028" },
                    { 234, "Eskom Holdings Limited", "0860037566" },
                    { 345, "Picaro 115 CC t/a H2O CT Services", "0216745710" },
                    { 392, "C.N. Braam t/a CNB Electrical Services", "0832835399" },
                    { 625, "Creative Crew (Pty) Ltd", "0120040218" },
                    { 667, "L. J. Ross t/a Petite Cafe'", "0117868101" },
                    { 876, "Safic (Pty) Ltd", "0114064000" },
                    { 935, "The Fitment Zone  CC", "0118234181" },
                    { 939, "Focus Rooms (Pty) Ltd", "0820776910" },
                    { 1264, "Jody and Herman Investments CC", "0118864227" },
                    { 1351, "LG Tow-In CC", "0828044026" },
                    { 1352, "LM Greyling t/a The Electric Advertiser", "0119545972" },
                    { 1437, "M.H Cloete Enterprises (Pty) Ltd  t/a  Rola Motors", "0218418300" },
                    { 1980, "Phulo Human Capital (Pty) Ltd", "0114755934" },
                    { 2279, "Safetygrip CC", "0117086660" },
                    { 2549, "The Financial Planning Institute Of Southern Africa", "0861000374" },
                    { 2693, "Turnweld Engineering CC", "0115468790" },
                    { 3277, "WP Sekuriteit", "0233421732" },
                    { 5667, "Johan Le Roux Ingenieurswerke", "0233423390" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 2279);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 2693);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 3277);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: 5667);

            migrationBuilder.AlterColumn<string>(
                name: "TelelphoneNo",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
