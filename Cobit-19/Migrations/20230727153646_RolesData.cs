using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class RolesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "eaa2564a-0fc2-4ba2-ac44-43ddc971feed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7", "ccde9603-224f-4844-8ab9-3126db7fc0b9", "Head Auditor", "HEAD AUDITOR" },
                    { "5e70cf29-1b64-4f58-85dd-07b3c46015a3", "bfb26c87-3e7a-4c87-a150-fb461eafc65b", "Auditor", "AUDITOR" },
                    { "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295", "599a056e-5da5-4253-bcf7-1068fd3bbf81", "Client", "CLIENT" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "902d0782-9d7f-43f2-bed7-db8a072f929b", "AQAAAAEAACcQAAAAEKt5zCyrlcOWKGTPJ/+JbaNvCD0z/yEiP8hDpHO7VgETL5zXcNu1CyI4gZ0PaNBTIQ==", "a049dbda-abee-43af-9daa-80af9cf1a37b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36c9f3b8-42e6-4ab1-a50d-e89986c5d1f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e70cf29-1b64-4f58-85dd-07b3c46015a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae1c6e-1c8a-43e7-9a2a-971fc7fbb295");

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
        }
    }
}
