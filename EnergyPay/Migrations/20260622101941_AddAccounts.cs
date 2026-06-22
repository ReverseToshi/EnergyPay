using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyPay.Migrations
{
    /// <inheritdoc />
    public partial class AddAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Customers_CustomerId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Account_AccountId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Reading_Account_AccountId",
                table: "Reading");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "Accounts");

            migrationBuilder.RenameIndex(
                name: "IX_Account_CustomerId",
                table: "Accounts",
                newName: "IX_Accounts_CustomerId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Customers_CustomerId",
                table: "Accounts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Accounts_AccountId",
                table: "Payment",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reading_Accounts_AccountId",
                table: "Reading",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Customers_CustomerId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Accounts_AccountId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Reading_Accounts_AccountId",
                table: "Reading");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_CustomerId",
                table: "Account",
                newName: "IX_Account_CustomerId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Account",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Customers_CustomerId",
                table: "Account",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Account_AccountId",
                table: "Payment",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reading_Account_AccountId",
                table: "Reading",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
