using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduPortalAPI.Migrations
{
    /// <inheritdoc />
    public partial class create_userTable_GroupSubjectTablse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentGroupSubjectInfoTemp",
                columns: table => new
                {
                    SgsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<long>(type: "bigint", nullable: false),
                    ClassID = table.Column<short>(type: "smallint", nullable: false),
                    ClsGrpID = table.Column<short>(type: "smallint", nullable: false),
                    BatchID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AprovedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroupSubjectInfoTemp", x => x.SgsId);
                });

            migrationBuilder.CreateTable(
                name: "UsersForPortal",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersForPortal", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "StudentGroupSubjectDetailsTemp",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubId = table.Column<long>(type: "bigint", nullable: false),
                    MSStatus = table.Column<bool>(type: "bit", nullable: false),
                    SgsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroupSubjectDetailsTemp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentGroupSubjectDetailsTemp_StudentGroupSubjectInfoTemp_SgsId",
                        column: x => x.SgsId,
                        principalTable: "StudentGroupSubjectInfoTemp",
                        principalColumn: "SgsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroupSubjectDetailsTemp_SgsId",
                table: "StudentGroupSubjectDetailsTemp",
                column: "SgsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersForPortal_UserName",
                table: "UsersForPortal",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentGroupSubjectDetailsTemp");

            migrationBuilder.DropTable(
                name: "UsersForPortal");

            migrationBuilder.DropTable(
                name: "StudentGroupSubjectInfoTemp");
        }
    }
}
