using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FocusAreasID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Audits_FocusAreas_FocusAreasID",
                        column: x => x.FocusAreasID,
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AuditsID = table.Column<int>(type: "int", nullable: false),
                    ObjectivesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditScopes", x => new { x.AuditID, x.ObjectiveID });
                    table.ForeignKey(
                        name: "FK_AuditScopes_Audits_AuditsID",
                        column: x => x.AuditsID,
                        principalTable: "Audits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditScopes_Objectives_ObjectivesID",
                        column: x => x.ObjectivesID,
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
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_FocusAreasID",
                table: "Audits",
                column: "FocusAreasID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditScopes_AuditsID",
                table: "AuditScopes",
                column: "AuditsID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditScopes_ObjectivesID",
                table: "AuditScopes",
                column: "ObjectivesID");

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
