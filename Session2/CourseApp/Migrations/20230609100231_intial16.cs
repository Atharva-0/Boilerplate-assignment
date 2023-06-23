using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseApp.Migrations
{
    public partial class intial16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "5d39120c-da6f-4397-b260-a908aeadacb0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "ae167529-4652-4f68-a389-0cd55d1ed8e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ead6c07-dc18-4fa9-beb9-417e26b7c5c5", "AQAAAAEAACcQAAAAEPRk+3jZlWh6vect9AzEphQMyf5aSFYisbTuQ1Qt1QJAk5Qy7iUxkbUJb6RjVvSnrw==", "70a78acc-9060-4bd3-987c-8dcc0244f84b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Course");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "94279c0f-ef0b-4761-b759-109d634e6490");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                column: "ConcurrencyStamp",
                value: "79bf6749-132e-4714-807b-725c8f09a85a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f02c222-cdd5-437d-ab77-c9292e295c59", "AQAAAAEAACcQAAAAEIF1lMo5w9HTX5kHJArBKcWIeUxCwPPZ6OCnJZ15JvwD7AjnsCRC9+nh8hs1tG1AbA==", "3d859977-a581-4ea8-80f0-c909267cf491" });
        }
    }
}
