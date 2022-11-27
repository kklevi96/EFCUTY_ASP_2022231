using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCUTY_ASP_2022231.Migrations
{
    public partial class final1 : Migration
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
                    { "51cef7a3-e765-48f6-bdce-c5fbee809bbc", 0, "e0a21c50-b0ad-4832-b627-bd08f62cd9a0", "SiteUser", null, false, "József", "Kiss", false, null, null, "JOZSEFKISS@GMAIL.COM", "AQAAAAEAACcQAAAAEPC4swraI2T+gxPc/MfSnGHVLW6NYYofhOxvvmo6ckpAEQ3faPsvATxpbZXOjcmeMQ==", null, false, "163d79bc-6b87-437c-b3ab-b8483596bba4", false, "jozsefkiss@gmail.com" },
                    { "7a23fd68-0620-4753-a50d-81891f39cf0f", 0, "4ec8fdea-82de-4029-b45b-39a06211e4e5", "SiteUser", null, false, "Mariann", "Kiss", false, null, null, "MARIANNKISS@UNI-OBUDA.HU", "AQAAAAEAACcQAAAAEN3erYHmTeK7ak2GKZ/D3Z1jC2mY1zqA9pBmKk4Z76Ho7u4oMr1YQ8wY/KHtFkcIPQ==", null, false, "090fa46f-4e48-4ab5-93ca-278c4da8bff1", false, "mariannkiss@uni-obuda.hu" },
                    { "7af33723-cc8a-4c91-8a5b-2f19530bf0fd", 0, "d7eebd00-17ed-4a97-b485-86ab81ccd96b", "SiteUser", null, false, "Béla", "Kovács", false, null, null, "BELA.KOVACS@GMAIL.COM", "AQAAAAEAACcQAAAAEP6PQpo+ALUJf3Hzc0cRYs7Ki6JalRa9a8l1wE89ix/LwSOLu5FjtaXanDjTsXJ7aA==", null, false, "1f81f5c2-6472-49ad-8320-47737140e872", false, "bela.kovacs@gmail.com" },
                    { "7c35c9be-b060-404c-b9ad-aa4914fcdf80", 0, "63556cf8-0f92-43f1-8173-d78fd0129c62", "SiteUser", null, false, "Ferenc", "Kovács", false, null, null, "ISTVANTAKACS@GMAIL.COM", "AQAAAAEAACcQAAAAEPk877ggs1i+GRKwIpwFAbU3KMpRlJX8mfbLK863Yc4jV7+udaESqkGQeoYP+gRQ2A==", null, false, "60154dca-d04c-4d46-89fc-e8d6d5f316e3", false, "istvantakacs@gmail.com" },
                    { "a280b392-10cd-4cfd-9dd5-777305c71183", 0, "27a22e23-3705-49de-a419-780bdddbdff8", "SiteUser", null, false, "Júlia", "Horváth", false, null, null, "JULIAHORVATH@YAHOO.COM", "AQAAAAEAACcQAAAAELUNBtYwKJv8cFvWGbzzmik+SdoaW5FJgzchrZfVli7diCtOgftlckQ6n2LiQhG67g==", null, false, "fd39bcec-de8c-4560-af90-cdb4673ce966", false, "juliahorvath@yahoo.com" }
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
                    { "32b811a2-a454-4daa-a9c4-e7744ef014e8", "Jövő héten lesz óra?", 0, null, "a280b392-10cd-4cfd-9dd5-777305c71183", "NIXBE1PBNE", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "552378cf-6279-4afd-9b30-95812ab56c92", "Határérték-számításban tud valaki segíteni?", 0, null, "7c35c9be-b060-404c-b9ad-aa4914fcdf80", "NIXMN1HBNE", new DateTime(2022, 9, 7, 7, 45, 28, 0, DateTimeKind.Unspecified) },
                    { "7d98431a-6854-43d1-a6c9-fcd48e59d3bd", "Sziasztok! Tudtok valamit, hogy mi lesz a jövő heti zh-ban?", 0, null, "7af33723-cc8a-4c91-8a5b-2f19530bf0fd", "KGK666BUKO", new DateTime(2022, 10, 23, 11, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "dcda1525-515a-4b0e-b95d-522f05d1d3f5", "Hányat lehet hiányozni sztf laboron?", 0, null, "51cef7a3-e765-48f6-bdce-c5fbee809bbc", "NIXMN1HBNE", new DateTime(2022, 10, 15, 11, 11, 22, 0, DateTimeKind.Unspecified) },
                    { "fd7395d8-607d-41ac-aaf2-58fd0c2ddb71", "Kedves mindenki! Ugye tudják, hogy a zárthelyi dolgozatot kiválthatják beadandó dolgozat megírásával?\nDe akkor legfeljebb hármast tudok majd adni.", 0, null, "7a23fd68-0620-4753-a50d-81891f39cf0f", "KGK666BUKO", new DateTime(2022, 10, 29, 8, 15, 28, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "EditCount", "LastEdited", "PostId", "SiteUserId", "Timestamp" },
                values: new object[,]
                {
                    { "4b79d0f1-3d54-4533-b46c-e509da4b4505", "Nekem se megy, meg szerintem senkinek se, mindenkinek bukó lesz a zh:D", 0, null, "552378cf-6279-4afd-9b30-95812ab56c92", "a280b392-10cd-4cfd-9dd5-777305c71183", new DateTime(2022, 9, 10, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "76b4bf9d-ad2b-477c-a597-ee29f3b2932b", "Ne szívass, akkor meg mit problémáztál szeptemberben? Én mehetek pótzh-ra...", 0, null, "552378cf-6279-4afd-9b30-95812ab56c92", "a280b392-10cd-4cfd-9dd5-777305c71183", new DateTime(2022, 10, 22, 11, 5, 33, 0, DateTimeKind.Unspecified) },
                    { "ac1976ff-f9df-485a-90cb-208ba26914b5", "Figyelj oda, hogy ez nem az sztf topik! Egyébként matekról meg progról is négy hiányzásnál letiltanak.", 0, null, "dcda1525-515a-4b0e-b95d-522f05d1d3f5", "7af33723-cc8a-4c91-8a5b-2f19530bf0fd", new DateTime(2022, 10, 29, 8, 13, 28, 0, DateTimeKind.Unspecified) },
                    { "e5edb05f-d8b8-4c3b-a393-153bc324dc21", "Ne felejtse el, hogy én is látom, ne tegezzen mindenkit csak úgy.\nEgyébként tesztes kérdések lesznek, Marshall-keresztet mindenképp nézzék át!", 0, null, "7d98431a-6854-43d1-a6c9-fcd48e59d3bd", "7a23fd68-0620-4753-a50d-81891f39cf0f", new DateTime(2022, 10, 28, 8, 15, 28, 0, DateTimeKind.Unspecified) },
                    { "fb261b19-bfb6-4064-8a00-72bd010acf84", "Mondjuk nem is volt olyan rossz, 69% lett a zh-m^^", 0, null, "552378cf-6279-4afd-9b30-95812ab56c92", "7c35c9be-b060-404c-b9ad-aa4914fcdf80", new DateTime(2022, 10, 20, 21, 15, 28, 0, DateTimeKind.Unspecified) }
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
