using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinictask.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "HealthCareSolutions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "HealthCareSolutions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareSolutions_CategoryId",
                table: "HealthCareSolutions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareSolutions_Category_CategoryId",
                table: "HealthCareSolutions",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);   
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareSolutions_Category_CategoryId",
                table: "HealthCareSolutions");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_HealthCareSolutions_CategoryId",
                table: "HealthCareSolutions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "HealthCareSolutions");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "HealthCareSolutions");
        }
    }
}
