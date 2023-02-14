using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LessonsBotDbProvider.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bots",
                columns: table => new
                {
                    IdBot = table.Column<Guid>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    Timer = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bots", x => x.IdBot);
                });

            migrationBuilder.CreateTable(
                name: "CachedCabs",
                columns: table => new
                {
                    IdCab = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CachedGroups",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    currator = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CachedGroups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CachedTeachers",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CachedTeachers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "WordBooks",
                columns: table => new
                {
                    IdWord = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordBooks", x => x.IdWord);
                });

            migrationBuilder.CreateTable(
                name: "ChatTask",
                columns: table => new
                {
                    IdTask = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdChat = table.Column<long>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    BotIdBot = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatTask", x => x.IdTask);
                    table.ForeignKey(
                        name: "FK_ChatTask_Bots_BotIdBot",
                        column: x => x.BotIdBot,
                        principalTable: "Bots",
                        principalColumn: "IdBot");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatTask_BotIdBot",
                table: "ChatTask",
                column: "BotIdBot");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CachedCabs");

            migrationBuilder.DropTable(
                name: "CachedGroups");

            migrationBuilder.DropTable(
                name: "CachedTeachers");

            migrationBuilder.DropTable(
                name: "ChatTask");

            migrationBuilder.DropTable(
                name: "WordBooks");

            migrationBuilder.DropTable(
                name: "Bots");
        }
    }
}
