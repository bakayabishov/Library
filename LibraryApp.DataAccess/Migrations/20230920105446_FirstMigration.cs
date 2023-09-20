using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "partitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    role = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    is_manager = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    PartitionId = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    given_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 20, 16, 54, 46, 246, DateTimeKind.Local).AddTicks(6419)),
                    is_expired = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                    table.ForeignKey(
                        name: "FK_books_authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_partitions_PartitionId",
                        column: x => x.PartitionId,
                        principalTable: "partitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Джуан Роулинг" },
                    { 2, "Агата Кристи" },
                    { 3, "Толстой А.Н." },
                    { 4, "Пётр Ершов" },
                    { 6, "Роберт Мартин" },
                    { 7, "Васильев А." },
                    { 8, "Геворкян П.С." },
                    { 9, "Аллен Дауни" },
                    { 10, "Заур Трегулов" }
                });

            migrationBuilder.InsertData(
                table: "partitions",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { 1, "Фантастика" },
                    { 2, "Детективы" },
                    { 3, "Детские" },
                    { 4, "Учебный материал" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "is_manager", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, false, "Администратор", "Admin", "Administrator" },
                    { 2, false, "Менеджер", "Manager", "Manager" },
                    { 3, false, "Читатель", "Reader", "User" },
                    { 4, false, "Администратор2", "Admin", "Administrator" },
                    { 5, false, "Менеджер2", "Manager", "Manager" },
                    { 6, false, "Читатель2", "Reader", "User" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "AuthorId", "name", "PartitionId", "status" },
                values: new object[,]
                {
                    { 1, 1, "Гарри Поттер и философский камень", 1, 0 },
                    { 2, 1, "Гарри Поттер и тайная комната", 1, 0 },
                    { 3, 1, "Гарри Поттер и принц полукровка", 1, 0 },
                    { 4, 1, "Гарри Поттер и орден феникса", 1, 0 },
                    { 5, 1, "Гарри Поттер и дары смерти", 1, 0 },
                    { 6, 2, "Убийство в восточном экспрессе", 2, 0 },
                    { 7, 2, "Убийство на Ниле", 2, 0 },
                    { 8, 2, "Призрак Венеции", 2, 0 },
                    { 9, 3, "Колобок", 3, 0 },
                    { 10, 4, "Конек горбунок", 3, 0 },
                    { 11, 3, "Гуси-Лебеди", 3, 0 },
                    { 12, 6, "Чистая архитектура", 4, 0 },
                    { 13, 7, "Самоучитель по c#", 4, 0 },
                    { 14, 8, "Высшая матиматика", 4, 0 },
                    { 15, 9, "Основы Python", 4, 0 },
                    { 16, 10, "SQL для начинающих с нуля до сертификата Oracle", 4, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_AuthorId",
                table: "books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_books_PartitionId",
                table: "books",
                column: "PartitionId");

            migrationBuilder.CreateIndex(
                name: "IX_books_user_id",
                table: "books",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "partitions");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
