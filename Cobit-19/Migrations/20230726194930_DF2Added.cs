using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DF2Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DesignFactors",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "874cf5a9-a28b-4921-ae04-20d5a9e8e878");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a47231e-f6de-4ac3-91ab-a77252cd98ad", "AQAAAAEAACcQAAAAEBbqINIpcIqH7CpSnIbq61vpX73z9aemFtcwk83wDHQ66q0yP+rtgFLkIHCMB4Fe4w==", "3c5d5a29-206c-4a52-8b46-d26a23328c1a" });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "ObjectiveID", "QuestionID", "Weight" },
                values: new object[,]
                {
                    { 1, 5, 4f },
                    { 1, 6, 4f },
                    { 1, 7, 4f },
                    { 1, 8, 0f },
                    { 1, 9, 4f },
                    { 1, 10, 1f },
                    { 1, 11, 0f },
                    { 1, 12, 3f },
                    { 1, 13, 2f },
                    { 1, 14, 1f },
                    { 1, 15, 3f },
                    { 1, 16, 6f },
                    { 1, 17, 1f },
                    { 2, 5, 10f },
                    { 2, 6, 0f },
                    { 2, 7, 0f },
                    { 2, 8, 0f },
                    { 2, 9, 6f },
                    { 2, 10, 1f },
                    { 2, 11, 0f },
                    { 2, 12, 5f },
                    { 2, 13, 2f },
                    { 2, 14, 1f },
                    { 2, 15, 0f },
                    { 2, 16, 9f },
                    { 2, 17, 4f },
                    { 3, 5, 0f },
                    { 3, 6, 8f },
                    { 3, 7, 4f },
                    { 3, 8, 0f },
                    { 3, 9, 0f },
                    { 3, 10, 6f },
                    { 3, 11, 0f },
                    { 3, 12, 0f },
                    { 3, 13, 0f },
                    { 3, 14, 0f },
                    { 3, 15, 3f },
                    { 3, 16, 0f },
                    { 3, 17, 0f },
                    { 4, 5, 11f },
                    { 4, 6, 0f },
                    { 4, 7, 0f },
                    { 4, 8, 0f },
                    { 4, 9, 7f },
                    { 4, 10, 1f },
                    { 4, 11, 0f },
                    { 4, 12, 6f },
                    { 4, 13, 3f },
                    { 4, 14, 1f },
                    { 4, 15, 0f },
                    { 4, 16, 10f },
                    { 4, 17, 4f },
                    { 5, 5, 0f },
                    { 5, 6, 1f },
                    { 5, 7, 2f },
                    { 5, 8, 6f },
                    { 5, 9, 0f },
                    { 5, 10, 0f },
                    { 5, 11, 6f },
                    { 5, 12, 0f },
                    { 5, 13, 4f },
                    { 5, 14, 0f },
                    { 5, 15, 2f },
                    { 5, 16, 0f },
                    { 5, 17, 0f },
                    { 6, 5, 8f },
                    { 6, 6, 6f },
                    { 6, 7, 6f },
                    { 6, 8, 2f },
                    { 6, 9, 6f },
                    { 6, 10, 4f },
                    { 6, 11, 2f },
                    { 6, 12, 5f },
                    { 6, 13, 4f },
                    { 6, 14, 1f },
                    { 6, 15, 5f },
                    { 6, 16, 9f },
                    { 6, 17, 2f },
                    { 7, 5, 11f },
                    { 7, 6, 0f },
                    { 7, 7, 0f },
                    { 7, 8, 0f },
                    { 7, 9, 8f },
                    { 7, 10, 1f },
                    { 7, 11, 0f },
                    { 7, 12, 5f },
                    { 7, 13, 1f },
                    { 7, 14, 4f },
                    { 7, 15, 0f },
                    { 7, 16, 9f },
                    { 7, 17, 5f },
                    { 8, 5, 11f },
                    { 8, 6, 1f },
                    { 8, 7, 0f },
                    { 8, 8, 0f },
                    { 8, 9, 8f },
                    { 8, 10, 3f },
                    { 8, 11, 0f },
                    { 8, 12, 6f },
                    { 8, 13, 1f },
                    { 8, 14, 2f },
                    { 8, 15, 0f },
                    { 8, 16, 9f },
                    { 8, 17, 4f },
                    { 9, 5, 11f },
                    { 9, 6, 0f },
                    { 9, 7, 0f },
                    { 9, 8, 0f },
                    { 9, 9, 6f },
                    { 9, 10, 0f },
                    { 9, 11, 0f },
                    { 9, 12, 4f },
                    { 9, 13, 1f },
                    { 9, 14, 3f },
                    { 9, 15, 0f },
                    { 9, 16, 8f },
                    { 9, 17, 7f },
                    { 10, 5, 12f },
                    { 10, 6, 0f },
                    { 10, 7, 0f },
                    { 10, 8, 0f },
                    { 10, 9, 8f },
                    { 10, 10, 2f },
                    { 10, 11, 0f },
                    { 10, 12, 7f },
                    { 10, 13, 3f },
                    { 10, 14, 1f },
                    { 10, 15, 0f },
                    { 10, 16, 11f },
                    { 10, 17, 3f },
                    { 11, 5, 5f },
                    { 11, 6, 0f },
                    { 11, 7, 0f },
                    { 11, 8, 6f },
                    { 11, 9, 3f },
                    { 11, 10, 0f },
                    { 11, 11, 6f },
                    { 11, 12, 3f },
                    { 11, 13, 8f },
                    { 11, 14, 0f },
                    { 11, 15, 0f },
                    { 11, 16, 6f },
                    { 11, 17, 2f },
                    { 12, 5, 9f },
                    { 12, 6, 0f },
                    { 12, 7, 0f },
                    { 12, 8, 0f },
                    { 12, 9, 5f },
                    { 12, 10, 1f },
                    { 12, 11, 0f },
                    { 12, 12, 3f },
                    { 12, 13, 2f },
                    { 12, 14, 4f },
                    { 12, 15, 0f },
                    { 12, 16, 7f },
                    { 12, 17, 5f },
                    { 13, 5, 17f },
                    { 13, 6, 0f },
                    { 13, 7, 0f },
                    { 13, 8, 0f },
                    { 13, 9, 10f },
                    { 13, 10, 2f },
                    { 13, 11, 0f },
                    { 13, 12, 7f },
                    { 13, 13, 2f },
                    { 13, 14, 5f },
                    { 13, 15, 0f },
                    { 13, 16, 12f },
                    { 13, 17, 8f },
                    { 14, 5, 6f },
                    { 14, 6, 0f },
                    { 14, 7, 0f },
                    { 14, 8, 0f },
                    { 14, 9, 4f },
                    { 14, 10, 2f },
                    { 14, 11, 0f },
                    { 14, 12, 3f },
                    { 14, 13, 0f },
                    { 14, 14, 1f },
                    { 14, 15, 0f },
                    { 14, 16, 4f },
                    { 14, 17, 1f },
                    { 15, 5, 8f },
                    { 15, 6, 0f },
                    { 15, 7, 0f },
                    { 15, 8, 0f },
                    { 15, 9, 4f },
                    { 15, 10, 2f },
                    { 15, 11, 0f },
                    { 15, 12, 4f },
                    { 15, 13, 1f },
                    { 15, 14, 0f },
                    { 15, 15, 0f },
                    { 15, 16, 5f },
                    { 15, 17, 2f },
                    { 16, 5, 7f },
                    { 16, 6, 0f },
                    { 16, 7, 0f },
                    { 16, 8, 6f },
                    { 16, 9, 4f },
                    { 16, 10, 1f },
                    { 16, 11, 6f },
                    { 16, 12, 4f },
                    { 16, 13, 7f },
                    { 16, 14, 0f },
                    { 16, 15, 0f },
                    { 16, 16, 7f },
                    { 16, 17, 2f },
                    { 17, 5, 0f },
                    { 17, 6, 6f },
                    { 17, 7, 0f },
                    { 17, 8, 0f },
                    { 17, 9, 0f },
                    { 17, 10, 6f },
                    { 17, 11, 0f },
                    { 17, 12, 0f },
                    { 17, 13, 0f },
                    { 17, 14, 0f },
                    { 17, 15, 0f },
                    { 17, 16, 0f },
                    { 17, 17, 0f },
                    { 18, 5, 0f },
                    { 18, 6, 5f },
                    { 18, 7, 2f },
                    { 18, 8, 0f },
                    { 18, 9, 0f },
                    { 18, 10, 5f },
                    { 18, 11, 0f },
                    { 18, 12, 0f },
                    { 18, 13, 0f },
                    { 18, 14, 0f },
                    { 18, 15, 1f },
                    { 18, 16, 0f },
                    { 18, 17, 0f },
                    { 19, 5, 0f },
                    { 19, 6, 4f },
                    { 19, 7, 2f },
                    { 19, 8, 6f },
                    { 19, 9, 0f },
                    { 19, 10, 3f },
                    { 19, 11, 6f },
                    { 19, 12, 0f },
                    { 19, 13, 4f },
                    { 19, 14, 0f },
                    { 19, 15, 1f },
                    { 19, 16, 0f },
                    { 19, 17, 0f },
                    { 20, 5, 10f },
                    { 20, 6, 0f },
                    { 20, 7, 0f },
                    { 20, 8, 0f },
                    { 20, 9, 7f },
                    { 20, 10, 0f },
                    { 20, 11, 0f },
                    { 20, 12, 6f },
                    { 20, 13, 4f },
                    { 20, 14, 1f },
                    { 20, 15, 0f },
                    { 20, 16, 11f },
                    { 20, 17, 4f },
                    { 21, 5, 15f },
                    { 21, 6, 0f },
                    { 21, 7, 0f },
                    { 21, 8, 0f },
                    { 21, 9, 10f },
                    { 21, 10, 2f },
                    { 21, 11, 0f },
                    { 21, 12, 8f },
                    { 21, 13, 3f },
                    { 21, 14, 3f },
                    { 21, 15, 0f },
                    { 21, 16, 12f },
                    { 21, 17, 5f },
                    { 22, 5, 15f },
                    { 22, 6, 0f },
                    { 22, 7, 0f },
                    { 22, 8, 0f },
                    { 22, 9, 9f },
                    { 22, 10, 2f },
                    { 22, 11, 0f },
                    { 22, 12, 8f },
                    { 22, 13, 3f },
                    { 22, 14, 1f },
                    { 22, 15, 0f },
                    { 22, 16, 12f },
                    { 22, 17, 5f },
                    { 23, 5, 6f },
                    { 23, 6, 1f },
                    { 23, 7, 0f },
                    { 23, 8, 0f },
                    { 23, 9, 3f },
                    { 23, 10, 4f },
                    { 23, 11, 0f },
                    { 23, 12, 3f },
                    { 23, 13, 1f },
                    { 23, 14, 0f },
                    { 23, 15, 0f },
                    { 23, 16, 4f },
                    { 23, 17, 1f },
                    { 24, 5, 14f },
                    { 24, 6, 0f },
                    { 24, 7, 0f },
                    { 24, 8, 0f },
                    { 24, 9, 11f },
                    { 24, 10, 1f },
                    { 24, 11, 0f },
                    { 24, 12, 8f },
                    { 24, 13, 4f },
                    { 24, 14, 4f },
                    { 24, 15, 0f },
                    { 24, 16, 14f },
                    { 24, 17, 5f },
                    { 25, 5, 8f },
                    { 25, 6, 2f },
                    { 25, 7, 0f },
                    { 25, 8, 0f },
                    { 25, 9, 5f },
                    { 25, 10, 2f },
                    { 25, 11, 0f },
                    { 25, 12, 4f },
                    { 25, 13, 0f },
                    { 25, 14, 1f },
                    { 25, 15, 0f },
                    { 25, 16, 5f },
                    { 25, 17, 3f },
                    { 26, 5, 6f },
                    { 26, 6, 2f },
                    { 26, 7, 0f },
                    { 26, 8, 0f },
                    { 26, 9, 3f },
                    { 26, 10, 1f },
                    { 26, 11, 0f },
                    { 26, 12, 3f },
                    { 26, 13, 1f },
                    { 26, 14, 0f },
                    { 26, 15, 0f },
                    { 26, 16, 4f },
                    { 26, 17, 3f },
                    { 27, 5, 11f },
                    { 27, 6, 0f },
                    { 27, 7, 0f },
                    { 27, 8, 0f },
                    { 27, 9, 7f },
                    { 27, 10, 0f },
                    { 27, 11, 0f },
                    { 27, 12, 4f },
                    { 27, 13, 2f },
                    { 27, 14, 5f },
                    { 27, 15, 0f },
                    { 27, 16, 9f },
                    { 27, 17, 7f },
                    { 28, 5, 0f },
                    { 28, 6, 0f },
                    { 28, 7, 0f },
                    { 28, 8, 6f },
                    { 28, 9, 0f },
                    { 28, 10, 0f },
                    { 28, 11, 6f },
                    { 28, 12, 0f },
                    { 28, 13, 5f },
                    { 28, 14, 0f },
                    { 28, 15, 0f },
                    { 28, 16, 0f },
                    { 28, 17, 0f },
                    { 29, 5, 2f },
                    { 29, 6, 0f },
                    { 29, 7, 0f },
                    { 29, 8, 0f },
                    { 29, 9, 1f },
                    { 29, 10, 1f },
                    { 29, 11, 0f },
                    { 29, 12, 1f },
                    { 29, 13, 0f },
                    { 29, 14, 0f },
                    { 29, 15, 0f },
                    { 29, 16, 1f },
                    { 29, 17, 0f },
                    { 30, 5, 12f },
                    { 30, 6, 0f },
                    { 30, 7, 0f },
                    { 30, 8, 0f },
                    { 30, 9, 7f },
                    { 30, 10, 1f },
                    { 30, 11, 0f },
                    { 30, 12, 7f },
                    { 30, 13, 4f },
                    { 30, 14, 0f },
                    { 30, 15, 0f },
                    { 30, 16, 11f },
                    { 30, 17, 4f },
                    { 31, 5, 6f },
                    { 31, 6, 0f },
                    { 31, 7, 0f },
                    { 31, 8, 0f },
                    { 31, 9, 4f },
                    { 31, 10, 2f },
                    { 31, 11, 0f },
                    { 31, 12, 3f },
                    { 31, 13, 0f },
                    { 31, 14, 1f },
                    { 31, 15, 0f },
                    { 31, 16, 4f },
                    { 31, 17, 1f },
                    { 32, 5, 4f },
                    { 32, 6, 3f },
                    { 32, 7, 0f },
                    { 32, 8, 0f },
                    { 32, 9, 2f },
                    { 32, 10, 5f },
                    { 32, 11, 0f },
                    { 32, 12, 2f },
                    { 32, 13, 0f },
                    { 32, 14, 0f },
                    { 32, 15, 0f },
                    { 32, 16, 2f },
                    { 32, 17, 0f },
                    { 33, 5, 4f },
                    { 33, 6, 3f },
                    { 33, 7, 0f },
                    { 33, 8, 0f },
                    { 33, 9, 2f },
                    { 33, 10, 5f },
                    { 33, 11, 0f },
                    { 33, 12, 2f },
                    { 33, 13, 0f },
                    { 33, 14, 0f },
                    { 33, 15, 0f },
                    { 33, 16, 2f },
                    { 33, 17, 0f },
                    { 34, 5, 4f },
                    { 34, 6, 3f },
                    { 34, 7, 0f },
                    { 34, 8, 0f },
                    { 34, 9, 2f },
                    { 34, 10, 5f },
                    { 34, 11, 0f },
                    { 34, 12, 2f },
                    { 34, 13, 0f },
                    { 34, 14, 0f },
                    { 34, 15, 0f },
                    { 34, 16, 2f },
                    { 34, 17, 0f },
                    { 35, 5, 2f },
                    { 35, 6, 8f },
                    { 35, 7, 4f },
                    { 35, 8, 0f },
                    { 35, 9, 1f },
                    { 35, 10, 7f },
                    { 35, 11, 0f },
                    { 35, 12, 1f },
                    { 35, 13, 0f },
                    { 35, 14, 0f },
                    { 35, 15, 3f },
                    { 35, 16, 1f },
                    { 35, 17, 0f },
                    { 36, 5, 6f },
                    { 36, 6, 4f },
                    { 36, 7, 2f },
                    { 36, 8, 0f },
                    { 36, 9, 5f },
                    { 36, 10, 4f },
                    { 36, 11, 0f },
                    { 36, 12, 3f },
                    { 36, 13, 0f },
                    { 36, 14, 2f },
                    { 36, 15, 2f },
                    { 36, 16, 5f },
                    { 36, 17, 2f },
                    { 37, 5, 7f },
                    { 37, 6, 2f },
                    { 37, 7, 4f },
                    { 37, 8, 4f },
                    { 37, 9, 4f },
                    { 37, 10, 2f },
                    { 37, 11, 4f },
                    { 37, 12, 4f },
                    { 37, 13, 4f },
                    { 37, 14, 0f },
                    { 37, 15, 3f },
                    { 37, 16, 6f },
                    { 37, 17, 1f },
                    { 38, 5, 4f },
                    { 38, 6, 6f },
                    { 38, 7, 6f },
                    { 38, 8, 4f },
                    { 38, 9, 2f },
                    { 38, 10, 4f },
                    { 38, 11, 4f },
                    { 38, 12, 2f },
                    { 38, 13, 4f },
                    { 38, 14, 0f },
                    { 38, 15, 5f },
                    { 38, 16, 3f },
                    { 38, 17, 1f },
                    { 39, 5, 0f },
                    { 39, 6, 3f },
                    { 39, 7, 6f },
                    { 39, 8, 0f },
                    { 39, 9, 0f },
                    { 39, 10, 0f },
                    { 39, 11, 0f },
                    { 39, 12, 0f },
                    { 39, 13, 0f },
                    { 39, 14, 0f },
                    { 39, 15, 4f },
                    { 39, 16, 0f },
                    { 39, 17, 0f },
                    { 40, 5, 2f },
                    { 40, 6, 6f },
                    { 40, 7, 6f },
                    { 40, 8, 4f },
                    { 40, 9, 1f },
                    { 40, 10, 4f },
                    { 40, 11, 4f },
                    { 40, 12, 1f },
                    { 40, 13, 3f },
                    { 40, 14, 0f },
                    { 40, 15, 5f },
                    { 40, 16, 1f },
                    { 40, 17, 0f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 17 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 5 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 6 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 7 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 8 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 9 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 10 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 11 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 12 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 13 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 14 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 15 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 16 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 17 });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ef4e528-6c05-416b-8eef-a3bc1eebf946", "AQAAAAEAACcQAAAAEG7gQC1BP7M3qgvKPdP21hUs86sgPF3SXABB9qC88sarJpX78fhzUk1MR8Hlrs+8EA==", "71e25299-3972-4e59-907b-7c19a3dd2735" });

            migrationBuilder.InsertData(
                table: "DesignFactors",
                columns: new[] { "ID", "Description", "FocusAreaID", "Name" },
                values: new object[] { 11, "Enterprise Size", 1, "Cobit Core Model - Design Factor 11" });
        }
    }
}
