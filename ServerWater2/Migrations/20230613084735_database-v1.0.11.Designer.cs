﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ServerWater2.Models;

#nullable disable

namespace ServerWater2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230613084735_database-v1.0.11")]
    partial class databasev1011
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ServerWater2.Models.SqlAction", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Action");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlArea", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastestTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nameArea")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlCustomer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("SqlAreaID")
                        .HasColumnType("bigint");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<string>>("images")
                        .HasColumnType("text[]");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("route")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("SqlAreaID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlDevice", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("SqlCustomerID")
                        .HasColumnType("bigint");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastestTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nameDevice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("startTimeSChedule")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("typeID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("SqlCustomerID");

                    b.HasIndex("typeID");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlFile", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("time")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.ToTable("File");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLayer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastestTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nameLayer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Layer");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLogDevice", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("deviceID")
                        .HasColumnType("bigint");

                    b.Property<List<string>>("images")
                        .HasColumnType("text[]");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("pointID")
                        .HasColumnType("bigint");

                    b.Property<long?>("scheduleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("timeDo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("timeRef")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("userID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("deviceID");

                    b.HasIndex("pointID");

                    b.HasIndex("scheduleID");

                    b.HasIndex("userID");

                    b.ToTable("LogDevice");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLogOrder", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("actionID")
                        .HasColumnType("bigint");

                    b.Property<List<string>>("images")
                        .HasColumnType("text[]");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("orderID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("time")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("userID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("actionID");

                    b.HasIndex("orderID");

                    b.HasIndex("userID");

                    b.ToTable("LogOrder");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLogValue", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("deviceID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("time")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("valueConfigID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("deviceID");

                    b.HasIndex("valueConfigID");

                    b.ToTable("LogValue");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlOrder", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("addressContract")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("addressCustomer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("addressWater")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("customerID")
                        .HasColumnType("bigint");

                    b.Property<bool>("isDelete")
                        .HasColumnType("boolean");

                    b.Property<bool>("isFinish")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastestTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("managerID")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("receiverID")
                        .HasColumnType("bigint");

                    b.Property<long?>("serviceID")
                        .HasColumnType("bigint");

                    b.Property<long?>("stateID")
                        .HasColumnType("bigint");

                    b.Property<long?>("typeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("workerID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("customerID");

                    b.HasIndex("managerID");

                    b.HasIndex("receiverID");

                    b.HasIndex("serviceID");

                    b.HasIndex("stateID");

                    b.HasIndex("typeID");

                    b.HasIndex("workerID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlPoint", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("imageShow")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<string>>("images")
                        .HasColumnType("text[]");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastestTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("namePoint")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlRole", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlSchedule", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("SqlTypeID")
                        .HasColumnType("bigint");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastestTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("period")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("SqlTypeID");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlService", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlState", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<int>("code")
                        .HasColumnType("integer");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("State");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlStatus", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("isOnline")
                        .HasColumnType("boolean");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastestTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nameStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlUser", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("displayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isClear")
                        .HasColumnType("boolean");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("notifications")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("roleID")
                        .HasColumnType("bigint");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("roleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlValue", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("SqlTypeID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("nameValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("SqlTypeID");

                    b.ToTable("Value");
                });

            modelBuilder.Entity("SqlAreaSqlPoint", b =>
                {
                    b.Property<long>("areasID")
                        .HasColumnType("bigint");

                    b.Property<long>("pointsID")
                        .HasColumnType("bigint");

                    b.HasKey("areasID", "pointsID");

                    b.HasIndex("pointsID");

                    b.ToTable("SqlAreaSqlPoint");
                });

            modelBuilder.Entity("SqlAreaSqlUser", b =>
                {
                    b.Property<long>("areasID")
                        .HasColumnType("bigint");

                    b.Property<long>("usersID")
                        .HasColumnType("bigint");

                    b.HasKey("areasID", "usersID");

                    b.HasIndex("usersID");

                    b.ToTable("SqlAreaSqlUser");
                });

            modelBuilder.Entity("SqlDeviceSqlLayer", b =>
                {
                    b.Property<long>("devicesID")
                        .HasColumnType("bigint");

                    b.Property<long>("layersID")
                        .HasColumnType("bigint");

                    b.HasKey("devicesID", "layersID");

                    b.HasIndex("layersID");

                    b.ToTable("SqlDeviceSqlLayer");
                });

            modelBuilder.Entity("SqlDeviceSqlPoint", b =>
                {
                    b.Property<long>("devicesID")
                        .HasColumnType("bigint");

                    b.Property<long>("pointsID")
                        .HasColumnType("bigint");

                    b.HasKey("devicesID", "pointsID");

                    b.HasIndex("pointsID");

                    b.ToTable("SqlDeviceSqlPoint");
                });

            modelBuilder.Entity("SqlStatusSqlType", b =>
                {
                    b.Property<long>("statussID")
                        .HasColumnType("bigint");

                    b.Property<long>("typesID")
                        .HasColumnType("bigint");

                    b.HasKey("statussID", "typesID");

                    b.HasIndex("typesID");

                    b.ToTable("SqlStatusSqlType");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlCustomer", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlArea", null)
                        .WithMany("customers")
                        .HasForeignKey("SqlAreaID");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlDevice", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlCustomer", null)
                        .WithMany("devices")
                        .HasForeignKey("SqlCustomerID");

                    b.HasOne("ServerWater2.Models.SqlType", "type")
                        .WithMany()
                        .HasForeignKey("typeID");

                    b.Navigation("type");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLogDevice", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlDevice", "device")
                        .WithMany()
                        .HasForeignKey("deviceID");

                    b.HasOne("ServerWater2.Models.SqlPoint", "point")
                        .WithMany()
                        .HasForeignKey("pointID");

                    b.HasOne("ServerWater2.Models.SqlSchedule", "schedule")
                        .WithMany()
                        .HasForeignKey("scheduleID");

                    b.HasOne("ServerWater2.Models.SqlUser", "user")
                        .WithMany()
                        .HasForeignKey("userID");

                    b.Navigation("device");

                    b.Navigation("point");

                    b.Navigation("schedule");

                    b.Navigation("user");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLogOrder", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlAction", "action")
                        .WithMany()
                        .HasForeignKey("actionID");

                    b.HasOne("ServerWater2.Models.SqlOrder", "order")
                        .WithMany()
                        .HasForeignKey("orderID");

                    b.HasOne("ServerWater2.Models.SqlUser", "user")
                        .WithMany()
                        .HasForeignKey("userID");

                    b.Navigation("action");

                    b.Navigation("order");

                    b.Navigation("user");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLogValue", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlDevice", "device")
                        .WithMany()
                        .HasForeignKey("deviceID");

                    b.HasOne("ServerWater2.Models.SqlValue", "valueConfig")
                        .WithMany()
                        .HasForeignKey("valueConfigID");

                    b.Navigation("device");

                    b.Navigation("valueConfig");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlOrder", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlCustomer", "customer")
                        .WithMany("orders")
                        .HasForeignKey("customerID");

                    b.HasOne("ServerWater2.Models.SqlUser", "manager")
                        .WithMany("managerOrders")
                        .HasForeignKey("managerID");

                    b.HasOne("ServerWater2.Models.SqlUser", "receiver")
                        .WithMany("receiverOrders")
                        .HasForeignKey("receiverID");

                    b.HasOne("ServerWater2.Models.SqlService", "service")
                        .WithMany()
                        .HasForeignKey("serviceID");

                    b.HasOne("ServerWater2.Models.SqlState", "state")
                        .WithMany()
                        .HasForeignKey("stateID");

                    b.HasOne("ServerWater2.Models.SqlType", "type")
                        .WithMany()
                        .HasForeignKey("typeID");

                    b.HasOne("ServerWater2.Models.SqlUser", "worker")
                        .WithMany("workerOrders")
                        .HasForeignKey("workerID");

                    b.Navigation("customer");

                    b.Navigation("manager");

                    b.Navigation("receiver");

                    b.Navigation("service");

                    b.Navigation("state");

                    b.Navigation("type");

                    b.Navigation("worker");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlSchedule", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlType", null)
                        .WithMany("schedules")
                        .HasForeignKey("SqlTypeID");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlUser", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlRole", "role")
                        .WithMany()
                        .HasForeignKey("roleID");

                    b.Navigation("role");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlValue", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlType", null)
                        .WithMany("values")
                        .HasForeignKey("SqlTypeID");
                });

            modelBuilder.Entity("SqlAreaSqlPoint", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlArea", null)
                        .WithMany()
                        .HasForeignKey("areasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerWater2.Models.SqlPoint", null)
                        .WithMany()
                        .HasForeignKey("pointsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SqlAreaSqlUser", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlArea", null)
                        .WithMany()
                        .HasForeignKey("areasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerWater2.Models.SqlUser", null)
                        .WithMany()
                        .HasForeignKey("usersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SqlDeviceSqlLayer", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlDevice", null)
                        .WithMany()
                        .HasForeignKey("devicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerWater2.Models.SqlLayer", null)
                        .WithMany()
                        .HasForeignKey("layersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SqlDeviceSqlPoint", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlDevice", null)
                        .WithMany()
                        .HasForeignKey("devicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerWater2.Models.SqlPoint", null)
                        .WithMany()
                        .HasForeignKey("pointsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SqlStatusSqlType", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlStatus", null)
                        .WithMany()
                        .HasForeignKey("statussID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerWater2.Models.SqlType", null)
                        .WithMany()
                        .HasForeignKey("typesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServerWater2.Models.SqlArea", b =>
                {
                    b.Navigation("customers");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlCustomer", b =>
                {
                    b.Navigation("devices");

                    b.Navigation("orders");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlType", b =>
                {
                    b.Navigation("schedules");

                    b.Navigation("values");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlUser", b =>
                {
                    b.Navigation("managerOrders");

                    b.Navigation("receiverOrders");

                    b.Navigation("workerOrders");
                });
#pragma warning restore 612, 618
        }
    }
}