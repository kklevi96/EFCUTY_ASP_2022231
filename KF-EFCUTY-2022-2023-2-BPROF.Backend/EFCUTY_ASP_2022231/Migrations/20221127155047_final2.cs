using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCUTY_ASP_2022231.Migrations
{
    public partial class final2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreditValue = table.Column<int>(type: "int", nullable: false),
                    ExamSubject = table.Column<bool>(type: "bit", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectCode);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditCount = table.Column<int>(type: "int", nullable: false),
                    SiteUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_SiteUserId",
                        column: x => x.SiteUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Subjects_SubjectCode",
                        column: x => x.SubjectCode,
                        principalTable: "Subjects",
                        principalColumn: "SubjectCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditCount = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SiteUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_SiteUserId",
                        column: x => x.SiteUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13dd7181-a74c-4baf-9574-85ab30a5f5e3", 0, "c71f1b00-bf37-486f-8f49-88c2271e77e2", "SiteUser", null, false, "Béla", "Kovács", false, null, null, "BELA.KOVACS@GMAIL.COM", "AQAAAAEAACcQAAAAEHi5cyGEecM687CM6XXQ+rJY2hn8ingLVV/uykxE9nCezFnHazf5TyE8AY2Az6bnxw==", null, false, "645f6aac-9a8b-4fbe-a150-a3e62d871df7", false, "bela.kovacs@gmail.com" },
                    { "3cc3ef7f-bc8e-461c-8271-4ac357cddd64", 0, "2b8d40af-2bee-4a7c-8b9d-c1c1ec010e8c", "SiteUser", null, false, "Júlia", "Horváth", false, null, null, "JULIAHORVATH@YAHOO.COM", "AQAAAAEAACcQAAAAEI5PoDcqIb4uuhGUgE8Waeg5jXn4gW8ol+6DjVqfzB9zYC1ZV6Zxit+0wC1n982/iA==", null, false, "a5874d0e-8a35-46de-9181-eb1d46527166", false, "juliahorvath@yahoo.com" },
                    { "4487b2cc-2e4a-4494-b8eb-8a448701e371", 0, "9fa87289-094a-423f-ad1c-f82c3d3e6193", "SiteUser", null, false, "Mariann", "Kiss", false, null, null, "MARIANNKISS@UNI-OBUDA.HU", "AQAAAAEAACcQAAAAENwjoctXHFwooobmNv+b+CMsF3QCnD1SL/tuRhrvqDobBDqfhJBCofu8sPwDWF77ow==", null, false, "cfd46591-b288-4c49-b016-46cae7a38a9e", false, "mariannkiss@uni-obuda.hu" },
                    { "88e6c8ee-bd0d-4a15-9b90-21514eccae4f", 0, "1680e943-4376-4958-a325-d18cc09d8035", "SiteUser", null, false, "Ferenc", "Kovács", false, null, null, "ISTVANTAKACS@GMAIL.COM", "AQAAAAEAACcQAAAAEJVFbz3LzBPTbeLlS3AwGL8KQqHAJFGYJzSISm2EyL2IokA+ezcbZEuPa+CORWrL7w==", null, false, "2c7c3f69-9c6b-4913-ba69-37846ec87fa7", false, "istvantakacs@gmail.com" },
                    { "cb2a61c1-3c9d-4b65-8f79-ccf91caa89a2", 0, "14fd4f0c-51fc-4851-8eee-2f4dccc3b265", "SiteUser", null, false, "József", "Kiss", false, null, null, "JOZSEFKISS@GMAIL.COM", "AQAAAAEAACcQAAAAELVzChkFXIXR1joIEFNMBw0GtXtPacDaDc22YB7uws0c8WVoeTSWsZWGCsMe25JZNA==", null, false, "4cb254b8-1f4f-4ece-bef8-8f303a724090", false, "jozsefkiss@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectCode", "CreditValue", "ExamSubject", "Name", "Semester" },
                values: new object[,]
                {
                    { "KGK666BUKO", 15, false, "Mikro- és makroökonómia", 1 },
                    { "NIXBE1PBNE", 3, true, "Beágyazott és érzékelőalapú rendszerek", 2 },
                    { "NIXMN1HBNE", 7, true, "Analízis 1", 1 },
                    { "NIXSF1HBNE", 7, true, "Szoftvertervezés és -fejlesztés 1.", 1 },
                    { "NIXSF2HBNE", 7, true, "Szoftvertervezés és -fejlesztés 2.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "SiteUserId", "SubjectCode", "Timestamp" },
                values: new object[,]
                {
                    { "138c5159-e3e0-4f06-a118-81062f1f1f61", "Határérték-számításban tud valaki segíteni?", 0, null, "88e6c8ee-bd0d-4a15-9b90-21514eccae4f", "NIXMN1HBNE", new DateTime(2022, 9, 7, 7, 45, 28, 0, DateTimeKind.Unspecified) },
                    { "31ed54bb-1fa5-430c-a965-06b65b7164ed", "Sziasztok! Tudtok valamit, hogy mi lesz a jövő heti zh-ban?", 0, null, "13dd7181-a74c-4baf-9574-85ab30a5f5e3", "KGK666BUKO", new DateTime(2022, 10, 23, 11, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "98d55237-599d-43e9-b3dd-33423c9344fc", "Kedves mindenki! Ugye tudják, hogy a zárthelyi dolgozatot kiválthatják beadandó dolgozat megírásával?\nDe akkor legfeljebb hármast tudok majd adni.", 0, null, "4487b2cc-2e4a-4494-b8eb-8a448701e371", "KGK666BUKO", new DateTime(2022, 10, 29, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "b59674e6-7b78-43ad-9c8e-7594be96410e", "Jövő héten lesz óra?", 0, null, "3cc3ef7f-bc8e-461c-8271-4ac357cddd64", "NIXBE1PBNE", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "dc78bd1e-80ce-4e0e-a03b-f91327b62378", "Hányat lehet hiányozni sztf laboron?", 0, null, "cb2a61c1-3c9d-4b65-8f79-ccf91caa89a2", "NIXMN1HBNE", new DateTime(2022, 10, 15, 11, 11, 22, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "PostId", "SiteUserId", "Timestamp" },
                values: new object[,]
                {
                    { "50590d26-0a29-4910-b985-3a322d343368", "Figyelj oda, hogy ez nem az sztf topik! Egyébként matekról meg progról is négy hiányzásnál letiltanak.", 0, null, "dc78bd1e-80ce-4e0e-a03b-f91327b62378", "13dd7181-a74c-4baf-9574-85ab30a5f5e3", new DateTime(2022, 10, 29, 8, 13, 28, 0, DateTimeKind.Unspecified) },
                    { "5f777676-f965-4267-9460-672b76c0f215", "Mondjuk nem is volt olyan rossz, 69% lett a zh-m^^", 0, null, "138c5159-e3e0-4f06-a118-81062f1f1f61", "88e6c8ee-bd0d-4a15-9b90-21514eccae4f", new DateTime(2022, 10, 20, 21, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "6e392491-71d4-418d-97cd-0c3f561ef5f3", "Ne szívass, akkor meg mit problémáztál szeptemberben? Én mehetek pótzh-ra...", 0, null, "138c5159-e3e0-4f06-a118-81062f1f1f61", "3cc3ef7f-bc8e-461c-8271-4ac357cddd64", new DateTime(2022, 10, 22, 11, 5, 33, 0, DateTimeKind.Unspecified) },
                    { "8b53c519-67f9-479e-881a-fae3704cbd60", "Nekem se megy, meg szerintem senkinek se, mindenkinek bukó lesz a zh:D", 0, null, "138c5159-e3e0-4f06-a118-81062f1f1f61", "3cc3ef7f-bc8e-461c-8271-4ac357cddd64", new DateTime(2022, 9, 10, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "ba6e3191-6817-4fcf-90ef-5d5045df9fc4", "Ne felejtse el, hogy én is látom, ne tegezzen mindenkit csak úgy.\nEgyébként tesztes kérdések lesznek, Marshall-keresztet mindenképp nézzék át!", 0, null, "31ed54bb-1fa5-430c-a965-06b65b7164ed", "4487b2cc-2e4a-4494-b8eb-8a448701e371", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SiteUserId",
                table: "Comments",
                column: "SiteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SiteUserId",
                table: "Posts",
                column: "SiteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SubjectCode",
                table: "Posts",
                column: "SubjectCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
