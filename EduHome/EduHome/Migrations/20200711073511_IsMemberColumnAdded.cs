using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class IsMemberColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCourseAdmin",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsEventAdmin",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsTeacherAdmin",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsUser",
                table: "User");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMember",
                table: "User",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsMember",
                table: "User");

            migrationBuilder.AddColumn<byte>(
                name: "IsCourseAdmin",
                table: "User",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "IsEventAdmin",
                table: "User",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "IsTeacherAdmin",
                table: "User",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "IsUser",
                table: "User",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
