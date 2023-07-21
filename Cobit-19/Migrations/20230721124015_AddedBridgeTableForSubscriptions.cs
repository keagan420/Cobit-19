using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class AddedBridgeTableForSubscriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    ApplicationUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FocusAreaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => new { x.ApplicationUserID, x.FocusAreaID });
                    table.ForeignKey(
                        name: "FK_Subscriptions_AspNetUsers_ApplicationUserID",
                        column: x => x.ApplicationUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_FocusAreas_FocusAreaID",
                        column: x => x.FocusAreaID,
                        principalTable: "FocusAreas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3be08902-fd96-4202-8865-88a4af33b1f1", "AQAAAAEAACcQAAAAEGUII5nUNIhJ69J1gqB5IE4AiF9xxIRe+swh1kWqIVFCorIyUjBdWkDJ4OEEIBHdGg==", "d87fbf63-d2a4-4dc4-83fd-3cd37acde55f" });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "ApplicationUserID", "FocusAreaID" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_FocusAreaID",
                table: "Subscriptions",
                column: "FocusAreaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "d3504dce-6861-4ba0-b9a2-4b155b85b38f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd026a10-874d-490d-8939-056280587113", "AQAAAAEAACcQAAAAECE+nHYGJkIhBvtUkCWgyKZQH5ZrCZ71b96cA7rJbviJJ9A3ugrLo91NDFSlmwP9cw==", "53f344f8-a258-479b-8cd7-c4658bf5e62b" });
        }
    }
}
