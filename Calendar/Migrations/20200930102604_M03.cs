using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calendar.Migrations
{
    public partial class M03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"), "54702b6c-f334-4900-80ec-8fb5ed3a766a", "Stylists role", "Stylist", "STYLIST", 1 },
                    { new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71"), "3cbe5c50-ec8e-4fa5-9c11-83910c5d14b6", "Administrators role", "Admin", "ADMIN", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "DefaultColor", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("54a3bc4b-11f6-4bb4-b533-39ceac4dafb2"), 0, "c762a28b-6eeb-484d-9f2f-58ae64c47970", new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(4422), "green", "michal.michal@seznam.cz", true, "Michal", "Michal", false, null, "MICHAL.MICHAL@SEZNAM.CZ", "MMICHAL", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "111222333", true, null, 2, false, "mmichal" },
                    { new Guid("aac3a6a0-c971-4fea-aed2-790ed9b7a6de"), 0, "3e0d9628-f18f-4f4b-bc85-1d57e41abf07", new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(4293), "pink", "sandra.nisterova@seznam.cz", true, "Sandra", "Nisterová", false, null, "SANDRA.NISTEROVA@SEZNAM.CZ", "SNISTEROVA", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "666555444", true, null, 2, false, "snisterova" },
                    { new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"), 0, "8fbad38b-233f-4a23-bd86-5a01d9e08cc7", new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(4117), "lightblue", "jiri.pragr@seznam.cz", true, "Jiří", "Prágr", false, null, "JIRI.PRAGR@SEZNAM.CZ", "JPRAGR", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "987654321", true, null, 2, false, "jpragr" },
                    { new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"), 0, "8efb102c-e1d6-47ce-96b5-88d0ac54f924", new DateTime(2020, 9, 30, 12, 26, 4, 442, DateTimeKind.Local).AddTicks(1494), "lightgreen", "xkalinam@email.cz", true, "Miroslav", "Kalina", false, null, "XKALINAM@EMAIL.CZ", "RESCATORX", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "123456789", true, null, 2, false, "RescatorX" },
                    { new Guid("3546d9ac-94bf-4bc0-95aa-c44b83e95a55"), 0, "433e661a-d55d-491f-babf-ef19df6f6c84", new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(4363), "yellow", "iveta.iveta@seznam.cz", true, "Iveta", "Iveta", false, null, "IVETA.IVETA@SEZNAM.CZ", "IIVETA", "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892", "777888999", true, null, 2, false, "iiveta" }
                });

            migrationBuilder.InsertData(
                table: "CalendarEventType",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { new Guid("89387522-843b-4aee-98b3-75ac1c80c1e8"), "lightbrown", "JINÉ" },
                    { new Guid("ba55b21c-eac8-440d-be6f-8ea971ede553"), "cyan", "VÝČES" },
                    { new Guid("8704d57e-38bf-45d4-bfe9-e34315adab54"), "red", "KONZULTACE" },
                    { new Guid("a38cc313-bbef-4143-8915-b9242bc143e2"), "green", "TONER" },
                    { new Guid("a592ee31-d662-45e9-bbcc-c46b8a48dff4"), "blue", "MSF" },
                    { new Guid("29f82be0-5f48-4ac9-aa76-bc00dd4507fb"), "brown", "MF" },
                    { new Guid("54639082-9dff-428d-9fb0-28c528aa34bf"), "orange", "BSF" },
                    { new Guid("3701d747-e546-4272-bc44-3e1c80bc2c71"), "pink", "BF" },
                    { new Guid("86e2c4f4-8149-4c10-8d34-09098a7c4dff"), "yellow", "SF" },
                    { new Guid("8e61e931-0ed3-4bcd-aff8-b46e1f6cc476"), "lightblue", "PS" },
                    { new Guid("15780fe4-ef61-4415-bd1a-696133eb3c29"), "magenta", "AGÁVE" },
                    { new Guid("35bcf96a-a7b8-4952-9596-7c9fbbb057f8"), "lightgreen", "F" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Added" },
                values: new object[,]
                {
                    { new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"), new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71"), new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(6965) },
                    { new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"), new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71"), new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7627) },
                    { new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"), new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"), new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7679) },
                    { new Guid("aac3a6a0-c971-4fea-aed2-790ed9b7a6de"), new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"), new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7702) },
                    { new Guid("3546d9ac-94bf-4bc0-95aa-c44b83e95a55"), new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"), new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7726) },
                    { new Guid("54a3bc4b-11f6-4bb4-b533-39ceac4dafb2"), new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"), new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7750) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"), "CalendarLoginProvider", "Token1", "Token1" },
                    { new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"), "CalendarLoginProvider", "Token2", "Token2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"), new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"), new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("3546d9ac-94bf-4bc0-95aa-c44b83e95a55"), new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("54a3bc4b-11f6-4bb4-b533-39ceac4dafb2"), new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"), new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("aac3a6a0-c971-4fea-aed2-790ed9b7a6de"), new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserTokens",
                keyColumns: new[] { "UserId", "LoginProvider", "Name" },
                keyValues: new object[] { new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"), "CalendarLoginProvider", "Token2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserTokens",
                keyColumns: new[] { "UserId", "LoginProvider", "Name" },
                keyValues: new object[] { new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"), "CalendarLoginProvider", "Token1" });

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("15780fe4-ef61-4415-bd1a-696133eb3c29"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("29f82be0-5f48-4ac9-aa76-bc00dd4507fb"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("35bcf96a-a7b8-4952-9596-7c9fbbb057f8"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("3701d747-e546-4272-bc44-3e1c80bc2c71"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("54639082-9dff-428d-9fb0-28c528aa34bf"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("86e2c4f4-8149-4c10-8d34-09098a7c4dff"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("8704d57e-38bf-45d4-bfe9-e34315adab54"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("89387522-843b-4aee-98b3-75ac1c80c1e8"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("8e61e931-0ed3-4bcd-aff8-b46e1f6cc476"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("a38cc313-bbef-4143-8915-b9242bc143e2"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("a592ee31-d662-45e9-bbcc-c46b8a48dff4"));

            migrationBuilder.DeleteData(
                table: "CalendarEventType",
                keyColumn: "Id",
                keyValue: new Guid("ba55b21c-eac8-440d-be6f-8ea971ede553"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3546d9ac-94bf-4bc0-95aa-c44b83e95a55"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("54a3bc4b-11f6-4bb4-b533-39ceac4dafb2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aac3a6a0-c971-4fea-aed2-790ed9b7a6de"));

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
    }
}
