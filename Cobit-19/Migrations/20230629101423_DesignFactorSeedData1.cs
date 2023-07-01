using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DesignFactorSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "ObjectiveID", "QuestionID", "Weight" },
                values: new object[,]
                {
                    { 1, 66, 1f },
                    { 1, 67, 1f },
                    { 1, 68, 1f },
                    { 1, 69, 1f },
                    { 1, 70, 1f },
                    { 1, 71, 1f },
                    { 2, 66, 1f },
                    { 2, 67, 1f },
                    { 2, 68, 1f },
                    { 2, 69, 1f },
                    { 2, 70, 1f },
                    { 2, 71, 1f },
                    { 3, 66, 1f },
                    { 3, 67, 2f },
                    { 3, 68, 1f },
                    { 3, 69, 1f },
                    { 3, 70, 1f },
                    { 3, 71, 1f },
                    { 4, 66, 1f },
                    { 4, 67, 1f },
                    { 4, 68, 1f },
                    { 4, 69, 1f },
                    { 4, 70, 1f },
                    { 4, 71, 1f },
                    { 5, 66, 1f },
                    { 5, 67, 1f },
                    { 5, 68, 1f },
                    { 5, 69, 1f },
                    { 5, 70, 1f },
                    { 5, 71, 1f },
                    { 6, 66, 1f },
                    { 6, 67, 1f },
                    { 6, 68, 1f },
                    { 6, 69, 1f },
                    { 6, 70, 1f },
                    { 6, 71, 1f },
                    { 7, 66, 1f },
                    { 7, 67, 1f },
                    { 7, 68, 1f },
                    { 7, 69, 1f },
                    { 7, 70, 1f },
                    { 7, 71, 1f },
                    { 8, 66, 1f },
                    { 8, 67, 1f },
                    { 8, 68, 1f },
                    { 8, 69, 1f },
                    { 8, 70, 2f },
                    { 8, 71, 1f },
                    { 9, 66, 1f },
                    { 9, 67, 1f },
                    { 9, 68, 1f },
                    { 9, 69, 1f },
                    { 9, 70, 1f },
                    { 9, 71, 1f },
                    { 10, 66, 1f },
                    { 10, 67, 1f },
                    { 10, 68, 1f },
                    { 10, 69, 1f },
                    { 10, 70, 1f },
                    { 10, 71, 1f },
                    { 11, 66, 1f },
                    { 11, 67, 1f },
                    { 11, 68, 1f },
                    { 11, 69, 1f },
                    { 11, 70, 1f },
                    { 11, 71, 1f },
                    { 12, 66, 1f },
                    { 12, 67, 1f },
                    { 12, 68, 1f },
                    { 12, 69, 1f },
                    { 12, 70, 1.5f },
                    { 12, 71, 1f },
                    { 13, 66, 1f },
                    { 13, 67, 1f },
                    { 13, 68, 1f },
                    { 13, 69, 1f },
                    { 13, 70, 1f },
                    { 13, 71, 1f },
                    { 14, 66, 4f },
                    { 14, 67, 4f },
                    { 14, 68, 1f },
                    { 14, 69, 1f },
                    { 14, 70, 1f },
                    { 14, 71, 1f },
                    { 15, 66, 4f },
                    { 15, 67, 4f },
                    { 15, 68, 1f },
                    { 15, 69, 1f },
                    { 15, 70, 1f },
                    { 15, 71, 1f },
                    { 16, 66, 1f },
                    { 16, 67, 1f },
                    { 16, 68, 1f },
                    { 16, 69, 1f },
                    { 16, 70, 1f },
                    { 16, 71, 1f },
                    { 17, 66, 2f },
                    { 17, 67, 2f },
                    { 17, 68, 1f },
                    { 17, 69, 1f },
                    { 17, 70, 1.5f },
                    { 17, 71, 1f },
                    { 18, 66, 1f },
                    { 18, 67, 1f },
                    { 18, 68, 1f },
                    { 18, 69, 1f },
                    { 18, 70, 1f },
                    { 18, 71, 1f },
                    { 19, 66, 1f },
                    { 19, 67, 1f },
                    { 19, 68, 1f },
                    { 19, 69, 1f },
                    { 19, 70, 1f },
                    { 19, 71, 1f },
                    { 20, 66, 1f },
                    { 20, 67, 1f },
                    { 20, 68, 1f },
                    { 20, 69, 2f },
                    { 20, 70, 1.5f },
                    { 20, 71, 1f },
                    { 21, 66, 1f },
                    { 21, 67, 1f },
                    { 21, 68, 1f },
                    { 21, 69, 3.5f },
                    { 21, 70, 2f },
                    { 21, 71, 1f },
                    { 22, 66, 1f },
                    { 22, 67, 1f },
                    { 22, 68, 1f },
                    { 22, 69, 4f },
                    { 22, 70, 3f },
                    { 22, 71, 1f },
                    { 23, 66, 1f },
                    { 23, 67, 1f },
                    { 23, 68, 1f },
                    { 23, 69, 1f },
                    { 23, 70, 1f },
                    { 23, 71, 1f },
                    { 24, 66, 1f },
                    { 24, 67, 1f },
                    { 24, 68, 1f },
                    { 24, 69, 2.5f },
                    { 24, 70, 1.5f },
                    { 24, 71, 1f },
                    { 25, 66, 1f },
                    { 25, 67, 1f },
                    { 25, 68, 1f },
                    { 25, 69, 3.5f },
                    { 25, 70, 2f },
                    { 25, 71, 1f },
                    { 26, 66, 1f },
                    { 26, 67, 1f },
                    { 26, 68, 1f },
                    { 26, 69, 2.5f },
                    { 26, 70, 2.5f },
                    { 26, 71, 1f },
                    { 27, 66, 1f },
                    { 27, 67, 1f },
                    { 27, 68, 1f },
                    { 27, 69, 1f },
                    { 27, 70, 1f },
                    { 27, 71, 1f },
                    { 28, 66, 1f },
                    { 28, 67, 1f },
                    { 28, 68, 1f },
                    { 28, 69, 1f },
                    { 28, 70, 1f },
                    { 28, 71, 1f },
                    { 29, 66, 1f },
                    { 29, 67, 1f },
                    { 29, 68, 1f },
                    { 29, 69, 1.5f },
                    { 29, 70, 2f },
                    { 29, 71, 1f },
                    { 30, 66, 1f },
                    { 30, 67, 1f },
                    { 30, 68, 1f },
                    { 30, 69, 2.5f },
                    { 30, 70, 1f },
                    { 30, 71, 1f },
                    { 31, 66, 1f },
                    { 31, 67, 1f },
                    { 31, 68, 1f },
                    { 31, 69, 1f },
                    { 31, 70, 2.5f },
                    { 31, 71, 1f },
                    { 32, 66, 1f },
                    { 32, 67, 1f },
                    { 32, 68, 1f },
                    { 32, 69, 1f },
                    { 32, 70, 1.5f },
                    { 32, 71, 1f },
                    { 33, 66, 1f },
                    { 33, 67, 1f },
                    { 33, 68, 1f },
                    { 33, 69, 1f },
                    { 33, 70, 1.5f },
                    { 33, 71, 1f },
                    { 34, 66, 1f },
                    { 34, 67, 1f },
                    { 34, 68, 1f },
                    { 34, 69, 1f },
                    { 34, 70, 1f },
                    { 34, 71, 1f },
                    { 35, 66, 1f },
                    { 35, 67, 1f },
                    { 35, 68, 1f },
                    { 35, 69, 1f },
                    { 35, 70, 1f },
                    { 35, 71, 1f },
                    { 36, 66, 1f },
                    { 36, 67, 1f },
                    { 36, 68, 1f },
                    { 36, 69, 1f },
                    { 36, 70, 1f },
                    { 36, 71, 1f },
                    { 37, 66, 1f },
                    { 37, 67, 1f },
                    { 37, 68, 1f },
                    { 37, 69, 1.5f },
                    { 37, 70, 1.5f },
                    { 37, 71, 1f },
                    { 38, 66, 1f },
                    { 38, 67, 1f },
                    { 38, 68, 1f },
                    { 38, 69, 1f },
                    { 38, 70, 1f },
                    { 38, 71, 1f },
                    { 39, 66, 1f },
                    { 39, 67, 1f },
                    { 39, 68, 1f },
                    { 39, 69, 1f },
                    { 39, 70, 1f },
                    { 39, 71, 1f },
                    { 40, 66, 1f },
                    { 40, 67, 1f },
                    { 40, 68, 1f },
                    { 40, 69, 1f },
                    { 40, 70, 1f },
                    { 40, 71, 1f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 71 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 66 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 67 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 68 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 69 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 70 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 71 });
        }
    }
}
