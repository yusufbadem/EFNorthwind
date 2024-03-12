using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFNorthwind.Migrations
{
    /// <inheritdoc />
    public partial class CategoryClassEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Categories",
                newName: "Picture");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Categories",
                newName: "Image");
        }
    }
}
