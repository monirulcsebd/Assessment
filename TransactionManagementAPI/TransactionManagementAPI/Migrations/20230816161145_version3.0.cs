using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransactionManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class version30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentAccountBalance",
                table: "client_transaction",
                newName: "InitialAccountBalance");

            migrationBuilder.AddColumn<string>(
                name: "DebitOrCredit",
                table: "client_transaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "client_transaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DebitOrCredit",
                table: "client_transaction");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "client_transaction");

            migrationBuilder.RenameColumn(
                name: "InitialAccountBalance",
                table: "client_transaction",
                newName: "CurrentAccountBalance");
        }
    }
}
