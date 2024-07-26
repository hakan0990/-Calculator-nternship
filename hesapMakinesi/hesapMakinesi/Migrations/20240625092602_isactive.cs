using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hesapMakinesi.Migrations
{
    /// <inheritdoc />
    public partial class isactive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Results",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Results");
        }
    }
}
