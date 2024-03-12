﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFNorthwind.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeClassEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees");
        }
    }
}
