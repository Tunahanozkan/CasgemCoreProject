using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzapan.DataAccessLayer.Migrations
{
    public partial class add_mig_referance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Referances",
                columns: table => new
                {
                    ReferanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferanceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferanceMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferancePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferanceComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referances", x => x.ReferanceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Referances");
        }
    }
}
