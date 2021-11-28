using Microsoft.EntityFrameworkCore.Migrations;

namespace MysqlEFCoreDemo.Migrations
{
    public partial class FixTinyIntLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Age",
                table: "Person",
                type: "tinyint(3)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Age",
                table: "Person",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint(3)");
        }
    }
}
