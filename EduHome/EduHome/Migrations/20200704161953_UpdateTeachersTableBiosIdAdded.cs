using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdateTeachersTableBiosIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BiosTeacherId",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeachersId",
                table: "BiosTeachers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BiosTeachers_TeachersId",
                table: "BiosTeachers",
                column: "TeachersId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiosTeachers_Teachers_TeachersId",
                table: "BiosTeachers",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BiosTeachers_Teachers_TeachersId",
                table: "BiosTeachers");

            migrationBuilder.DropIndex(
                name: "IX_BiosTeachers_TeachersId",
                table: "BiosTeachers");

            migrationBuilder.DropColumn(
                name: "BiosTeacherId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeachersId",
                table: "BiosTeachers");
        }
    }
}
