using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCUTY_ASP_2022231.Migrations
{
    public partial class seedsubject1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectCode", "CreditValue", "ExamSubject", "Name", "Semester" },
                values: new object[] { "NIXMN1HBNE", 7, true, "Analízis 1", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "NIXMN1HBNE");
        }
    }
}
