using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyPay.Migrations
{
    /// <inheritdoc />
    public partial class FixAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Accounts_AccountId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Reading_Accounts_AccountId",
                table: "Reading");

            migrationBuilder.DropIndex(
                name: "IX_Reading_AccountId",
                table: "Reading");

            migrationBuilder.DropIndex(
                name: "IX_Payment_AccountId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "AccountId1",
                table: "Reading",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AccountId1",
                table: "Payment",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Reading_AccountId1",
                table: "Reading",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_AccountId1",
                table: "Payment",
                column: "AccountId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Accounts_AccountId1",
                table: "Payment",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reading_Accounts_AccountId1",
                table: "Reading",
                column: "AccountId1",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Accounts_AccountId1",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Reading_Accounts_AccountId1",
                table: "Reading");

            migrationBuilder.DropIndex(
                name: "IX_Reading_AccountId1",
                table: "Reading");

            migrationBuilder.DropIndex(
                name: "IX_Payment_AccountId1",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "AccountId1",
                table: "Reading");

            migrationBuilder.DropColumn(
                name: "AccountId1",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reading_AccountId",
                table: "Reading",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_AccountId",
                table: "Payment",
                column: "AccountId");

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
    }
}
