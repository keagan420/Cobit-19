using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class answerSeedingComplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AuditID", "QuestionID", "Answer" },
                values: new object[,]
                {
                    { 1, 5, 1 },
                    { 1, 6, 1 },
                    { 1, 7, 2 },
                    { 1, 8, 3 },
                    { 1, 9, 1 },
                    { 1, 10, 1 },
                    { 1, 11, 2 },
                    { 1, 12, 3 },
                    { 1, 13, 1 },
                    { 1, 14, 1 },
                    { 1, 15, 2 },
                    { 1, 16, 3 },
                    { 1, 17, 1 },
                    { 1, 18, 1 },
                    { 1, 19, 1 },
                    { 1, 20, 1 },
                    { 1, 21, 1 },
                    { 1, 22, 1 },
                    { 1, 23, 1 },
                    { 1, 24, 1 },
                    { 1, 25, 1 },
                    { 1, 26, 1 },
                    { 1, 27, 1 },
                    { 1, 28, 1 },
                    { 1, 29, 1 },
                    { 1, 30, 1 },
                    { 1, 31, 1 },
                    { 1, 32, 1 },
                    { 1, 33, 1 },
                    { 1, 34, 1 },
                    { 1, 35, 1 },
                    { 1, 36, 1 },
                    { 1, 37, 1 },
                    { 1, 38, 1 },
                    { 1, 39, 1 },
                    { 1, 40, 1 },
                    { 1, 41, 1 },
                    { 1, 42, 1 },
                    { 1, 43, 1 },
                    { 1, 44, 1 },
                    { 1, 45, 1 },
                    { 1, 46, 1 },
                    { 1, 47, 1 },
                    { 1, 48, 1 },
                    { 1, 49, 1 },
                    { 1, 50, 1 },
                    { 1, 51, 1 },
                    { 1, 52, 1 },
                    { 1, 53, 1 },
                    { 1, 54, 1 },
                    { 1, 55, 1 },
                    { 1, 56, 1 },
                    { 1, 57, 1 },
                    { 1, 58, 1 },
                    { 1, 59, 1 },
                    { 1, 60, 1 },
                    { 1, 61, 1 },
                    { 1, 62, 1 },
                    { 1, 63, 1 },
                    { 1, 64, 1 },
                    { 1, 65, 1 },
                    { 1, 66, 1 },
                    { 1, 67, 1 },
                    { 1, 68, 1 },
                    { 1, 69, 1 },
                    { 1, 70, 1 },
                    { 1, 71, 1 },
                    { 1, 72, 1 },
                    { 1, 73, 1 },
                    { 1, 74, 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "744e1192-5279-47ee-9b17-512fe05fc660");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46ccca27-60ec-4dce-84de-998d5928a860", "AQAAAAEAACcQAAAAEMEs0l321iWkZwonhqj2q2QYueHKM6wmeKQqJ8QrKWqHBnbRrwH2Mv6kvybUbYjTrg==", "987c9d6d-7664-4f68-b337-ac41e4009af6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 36 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 39 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 40 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 43 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 44 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 47 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 48 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 49 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 50 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 51 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 52 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 53 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 54 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 56 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 57 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 58 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 59 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 60 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 61 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 62 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 63 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 64 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 65 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 66 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 68 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 69 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 70 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 71 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 72 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 73 });

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 74 });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AuditID", "QuestionID", "Answer" },
                values: new object[,]
                {
                    { 2, 1, 1 },
                    { 2, 2, 1 },
                    { 2, 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "da265c2c-b2a1-4443-b783-3542dcd8cc97");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "029d3bc2-1c37-4736-82ca-844274282f46", "AQAAAAEAACcQAAAAEBPOVQhGzI/0o3Jc5bKs0atE8UYvhyIJ5rEgSX0sOLUX2z3Cf1HQV/m9uSyEOdxabA==", "5668b0c1-1c79-46af-994a-196914a80394" });
        }
    }
}
