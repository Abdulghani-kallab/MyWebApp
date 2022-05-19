using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class passwordChang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 890, DateTimeKind.Local).AddTicks(8879), new DateTime(2022, 3, 20, 1, 12, 38, 890, DateTimeKind.Local).AddTicks(9328), new DateTime(2022, 3, 20, 1, 12, 38, 890, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 892, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 3, 20, 1, 12, 38, 892, DateTimeKind.Local).AddTicks(9936), "c863fb7dd9e5a18b8f142db629fa563a" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 897, DateTimeKind.Local).AddTicks(5438), new DateTime(2022, 3, 20, 1, 12, 38, 897, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 898, DateTimeKind.Local).AddTicks(9101), new DateTime(2022, 3, 20, 1, 12, 38, 898, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 900, DateTimeKind.Local).AddTicks(7273), new DateTime(2022, 3, 20, 1, 12, 38, 900, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 902, DateTimeKind.Local).AddTicks(2579), new DateTime(2022, 3, 20, 1, 12, 38, 902, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 903, DateTimeKind.Local).AddTicks(7759), new DateTime(2022, 3, 20, 1, 12, 38, 903, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 903, DateTimeKind.Local).AddTicks(7778), new DateTime(2022, 3, 20, 1, 12, 38, 903, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 904, DateTimeKind.Local).AddTicks(9406), new DateTime(2022, 3, 20, 1, 12, 38, 904, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 906, DateTimeKind.Local).AddTicks(4057), new DateTime(2022, 3, 20, 1, 12, 38, 906, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 906, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 3, 20, 1, 12, 38, 906, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 907, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 3, 20, 1, 12, 38, 907, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 907, DateTimeKind.Local).AddTicks(4086), new DateTime(2022, 3, 20, 1, 12, 38, 907, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 907, DateTimeKind.Local).AddTicks(4091), new DateTime(2022, 3, 20, 1, 12, 38, 907, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 909, DateTimeKind.Local).AddTicks(1575), new DateTime(2022, 3, 20, 1, 12, 38, 909, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 910, DateTimeKind.Local).AddTicks(7018), new DateTime(2022, 3, 20, 1, 12, 38, 910, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(380), new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(398), new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(403), new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(408), new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(413), new DateTime(2022, 3, 20, 1, 12, 38, 912, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2586), new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2603), new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2608), new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2612), new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2617), new DateTime(2022, 3, 20, 1, 12, 38, 913, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 12, 38, 914, DateTimeKind.Local).AddTicks(2242), new DateTime(2022, 3, 20, 1, 12, 38, 914, DateTimeKind.Local).AddTicks(2249) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 567, DateTimeKind.Local).AddTicks(2447), new DateTime(2022, 3, 20, 1, 11, 11, 567, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 3, 20, 1, 11, 11, 567, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 570, DateTimeKind.Local).AddTicks(7894), new DateTime(2022, 3, 20, 1, 11, 11, 570, DateTimeKind.Local).AddTicks(7899), "202cb962ac59075b964b07152d234b70" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 575, DateTimeKind.Local).AddTicks(5416), new DateTime(2022, 3, 20, 1, 11, 11, 575, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 576, DateTimeKind.Local).AddTicks(6152), new DateTime(2022, 3, 20, 1, 11, 11, 576, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 577, DateTimeKind.Local).AddTicks(9979), new DateTime(2022, 3, 20, 1, 11, 11, 577, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 579, DateTimeKind.Local).AddTicks(2772), new DateTime(2022, 3, 20, 1, 11, 11, 579, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 580, DateTimeKind.Local).AddTicks(9393), new DateTime(2022, 3, 20, 1, 11, 11, 580, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 580, DateTimeKind.Local).AddTicks(9413), new DateTime(2022, 3, 20, 1, 11, 11, 580, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 582, DateTimeKind.Local).AddTicks(3593), new DateTime(2022, 3, 20, 1, 11, 11, 582, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 583, DateTimeKind.Local).AddTicks(7130), new DateTime(2022, 3, 20, 1, 11, 11, 583, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 583, DateTimeKind.Local).AddTicks(7182), new DateTime(2022, 3, 20, 1, 11, 11, 583, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 584, DateTimeKind.Local).AddTicks(7594), new DateTime(2022, 3, 20, 1, 11, 11, 584, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 584, DateTimeKind.Local).AddTicks(7610), new DateTime(2022, 3, 20, 1, 11, 11, 584, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 584, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 3, 20, 1, 11, 11, 584, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 586, DateTimeKind.Local).AddTicks(977), new DateTime(2022, 3, 20, 1, 11, 11, 586, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 587, DateTimeKind.Local).AddTicks(4925), new DateTime(2022, 3, 20, 1, 11, 11, 587, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6801), new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6817), new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6822), new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6827), new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6831), new DateTime(2022, 3, 20, 1, 11, 11, 588, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2373), new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2390), new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2396), new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2401), new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2405), new DateTime(2022, 3, 20, 1, 11, 11, 590, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 11, 11, 591, DateTimeKind.Local).AddTicks(2289), new DateTime(2022, 3, 20, 1, 11, 11, 591, DateTimeKind.Local).AddTicks(2295) });
        }
    }
}
