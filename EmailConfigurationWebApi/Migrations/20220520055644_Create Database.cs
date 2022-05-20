using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailConfigurationWebApi.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailConfigures",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmailName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    WatchedFolder = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    StoreAttachment = table.Column<bool>(type: "INTEGER", nullable: false),
                    ProviderType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfigures", x => x.EmailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailConfigures");
        }
    }
}
