using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    { 5, "EDM05", "Ensure Stakeholder Engagement", "EDM05" },
                    { 6, "APO01", "Manage the IT Management Framework", "APO01" },
                    { 7, "APO02", "Manage Strategy", "APO02" },
                    { 8, "APO03", "Manage Enterprise Architecture", "APO03" },
                    { 9, "APO04", "Manage Innovation", "APO04" },
                    { 10, "APO05", "Manage Portfolio", "APO05" },
                    { 11, "APO06", "Manage Budget and Costs", "APO06" },
                    { 12, "APO07", "Manage Human Resources", "APO07" },
                    { 13, "APO08", "Manage Relationships", "APO08" },
                    { 14, "APO09", "Manage Service Agreements", "APO09" },
                    { 15, "APO010", "Manage Vendors", "APO010" },
                    { 16, "APO011", "Manage Quality", "APO011" },
                    { 17, "APO012", "Manage Risk", "APO012" },
                    { 18, "APO013", "Manage Security", "APO013" },
                    { 19, "APO014", "Manage Data", "APO014" },
                    { 20, "BAI12", "Manage Programs", "BAI01" },
                    { 21, "BAI02", "Manage Requirements Definition", "BAI02" },
                    { 22, "BAI03", "Manage Solutions Identification and Build", "BAI03" },
                    { 23, "BAI04", "Manage Availability and Capacity", "BAI04" },
                    { 24, "BAI05", "Manage Organizational Change", "BAI05" },
                    { 25, "BAI06", "Manage IT Changes", "BAI06" },
                    { 26, "BAI07", "Manage IT Change Acceptance and Transitioning", "BAI07" },
                    { 27, "BAI08", "Manage Knowledge", "BAI08" },
                    { 28, "BAI09", "Manage Assets", "BAI09" },
                    { 29, "BAI010", "Manage Configuration", "BAI10" },
                    { 30, "BAI011", "Manage Projects", "BAI11" },
                    { 31, "DSS01", "Manage Operations", "DSS01" },
                    { 32, "DSS02", "Manage Service Requests and Incidents", "DSS02" },
                    { 33, "DSS03", "Manage Problems", "DSS03" },
                    { 34, "DSS04", "Manage Continuity", "DSS04" },
                    { 35, "DSS05", "Manage Security Services", "DSS05" },
                    { 36, "DSS06", "Manage Business Process Controls", "DSS06" },
                    { 37, "MEA01", "Manage Perfomance and Comformance Monitoring", "MEA01" },
                    { 38, "MEA02", "Manage System of Internal Control", "MEA02" },
                    { 39, "MEA03", "Manage Compliance With External Requirement", "MEA03" },
                    { 40, "MEA04", "Manage Assurance", "MEA04" }
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
                    { 1, "Enterprise Strategy", 1, "Cobit Core Model - Design Factor 1" },
                    { 2, "Enterprise Goals", 1, "Cobit Core Model - Design Factor 2" },
                    { 3, "Risk Profile", 1, "Cobit Core Model - Design Factor 3" },
                    { 4, "IT-Related Issues", 1, "Cobit Core Model - Design Factor 4" },
                    { 5, "Threat landscape", 1, "Cobit Core Model - Design Factor 5" },
                    { 6, "Compliance Requirements", 1, "Cobit Core Model - Design Factor 6" },
                    { 7, "Role of IT", 1, "Cobit Core Model - Design Factor 7" },
                    { 8, "Sourcing model for IT", 1, "Cobit Core Model - Design Factor 8" },
                    { 9, "IT implementation methods", 1, "Cobit Core Model - Design Factor 9" },
                    { 10, "Technology adoption strategy", 1, "Cobit Core Model - Design Factor 10" },
                    { 11, "Enterprise Size", 1, "Cobit Core Model - Design Factor 11" }
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
                columns: new[] { "ID", "DesignFactorID", "Question" },
                values: new object[,]
                {
                    { 1, 1, "Growth/Acquisition" },
                    { 2, 1, "Innovation/Differentiation" },
                    { 3, 1, "Cost Leadership" },
                    { 4, 1, "Client Service/Stability" },
                    { 5, 2, "EG01—Portfolio of competitive products and services" },
                    { 6, 2, "EG02—Managed business risk" },
                    { 7, 2, "EG03—Compliance with external laws and regulations" },
                    { 8, 2, "EG04—Quality of financial information" },
                    { 9, 2, "EG05—Customer-oriented service culture" },
                    { 10, 2, "EG06—Business-service continuity and availability" },
                    { 11, 2, "EG07—Quality of management information" },
                    { 12, 2, "EG08—Optimization of internal business process functionality" },
                    { 13, 2, "EG09—Optimization of business process costs" },
                    { 14, 2, "EG10—Staff skills, motivation and productivity" },
                    { 15, 2, "EG11—Compliance with internal policies" },
                    { 16, 2, "EG12—Managed digital transformation programs" },
                    { 17, 2, "EG13—Product and business innovation" },
                    { 18, 3, "IT investment decision-making, portfolio definition & maintenance" },
                    { 19, 3, "Program & projects life cycle management" },
                    { 20, 3, "IT cost & oversight" },
                    { 21, 3, "IT expertise, skills & behaviour" },
                    { 22, 3, "Enterprise/IT architecture" },
                    { 23, 3, "IT operational infrastructure incidents" },
                    { 24, 3, "Unauthorized actions" },
                    { 25, 3, "Software adoption/usage problems" },
                    { 26, 3, "Hardware incidents" },
                    { 27, 3, "Software failures" },
                    { 28, 3, "Logical attacks (hacking, malware, etc.)" },
                    { 29, 3, "Third-party/supplier incidents" },
                    { 30, 3, "Noncompliance" },
                    { 31, 3, "Geopolitical Issues" },
                    { 32, 3, "Industrial action" },
                    { 33, 3, "Acts of nature" },
                    { 34, 3, "Technology-based innovation" },
                    { 35, 3, "Environmental" },
                    { 36, 3, "Data & information management" },
                    { 37, 4, "Frustration between different IT entities across the organization because of a perception of low contribution to business value" },
                    { 38, 4, "Frustration between business departments (i.e., the IT customer) and the IT department because of failed initiatives or a perception of low contribution to business value" },
                    { 39, 4, "Significant IT-related incidents, such as data loss, security breaches, project failure and application errors, linked to IT" },
                    { 40, 4, "Service delivery problems by the IT outsourcer(s)" },
                    { 41, 4, "Failures to meet IT-related regulatory or contractual requirements" },
                    { 42, 4, "Regular audit findings or other assessment reports about poor IT performance or reported IT quality or service problems" },
                    { 43, 4, "Substantial hidden and rogue IT spending, that is, IT spending by user departments outside the control of the normal IT investment decision mechanisms and approved budgets" },
                    { 44, 4, "Duplications or overlaps between various initiatives, or other forms of wasted resources" },
                    { 45, 4, "Insufficient IT resources, staff with inadequate skills or staff burnout/dissatisfaction" },
                    { 46, 4, "IT-enabled changes or projects frequently failing to meet business needs and delivered late or over budget" },
                    { 47, 4, "Reluctance by board members, executives or senior management to engage with IT, or a lack of committed business sponsorship for IT" },
                    { 48, 4, "Complex IT operating model and/or unclear decision mechanisms for IT-related decisions" },
                    { 49, 4, "Excessively high cost of IT" },
                    { 50, 4, "Obstructed or failed implementation of new initiatives or innovations caused by the current IT architecture and systems" },
                    { 51, 4, "Gap between business and technical knowledge, which leads to business users and information and/or technology specialists speaking different languages" },
                    { 52, 4, "Regular issues with data quality and integration of data across various sources" },
                    { 53, 4, "High level of end-user computing, creating (among other problems) a lack of oversight and quality control over the applications that are being developed and put in operation" },
                    { 54, 4, "Business departments implementing their own information solutions with little or no involvement of the enterprise IT department (related to end-user computing, which often stems from dissatisfaction with IT solutions and services)" },
                    { 55, 4, "Ignorance of and/or noncompliance with privacy regulations" },
                    { 56, 4, "Inability to exploit new technologies or innovate using I&T" },
                    { 57, 5, "High" },
                    { 58, 5, "Normal" },
                    { 59, 6, "High compliance requirements" },
                    { 60, 6, "Normal compliance requirements" },
                    { 61, 6, "Low compliance requirements" },
                    { 62, 7, "Support" },
                    { 63, 7, "Factory" },
                    { 64, 7, "Turnaround" },
                    { 65, 7, "Strategic" },
                    { 66, 8, "Outsourcing" },
                    { 67, 8, "Cloud" },
                    { 68, 8, "Insourced" },
                    { 69, 9, "Agile" },
                    { 70, 9, "DevOps" },
                    { 71, 9, "Traditional" },
                    { 72, 10, "First mover" },
                    { 73, 10, "Follower" },
                    { 74, 10, "Slow adopter" }
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
