using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FocusAreas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FocusAreas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FocusAreaID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Audits_FocusAreas_FocusAreaID",
                        column: x => x.FocusAreaID,
                        principalTable: "FocusAreas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesignFactors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FocusAreaID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignFactors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DesignFactors_FocusAreas_FocusAreaID",
                        column: x => x.FocusAreaID,
                        principalTable: "FocusAreas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditScopes",
                columns: table => new
                {
                    AuditID = table.Column<int>(type: "int", nullable: false),
                    ObjectiveID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditScopes", x => new { x.AuditID, x.ObjectiveID });
                    table.ForeignKey(
                        name: "FK_AuditScopes_Audits_AuditID",
                        column: x => x.AuditID,
                        principalTable: "Audits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditScopes_Objectives_ObjectiveID",
                        column: x => x.ObjectiveID,
                        principalTable: "Objectives",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignFactorID = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultAnswer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Questions_DesignFactors_DesignFactorID",
                        column: x => x.DesignFactorID,
                        principalTable: "DesignFactors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AuditID = table.Column<int>(type: "int", nullable: false),
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => new { x.AuditID, x.QuestionID });
                    table.ForeignKey(
                        name: "FK_Answers_Audits_AuditID",
                        column: x => x.AuditID,
                        principalTable: "Audits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    ObjectiveID = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => new { x.ObjectiveID, x.QuestionID });
                    table.ForeignKey(
                        name: "FK_Maps_Objectives_ObjectiveID",
                        column: x => x.ObjectiveID,
                        principalTable: "Objectives",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Maps_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FocusAreas",
                columns: new[] { "ID", "DateCreated", "Description", "Name", "UserID" },
                values: new object[] { 1, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "General Core Model", "Cobit Core Model", 0 });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "ID", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "EDM01", "Ensure Governance Framework Setting and Maintenance", "EDM01" },
                    { 2, "EDM02", "Ensure Benefits Delivery", "EDM02" },
                    { 3, "EDM03", "Ensure Risk Optimisation", "EDM03" },
                    { 4, "EDM04", "Ensure Resource Optimisation", "EDM04" },
                    { 5, "EDM05", "Ensure Stakeholder Transparency", "EDM05" },
                    { 6, "APO01", "Manage the IT Management Framework", "APO01" }
                });

            migrationBuilder.InsertData(
                table: "Audits",
                columns: new[] { "ID", "DateCompleted", "DateCreated", "FocusAreaID", "Name", "Status", "UserID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Audit 1", 0, 1 },
                    { 2, null, new DateTime(2009, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Audit 2", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "DesignFactors",
                columns: new[] { "ID", "Description", "FocusAreaID", "Name" },
                values: new object[,]
                {
                    { 1, "Ensure Governance Framework Setting and Maintenance", 1, "1" },
                    { 2, "Ensure Benefits Delivery", 1, "2" }
                });

            migrationBuilder.InsertData(
                table: "AuditScopes",
                columns: new[] { "AuditID", "ObjectiveID", "UserID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 1 },
                    { 1, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "ID", "DefaultAnswer", "DesignFactorID", "Question" },
                values: new object[,]
                {
                    { 1, 1, 1, "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?" },
                    { 2, 1, 1, "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?" },
                    { 3, 1, 1, "Is there a governance framework that includes the organisational structure, as well as the assignment of authorities and responsibilities for executing governance activities and monitoring their adequacy and effectiveness?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AuditID", "QuestionID", "Answer" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 1 },
                    { 1, 3, 1 },
                    { 2, 1, 1 },
                    { 2, 2, 1 },
                    { 2, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "ObjectiveID", "QuestionID", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1f },
                    { 1, 2, 0.5f },
                    { 1, 3, 0.1f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_FocusAreaID",
                table: "Audits",
                column: "FocusAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditScopes_ObjectiveID",
                table: "AuditScopes",
                column: "ObjectiveID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignFactors_FocusAreaID",
                table: "DesignFactors",
                column: "FocusAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Maps_QuestionID",
                table: "Maps",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_DesignFactorID",
                table: "Questions",
                column: "DesignFactorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AuditScopes");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropTable(
                name: "Objectives");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "DesignFactors");

            migrationBuilder.DropTable(
                name: "FocusAreas");
        }
    }
}
