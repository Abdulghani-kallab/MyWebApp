using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class passwordChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(1998, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 26, 17, 1, 27, 284, DateTimeKind.Local).AddTicks(2516), new DateTime(2020, 12, 26, 17, 1, 27, 284, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "PasswordHash" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 288, DateTimeKind.Local).AddTicks(5827), new DateTime(2020, 12, 26, 17, 1, 27, 288, DateTimeKind.Local).AddTicks(5841), "6449f8c4593cfb33c2404abdbc0c51e8" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 298, DateTimeKind.Local).AddTicks(2380), new DateTime(2020, 12, 26, 17, 1, 27, 298, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 300, DateTimeKind.Local).AddTicks(3462), new DateTime(2020, 12, 26, 17, 1, 27, 300, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 303, DateTimeKind.Local).AddTicks(6866), new DateTime(2020, 12, 26, 17, 1, 27, 303, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 305, DateTimeKind.Local).AddTicks(9704), new DateTime(2020, 12, 26, 17, 1, 27, 305, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 308, DateTimeKind.Local).AddTicks(5384), new DateTime(2020, 12, 26, 17, 1, 27, 308, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 308, DateTimeKind.Local).AddTicks(5479), new DateTime(2020, 12, 26, 17, 1, 27, 308, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 310, DateTimeKind.Local).AddTicks(8536), new DateTime(2020, 12, 26, 17, 1, 27, 310, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 313, DateTimeKind.Local).AddTicks(6150), new DateTime(2020, 12, 26, 17, 1, 27, 313, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 313, DateTimeKind.Local).AddTicks(6209), new DateTime(2020, 12, 26, 17, 1, 27, 313, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4357), new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4390), new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4396), new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 318, DateTimeKind.Local).AddTicks(1224), new DateTime(2020, 12, 26, 17, 1, 27, 318, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 320, DateTimeKind.Local).AddTicks(5718), new DateTime(2020, 12, 26, 17, 1, 27, 320, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(6974), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7041), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7048), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7054), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7059), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8225), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8268), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8274), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8279), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8285), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 326, DateTimeKind.Local).AddTicks(5109), new DateTime(2020, 12, 26, 17, 1, 27, 326, DateTimeKind.Local).AddTicks(5114) });
        }
    }
}
