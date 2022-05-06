using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FAQs.Migrations
{
    public partial class AddQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "QuestionId", "Answer", "CategoryId", "QuestionName", "TopicId" },
                values: new object[] { 5, "A general purpose object oriented language that uses a concise, Java-like syntax.", "gen", "What is C#?", "csharp" });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "QuestionId", "Answer", "CategoryId", "QuestionName", "TopicId" },
                values: new object[] { 6, "A CSS framework for creating responsive web apps for multiple screen sizes.", "gen", "What is Bootstrap?", "boot" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
