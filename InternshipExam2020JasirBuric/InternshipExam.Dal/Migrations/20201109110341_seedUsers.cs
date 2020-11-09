using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipExam2020JasirBuric.Dal.Migrations
{
    public partial class seedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CreatedAt", "CreatedBy", "Email", "Name", "ProfileId" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2020, 11, 9, 11, 3, 41, 224, DateTimeKind.Utc).AddTicks(7121), null, "gwannop0@hud.gov", "Garvin Wannop", 0 },
                    { 2, 24, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2213), null, "cvines1@xinhuanet.com", "Cherin Vines", 0 },
                    { 3, 26, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2283), null, "mivashnikov2@wikimedia.org", "Myer Ivashnikov", 0 },
                    { 4, 29, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2287), null, "vmcclure3@usgs.gov", "Vern McClure", 0 },
                    { 5, 40, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2290), null, "sferenczy4@hugedomains.com", "Sheridan Ferenczy", 0 },
                    { 6, 36, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2298), null, "gwannop0@hud.gov", "Garvin Wannop", 0 },
                    { 7, 27, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2300), null, "xdewdeny5@china.com.cn", "Xenos Dewdeny", 0 },
                    { 8, 20, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2303), null, "lbloxsum6@sina.com.cn", "Leela Bloxsum", 0 },
                    { 9, 21, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2305), null, "rnoteyoung7@thetimes.co.uk", "Rocky Noteyoung", 0 },
                    { 10, 20, new DateTime(2020, 11, 9, 11, 3, 41, 225, DateTimeKind.Utc).AddTicks(2309), null, "gwannop0@hud.gov", "Garvin Wannop", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
