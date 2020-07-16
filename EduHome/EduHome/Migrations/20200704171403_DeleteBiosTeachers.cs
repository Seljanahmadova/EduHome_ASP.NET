using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class DeleteBiosTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiosTeachers");

            migrationBuilder.DropColumn(
                name: "BiosTeacherId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Communication",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Design",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Development",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Innovation",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Skills");

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pinterest",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vimeo",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Pinterest",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Vimeo",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "BiosTeacherId",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Communication",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Design",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Development",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Innovation",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BiosTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    TeachersId = table.Column<int>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiosTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BiosTeachers_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiosTeachers_TeachersId",
                table: "BiosTeachers",
                column: "TeachersId");
        }
    }
}
