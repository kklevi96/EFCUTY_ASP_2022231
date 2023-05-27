using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCUTY_ASP_2022231.Migrations
{
    public partial class apiinit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aa3e82c-3e7b-4cc4-804e-1ea6f8922f8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6656bbe9-66c7-4069-be44-a1e368d4669d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "921df54a-d1ba-47fc-af44-8ac65b786883");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c22192a2-5083-40a1-af8e-fb652a0914bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f90bda35-d092-4bb8-84cd-a611aeab470a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f04559c-ceb0-45c6-9b3b-35e9781b4bfd", 0, "3d3874fc-ea7c-40b4-927a-bbc4d557cd09", null, false, "Ferenc", "Kovács", false, null, null, "ISTVANTAKACS@GMAIL.COM", "AQAAAAEAACcQAAAAEA49xa4aAA/uefo479T4B5+Q56gsfUoUMcMKHxlGXjjeeaOgUTjXFpRz2Iws/wfW/w==", null, false, "723671f2-a00b-4356-83ae-4129c70dfc37", false, "istvantakacs@gmail.com" },
                    { "35806983-b7c1-4704-b396-6f3510d13393", 0, "daf02808-0240-4d9f-93c0-ce2507bcecf4", null, false, "József", "Kiss", false, null, null, "JOZSEFKISS@GMAIL.COM", "AQAAAAEAACcQAAAAEBt6kogaA0iZm2CV8Qws1tmXyVF1Eog0URhx+icafMW05zcUTGkgn019aaUszcTAqw==", null, false, "87f5eaf8-1154-42eb-bed9-76817ab0b00b", false, "jozsefkiss@gmail.com" },
                    { "98f59a86-4808-4f0f-8b51-1fb8e55eb321", 0, "ec0cda04-9009-4165-bc5f-5cef88452a06", null, false, "Mariann", "Kiss", false, null, null, "MARIANNKISS@UNI-OBUDA.HU", "AQAAAAEAACcQAAAAEM67HF+ofUUwfqtR3RJ7s7I8xib7VvwL3Cxa2BI69JLDzy0QK1hGIhabCqhzQBYzTg==", null, false, "c254a00c-81a4-4e53-b057-672bce54ffe7", false, "mariannkiss@uni-obuda.hu" },
                    { "a43ba7a2-896b-4fa7-b41d-6ecb4723b5d0", 0, "f232d90c-6997-4b5a-8d59-e566ac9cc3cf", null, false, "Júlia", "Horváth", false, null, null, "JULIAHORVATH@YAHOO.COM", "AQAAAAEAACcQAAAAEPLUkQodL+dRzvAc/wrmk+2R6oS1K73wbUICYFtfCZSBojroDnnD88hEnPu0ZZdvvg==", null, false, "8e4534e0-31b0-44bd-b6dd-6a51fae94419", false, "juliahorvath@yahoo.com" },
                    { "dcc99930-fcf5-4730-be6c-fc0ad9d4a836", 0, "78c6aa8f-1a31-47de-a2f0-99fe8920c37c", null, false, "Béla", "Kovács", false, null, null, "BELA.KOVACS@GMAIL.COM", "AQAAAAEAACcQAAAAEBmPjBNlOoXb9YTdQW0+T3T0OfMNsqjXBo8PmCA9VvMr3yNkggr3CIKmemN/RtXlWg==", null, false, "fed5bbbf-b3fa-41b7-9476-3e7f4a0868ee", false, "bela.kovacs@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "SiteUserId", "SubjectCode", "Timestamp" },
                values: new object[,]
                {
                    { "782e6967-67cd-40de-82fc-e79d4a535dab", "Jövő héten lesz óra?", 0, null, "a43ba7a2-896b-4fa7-b41d-6ecb4723b5d0", "NIXBE1PBNE", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "86749716-3490-4914-8bfb-7bb92e5f52c9", "Sziasztok! Tudtok valamit, hogy mi lesz a jövő heti zh-ban?", 0, null, "dcc99930-fcf5-4730-be6c-fc0ad9d4a836", "KGK666BUKO", new DateTime(2022, 10, 23, 11, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "8f5b166d-43e7-4592-b365-b24b3b3220e2", "Hányat lehet hiányozni sztf laboron?", 0, null, "35806983-b7c1-4704-b396-6f3510d13393", "NIXMN1HBNE", new DateTime(2022, 10, 15, 11, 11, 22, 0, DateTimeKind.Unspecified) },
                    { "b0dde3b8-70b5-4295-a18d-f0649e7407e9", "Határérték-számításban tud valaki segíteni?", 0, null, "0f04559c-ceb0-45c6-9b3b-35e9781b4bfd", "NIXMN1HBNE", new DateTime(2022, 9, 7, 7, 45, 28, 0, DateTimeKind.Unspecified) },
                    { "d3dd4ab6-2a12-4212-9177-6b2d9e8ddede", "Kedves mindenki! Ugye tudják, hogy a zárthelyi dolgozatot kiválthatják beadandó dolgozat megírásával?\nDe akkor legfeljebb hármast tudok majd adni.", 0, null, "98f59a86-4808-4f0f-8b51-1fb8e55eb321", "KGK666BUKO", new DateTime(2022, 10, 29, 8, 15, 28, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "PostId", "SiteUserId", "Timestamp" },
                values: new object[,]
                {
                    { "3f4d4861-3984-45f1-8f2c-f5ae78e954bc", "Nekem se megy, meg szerintem senkinek se, mindenkinek bukó lesz a zh:D", 0, null, "b0dde3b8-70b5-4295-a18d-f0649e7407e9", "a43ba7a2-896b-4fa7-b41d-6ecb4723b5d0", new DateTime(2022, 9, 10, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "b719a349-ac37-4e79-85a8-6c3854027b95", "Figyelj oda, hogy ez nem az sztf topik! Egyébként matekról meg progról is négy hiányzásnál letiltanak.", 0, null, "8f5b166d-43e7-4592-b365-b24b3b3220e2", "dcc99930-fcf5-4730-be6c-fc0ad9d4a836", new DateTime(2022, 10, 29, 8, 13, 28, 0, DateTimeKind.Unspecified) },
                    { "bab7742d-3183-4934-9ee2-95c152f63b10", "Ne szívass, akkor meg mit problémáztál szeptemberben? Én mehetek pótzh-ra...", 0, null, "b0dde3b8-70b5-4295-a18d-f0649e7407e9", "a43ba7a2-896b-4fa7-b41d-6ecb4723b5d0", new DateTime(2022, 10, 22, 11, 5, 33, 0, DateTimeKind.Unspecified) },
                    { "edd18bb6-6ef2-4638-a73f-806902266183", "Ne felejtse el, hogy én is látom, ne tegezzen mindenkit csak úgy.\nEgyébként tesztes kérdések lesznek, Marshall-keresztet mindenképp nézzék át!", 0, null, "86749716-3490-4914-8bfb-7bb92e5f52c9", "98f59a86-4808-4f0f-8b51-1fb8e55eb321", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "fa5fec09-647f-4d56-9861-9334a5e3b461", "Mondjuk nem is volt olyan rossz, 69% lett a zh-m^^", 0, null, "b0dde3b8-70b5-4295-a18d-f0649e7407e9", "0f04559c-ceb0-45c6-9b3b-35e9781b4bfd", new DateTime(2022, 10, 20, 21, 15, 28, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "3f4d4861-3984-45f1-8f2c-f5ae78e954bc");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "b719a349-ac37-4e79-85a8-6c3854027b95");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "bab7742d-3183-4934-9ee2-95c152f63b10");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "edd18bb6-6ef2-4638-a73f-806902266183");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: "fa5fec09-647f-4d56-9861-9334a5e3b461");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "782e6967-67cd-40de-82fc-e79d4a535dab");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "d3dd4ab6-2a12-4212-9177-6b2d9e8ddede");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98f59a86-4808-4f0f-8b51-1fb8e55eb321");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a43ba7a2-896b-4fa7-b41d-6ecb4723b5d0");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "86749716-3490-4914-8bfb-7bb92e5f52c9");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "8f5b166d-43e7-4592-b365-b24b3b3220e2");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "b0dde3b8-70b5-4295-a18d-f0649e7407e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f04559c-ceb0-45c6-9b3b-35e9781b4bfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35806983-b7c1-4704-b396-6f3510d13393");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcc99930-fcf5-4730-be6c-fc0ad9d4a836");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5aa3e82c-3e7b-4cc4-804e-1ea6f8922f8b", 0, "ec5c1f8d-392d-40d4-8663-5695c9ab1b78", null, false, "Ferenc", "Kovács", false, null, null, "ISTVANTAKACS@GMAIL.COM", "AQAAAAEAACcQAAAAEH09JHyfWPLnG7KHq3vX8oB2VlG+pZdfbFJJXtjY96RyDSwswPG3GcEAJcrurkH5WQ==", null, false, "c8696ec3-ca52-4627-b5db-ad2073dc6e99", false, "istvantakacs@gmail.com" },
                    { "6656bbe9-66c7-4069-be44-a1e368d4669d", 0, "ab013e34-6d08-42e3-ae60-322b5a31f6a1", null, false, "Mariann", "Kiss", false, null, null, "MARIANNKISS@UNI-OBUDA.HU", "AQAAAAEAACcQAAAAEGluqJqm59iQwRkrH+pfQBvsmPbQhpjLnyDtdIdCKUpYq7ztNacc7MHvoApXOkjZjg==", null, false, "77895e66-afeb-4c3a-aa01-d4973e14f93a", false, "mariannkiss@uni-obuda.hu" },
                    { "921df54a-d1ba-47fc-af44-8ac65b786883", 0, "997b8879-1b87-434c-99b9-9d04272e578c", null, false, "Júlia", "Horváth", false, null, null, "JULIAHORVATH@YAHOO.COM", "AQAAAAEAACcQAAAAEELg7hzSs98j7cxzdr+3FtIbZKBwD+j7/gfagqz3yHOzwFpUQDc9TvR4EfEkArLT4A==", null, false, "fd37a41d-0f5e-40a4-b701-efa54340188d", false, "juliahorvath@yahoo.com" },
                    { "c22192a2-5083-40a1-af8e-fb652a0914bd", 0, "59485fe1-96b5-4239-a673-05c3d8a963f8", null, false, "Béla", "Kovács", false, null, null, "BELA.KOVACS@GMAIL.COM", "AQAAAAEAACcQAAAAEFO6jAjt/hxwUQxW1q3RpsvTCq27f4x470ikuCg6xdeXxGaIVvoi5D1ECuZmn15U2Q==", null, false, "0aace00b-b8d8-4983-9348-286e14dc5d89", false, "bela.kovacs@gmail.com" },
                    { "f90bda35-d092-4bb8-84cd-a611aeab470a", 0, "21e99639-a160-4065-9adf-4be9630f39b1", null, false, "József", "Kiss", false, null, null, "JOZSEFKISS@GMAIL.COM", "AQAAAAEAACcQAAAAEPPqcEALuOKPBH0vbsxA9E+BAvzpq6jdUPy93tG5Urfa65vV2hDVmMH8esdG+QAB5A==", null, false, "98eed380-77a0-4425-871e-ea9f89a9dd07", false, "jozsefkiss@gmail.com" }
                });
        }
    }
}
