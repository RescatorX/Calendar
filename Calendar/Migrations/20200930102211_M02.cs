using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendar.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("7e502507-6fa4-4b6c-a50b-445a97a2ff14"), new Guid("7fee6a73-5030-4f87-9b4f-0bdef0b43868") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bb3fe4a5-6dca-470c-b50a-6cdc70e6a1da"), new Guid("7fee6a73-5030-4f87-9b4f-0bdef0b43868") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bb3fe4a5-6dca-470c-b50a-6cdc70e6a1da"), new Guid("ff1ee1d7-122b-4c9b-b19d-2b2a10e0f27c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("db032eef-72ec-4f1a-bd7e-3e85eb71a65f"), new Guid("ff1ee1d7-122b-4c9b-b19d-2b2a10e0f27c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserTokens",
                keyColumns: new[] { "UserId", "LoginProvider", "Name" },
                keyValues: new object[] { new Guid("7e502507-6fa4-4b6c-a50b-445a97a2ff14"), "CalendarLoginProvider", "Token1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserTokens",
                keyColumns: new[] { "UserId", "LoginProvider", "Name" },
                keyValues: new object[] { new Guid("bb3fe4a5-6dca-470c-b50a-6cdc70e6a1da"), "CalendarLoginProvider", "Token2" });

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("0dedc278-11cd-4f01-81e1-9f675bee1d8a"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("16ebb38d-42ca-4144-b84e-e26bb9b553ab"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("33d974ef-290e-4e05-bba2-c6b802686213"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("4d1c89fc-e435-497f-ad5b-f898145bf7a3"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("6a5aec8d-5db7-4bb7-a378-1edab399689a"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("7395d4cb-7a9e-40f2-9bc5-044190608d37"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("77a4641d-0f7f-4697-ae95-882269bf689c"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("783d5122-5f5a-4f3c-a92d-60b5f9616756"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("b11e84d0-c38c-4e09-a0e0-8dea8fa732ef"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("c3ad5a8e-71ba-4cc8-ac1f-6557b7b26912"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("e2eb49f1-9a26-4a62-bc5b-644c24ef6be6"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("f546711f-2d14-4180-8e73-21e055e9dae8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7fee6a73-5030-4f87-9b4f-0bdef0b43868"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ff1ee1d7-122b-4c9b-b19d-2b2a10e0f27c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e502507-6fa4-4b6c-a50b-445a97a2ff14"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bb3fe4a5-6dca-470c-b50a-6cdc70e6a1da"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db032eef-72ec-4f1a-bd7e-3e85eb71a65f"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Status" },
                values: new object[,]
                {
                    { new Guid("9ceb321f-0a0b-4a45-9f45-2c2a17da761a"), "9dbc935b-fdb4-4da7-b4c6-6a75452c074e", "Stylists role", "Stylist", "STYLIST", 1 },
                    { new Guid("36c1d130-1233-42e4-a732-c33cc648331a"), "4aa87eaf-7cd5-4b34-8b64-0f46c57b3cc0", "Administrators role", "Admin", "ADMIN", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "DefaultColor", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("eb5875cd-35df-4638-a7c3-6d8bc0ff0188"), 0, "0e62101d-ac4e-457a-978f-8bd0b5221e8d", new DateTime(2020, 9, 30, 12, 22, 11, 58, DateTimeKind.Local).AddTicks(816), "green", "michal.michal@seznam.cz", true, "Michal", "Michal", false, null, "MICHAL.MICHAL@SEZNAM.CZ", "MMICHAL", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "111222333", true, null, 2, false, "mmichal" },
                    { new Guid("c9ed137c-6333-4246-8c24-680a5e61eaa2"), 0, "de2d987c-d190-48c2-9977-5237b0df2040", new DateTime(2020, 9, 30, 12, 22, 11, 58, DateTimeKind.Local).AddTicks(652), "pink", "sandra.nisterova@seznam.cz", true, "Sandra", "Nisterová", false, null, "SANDRA.NISTEROVA@SEZNAM.CZ", "SNISTEROVA", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "666555444", true, null, 2, false, "snisterova" },
                    { new Guid("57e9c5c9-0995-45ab-b5c3-bf4373533462"), 0, "687c82a8-abf7-4628-b02e-bbc099e66ca6", new DateTime(2020, 9, 30, 12, 22, 11, 58, DateTimeKind.Local).AddTicks(488), "lightblue", "jiri.pragr@seznam.cz", true, "Jiří", "Prágr", false, null, "JIRI.PRAGR@SEZNAM.CZ", "JPRAGR", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "987654321", true, null, 2, false, "jpragr" },
                    { new Guid("93b8792c-2cd6-4a75-9f96-1fa8aab99660"), 0, "62c67ae3-55b5-411c-8502-ce6b8269c6f9", new DateTime(2020, 9, 30, 12, 22, 11, 55, DateTimeKind.Local).AddTicks(8689), "lightgreen", "xkalinam@email.cz", true, "Miroslav", "Kalina", false, null, "XKALINAM@EMAIL.CZ", "RESCATORX", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "123456789", true, null, 2, false, "RescatorX" },
                    { new Guid("2647f5d5-f29a-4b26-9066-a8a6625f867e"), 0, "b34b2704-1110-40dc-b59f-67933236c547", new DateTime(2020, 9, 30, 12, 22, 11, 58, DateTimeKind.Local).AddTicks(751), "yellow", "iveta.iveta@seznam.cz", true, "Iveta", "Iveta", false, null, "IVETA.IVETA@SEZNAM.CZ", "IIVETA", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "777888999", true, null, 2, false, "iiveta" }
                });

            migrationBuilder.InsertData(
                table: "CalendarEventType",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { new Guid("e7d69b69-13ad-44f5-b291-f6c4f4b186bc"), "lightbrown", "JINÉ" },
                    { new Guid("5a52d99b-ac05-409e-abd2-668a80e6be50"), "cyan", "VÝČES" },
                    { new Guid("f5f500b0-3c71-490f-bac0-a757c58de99e"), "red", "KONZULTACE" },
                    { new Guid("679d74cd-f790-4927-b6e3-b383b6ac5cea"), "green", "TONER" },
                    { new Guid("0cee543d-aef7-4b25-975f-07179df27537"), "blue", "MSF" },
                    { new Guid("9de04db1-7ed8-473d-a531-2f0a4044089c"), "brown", "MF" },
                    { new Guid("0253df6e-77fc-4cd0-a77f-3019bb4ca5c5"), "orange", "BSF" },
                    { new Guid("873e54c1-e758-406a-8786-a9cd482bfd7d"), "pink", "BF" },
                    { new Guid("134e7506-e905-4527-9280-6239f5540280"), "yellow", "SF" },
                    { new Guid("9c37d3ac-3b57-40c6-9710-6edfc2ba197c"), "lightblue", "PS" },
                    { new Guid("034a2d2a-d5d6-48a5-a76a-5eef35da93ef"), "magenta", "AGÁVE" },
                    { new Guid("e4a9ed74-0a95-4dee-99e8-02c0386bed5d"), "lightgreen", "F" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Added" },
                values: new object[,]
                {
                    { new Guid("93b8792c-2cd6-4a75-9f96-1fa8aab99660"), new Guid("36c1d130-1233-42e4-a732-c33cc648331a"), new DateTime(2020, 9, 30, 12, 22, 11, 58, DateTimeKind.Local).AddTicks(3188) },
                    { new Guid("57e9c5c9-0995-45ab-b5c3-bf4373533462"), new Guid("36c1d130-1233-42e4-a732-c33cc648331a"), new DateTime(2020, 9, 30, 12, 22, 11, 58, DateTimeKind.Local).AddTicks(3840) },
                    { new Guid("57e9c5c9-0995-45ab-b5c3-bf4373533462"), new Guid("9ceb321f-0a0b-4a45-9f45-2c2a17da761a"), new DateTime(2020, 9, 30, 12, 22, 11, 58, DateTimeKind.Local).AddTicks(3892) },
                    { new Guid("c9ed137c-6333-4246-8c24-680a5e61eaa2"), new Guid("9ceb321f-0a0b-4a45-9f45-2c2a17da761a"), new DateTime(2020, 9, 30, 12, 22, 11, 58, DateTimeKind.Local).AddTicks(3915) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("93b8792c-2cd6-4a75-9f96-1fa8aab99660"), "CalendarLoginProvider", "Token1", "Token1" },
                    { new Guid("57e9c5c9-0995-45ab-b5c3-bf4373533462"), "CalendarLoginProvider", "Token2", "Token2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("57e9c5c9-0995-45ab-b5c3-bf4373533462"), new Guid("36c1d130-1233-42e4-a732-c33cc648331a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("57e9c5c9-0995-45ab-b5c3-bf4373533462"), new Guid("9ceb321f-0a0b-4a45-9f45-2c2a17da761a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("93b8792c-2cd6-4a75-9f96-1fa8aab99660"), new Guid("36c1d130-1233-42e4-a732-c33cc648331a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c9ed137c-6333-4246-8c24-680a5e61eaa2"), new Guid("9ceb321f-0a0b-4a45-9f45-2c2a17da761a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserTokens",
                keyColumns: new[] { "UserId", "LoginProvider", "Name" },
                keyValues: new object[] { new Guid("57e9c5c9-0995-45ab-b5c3-bf4373533462"), "CalendarLoginProvider", "Token2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserTokens",
                keyColumns: new[] { "UserId", "LoginProvider", "Name" },
                keyValues: new object[] { new Guid("93b8792c-2cd6-4a75-9f96-1fa8aab99660"), "CalendarLoginProvider", "Token1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2647f5d5-f29a-4b26-9066-a8a6625f867e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("eb5875cd-35df-4638-a7c3-6d8bc0ff0188"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("0253df6e-77fc-4cd0-a77f-3019bb4ca5c5"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("034a2d2a-d5d6-48a5-a76a-5eef35da93ef"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("0cee543d-aef7-4b25-975f-07179df27537"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("134e7506-e905-4527-9280-6239f5540280"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("5a52d99b-ac05-409e-abd2-668a80e6be50"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("679d74cd-f790-4927-b6e3-b383b6ac5cea"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("873e54c1-e758-406a-8786-a9cd482bfd7d"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("9c37d3ac-3b57-40c6-9710-6edfc2ba197c"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("9de04db1-7ed8-473d-a531-2f0a4044089c"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("e4a9ed74-0a95-4dee-99e8-02c0386bed5d"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("e7d69b69-13ad-44f5-b291-f6c4f4b186bc"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("f5f500b0-3c71-490f-bac0-a757c58de99e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("36c1d130-1233-42e4-a732-c33cc648331a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9ceb321f-0a0b-4a45-9f45-2c2a17da761a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57e9c5c9-0995-45ab-b5c3-bf4373533462"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("93b8792c-2cd6-4a75-9f96-1fa8aab99660"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c9ed137c-6333-4246-8c24-680a5e61eaa2"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Status" },
                values: new object[,]
                {
                    { new Guid("ff1ee1d7-122b-4c9b-b19d-2b2a10e0f27c"), "bebcb31e-b3f8-441b-b01d-e06e51a2bb62", "Stylists role", "Stylist", "STYLIST", 1 },
                    { new Guid("7fee6a73-5030-4f87-9b4f-0bdef0b43868"), "55e22040-1d6d-4640-aebd-3f8b6764eca9", "Administrators role", "Admin", "ADMIN", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "DefaultColor", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("db032eef-72ec-4f1a-bd7e-3e85eb71a65f"), 0, "09b4c35e-100e-4465-8095-28a3131b91b2", new DateTime(2020, 9, 25, 11, 14, 37, 878, DateTimeKind.Local).AddTicks(3990), "pink", "sandra.nisterova@seznam.cz", true, "Sandra", "Nisterová", false, null, "SANDRA.NISTEROVA@SEZNAM.CZ", "SNISTEROVA", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "666555444", true, null, 2, false, "snisterova" },
                    { new Guid("7e502507-6fa4-4b6c-a50b-445a97a2ff14"), 0, "f1bea363-ff97-4343-bd58-b7f33a3ef316", new DateTime(2020, 9, 25, 11, 14, 37, 876, DateTimeKind.Local).AddTicks(3000), "lightgreen", "xkalinam@email.cz", true, "Miroslav", "Kalina", false, null, "XKALINAM@EMAIL.CZ", "RESCATORX", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "123456789", true, null, 2, false, "RescatorX" },
                    { new Guid("bb3fe4a5-6dca-470c-b50a-6cdc70e6a1da"), 0, "0a49e523-5af3-42f0-a1fb-68ae829d058e", new DateTime(2020, 9, 25, 11, 14, 37, 878, DateTimeKind.Local).AddTicks(3765), "lightblue", "jiri.pragr@seznam.cz", true, "Jiří", "Prágr", false, null, "JIRI.PRAGR@SEZNAM.CZ", "JPRAGR", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "987654321", true, null, 2, false, "jpragr" }
                });

            migrationBuilder.InsertData(
                table: "CalendarEventType",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { new Guid("e2eb49f1-9a26-4a62-bc5b-644c24ef6be6"), "lightbrown", "JINÉ" },
                    { new Guid("6a5aec8d-5db7-4bb7-a378-1edab399689a"), "cyan", "VÝČES" },
                    { new Guid("7395d4cb-7a9e-40f2-9bc5-044190608d37"), "red", "KONZULTACE" },
                    { new Guid("c3ad5a8e-71ba-4cc8-ac1f-6557b7b26912"), "magenta", "AGÁVE" },
                    { new Guid("0dedc278-11cd-4f01-81e1-9f675bee1d8a"), "blue", "MSF" },
                    { new Guid("33d974ef-290e-4e05-bba2-c6b802686213"), "brown", "MF" },
                    { new Guid("16ebb38d-42ca-4144-b84e-e26bb9b553ab"), "orange", "BSF" },
                    { new Guid("b11e84d0-c38c-4e09-a0e0-8dea8fa732ef"), "pink", "BF" },
                    { new Guid("783d5122-5f5a-4f3c-a92d-60b5f9616756"), "yellow", "SF" },
                    { new Guid("f546711f-2d14-4180-8e73-21e055e9dae8"), "lightblue", "PS" },
                    { new Guid("77a4641d-0f7f-4697-ae95-882269bf689c"), "green", "TONER" },
                    { new Guid("4d1c89fc-e435-497f-ad5b-f898145bf7a3"), "lightgreen", "F" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Added" },
                values: new object[,]
                {
                    { new Guid("7e502507-6fa4-4b6c-a50b-445a97a2ff14"), new Guid("7fee6a73-5030-4f87-9b4f-0bdef0b43868"), new DateTime(2020, 9, 25, 11, 14, 37, 878, DateTimeKind.Local).AddTicks(6528) },
                    { new Guid("bb3fe4a5-6dca-470c-b50a-6cdc70e6a1da"), new Guid("7fee6a73-5030-4f87-9b4f-0bdef0b43868"), new DateTime(2020, 9, 25, 11, 14, 37, 878, DateTimeKind.Local).AddTicks(7189) },
                    { new Guid("bb3fe4a5-6dca-470c-b50a-6cdc70e6a1da"), new Guid("ff1ee1d7-122b-4c9b-b19d-2b2a10e0f27c"), new DateTime(2020, 9, 25, 11, 14, 37, 878, DateTimeKind.Local).AddTicks(7245) },
                    { new Guid("db032eef-72ec-4f1a-bd7e-3e85eb71a65f"), new Guid("ff1ee1d7-122b-4c9b-b19d-2b2a10e0f27c"), new DateTime(2020, 9, 25, 11, 14, 37, 878, DateTimeKind.Local).AddTicks(7271) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("7e502507-6fa4-4b6c-a50b-445a97a2ff14"), "CalendarLoginProvider", "Token1", "Token1" },
                    { new Guid("bb3fe4a5-6dca-470c-b50a-6cdc70e6a1da"), "CalendarLoginProvider", "Token2", "Token2" }
                });
        }
    }
}
