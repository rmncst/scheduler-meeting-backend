using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulerMeeting.Api.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MeetingRooms",
                keyColumn: "MeetingRoomId",
                keyValue: new Guid("8b392a9b-80d6-424e-87d5-84f2c73f362c"));

            migrationBuilder.DeleteData(
                table: "MeetingRooms",
                keyColumn: "MeetingRoomId",
                keyValue: new Guid("d7c278b2-9a98-4793-8a8d-2ec257bc007b"));

            migrationBuilder.DeleteData(
                table: "MeetingRooms",
                keyColumn: "MeetingRoomId",
                keyValue: new Guid("db84c0a7-15f5-42fc-9902-4efc8e8d9ddf"));

            migrationBuilder.InsertData(
                table: "MeetingRooms",
                columns: new[] { "MeetingRoomId", "Active", "Description", "Local" },
                values: new object[] { new Guid("fa53bb0c-b2e3-4d95-8d2f-d2cbf86b0d02"), true, "Meeting Room 1", "Alameda dos Anjos" });

            migrationBuilder.InsertData(
                table: "MeetingRooms",
                columns: new[] { "MeetingRoomId", "Active", "Description", "Local" },
                values: new object[] { new Guid("618acd1f-897c-4a30-b0d2-8e8e787f7e94"), true, "Meeting Room 2", "Gotam City" });

            migrationBuilder.InsertData(
                table: "MeetingRooms",
                columns: new[] { "MeetingRoomId", "Active", "Description", "Local" },
                values: new object[] { new Guid("620b3555-4526-440b-af3c-3fb5c2aacfa5"), true, "Meeting Room 1", "Konoha" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MeetingRooms",
                keyColumn: "MeetingRoomId",
                keyValue: new Guid("618acd1f-897c-4a30-b0d2-8e8e787f7e94"));

            migrationBuilder.DeleteData(
                table: "MeetingRooms",
                keyColumn: "MeetingRoomId",
                keyValue: new Guid("620b3555-4526-440b-af3c-3fb5c2aacfa5"));

            migrationBuilder.DeleteData(
                table: "MeetingRooms",
                keyColumn: "MeetingRoomId",
                keyValue: new Guid("fa53bb0c-b2e3-4d95-8d2f-d2cbf86b0d02"));

            migrationBuilder.InsertData(
                table: "MeetingRooms",
                columns: new[] { "MeetingRoomId", "Active", "Description", "Local" },
                values: new object[] { new Guid("d7c278b2-9a98-4793-8a8d-2ec257bc007b"), true, "Meeting Room 1", "Alameda dos Anjos" });

            migrationBuilder.InsertData(
                table: "MeetingRooms",
                columns: new[] { "MeetingRoomId", "Active", "Description", "Local" },
                values: new object[] { new Guid("db84c0a7-15f5-42fc-9902-4efc8e8d9ddf"), true, "Meeting Room 2", "Gotam City" });

            migrationBuilder.InsertData(
                table: "MeetingRooms",
                columns: new[] { "MeetingRoomId", "Active", "Description", "Local" },
                values: new object[] { new Guid("8b392a9b-80d6-424e-87d5-84f2c73f362c"), true, "Meeting Room 1", "Konoha" });
        }
    }
}
