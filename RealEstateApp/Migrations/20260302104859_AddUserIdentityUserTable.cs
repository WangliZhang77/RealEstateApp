using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RealEstateApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdentityUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotographyCompanyId",
                table: "ListingCases",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AgentListingCases",
                columns: table => new
                {
                    AgentId = table.Column<string>(type: "text", nullable: false),
                    ListingCaseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentListingCases", x => new { x.AgentId, x.ListingCaseId });
                    table.ForeignKey(
                        name: "FK_AgentListingCases_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentListingCases_ListingCases_ListingCaseId",
                        column: x => x.ListingCaseId,
                        principalTable: "ListingCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediaAssets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MediaType = table.Column<string>(type: "text", nullable: false),
                    MediaUrl = table.Column<string>(type: "text", nullable: false),
                    IsSelected = table.Column<bool>(type: "boolean", nullable: false),
                    IsMain = table.Column<bool>(type: "boolean", nullable: false),
                    ListingCaseId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaAssets_ListingCases_ListingCaseId",
                        column: x => x.ListingCaseId,
                        principalTable: "ListingCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhotographyCompanies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PhotographyCompanyName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotographyCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserIdentityUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIdentityUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgentPhotographyCompanies",
                columns: table => new
                {
                    AgentId = table.Column<string>(type: "text", nullable: false),
                    PhotographyCompanyId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentPhotographyCompanies", x => new { x.AgentId, x.PhotographyCompanyId });
                    table.ForeignKey(
                        name: "FK_AgentPhotographyCompanies_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentPhotographyCompanies_PhotographyCompanies_PhotographyC~",
                        column: x => x.PhotographyCompanyId,
                        principalTable: "PhotographyCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListingCases_PhotographyCompanyId",
                table: "ListingCases",
                column: "PhotographyCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentListingCases_ListingCaseId",
                table: "AgentListingCases",
                column: "ListingCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentPhotographyCompanies_PhotographyCompanyId",
                table: "AgentPhotographyCompanies",
                column: "PhotographyCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaAssets_ListingCaseId",
                table: "MediaAssets",
                column: "ListingCaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListingCases_PhotographyCompanies_PhotographyCompanyId",
                table: "ListingCases",
                column: "PhotographyCompanyId",
                principalTable: "PhotographyCompanies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListingCases_PhotographyCompanies_PhotographyCompanyId",
                table: "ListingCases");

            migrationBuilder.DropTable(
                name: "AgentListingCases");

            migrationBuilder.DropTable(
                name: "AgentPhotographyCompanies");

            migrationBuilder.DropTable(
                name: "MediaAssets");

            migrationBuilder.DropTable(
                name: "UserIdentityUsers");

            migrationBuilder.DropTable(
                name: "PhotographyCompanies");

            migrationBuilder.DropIndex(
                name: "IX_ListingCases_PhotographyCompanyId",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "PhotographyCompanyId",
                table: "ListingCases");
        }
    }
}
