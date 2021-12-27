using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NataliesCupcakeShop.Data.Migrations
{
    public partial class addLogin12242021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAdministrator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "loginId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    loginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAdministrator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.loginId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_loginId",
                table: "Users",
                column: "loginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Logins_loginId",
                table: "Users",
                column: "loginId",
                principalTable: "Logins",
                principalColumn: "loginId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Logins_loginId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Users_loginId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "loginId",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "isAdministrator",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
