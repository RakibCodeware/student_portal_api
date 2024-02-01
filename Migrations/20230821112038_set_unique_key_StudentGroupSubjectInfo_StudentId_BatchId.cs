using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduPortalAPI.Migrations
{
    /// <inheritdoc />
    public partial class set_unique_key_StudentGroupSubjectInfo_StudentId_BatchId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StudentGroupSubjectInfoTemp_StudentId_BatchID",
                table: "StudentGroupSubjectInfoTemp",
                columns: new[] { "StudentId", "BatchID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentGroupSubjectInfoTemp_StudentId_BatchID",
                table: "StudentGroupSubjectInfoTemp");
        }
    }
}
