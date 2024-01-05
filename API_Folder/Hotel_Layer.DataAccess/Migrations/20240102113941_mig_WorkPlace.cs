using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Layer.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_WorkPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkDepartment",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "WorkPlaceID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkPlaces",
                columns: table => new
                {
                    WorkPlaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkPlaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkPlaceCity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlaces", x => x.WorkPlaceID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WorkPlaceID",
                table: "AspNetUsers",
                column: "WorkPlaceID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkPlaces_WorkPlaceID",
                table: "AspNetUsers",
                column: "WorkPlaceID",
                principalTable: "WorkPlaces",
                principalColumn: "WorkPlaceID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkPlaces_WorkPlaceID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WorkPlaces");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WorkPlaceID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkDepartment",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkPlaceID",
                table: "AspNetUsers");
        }
    }
}
