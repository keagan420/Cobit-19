using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class DesignFactorSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "ObjectiveID", "QuestionID", "Weight" },
                values: new object[,]
                {
                    { 1, 72, 3.5f },
                    { 1, 73, 2.5f },
                    { 1, 74, 1.5f },
                    { 2, 72, 4f },
                    { 2, 73, 2.5f },
                    { 2, 74, 1.5f },
                    { 3, 72, 1.5f },
                    { 3, 73, 1f },
                    { 3, 74, 1f },
                    { 4, 72, 2.5f },
                    { 4, 73, 2f },
                    { 4, 74, 1.5f },
                    { 5, 72, 1.5f },
                    { 5, 73, 1f },
                    { 5, 74, 1f },
                    { 6, 72, 2.5f },
                    { 6, 73, 1.5f },
                    { 6, 74, 1f },
                    { 7, 72, 4f },
                    { 7, 73, 3f },
                    { 7, 74, 1.5f },
                    { 8, 72, 2f },
                    { 8, 73, 1f },
                    { 8, 74, 1f },
                    { 9, 72, 4f },
                    { 9, 73, 3f },
                    { 9, 74, 1f },
                    { 10, 72, 4f },
                    { 10, 73, 2.5f },
                    { 10, 74, 1f },
                    { 11, 72, 1f },
                    { 11, 73, 1.5f },
                    { 11, 74, 1f },
                    { 12, 72, 2.5f },
                    { 12, 73, 1f },
                    { 12, 74, 1f },
                    { 13, 72, 3f },
                    { 13, 73, 1.5f },
                    { 13, 74, 1f },
                    { 14, 72, 1.5f },
                    { 14, 73, 1.5f },
                    { 14, 74, 1f },
                    { 15, 72, 2.5f },
                    { 15, 73, 1.5f },
                    { 15, 74, 1f },
                    { 16, 72, 1.5f },
                    { 16, 73, 1.5f },
                    { 16, 74, 1f },
                    { 17, 72, 2f },
                    { 17, 73, 1.5f },
                    { 17, 74, 1f },
                    { 18, 72, 1f },
                    { 18, 73, 1f },
                    { 18, 74, 1f },
                    { 19, 72, 2.5f },
                    { 19, 73, 2f },
                    { 19, 74, 1f },
                    { 20, 72, 4f },
                    { 20, 73, 3f },
                    { 20, 74, 1.5f },
                    { 21, 72, 3.5f },
                    { 21, 73, 2.5f },
                    { 21, 74, 1f },
                    { 22, 72, 4f },
                    { 22, 73, 2.5f },
                    { 22, 74, 1f },
                    { 23, 72, 1.5f },
                    { 23, 73, 1.5f },
                    { 23, 74, 1f },
                    { 24, 72, 3f },
                    { 24, 73, 2f },
                    { 24, 74, 1f },
                    { 25, 72, 2.5f },
                    { 25, 73, 2f },
                    { 25, 74, 1f },
                    { 26, 72, 3.5f },
                    { 26, 73, 2.5f },
                    { 26, 74, 1f },
                    { 27, 72, 1.5f },
                    { 27, 73, 1f },
                    { 27, 74, 1f },
                    { 28, 72, 1f },
                    { 28, 73, 1f },
                    { 28, 74, 1f },
                    { 29, 72, 1.5f },
                    { 29, 73, 1f },
                    { 29, 74, 1f },
                    { 30, 72, 3.5f },
                    { 30, 73, 2.5f },
                    { 30, 74, 1f },
                    { 31, 72, 1f },
                    { 31, 73, 1f },
                    { 31, 74, 1f },
                    { 32, 72, 1f },
                    { 32, 73, 1f },
                    { 32, 74, 1f },
                    { 33, 72, 1.5f },
                    { 33, 73, 1f },
                    { 33, 74, 1f },
                    { 34, 72, 1.5f },
                    { 34, 73, 1f },
                    { 34, 74, 1f },
                    { 35, 72, 1.5f },
                    { 35, 73, 1f },
                    { 35, 74, 1f },
                    { 36, 72, 1f },
                    { 36, 73, 1f },
                    { 36, 74, 1f },
                    { 37, 72, 3f },
                    { 37, 73, 2f },
                    { 37, 74, 1f },
                    { 38, 72, 1f },
                    { 38, 73, 1f },
                    { 38, 74, 1f },
                    { 39, 72, 1f },
                    { 39, 73, 1f },
                    { 39, 74, 1f },
                    { 40, 72, 1f },
                    { 40, 73, 1f },
                    { 40, 74, 1f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 1, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 2, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 3, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 4, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 5, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 6, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 7, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 8, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 9, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 10, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 11, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 12, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 13, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 14, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 15, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 16, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 17, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 18, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 19, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 20, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 21, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 22, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 23, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 24, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 25, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 26, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 27, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 28, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 29, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 30, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 31, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 32, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 33, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 34, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 35, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 36, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 37, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 38, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 39, 74 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 72 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 73 });

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumns: new[] { "ObjectiveID", "QuestionID" },
                keyValues: new object[] { 40, 74 });
        }
    }
}
