using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cobit_19.Migrations
{
    /// <inheritdoc />
    public partial class InitialScopeDb4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audits_AuditScopes_AuditScopeAuditID_AuditScopeObjectiveID",
                table: "Audits");

            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_AuditScopes_AuditScopeModelAuditID_AuditScopeModelObjectiveID",
                table: "Objectives");

            migrationBuilder.DropIndex(
                name: "IX_Objectives_AuditScopeModelAuditID_AuditScopeModelObjectiveID",
                table: "Objectives");

            migrationBuilder.DropIndex(
                name: "IX_Audits_AuditScopeAuditID_AuditScopeObjectiveID",
                table: "Audits");

            migrationBuilder.DropColumn(
                name: "AuditScopeModelAuditID",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "AuditScopeModelObjectiveID",
                table: "Objectives");

            migrationBuilder.DropColumn(
                name: "AuditScopeAuditID",
                table: "Audits");

            migrationBuilder.DropColumn(
                name: "AuditScopeObjectiveID",
                table: "Audits");

            migrationBuilder.AddColumn<int>(
                name: "AuditsID",
                table: "AuditScopes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ObjectivesID",
                table: "AuditScopes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AuditScopes_AuditsID",
                table: "AuditScopes",
                column: "AuditsID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditScopes_ObjectivesID",
                table: "AuditScopes",
                column: "ObjectivesID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditScopes_Audits_AuditsID",
                table: "AuditScopes",
                column: "AuditsID",
                principalTable: "Audits",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditScopes_Objectives_ObjectivesID",
                table: "AuditScopes",
                column: "ObjectivesID",
                principalTable: "Objectives",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditScopes_Audits_AuditsID",
                table: "AuditScopes");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditScopes_Objectives_ObjectivesID",
                table: "AuditScopes");

            migrationBuilder.DropIndex(
                name: "IX_AuditScopes_AuditsID",
                table: "AuditScopes");

            migrationBuilder.DropIndex(
                name: "IX_AuditScopes_ObjectivesID",
                table: "AuditScopes");

            migrationBuilder.DropColumn(
                name: "AuditsID",
                table: "AuditScopes");

            migrationBuilder.DropColumn(
                name: "ObjectivesID",
                table: "AuditScopes");

            migrationBuilder.AddColumn<int>(
                name: "AuditScopeModelAuditID",
                table: "Objectives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditScopeModelObjectiveID",
                table: "Objectives",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuditScopeAuditID",
                table: "Audits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuditScopeObjectiveID",
                table: "Audits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_AuditScopeModelAuditID_AuditScopeModelObjectiveID",
                table: "Objectives",
                columns: new[] { "AuditScopeModelAuditID", "AuditScopeModelObjectiveID" });

            migrationBuilder.CreateIndex(
                name: "IX_Audits_AuditScopeAuditID_AuditScopeObjectiveID",
                table: "Audits",
                columns: new[] { "AuditScopeAuditID", "AuditScopeObjectiveID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Audits_AuditScopes_AuditScopeAuditID_AuditScopeObjectiveID",
                table: "Audits",
                columns: new[] { "AuditScopeAuditID", "AuditScopeObjectiveID" },
                principalTable: "AuditScopes",
                principalColumns: new[] { "AuditID", "ObjectiveID" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Objectives_AuditScopes_AuditScopeModelAuditID_AuditScopeModelObjectiveID",
                table: "Objectives",
                columns: new[] { "AuditScopeModelAuditID", "AuditScopeModelObjectiveID" },
                principalTable: "AuditScopes",
                principalColumns: new[] { "AuditID", "ObjectiveID" });
        }
    }
}
