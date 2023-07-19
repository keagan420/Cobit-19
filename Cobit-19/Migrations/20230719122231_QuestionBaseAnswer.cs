using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class QuestionBaseAnswer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseAnswer",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3521a8ed-1ecc-4d63-becd-1114ff5c9253");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a28a2388-1a32-4880-aa5b-0b3868bea83e", "AQAAAAEAACcQAAAAEMA3A042Nq7JLmgrX9GtyhDq6dZp2tAaQixyUSlROpMejsAIzxxp0LdM3vaZF7FlTA==", "6eca69f6-5235-422d-b97a-441a29825ac7" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 1,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 2,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 3,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 4,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 5,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 6,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 7,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 8,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 9,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 10,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 11,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 12,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 13,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 14,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 15,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 16,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 17,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 18,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 19,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 20,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 21,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 22,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 23,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 24,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 25,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 26,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 27,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 28,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 29,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 30,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 31,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 32,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 33,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 34,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 35,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 36,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 37,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 38,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 39,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 40,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 41,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 42,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 43,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 44,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 45,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 46,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 47,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 48,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 49,
                column: "BaseAnswer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 50,
                column: "BaseAnswer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 51,
                column: "BaseAnswer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 52,
                column: "BaseAnswer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 53,
                column: "BaseAnswer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 54,
                column: "BaseAnswer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 55,
                column: "BaseAnswer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 56,
                column: "BaseAnswer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 57,
                column: "BaseAnswer",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 58,
                column: "BaseAnswer",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 59,
                column: "BaseAnswer",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 60,
                column: "BaseAnswer",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 61,
                column: "BaseAnswer",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 62,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 63,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 64,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 65,
                column: "BaseAnswer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 66,
                column: "BaseAnswer",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 67,
                column: "BaseAnswer",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 68,
                column: "BaseAnswer",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 69,
                column: "BaseAnswer",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 70,
                column: "BaseAnswer",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 71,
                column: "BaseAnswer",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 72,
                column: "BaseAnswer",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 73,
                column: "BaseAnswer",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 74,
                column: "BaseAnswer",
                value: 15);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseAnswer",
                table: "Questions");

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
    }
}
