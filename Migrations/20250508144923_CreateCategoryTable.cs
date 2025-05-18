using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinictask.Migrations
{
    /// <inheritdoc />
    public partial class CreateCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "HealthCareSolutions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "HealthCareSolutions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
