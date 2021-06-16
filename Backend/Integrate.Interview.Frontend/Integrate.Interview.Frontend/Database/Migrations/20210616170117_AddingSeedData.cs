using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrate.Interview.Frontend.Database.Migrations
{
    public partial class AddingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "City", "FirstName", "LastName", "State", "StreetAddress", "Title", "Zipcode" },
                values: new object[] { 1, "Birmingham", "Hunter", "Horton", "Alabama", "123 Mockingbird Lane", "Mr", "35242" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "City", "FirstName", "LastName", "State", "StreetAddress", "Title", "Zipcode" },
                values: new object[] { 2, "Birmingham", "Aaron", "Hall", "Alabama", "777 Sunshine Drive", "Mr", "35242" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "City", "FirstName", "LastName", "State", "StreetAddress", "Title", "Zipcode" },
                values: new object[] { 3, "Birmingham", "Robert", "Blackwood", "Alabama", "1 Pleasant Way", "Mr", "35242" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "City", "FirstName", "LastName", "State", "StreetAddress", "Title", "Zipcode" },
                values: new object[] { 4, "Birmingham", "Scott", "Carl", "Alabama", "246 Yellowhammer Circle", "Mr", "35242" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "City", "FirstName", "LastName", "State", "StreetAddress", "Title", "Zipcode" },
                values: new object[] { 5, "Birmingham", "Andrew", "Pearson", "Alabama", "357 Oriole Parkway", "Mr", "35242" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
