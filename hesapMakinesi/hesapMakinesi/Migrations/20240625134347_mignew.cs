using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hesapMakinesi.Migrations
{
    /// <inheritdoc />
    public partial class mignew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "numerusordo2",
                table: "Results",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numerusordo2",
                table: "Results");
        }
    }
}
