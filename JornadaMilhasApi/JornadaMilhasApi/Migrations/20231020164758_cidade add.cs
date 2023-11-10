using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JornadaMilhasApi.Migrations
{
    /// <inheritdoc />
    public partial class cidadeadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Users",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Users");
        }
    }
}
