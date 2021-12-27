using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NataliesCupcakeShop.Data.Migrations
{
    public partial class updateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_orderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_productId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Products",
                newName: "productContractId");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "Orders",
                newName: "orderContractId");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "OrderItems",
                newName: "productContractId");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "OrderItems",
                newName: "orderContractId");

            migrationBuilder.RenameColumn(
                name: "orderItemId",
                table: "OrderItems",
                newName: "orderItemContractId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_productId",
                table: "OrderItems",
                newName: "IX_OrderItems_productContractId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_orderId",
                table: "OrderItems",
                newName: "IX_OrderItems_orderContractId");

            migrationBuilder.RenameColumn(
                name: "loginId",
                table: "Logins",
                newName: "loginContractId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "loginContractId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "storeUserContractId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_loginContractId",
                table: "AspNetUsers",
                column: "loginContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Logins_loginContractId",
                table: "AspNetUsers",
                column: "loginContractId",
                principalTable: "Logins",
                principalColumn: "loginContractId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_orderContractId",
                table: "OrderItems",
                column: "orderContractId",
                principalTable: "Orders",
                principalColumn: "orderContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_productContractId",
                table: "OrderItems",
                column: "productContractId",
                principalTable: "Products",
                principalColumn: "productContractId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Logins_loginContractId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_orderContractId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_productContractId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_loginContractId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "loginContractId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "storeUserContractId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "productContractId",
                table: "Products",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "orderContractId",
                table: "Orders",
                newName: "orderId");

            migrationBuilder.RenameColumn(
                name: "productContractId",
                table: "OrderItems",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "orderContractId",
                table: "OrderItems",
                newName: "orderId");

            migrationBuilder.RenameColumn(
                name: "orderItemContractId",
                table: "OrderItems",
                newName: "orderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_productContractId",
                table: "OrderItems",
                newName: "IX_OrderItems_productId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_orderContractId",
                table: "OrderItems",
                newName: "IX_OrderItems_orderId");

            migrationBuilder.RenameColumn(
                name: "loginContractId",
                table: "Logins",
                newName: "loginId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loginId = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_Users_Logins_loginId",
                        column: x => x.loginId,
                        principalTable: "Logins",
                        principalColumn: "loginId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_loginId",
                table: "Users",
                column: "loginId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_orderId",
                table: "OrderItems",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "orderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_productId",
                table: "OrderItems",
                column: "productId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
