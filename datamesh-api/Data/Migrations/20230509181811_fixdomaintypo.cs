using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace datamesh.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixdomaintypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameAbbrevationLong",
                table: "DataDomainSet",
                newName: "NameAbbreviationLong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameAbbreviationLong",
                table: "DataDomainSet",
                newName: "NameAbbrevationLong");
        }
    }
}
