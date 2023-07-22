using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class TweakedUserSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "de7eca78-19e6-452c-91ba-513621f92b86");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2ef4e528-6c05-416b-8eef-a3bc1eebf946", "test@gmail.com", true, "TEST@GMAIL.COM", "AQAAAAEAACcQAAAAEG7gQC1BP7M3qgvKPdP21hUs86sgPF3SXABB9qC88sarJpX78fhzUk1MR8Hlrs+8EA==", "71e25299-3972-4e59-907b-7c19a3dd2735", "test@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "143d2ecf-dd8b-4897-a979-92a673ab280e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3be08902-fd96-4202-8865-88a4af33b1f1", null, false, "MYUSER", "AQAAAAEAACcQAAAAEGUII5nUNIhJ69J1gqB5IE4AiF9xxIRe+swh1kWqIVFCorIyUjBdWkDJ4OEEIBHdGg==", "d87fbf63-d2a4-4dc4-83fd-3cd37acde55f", "myuser" });
        }
    }
}
