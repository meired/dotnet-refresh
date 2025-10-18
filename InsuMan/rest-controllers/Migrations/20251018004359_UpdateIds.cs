using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rest_controllers.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Insurances");

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Insurances",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Insurances");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Insurances",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Clients");

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Clients");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Insurances");

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Insurances",
                type: "int",
                nullable: false);

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Insurances");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Insurances",
                type: "int",
                nullable: false);

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Clients",
                type: "int",
                nullable: false);

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Clients",
                type: "int",
                nullable: false);
        }
    }
}
