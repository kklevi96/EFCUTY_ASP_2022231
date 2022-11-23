using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCUTY_ASP_2022231.Migrations
{
    public partial class dbseed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ec37df0-916d-464d-a8f6-9d3c0dc97848", 0, "9bc36164-ac9b-4da4-84aa-6c1024050220", null, null, "SiteUser", null, false, "Mariann", "Kiss", false, null, null, "MARIANNKISS@UNI-OBUDA.HU", "AQAAAAEAACcQAAAAEOiVy1bKH3/jkDFGmWAz/G0QtcBahTyFJtyrS5miBp24gKB48De6etWWt//hSkkZhw==", null, false, "77b0e49b-76d0-417a-9e73-cfb2fe21a444", false, "mariannkiss@uni-obuda.hu" },
                    { "4799780d-a03f-471a-9622-c4866dd0f5bc", 0, "95b819fd-981f-445f-85af-39363040829b", null, null, "SiteUser", null, false, "József", "Kiss", false, null, null, "JOZSEFKISS@GMAIL.COM", "AQAAAAEAACcQAAAAEPqXDGfAsCS0zKfpnWyM7vHnCy+ULujmN+BfhVh5p6sd/UapluEEwfMIYgL9Io76fg==", null, false, "046df45d-a7f4-4c28-9e9c-926f9d9bb2a5", false, "jozsefkiss@gmail.com" },
                    { "8b7de85f-3ef6-48d6-9fb8-ae666ed39c43", 0, "b352f0c6-e8da-4714-99ab-ce5cbab1e712", null, null, "SiteUser", null, false, "Béla", "Kovács", false, null, null, "BELA.KOVACS@GMAIL.COM", "AQAAAAEAACcQAAAAEJb5/6HEI0B27RtTwH8YFufe9Ei7+a1PV6iQLEvDVbPbEhlgT2euPovpFEb1iKsriA==", null, false, "185f322d-c1e4-4b15-9253-c42aad776f7f", false, "bela.kovacs@gmail.com" },
                    { "ef2c07be-a9fb-4548-ba12-e2201018a7de", 0, "350de7c8-d57d-4fe6-848a-cd1b8c96b67d", null, null, "SiteUser", null, false, "Ferenc", "Kovács", false, null, null, "ISTVANTAKACS@GMAIL.COM", "AQAAAAEAACcQAAAAEIICwlR503dpnnQy6C6FJGoPkqHSXdcBKP0h40Ruami/hf6x4KMSffb7jgSXz+NwEw==", null, false, "4905909c-e9ca-4378-96e4-63ece924db61", false, "istvantakacs@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "SiteUserId", "SubjectCode", "Timestamp" },
                values: new object[] { "58170dd4-a18e-4d39-9d29-94482c9a0121", "Jövő héten lesz óra?", 0, null, "5d16e2fc-89c7-42d2-8628-1b19b19650ae", "NIXBE1PBNE", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "SiteUserId", "SubjectCode", "Timestamp" },
                values: new object[,]
                {
                    { "497b04f7-3b5e-417b-9080-ed0a8adc729a", "Hányat lehet hiányozni sztf laboron?", 0, null, "4799780d-a03f-471a-9622-c4866dd0f5bc", "NIXMN1HBNE", new DateTime(2022, 10, 15, 11, 11, 22, 0, DateTimeKind.Unspecified) },
                    { "7bc16cac-943e-4b54-b161-9f5ff3ce5d26", "Határérték-számításban tud valaki segíteni?", 0, null, "ef2c07be-a9fb-4548-ba12-e2201018a7de", "NIXMN1HBNE", new DateTime(2022, 9, 7, 7, 45, 28, 0, DateTimeKind.Unspecified) },
                    { "905e51c3-9c04-40e9-97de-9cd0186ab687", "Kedves mindenki! Ugye tudják, hogy a zárthelyi dolgozatot kiválthatják beadandó dolgozat megírásával?\nDe akkor legfeljebb hármast tudok majd adni.", 0, null, "0ec37df0-916d-464d-a8f6-9d3c0dc97848", "KGK666BUKO", new DateTime(2022, 10, 29, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "a9022b00-d683-46fb-858f-383b2e1c93c6", "Sziasztok! Tudtok valamit, hogy mi lesz a jövő heti zh-ban?", 0, null, "8b7de85f-3ef6-48d6-9fb8-ae666ed39c43", "KGK666BUKO", new DateTime(2022, 10, 23, 11, 15, 28, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "PostId", "SiteUserId", "Timestamp" },
                values: new object[,]
                {
                    { "4411667d-a822-4d61-986e-b36700c6bae3", "Ne szívass, akkor meg mit problémáztál szeptemberben? Én mehetek pótzh-ra...", 0, null, "7bc16cac-943e-4b54-b161-9f5ff3ce5d26", "5d16e2fc-89c7-42d2-8628-1b19b19650ae", new DateTime(2022, 10, 22, 11, 5, 33, 0, DateTimeKind.Unspecified) },
                    { "5654c02e-715b-40e1-acfd-41331797b6a7", "Nekem se megy, meg szerintem senkinek se, mindenkinek bukó lesz a zh:D", 0, null, "7bc16cac-943e-4b54-b161-9f5ff3ce5d26", "5d16e2fc-89c7-42d2-8628-1b19b19650ae", new DateTime(2022, 9, 10, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "8e8e006c-8206-4c30-9885-8deac3f52be4", "Mondjuk nem is volt olyan rossz, 69% lett a zh-m^^", 0, null, "7bc16cac-943e-4b54-b161-9f5ff3ce5d26", "ef2c07be-a9fb-4548-ba12-e2201018a7de", new DateTime(2022, 10, 20, 21, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "bfb370a3-263a-4127-971d-706541e01b02", "Ne felejtse el, hogy én is látom, ne tegezzen mindenkit csak úgy.\nEgyébként tesztes kérdések lesznek, Marshall-keresztet mindenképp nézzék át!", 0, null, "a9022b00-d683-46fb-858f-383b2e1c93c6", "0ec37df0-916d-464d-a8f6-9d3c0dc97848", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "c35b13b8-c415-44af-a6fd-9dc49dc309df", "Figyelj oda, hogy ez nem az sztf topik! Egyébként matekról meg progról is négy hiányzásnál letiltanak.", 0, null, "497b04f7-3b5e-417b-9080-ed0a8adc729a", "8b7de85f-3ef6-48d6-9fb8-ae666ed39c43", new DateTime(2022, 10, 29, 8, 13, 28, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "4411667d-a822-4d61-986e-b36700c6bae3");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "5654c02e-715b-40e1-acfd-41331797b6a7");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "8e8e006c-8206-4c30-9885-8deac3f52be4");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "bfb370a3-263a-4127-971d-706541e01b02");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "c35b13b8-c415-44af-a6fd-9dc49dc309df");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "58170dd4-a18e-4d39-9d29-94482c9a0121");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "905e51c3-9c04-40e9-97de-9cd0186ab687");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ec37df0-916d-464d-a8f6-9d3c0dc97848");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "497b04f7-3b5e-417b-9080-ed0a8adc729a");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "7bc16cac-943e-4b54-b161-9f5ff3ce5d26");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "a9022b00-d683-46fb-858f-383b2e1c93c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4799780d-a03f-471a-9622-c4866dd0f5bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b7de85f-3ef6-48d6-9fb8-ae666ed39c43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef2c07be-a9fb-4548-ba12-e2201018a7de");

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
    }
}
