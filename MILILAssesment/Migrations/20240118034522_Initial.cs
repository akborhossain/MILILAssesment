using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MILILAssesment.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblPRBookInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReqNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReqBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IssuedQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OfficeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReqbyTierCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateEntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntryWSIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateWSIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Archive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPRBookInfo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPRBookInfo");
        }
    }
}
