using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingSearch.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BATCH_NO = table.Column<string>(type: "TEXT", nullable: true),
                    CAD_ZONE = table.Column<string>(type: "TEXT", nullable: true),
                    PLOT_NO = table.Column<string>(type: "TEXT", nullable: true),
                    FILE_NUMBER = table.Column<string>(type: "TEXT", nullable: true),
                    DEVELOPER_S_NAME = table.Column<string>(type: "TEXT", nullable: true),
                    DATE = table.Column<string>(type: "TEXT", nullable: true),
                    DATE_RETURNED = table.Column<string>(type: "TEXT", nullable: true),
                    ORIGINAL_FILE_LOCATION = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}
