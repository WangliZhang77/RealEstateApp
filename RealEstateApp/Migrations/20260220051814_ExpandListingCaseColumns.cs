using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateApp.Migrations
{
    /// <inheritdoc />
    public partial class ExpandListingCaseColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bathrooms",
                table: "ListingCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bedrooms",
                table: "ListingCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "ListingCases",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ListingCases",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "FloorArea",
                table: "ListingCases",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Garages",
                table: "ListingCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ListingCases",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Latitude",
                table: "ListingCases",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ListingCaseStatus",
                table: "ListingCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Longitude",
                table: "ListingCases",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ListingCases",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PropertyType",
                table: "ListingCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaleCategory",
                table: "ListingCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "ListingCases",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "ListingCases",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ListingCases",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "postcode",
                table: "ListingCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bathrooms",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "Bedrooms",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "City",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "FloorArea",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "Garages",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "ListingCaseStatus",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "SaleCategory",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ListingCases");

            migrationBuilder.DropColumn(
                name: "postcode",
                table: "ListingCases");
        }
    }
}
