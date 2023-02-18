using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBotDbProvider.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Question",
                table: "WordBooks",
                newName: "Questions");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "WordBooks",
                newName: "Answers");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdWord",
                table: "WordBooks",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Questions",
                table: "WordBooks",
                newName: "Question");

            migrationBuilder.RenameColumn(
                name: "Answers",
                table: "WordBooks",
                newName: "Answer");

            migrationBuilder.AlterColumn<long>(
                name: "IdWord",
                table: "WordBooks",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
