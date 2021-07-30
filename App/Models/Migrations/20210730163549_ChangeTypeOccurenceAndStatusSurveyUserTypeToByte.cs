using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ChangeTypeOccurenceAndStatusSurveyUserTypeToByte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "UserType",
                table: "Users",
                type: "tinyint",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Surveys",
                type: "tinyint",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<byte>(
                name: "Type",
                table: "Occurrences",
                type: "tinyint",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserType",
                table: "Users",
                type: "int",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Surveys",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Occurrences",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 100);
        }
    }
}
