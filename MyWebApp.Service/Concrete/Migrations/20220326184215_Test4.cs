using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class Test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 317, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 3, 26, 21, 42, 14, 317, DateTimeKind.Local).AddTicks(5123), new DateTime(2022, 3, 26, 21, 42, 14, 317, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 319, DateTimeKind.Local).AddTicks(7338), new DateTime(2022, 3, 26, 21, 42, 14, 319, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 324, DateTimeKind.Local).AddTicks(5991), new DateTime(2022, 3, 26, 21, 42, 14, 324, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 325, DateTimeKind.Local).AddTicks(7582), new DateTime(2022, 3, 26, 21, 42, 14, 325, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 327, DateTimeKind.Local).AddTicks(2143), new DateTime(2022, 3, 26, 21, 42, 14, 327, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 328, DateTimeKind.Local).AddTicks(6392), new DateTime(2022, 3, 26, 21, 42, 14, 328, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 330, DateTimeKind.Local).AddTicks(1979), new DateTime(2022, 3, 26, 21, 42, 14, 330, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 330, DateTimeKind.Local).AddTicks(1997), new DateTime(2022, 3, 26, 21, 42, 14, 330, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 331, DateTimeKind.Local).AddTicks(4755), new DateTime(2022, 3, 26, 21, 42, 14, 331, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 332, DateTimeKind.Local).AddTicks(7186), new DateTime(2022, 3, 26, 21, 42, 14, 332, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 332, DateTimeKind.Local).AddTicks(7204), new DateTime(2022, 3, 26, 21, 42, 14, 332, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 333, DateTimeKind.Local).AddTicks(7319), new DateTime(2022, 3, 26, 21, 42, 14, 333, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 333, DateTimeKind.Local).AddTicks(7336), new DateTime(2022, 3, 26, 21, 42, 14, 333, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 333, DateTimeKind.Local).AddTicks(7341), new DateTime(2022, 3, 26, 21, 42, 14, 333, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 335, DateTimeKind.Local).AddTicks(435), new DateTime(2022, 3, 26, 21, 42, 14, 335, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 336, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 3, 26, 21, 42, 14, 336, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6010), new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6027), new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6032), new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6037), new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6041), new DateTime(2022, 3, 26, 21, 42, 14, 337, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8211), new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8227), new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8232), new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8237), new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8242), new DateTime(2022, 3, 26, 21, 42, 14, 338, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 42, 14, 339, DateTimeKind.Local).AddTicks(7744), new DateTime(2022, 3, 26, 21, 42, 14, 339, DateTimeKind.Local).AddTicks(7752) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 352, DateTimeKind.Local).AddTicks(6975), new DateTime(2022, 3, 26, 21, 31, 45, 352, DateTimeKind.Local).AddTicks(7394), new DateTime(2022, 3, 26, 21, 31, 45, 352, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 354, DateTimeKind.Local).AddTicks(7757), new DateTime(2022, 3, 26, 21, 31, 45, 354, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 360, DateTimeKind.Local).AddTicks(52), new DateTime(2022, 3, 26, 21, 31, 45, 360, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 361, DateTimeKind.Local).AddTicks(3374), new DateTime(2022, 3, 26, 21, 31, 45, 361, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 362, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 3, 26, 21, 31, 45, 362, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 364, DateTimeKind.Local).AddTicks(586), new DateTime(2022, 3, 26, 21, 31, 45, 364, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 365, DateTimeKind.Local).AddTicks(4638), new DateTime(2022, 3, 26, 21, 31, 45, 365, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 365, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 3, 26, 21, 31, 45, 365, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 366, DateTimeKind.Local).AddTicks(6744), new DateTime(2022, 3, 26, 21, 31, 45, 366, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 367, DateTimeKind.Local).AddTicks(8059), new DateTime(2022, 3, 26, 21, 31, 45, 367, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 367, DateTimeKind.Local).AddTicks(8076), new DateTime(2022, 3, 26, 21, 31, 45, 367, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 368, DateTimeKind.Local).AddTicks(7698), new DateTime(2022, 3, 26, 21, 31, 45, 368, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 368, DateTimeKind.Local).AddTicks(7714), new DateTime(2022, 3, 26, 21, 31, 45, 368, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 368, DateTimeKind.Local).AddTicks(7719), new DateTime(2022, 3, 26, 21, 31, 45, 368, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 369, DateTimeKind.Local).AddTicks(9975), new DateTime(2022, 3, 26, 21, 31, 45, 369, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 371, DateTimeKind.Local).AddTicks(2550), new DateTime(2022, 3, 26, 21, 31, 45, 371, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3257), new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3262), new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3266), new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3271), new DateTime(2022, 3, 26, 21, 31, 45, 372, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4767), new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4810), new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4815), new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4819), new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4824), new DateTime(2022, 3, 26, 21, 31, 45, 373, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 374, DateTimeKind.Local).AddTicks(5386), new DateTime(2022, 3, 26, 21, 31, 45, 374, DateTimeKind.Local).AddTicks(5393) });
        }
    }
}
