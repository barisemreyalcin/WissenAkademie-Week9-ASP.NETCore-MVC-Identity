using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentitySample.Migrations
{
    /// <inheritdoc />
    public partial class UserClaimMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LocaleClaim",
                table: "AspNetUserClaims",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocaleClaim",
                table: "AspNetUserClaims");
        }
    }
}
