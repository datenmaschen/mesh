using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace datamesh.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToDataDomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DataDomainSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DevOpsProjectName",
                table: "DataDomainSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "DataDomainSet",
                type: "nvarchar(43)",
                maxLength: 43,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameAbbrevationLong",
                table: "DataDomainSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameAbbreviationShort",
                table: "DataDomainSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionId",
                table: "DataDomainSet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "SubscriptionName",
                table: "DataDomainSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DevOpsProjectName",
                table: "DataDomainSet");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "DataDomainSet");

            migrationBuilder.DropColumn(
                name: "NameAbbrevationLong",
                table: "DataDomainSet");

            migrationBuilder.DropColumn(
                name: "NameAbbreviationShort",
                table: "DataDomainSet");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "DataDomainSet");

            migrationBuilder.DropColumn(
                name: "SubscriptionName",
                table: "DataDomainSet");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DataDomainSet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
