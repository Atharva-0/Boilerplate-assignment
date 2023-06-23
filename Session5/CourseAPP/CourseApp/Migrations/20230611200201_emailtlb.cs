using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseApp.Migrations
{
    public partial class emailtlb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_AspNetUsers_UserId",
                table: "Cart");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Cart",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                newName: "IX_Cart_Email");

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Email);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "f95530a3-7f7f-47b1-a1d7-7755eef2dc46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "069223eb-7db3-4ad8-ba5b-58cabf285f8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f142989-e0bd-4a9a-bb75-fcd1f68de4d1", "AQAAAAEAACcQAAAAEI+b1uColbmeoChLMAKwAA+8YFLvEIJVP4GatGqNiBSzBJF08vVp566e+xPZzoPoAQ==", "9d8f3756-2323-44ea-9d3a-fb73ecb7e719" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_AspNetUsers_Email",
                table: "Cart",
                column: "Email",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_AspNetUsers_Email",
                table: "Cart");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cart",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_Email",
                table: "Cart",
                newName: "IX_Cart_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "0071fda2-f58d-446b-8fd5-f3d8df32fd11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "fe5946fe-f93b-4181-8144-b0bb07cd60db");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8579b986-9968-417d-9239-3221ee233cf1", "AQAAAAEAACcQAAAAEPCJfeQRBEg3V4yenQHHh4vO0extYbnsImtIsyU6dWcV0G2Fb/QFaHTQAjkfQbVoXw==", "b0e36ad5-e228-4ee4-a26d-82831141a600" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_AspNetUsers_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
