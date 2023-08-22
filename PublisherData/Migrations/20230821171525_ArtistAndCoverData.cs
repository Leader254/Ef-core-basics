using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PublisherData.Migrations
{
    /// <inheritdoc />
    public partial class ArtistAndCoverData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Pablo", "Picasso" },
                    { 2, "Dee", "Bell" },
                    { 3, "Katharine", "Kuharic" }
                });

            migrationBuilder.InsertData(
                table: "Covers",
                columns: new[] { "CoverId", "DesignIdea", "DigitalOnly" },
                values: new object[,]
                {
                    { 1, "How about a left hand in the dark?", false },
                    { 2, "Should we put a clock?", true },
                    { 3, "A big ear in the clouds?", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Samuel", "Wachira" },
                    { 2, "Janet", "Gatheru" },
                    { 3, "Grace", "Nduta" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 2, 1, 0m, new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# Learning" },
                    { 3, 2, 0m, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals" }
                });
        }
    }
}
