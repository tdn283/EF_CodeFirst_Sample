using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_CodeFirst_Sample.Migrations
{
    /// <inheritdoc />
    public partial class seededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Khoas",
                columns: new[] { "Id", "TenKhoa" },
                values: new object[,]
                {
                    { 1, "CNTT" },
                    { 2, "DT" },
                    { 3, "SPCN" }
                });

            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "Id", "KhoaId", "TenLop" },
                values: new object[,]
                {
                    { 1, 1, "21T1" },
                    { 2, 1, "21T2" },
                    { 3, 1, "21T3" }
                });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "Id", "HoTen", "LopId", "NgaySinh" },
                values: new object[,]
                {
                    { 1, "NTruong Dinh Nhat", 1, new DateTime(2003, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Nguyen Duy Tung", 2, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "To Ngoc Hai", 3, new DateTime(2004, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
