using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedTime", "Duration", "ModifiedTime", "School", "Title" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 365, DateTimeKind.Local).AddTicks(4638), "Eylül 2018--Devam Ediyor", new DateTime(2022, 3, 26, 21, 31, 45, 365, DateTimeKind.Local).AddTicks(4645), "Firat Üniversitesi-yazılım Müh", "Doktroa Derecesi" });

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
                columns: new[] { "CreatedTime", "Description", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 31, 45, 366, DateTimeKind.Local).AddTicks(6744), "Haziran 2020'den beridir", new DateTime(2022, 3, 26, 21, 31, 45, 366, DateTimeKind.Local).AddTicks(6753) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 940, DateTimeKind.Local).AddTicks(1678), new DateTime(2022, 3, 26, 21, 25, 39, 940, DateTimeKind.Local).AddTicks(2103), new DateTime(2022, 3, 26, 21, 25, 39, 940, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 942, DateTimeKind.Local).AddTicks(2791), new DateTime(2022, 3, 26, 21, 25, 39, 942, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 946, DateTimeKind.Local).AddTicks(8001), new DateTime(2022, 3, 26, 21, 25, 39, 946, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 947, DateTimeKind.Local).AddTicks(8719), new DateTime(2022, 3, 26, 21, 25, 39, 947, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 949, DateTimeKind.Local).AddTicks(2243), new DateTime(2022, 3, 26, 21, 25, 39, 949, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 950, DateTimeKind.Local).AddTicks(4788), new DateTime(2022, 3, 26, 21, 25, 39, 950, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Duration", "ModifiedTime", "School", "Title" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 952, DateTimeKind.Local).AddTicks(42), "Eylül 2016--Devam Ediyor", new DateTime(2022, 3, 26, 21, 25, 39, 952, DateTimeKind.Local).AddTicks(50), "Uludağ Üniversitesi-Elektrik Elektronik Müh", "Lisans Derecesi" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 952, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 3, 26, 21, 25, 39, 952, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Description", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 953, DateTimeKind.Local).AddTicks(2107), "Haziran 2020'den beridir, arkadaşlar ve çevrwm için web sitesi yapıyorum. Birkaç tanesini yayına aldım.", new DateTime(2022, 3, 26, 21, 25, 39, 953, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 954, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 3, 26, 21, 25, 39, 954, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 954, DateTimeKind.Local).AddTicks(5422), new DateTime(2022, 3, 26, 21, 25, 39, 954, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 955, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 3, 26, 21, 25, 39, 955, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 955, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 3, 26, 21, 25, 39, 955, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 955, DateTimeKind.Local).AddTicks(4585), new DateTime(2022, 3, 26, 21, 25, 39, 955, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 956, DateTimeKind.Local).AddTicks(6573), new DateTime(2022, 3, 26, 21, 25, 39, 956, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 958, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 3, 26, 21, 25, 39, 958, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3207), new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3212), new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3217), new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3222), new DateTime(2022, 3, 26, 21, 25, 39, 959, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6742), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6757), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6763), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6767), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6772), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 961, DateTimeKind.Local).AddTicks(6260), new DateTime(2022, 3, 26, 21, 25, 39, 961, DateTimeKind.Local).AddTicks(6266) });
        }
    }
}
