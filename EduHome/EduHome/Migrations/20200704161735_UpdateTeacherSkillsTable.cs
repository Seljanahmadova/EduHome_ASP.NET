using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdateTeacherSkillsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkills_Teachers_TeachersId",
                table: "TeacherSkills");

            migrationBuilder.DropIndex(
                name: "IX_TeacherSkills_TeachersId",
                table: "TeacherSkills");

            migrationBuilder.DropColumn(
                name: "TeachersId",
                table: "TeacherSkills");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkills_TeacherId",
                table: "TeacherSkills",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.DropIndex(
                name: "IX_TeacherSkills_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.AddColumn<int>(
                name: "TeachersId",
                table: "TeacherSkills",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkills_TeachersId",
                table: "TeacherSkills",
                column: "TeachersId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkills_Teachers_TeachersId",
                table: "TeacherSkills",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
