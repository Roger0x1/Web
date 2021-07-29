using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class employeeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeAddress_City",
                table: "Audit_Employees");

            migrationBuilder.DropColumn(
                name: "HomeAddress_State",
                table: "Audit_Employees");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Street",
                table: "Audit_Employees");

            migrationBuilder.DropColumn(
                name: "HomeAddress_ZipCode",
                table: "Audit_Employees");

            migrationBuilder.DropColumn(
                name: "MailingAddress_City",
                table: "Audit_Employees");

            migrationBuilder.DropColumn(
                name: "MailingAddress_State",
                table: "Audit_Employees");

            migrationBuilder.DropColumn(
                name: "MailingAddress_Street",
                table: "Audit_Employees");

            migrationBuilder.DropColumn(
                name: "MailingAddress_ZipCode",
                table: "Audit_Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_City",
                table: "Audit_Employees",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_State",
                table: "Audit_Employees",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Street",
                table: "Audit_Employees",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_ZipCode",
                table: "Audit_Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailingAddress_City",
                table: "Audit_Employees",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailingAddress_State",
                table: "Audit_Employees",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailingAddress_Street",
                table: "Audit_Employees",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MailingAddress_ZipCode",
                table: "Audit_Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
