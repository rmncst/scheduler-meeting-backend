﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchedulerMeeting.Api.Data;

namespace SchedulerMeeting.Api.Migrations
{
    [DbContext(typeof(SchedulerMeetingContext))]
    [Migration("20200419192059_SchedulingEntity")]
    partial class SchedulingEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("SchedulerMeeting.Api.Models.MeetingRoom", b =>
                {
                    b.Property<Guid>("MeetingRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Local")
                        .HasColumnType("TEXT");

                    b.HasKey("MeetingRoomId");

                    b.ToTable("MeetingRooms");
                });

            modelBuilder.Entity("SchedulerMeeting.Api.Models.Scheduling", b =>
                {
                    b.Property<Guid>("SchedulingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observation")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RoomMeetingRoomId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SchedulingEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SchedulingStart")
                        .HasColumnType("TEXT");

                    b.HasKey("SchedulingId");

                    b.HasIndex("RoomMeetingRoomId");

                    b.ToTable("Schedulings");
                });

            modelBuilder.Entity("SchedulerMeeting.Api.Models.Scheduling", b =>
                {
                    b.HasOne("SchedulerMeeting.Api.Models.MeetingRoom", "Room")
                        .WithMany()
                        .HasForeignKey("RoomMeetingRoomId");
                });
#pragma warning restore 612, 618
        }
    }
}
