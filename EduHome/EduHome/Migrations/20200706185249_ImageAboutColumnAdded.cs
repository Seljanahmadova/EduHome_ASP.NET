using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class ImageAboutColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "CourseCategory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "CourseCategory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "CourseCategory");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "CourseCategory");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Course");
        }
    }
}
