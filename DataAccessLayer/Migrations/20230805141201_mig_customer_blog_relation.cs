using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_customer_blog_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CustomerID",
                table: "Blogs",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Customers_CustomerID",
                table: "Blogs",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Customers_CustomerID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CustomerID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Blogs");
        }
    }
}
