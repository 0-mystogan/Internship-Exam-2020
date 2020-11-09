using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipExam2020JasirBuric.Dal.Migrations
{
    public partial class seedProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1, new DateTime(2020, 11, 9, 12, 7, 38, 990, DateTimeKind.Utc).AddTicks(7711), null, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 7, 38, 996, DateTimeKind.Utc).AddTicks(8034));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 253, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 11, 6, 6, 254, DateTimeKind.Utc).AddTicks(1855));
        }
    }
}
