using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulerMeeting.Api.Migrations
{
    public partial class SchedulingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedulings",
                columns: table => new
                {
                    SchedulingId = table.Column<Guid>(nullable: false),
                    SchedulingStart = table.Column<DateTime>(nullable: false),
                    SchedulingEnd = table.Column<DateTime>(nullable: false),
                    RoomMeetingRoomId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Observation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedulings", x => x.SchedulingId);
                    table.ForeignKey(
                        name: "FK_Schedulings_MeetingRooms_RoomMeetingRoomId",
                        column: x => x.RoomMeetingRoomId,
                        principalTable: "MeetingRooms",
                        principalColumn: "MeetingRoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedulings_RoomMeetingRoomId",
                table: "Schedulings",
                column: "RoomMeetingRoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedulings");
        }
    }
}
