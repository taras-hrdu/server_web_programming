using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppOrmEntity.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    IdBook = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.IdBook);
                });

            migrationBuilder.CreateTable(
                name: "Sages",
                columns: table => new
                {
                    IdSage = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Photo = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sages", x => x.IdSage);
                });

            migrationBuilder.CreateTable(
                name: "SageBooks",
                columns: table => new
                {
                    IdSageBook = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdSage = table.Column<int>(type: "INTEGER", nullable: false),
                    IdBook = table.Column<int>(type: "INTEGER", nullable: false),
                    SageIdSage = table.Column<int>(type: "INTEGER", nullable: false),
                    BookIdBook = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SageBooks", x => x.IdSageBook);
                    table.ForeignKey(
                        name: "FK_SageBooks_Books_BookIdBook",
                        column: x => x.BookIdBook,
                        principalTable: "Books",
                        principalColumn: "IdBook",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SageBooks_Sages_SageIdSage",
                        column: x => x.SageIdSage,
                        principalTable: "Sages",
                        principalColumn: "IdSage",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SageBooks_BookIdBook",
                table: "SageBooks",
                column: "BookIdBook");

            migrationBuilder.CreateIndex(
                name: "IX_SageBooks_SageIdSage",
                table: "SageBooks",
                column: "SageIdSage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SageBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Sages");
        }
    }
}
