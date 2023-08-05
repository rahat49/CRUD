using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDwithAngular.Migrations
{
    public partial class st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "stname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stname",
                table: "Students",
                newName: "Name");
        }
    }
}
