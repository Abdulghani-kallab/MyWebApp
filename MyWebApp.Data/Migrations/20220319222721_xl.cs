using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class xl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 933, DateTimeKind.Local).AddTicks(9587), new DateTime(2022, 3, 20, 1, 27, 20, 934, DateTimeKind.Local).AddTicks(10), new DateTime(2022, 3, 20, 1, 27, 20, 934, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 936, DateTimeKind.Local).AddTicks(179), new DateTime(2022, 3, 20, 1, 27, 20, 936, DateTimeKind.Local).AddTicks(184), "C863FB7DD9E5A18B8F142DB629FA563A" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 942, DateTimeKind.Local).AddTicks(7885), new DateTime(2022, 3, 20, 1, 27, 20, 942, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 944, DateTimeKind.Local).AddTicks(480), new DateTime(2022, 3, 20, 1, 27, 20, 944, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 945, DateTimeKind.Local).AddTicks(5506), new DateTime(2022, 3, 20, 1, 27, 20, 945, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 946, DateTimeKind.Local).AddTicks(8587), new DateTime(2022, 3, 20, 1, 27, 20, 946, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 948, DateTimeKind.Local).AddTicks(2989), new DateTime(2022, 3, 20, 1, 27, 20, 948, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 948, DateTimeKind.Local).AddTicks(3007), new DateTime(2022, 3, 20, 1, 27, 20, 948, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 949, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 3, 20, 1, 27, 20, 949, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 951, DateTimeKind.Local).AddTicks(443), new DateTime(2022, 3, 20, 1, 27, 20, 951, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 951, DateTimeKind.Local).AddTicks(459), new DateTime(2022, 3, 20, 1, 27, 20, 951, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 952, DateTimeKind.Local).AddTicks(622), new DateTime(2022, 3, 20, 1, 27, 20, 952, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 952, DateTimeKind.Local).AddTicks(638), new DateTime(2022, 3, 20, 1, 27, 20, 952, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 952, DateTimeKind.Local).AddTicks(642), new DateTime(2022, 3, 20, 1, 27, 20, 952, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 953, DateTimeKind.Local).AddTicks(5038), new DateTime(2022, 3, 20, 1, 27, 20, 953, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 954, DateTimeKind.Local).AddTicks(7562), new DateTime(2022, 3, 20, 1, 27, 20, 954, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8848), new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8863), new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8868), new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8872), new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8877), new DateTime(2022, 3, 20, 1, 27, 20, 955, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1653), new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1669), new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1674), new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1679), new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1683), new DateTime(2022, 3, 20, 1, 27, 20, 957, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 958, DateTimeKind.Local).AddTicks(544), new DateTime(2022, 3, 20, 1, 27, 20, 958, DateTimeKind.Local).AddTicks(549) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
