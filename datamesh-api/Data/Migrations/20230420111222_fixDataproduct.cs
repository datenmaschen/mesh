using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace datamesh.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixDataproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dataproduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(43)", maxLength: 43, nullable: false),
                    Key = table.Column<string>(type: "nvarchar(43)", maxLength: 43, nullable: false),
                    AdGroupContributor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeputyOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    RefreshInHour = table.Column<int>(type: "int", nullable: false),
                    ServiceLevelObjectiveStability = table.Column<int>(type: "int", nullable: false),
                    UsageRestrictions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApiUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dataproduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dataproduct_DataDomainSet_DataDomainId",
                        column: x => x.DataDomainId,
                        principalTable: "DataDomainSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dataproduct_DataDomainId",
                table: "Dataproduct",
                column: "DataDomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Dataproduct_Key",
                table: "Dataproduct",
                column: "Key",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dataproduct");
        }
    }
}
