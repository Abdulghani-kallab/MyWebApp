using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "FirstName", "LastName", "ModifiedTime", "MyJob" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 940, DateTimeKind.Local).AddTicks(1678), new DateTime(2022, 3, 26, 21, 25, 39, 940, DateTimeKind.Local).AddTicks(2103), "Fatih", "ÖZYURT", new DateTime(2022, 3, 26, 21, 25, 39, 940, DateTimeKind.Local).AddTicks(2374), "fırat üniversitesinde Doç. Dr" });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Email", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 942, DateTimeKind.Local).AddTicks(2791), "fatihozyurt@firat.edu.tr", new DateTime(2022, 3, 26, 21, 25, 39, 942, DateTimeKind.Local).AddTicks(2795) });

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
                columns: new[] { "CreatedTime", "FirstName", "LastName", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 949, DateTimeKind.Local).AddTicks(2243), "Fatih", "ÖZYURT", new DateTime(2022, 3, 26, 21, 25, 39, 949, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Email", "LongAdress", "ModifiedTime", "PhoneNumber", "ShortAdress" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 950, DateTimeKind.Local).AddTicks(4788), "fatihozyurt@firat.edu.tr", "sürüsürü Mah Daire 10/5", new DateTime(2022, 3, 26, 21, 25, 39, 950, DateTimeKind.Local).AddTicks(4794), "04242370005585", "Elazığ/Turkey" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 952, DateTimeKind.Local).AddTicks(42), new DateTime(2022, 3, 26, 21, 25, 39, 952, DateTimeKind.Local).AddTicks(50) });

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
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 953, DateTimeKind.Local).AddTicks(2107), new DateTime(2022, 3, 26, 21, 25, 39, 953, DateTimeKind.Local).AddTicks(2114) });

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
                columns: new[] { "CreatedTime", "Description", "Keywords", "LogoText", "ModifiedTime", "Title" },
                values: new object[] { new DateTime(2022, 3, 26, 21, 25, 39, 958, DateTimeKind.Local).AddTicks(310), "Ben Fatih ÖZYURT Yazılım geliştiricisiyim. C#, python ve web bilgim var.", "Fatih ÖZYURT, Fatih,ÖZYURT, Software, Developer, Engineer", "Fatih ÖZYURT", new DateTime(2022, 3, 26, 21, 25, 39, 958, DateTimeKind.Local).AddTicks(317), "Fatih ÖZYURT" });

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
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://www.facebook.com", new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6742), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://twitter.com", new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6757), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://www.linkedin.com", new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6763), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://github.com", new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6767), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://www.youtube.com", new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6772), new DateTime(2022, 3, 26, 21, 25, 39, 960, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedTime", "ModifiedTime" },
                values: new object[] { "Merhaba siteme hoşgeldiniz. Ben Fatih ÖZYURT.", new DateTime(2022, 3, 26, 21, 25, 39, 961, DateTimeKind.Local).AddTicks(6260), new DateTime(2022, 3, 26, 21, 25, 39, 961, DateTimeKind.Local).AddTicks(6266) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedTime", "FirstName", "LastName", "ModifiedTime", "MyJob" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 689, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 3, 26, 20, 46, 9, 689, DateTimeKind.Local).AddTicks(6753), "Hasan", "Erdal", new DateTime(2022, 3, 26, 20, 46, 9, 689, DateTimeKind.Local).AddTicks(7549), "Full-stack Web Developer" });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Email", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 695, DateTimeKind.Local).AddTicks(8382), "hasaerda@hotmail.com", new DateTime(2022, 3, 26, 20, 46, 9, 695, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 709, DateTimeKind.Local).AddTicks(9661), new DateTime(2022, 3, 26, 20, 46, 9, 709, DateTimeKind.Local).AddTicks(9688) });

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
                columns: new[] { "CreatedTime", "FirstName", "LastName", "ModifiedTime" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 716, DateTimeKind.Local).AddTicks(8283), "Hasan", "Erdal", new DateTime(2022, 3, 26, 20, 46, 9, 716, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Email", "LongAdress", "ModifiedTime", "PhoneNumber", "ShortAdress" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 720, DateTimeKind.Local).AddTicks(7256), "hasaerda@hotmail.com", "Yukarıbayır Mh. Hüseyin Aşkın Sk. No:44 Kat-1", new DateTime(2022, 3, 26, 20, 46, 9, 720, DateTimeKind.Local).AddTicks(7280), "+905370352059", "Şahinbey/Gaziantep" });

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
                columns: new[] { "CreatedTime", "Description", "Keywords", "LogoText", "ModifiedTime", "Title" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 46, 9, 743, DateTimeKind.Local).AddTicks(7825), "Ben Hasan Erdal. Yazılım geliştiricisiyim. C#, python ve web bilgim var.", "Hasan Erdal, Hasan, Erdal, Software, Developer, Engineer", "HASAN ERDAL", new DateTime(2022, 3, 26, 20, 46, 9, 743, DateTimeKind.Local).AddTicks(7850), "Hasan Erdal" });

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
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://www.facebook.com/xxfiliphasanxx", new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7104), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://twitter.com/hasaerda", new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7152), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://www.linkedin.com/in/hasan-erdal-2b57a3136/", new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7162), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://github.com/Filiphasan", new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7172), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccountUrl", "CreatedTime", "ModifiedTime" },
                values: new object[] { "https://www.youtube.com/channel/UCKgQs4J8PEFS97iOGop_X4w", new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7181), new DateTime(2022, 3, 26, 20, 46, 9, 750, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedTime", "ModifiedTime" },
                values: new object[] { "Merhaba siteme hoşgeldiniz. Ben Elektrik Elektronik Mühendisliği okuyan aynı zamanda yazılıma gönül vermiş birisiyim. C# ve .NET alanlarında yoğun bir şekilde kendimi geliştiriyorum. Python ve JavaScript dillerinde ise yavaş ve planlı şekilde gelişimime devam ediyorum. Gelişime açık ve hızlı öğrenen birisi olduğumu düşünüyorum. Geleceğimi yazılım üzerine şekillendireceğime eminim. Bu yolda elimden gelenin en iyisini değil, her şeyi yapacağım. Yazılım üzerine birçok hayalim, uzun ve kısa vadeli planlarım var. Açıkçası yazılımın hayatımın her alanına yeterli ölçüde etki etmesini istiyorum. Bilgisayar eskiden beridir tutkum olan bir alan. Bilgisayardan bir şeyler yazarak bunun somut sonuçlarını görmek beni mutlu ediyor.", new DateTime(2022, 3, 26, 20, 46, 9, 753, DateTimeKind.Local).AddTicks(7766), new DateTime(2022, 3, 26, 20, 46, 9, 753, DateTimeKind.Local).AddTicks(7788) });
        }
    }
}
