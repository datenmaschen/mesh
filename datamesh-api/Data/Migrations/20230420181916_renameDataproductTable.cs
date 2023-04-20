using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace datamesh.Data.Migrations
{
    /// <inheritdoc />
    public partial class renameDataproductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dataproduct_DataDomainSet_DataDomainId",
                table: "Dataproduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dataproduct",
                table: "Dataproduct");

            migrationBuilder.RenameTable(
                name: "Dataproduct",
                newName: "DataproductSet");

            migrationBuilder.RenameIndex(
                name: "IX_Dataproduct_Key",
                table: "DataproductSet",
                newName: "IX_DataproductSet_Key");

            migrationBuilder.RenameIndex(
                name: "IX_Dataproduct_DataDomainId",
                table: "DataproductSet",
                newName: "IX_DataproductSet_DataDomainId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataproductSet",
                table: "DataproductSet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DataproductSet_DataDomainSet_DataDomainId",
                table: "DataproductSet",
                column: "DataDomainId",
                principalTable: "DataDomainSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataproductSet_DataDomainSet_DataDomainId",
                table: "DataproductSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataproductSet",
                table: "DataproductSet");

            migrationBuilder.RenameTable(
                name: "DataproductSet",
                newName: "Dataproduct");

            migrationBuilder.RenameIndex(
                name: "IX_DataproductSet_Key",
                table: "Dataproduct",
                newName: "IX_Dataproduct_Key");

            migrationBuilder.RenameIndex(
                name: "IX_DataproductSet_DataDomainId",
                table: "Dataproduct",
                newName: "IX_Dataproduct_DataDomainId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dataproduct",
                table: "Dataproduct",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dataproduct_DataDomainSet_DataDomainId",
                table: "Dataproduct",
                column: "DataDomainId",
                principalTable: "DataDomainSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
