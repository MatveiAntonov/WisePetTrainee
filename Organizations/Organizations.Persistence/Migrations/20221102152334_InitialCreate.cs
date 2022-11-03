using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Organizations.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City_Id = table.Column<short>(type: "smallint", nullable: false),
                    Street_Id = table.Column<short>(type: "smallint", nullable: false),
                    House_Number = table.Column<short>(type: "smallint", nullable: true),
                    Flat_Number = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "chain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", nullable: false),
                    Chain_Id = table.Column<int>(type: "int", nullable: true),
                    Feedback_Id = table.Column<int>(type: "int", nullable: true),
                    Image_Id = table.Column<short>(type: "smallint", nullable: true),
                    Organization_Category_Id = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organization_category",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organization_category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organization_contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organization_Id = table.Column<int>(type: "int", nullable: false),
                    Organization_Address_Id = table.Column<int>(type: "int", nullable: true),
                    Organization_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organization_contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "street",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_street", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "chain");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "organization");

            migrationBuilder.DropTable(
                name: "organization_category");

            migrationBuilder.DropTable(
                name: "organization_contact");

            migrationBuilder.DropTable(
                name: "street");
        }
    }
}
