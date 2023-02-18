using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBotDbProvider.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CachedTeachers",
                table: "CachedTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CachedGroups",
                table: "CachedGroups");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTask",
                table: "ChatTask",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdTeacherGuid",
                table: "CachedTeachers",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "CachedGroups",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdGroupGuid",
                table: "CachedGroups",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CachedTeachers",
                table: "CachedTeachers",
                column: "IdTeacherGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CachedGroups",
                table: "CachedGroups",
                column: "IdGroupGuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CachedTeachers",
                table: "CachedTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CachedGroups",
                table: "CachedGroups");

            migrationBuilder.DropColumn(
                name: "IdTeacherGuid",
                table: "CachedTeachers");

            migrationBuilder.DropColumn(
                name: "IdGroupGuid",
                table: "CachedGroups");

            migrationBuilder.AlterColumn<long>(
                name: "IdTask",
                table: "ChatTask",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "CachedGroups",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CachedTeachers",
                table: "CachedTeachers",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CachedGroups",
                table: "CachedGroups",
                column: "id");
        }
    }
}
