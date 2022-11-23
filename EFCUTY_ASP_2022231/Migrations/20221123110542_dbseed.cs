using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCUTY_ASP_2022231.Migrations
{
    public partial class dbseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "206ec4b9-cbea-41ad-8cfc-46ab46c3f639", 0, "f01da23f-a50b-4f55-a0d9-6929a6ce0c5b", null, null, "SiteUser", null, false, "Mariann", "Kiss", false, null, null, "MARIANNKISS@UNI-OBUDA.HU", "AQAAAAEAACcQAAAAEJoBB3BgBK0m6s3m+wX4r3mjEJDVhBjbzeWb014gqe30jYRLiLcOFIrtiggJGAiwzw==", null, false, "7cbb615d-6600-4656-bb87-5c2b84b84926", false, "mariannkiss@uni-obuda.hu" },
                    { "51fee3a6-2689-4d2e-b9c8-3b8f0ce9ab53", 0, "5326248e-43e6-4c97-bdd9-2cf78c2c412e", null, null, "SiteUser", null, false, "Béla", "Kovács", false, null, null, "BELA.KOVACS@GMAIL.COM", "AQAAAAEAACcQAAAAEHhyHPzk1SsICeY/0sZntwusXfOL7Lq9AnZX6EaHmtbWSdyw1UWcdoVNuYGF4D1PRw==", null, false, "0cc9b9ba-0552-4554-a412-dba3dc96a82b", false, "bela.kovacs@gmail.com" },
                    { "9b0246f8-4fa8-4859-8b2a-8dd469a4a530", 0, "e2d1e226-27b3-45dc-80e5-0ea977166a65", null, null, "SiteUser", null, false, "József", "Kiss", false, null, null, "JOZSEFKISS@GMAIL.COM", "AQAAAAEAACcQAAAAELM2JZRFh9u0xD5us7nIBUfjlhchVBXcb3s5hc+rQjCGoeYixEtzC8/1axDv+LrTRw==", null, false, "dfda0a15-1c79-44a6-aa4a-79eab622b8cc", false, "jozsefkiss@gmail.com" },
                    { "d223250f-27f0-4b7f-8342-a363ae2e3d23", 0, "55fc1fb5-2264-418a-b353-a034aac8b0ed", null, null, "SiteUser", null, false, "Ferenc", "Kovács", false, null, null, "ISTVANTAKACS@GMAIL.COM", "AQAAAAEAACcQAAAAECRI3HaGMzb25QL7moWZEh2lfKrj189/ai+Vn9mNOz3XVANX2KDnicO8tbAicBSjKA==", null, false, "1fa25c71-8b9f-495e-8407-9b3fb79aac8f", false, "istvantakacs@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectCode", "CreditValue", "ExamSubject", "Name", "Semester" },
                values: new object[,]
                {
                    { "NIXBE1PBNE", 3, true, "Beágyazott és érzékelőalapú rendszerek", 2 },
                    { "NIXSF1HBNE", 7, true, "Szoftvertervezés és -fejlesztés 1.", 1 },
                    { "NIXSF2HBNE", 7, true, "Szoftvertervezés és -fejlesztés 2.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "SiteUserId", "SubjectCode", "Timestamp" },
                values: new object[,]
                {
                    { "3db98627-f66a-4a84-986b-a648f290be85", "Sziasztok! Tudtok valamit, hogy mi lesz a jövő heti zh-ban?", 0, null, "51fee3a6-2689-4d2e-b9c8-3b8f0ce9ab53", "KGK666BUKO", new DateTime(2022, 10, 23, 11, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "791ebfa4-227d-4039-b421-7d85ff0154a9", "Kedves mindenki! Ugye tudják, hogy a zárthelyi dolgozatot kiválthatják beadandó dolgozat megírásával?\nDe akkor legfeljebb hármast tudok majd adni.", 0, null, "206ec4b9-cbea-41ad-8cfc-46ab46c3f639", "KGK666BUKO", new DateTime(2022, 10, 29, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "d16ce0d1-5a8e-4e3c-a221-4bc76a4ab819", "Határérték-számításban tud valaki segíteni?", 0, null, "d223250f-27f0-4b7f-8342-a363ae2e3d23", "NIXMN1HBNE", new DateTime(2022, 9, 7, 7, 45, 28, 0, DateTimeKind.Unspecified) },
                    { "e133ff46-7097-45c4-b8e3-186eef704178", "Hányat lehet hiányozni sztf laboron?", 0, null, "9b0246f8-4fa8-4859-8b2a-8dd469a4a530", "NIXMN1HBNE", new DateTime(2022, 10, 15, 11, 11, 22, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "PostId", "SiteUserId", "Timestamp" },
                values: new object[,]
                {
                    { "0d8217db-6283-42d9-a16f-e1a5af6c6dcf", "Ne szívass, akkor meg mit problémáztál szeptemberben? Én mehetek pótzh-ra...", 0, null, "d16ce0d1-5a8e-4e3c-a221-4bc76a4ab819", "78fabc64-2e18-4e07-9476-ccfaab3643f9", new DateTime(2022, 10, 22, 11, 5, 33, 0, DateTimeKind.Unspecified) },
                    { "5a3803cd-dc44-450e-b52a-1c99de1deab8", "Figyelj oda, hogy ez nem az sztf topik! Egyébként matekról meg progról is négy hiányzásnál letiltanak.", 0, null, "e133ff46-7097-45c4-b8e3-186eef704178", "51fee3a6-2689-4d2e-b9c8-3b8f0ce9ab53", new DateTime(2022, 10, 29, 8, 13, 28, 0, DateTimeKind.Unspecified) },
                    { "8b8aba3c-4769-4620-8716-f17053a53a22", "Nekem se megy, meg szerintem senkinek se, mindenkinek bukó lesz a zh:D", 0, null, "d16ce0d1-5a8e-4e3c-a221-4bc76a4ab819", "78fabc64-2e18-4e07-9476-ccfaab3643f9", new DateTime(2022, 9, 10, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "dc959e50-840c-4ecb-b238-63595e5e06a6", "Mondjuk nem is volt olyan rossz, 69% lett a zh-m^^", 0, null, "d16ce0d1-5a8e-4e3c-a221-4bc76a4ab819", "d223250f-27f0-4b7f-8342-a363ae2e3d23", new DateTime(2022, 10, 20, 21, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "f57194e1-146f-4d2b-bc56-56366286aa7d", "Ne felejtse el, hogy én is látom, ne tegezzen mindenkit csak úgy.\nEgyébként tesztes kérdések lesznek, Marshall-keresztet mindenképp nézzék át!", 0, null, "3db98627-f66a-4a84-986b-a648f290be85", "206ec4b9-cbea-41ad-8cfc-46ab46c3f639", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "0d8217db-6283-42d9-a16f-e1a5af6c6dcf");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "5a3803cd-dc44-450e-b52a-1c99de1deab8");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "8b8aba3c-4769-4620-8716-f17053a53a22");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "dc959e50-840c-4ecb-b238-63595e5e06a6");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "f57194e1-146f-4d2b-bc56-56366286aa7d");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "791ebfa4-227d-4039-b421-7d85ff0154a9");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "NIXBE1PBNE");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "NIXSF1HBNE");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "NIXSF2HBNE");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "206ec4b9-cbea-41ad-8cfc-46ab46c3f639");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "3db98627-f66a-4a84-986b-a648f290be85");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "d16ce0d1-5a8e-4e3c-a221-4bc76a4ab819");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "e133ff46-7097-45c4-b8e3-186eef704178");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51fee3a6-2689-4d2e-b9c8-3b8f0ce9ab53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b0246f8-4fa8-4859-8b2a-8dd469a4a530");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d223250f-27f0-4b7f-8342-a363ae2e3d23");
        }
    }
}
