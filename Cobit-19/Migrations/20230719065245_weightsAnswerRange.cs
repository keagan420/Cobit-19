using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class weightsAnswerRange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnswerRange",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Odds",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 11 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 12 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 13 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 14 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 15 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 16 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 17 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 18 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 19 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 20 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 21 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 22 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 23 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 24 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 25 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 26 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 27 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 28 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 29 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 30 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 31 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 32 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 33 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 34 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 35 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 36 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 37 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 38 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 39 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 40 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 41 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 42 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 43 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 44 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 45 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 46 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 47 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 48 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 49 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 50 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 51 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 52 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 53 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 54 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 55 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 56 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 57 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 58 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 59 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 60 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 61 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 62 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 63 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 64 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 65 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 66 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 67 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 68 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 69 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 70 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 71 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 72 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 73 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumns: new[] { "AuditID", "QuestionID" },
                keyValues: new object[] { 1, 74 },
                columns: new[] { "AnswerRange", "Odds" },
                values: new object[] { 100, 0 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c61da866-8ea4-4d8d-86cc-7f9469f3e534");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "384e6383-cd2d-408b-b7d8-7e55b357956f", "AQAAAAEAACcQAAAAEI2kjbWyCHDX5pEkJ5ooAgtoR8q+9x3jBwrhJtsPlns2u/a2YCa2e6/p+OhQwUMIZg==", "f2949758-6a5f-4a19-ad92-b3ffef859858" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerRange",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Odds",
                table: "Answers");

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
    }
}
