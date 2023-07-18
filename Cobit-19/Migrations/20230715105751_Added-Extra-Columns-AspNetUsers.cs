using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class AddedExtraColumnsAspNetUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomTag",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "9b769c01-22b3-42e7-a3a1-9f009c72f713");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eba5d039-6060-4b31-a0cb-8315deae5fef", "Daniel", "Coetzee", "AQAAAAEAACcQAAAAENoLOETxXwa8HmQCiRVOshcjjRX9xE4qlY/OZ4ERGoVqo/xfFuDkEwYirRLpwhIIMQ==", "3fb8a624-521c-4f7c-b6df-64c8069535b4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "CustomTag",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "aa7f815d-b0e9-4c02-b098-4358a7eccc24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "CustomTag", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80524b78-9b67-4946-972b-74983bb3cf19", "Custom", "AQAAAAEAACcQAAAAEIbVjpIDljxt2qH/PeRuphPO/x1nvRdeEcOAfugj2IH/UZ7z/eCFAomaMCUlYeKj/w==", "b4602869-29e5-4a4f-997c-dc61d3720698" });
        }
    }
}
