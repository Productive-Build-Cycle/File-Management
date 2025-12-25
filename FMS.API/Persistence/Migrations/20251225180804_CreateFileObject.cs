using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMS.API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreateFileObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginalFileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StoredFileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    BucketName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StoragePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileObjects", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileObjects_CreatedAt",
                table: "FileObjects",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_FileObjects_IsDeleted",
                table: "FileObjects",
                column: "IsDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileObjects");
        }
    }
}
