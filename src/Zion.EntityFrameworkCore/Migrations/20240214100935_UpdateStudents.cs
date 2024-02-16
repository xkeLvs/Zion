using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zion.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "AppStudents",
                newName: "BirthDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "AppStudents",
                newName: "Birthdate");
        }
    }
}
