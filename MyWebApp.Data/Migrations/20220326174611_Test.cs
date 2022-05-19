using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 689, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 3, 26, 20, 46, 9, 689, DateTimeKind.Local).AddTicks(6753), new DateTime(2022, 3, 26, 20, 46, 9, 689, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 695, DateTimeKind.Local).AddTicks(8382), new DateTime(2022, 3, 26, 20, 46, 9, 695, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note", "SeoDescription", "SeoTags", "ShortContent", "Thumbnail", "Title", "ViewsCount" },
                values: new object[] { 2, 1, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2022, 3, 26, 20, 46, 9, 709, DateTimeKind.Local).AddTicks(9661), true, false, "InitialCreate", new DateTime(2022, 3, 26, 20, 46, 9, 709, DateTimeKind.Local).AddTicks(9688), "InitialCreate", "C# 9.0 ve .Net 5.0 Yenilikleri", "C#, C#9, .NET5", "Test of Article", "", "C# 9.0 ve .Net 5.0 Yenilikleri", 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 713, DateTimeKind.Local).AddTicks(538), new DateTime(2022, 3, 26, 20, 46, 9, 713, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 716, DateTimeKind.Local).AddTicks(8283), new DateTime(2022, 3, 26, 20, 46, 9, 716, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 720, DateTimeKind.Local).AddTicks(7256), new DateTime(2022, 3, 26, 20, 46, 9, 720, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 724, DateTimeKind.Local).AddTicks(6646), new DateTime(2022, 3, 26, 20, 46, 9, 724, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 724, DateTimeKind.Local).AddTicks(6684), new DateTime(2022, 3, 26, 20, 46, 9, 724, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 729, DateTimeKind.Local).AddTicks(2698), new DateTime(2022, 3, 26, 20, 46, 9, 729, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 732, DateTimeKind.Local).AddTicks(8039), new DateTime(2022, 3, 26, 20, 46, 9, 732, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 732, DateTimeKind.Local).AddTicks(8080), new DateTime(2022, 3, 26, 20, 46, 9, 732, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 735, DateTimeKind.Local).AddTicks(5647), new DateTime(2022, 3, 26, 20, 46, 9, 735, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 735, DateTimeKind.Local).AddTicks(5696), new DateTime(2022, 3, 26, 20, 46, 9, 735, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 735, DateTimeKind.Local).AddTicks(5708), new DateTime(2022, 3, 26, 20, 46, 9, 735, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 739, DateTimeKind.Local).AddTicks(9206), new DateTime(2022, 3, 26, 20, 46, 9, 739, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 743, DateTimeKind.Local).AddTicks(7825), new DateTime(2022, 3, 26, 20, 46, 9, 743, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9820), new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9875), new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9887), new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9911), new DateTime(2022, 3, 26, 20, 46, 9, 746, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7104), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7152), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7162), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7172), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7181), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 753, DateTimeKind.Local).AddTicks(7766), new DateTime(2022, 3, 26, 20, 46, 9, 753, DateTimeKind.Local).AddTicks(7788) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

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
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 27, 20, 936, DateTimeKind.Local).AddTicks(179), new DateTime(2022, 3, 20, 1, 27, 20, 936, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note", "SeoDescription", "SeoTags", "ShortContent", "Thumbnail", "Title", "ViewsCount" },
                values: new object[] { 1, 1, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2022, 3, 20, 1, 27, 20, 942, DateTimeKind.Local).AddTicks(7885), true, false, "InitialCreate", new DateTime(2022, 3, 20, 1, 27, 20, 942, DateTimeKind.Local).AddTicks(7899), "InitialCreate", "C# 9.0 ve .Net 5.0 Yenilikleri", "C#, C#9, .NET5", "", "", "C# 9.0 ve .Net 5.0 Yenilikleri", 0 });

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
    }
}
