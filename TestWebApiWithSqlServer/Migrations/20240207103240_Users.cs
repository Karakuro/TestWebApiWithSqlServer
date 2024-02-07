using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestWebApiWithSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ActivityTasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTasks_UserId",
                table: "ActivityTasks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityTasks_User_UserId",
                table: "ActivityTasks",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityTasks_User_UserId",
                table: "ActivityTasks");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_ActivityTasks_UserId",
                table: "ActivityTasks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ActivityTasks");
        }
    }
}
