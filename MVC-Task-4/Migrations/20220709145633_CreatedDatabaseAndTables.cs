using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Task_4.Migrations
{
    public partial class CreatedDatabaseAndTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    About = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    FacebookIcon = table.Column<string>(nullable: true),
                    FacebookUrl = table.Column<string>(nullable: true),
                    PinterestIcon = table.Column<string>(nullable: true),
                    PinterestUrl = table.Column<string>(nullable: true),
                    VimeoIcon = table.Column<string>(nullable: true),
                    VimeoUrl = table.Column<string>(nullable: true),
                    TwitterIcon = table.Column<string>(nullable: true),
                    TwitterUrl = table.Column<string>(nullable: true),
                    ProfessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Percent = table.Column<string>(nullable: true),
                    CardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ProfessionId",
                table: "Cards",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CardId",
                table: "Skills",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Professions");
        }
    }
}
