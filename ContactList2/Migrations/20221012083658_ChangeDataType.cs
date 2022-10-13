using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactList2.Migrations
{
    public partial class ChangeDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact_No",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "Employees");

            migrationBuilder.AddColumn<Guid>(
                name: "Contact_No",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
