﻿// <auto-generated />
using System;
using Calendar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Calendar.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200930102604_M03")]
    partial class M03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Calendar.Data.Entities.AuditTrail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AuditTrail");
                });

            modelBuilder.Entity("Calendar.Data.Entities.CalendarEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AllDay")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EventTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("SendEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("SendSms")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EventTypeId");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("OwnerId");

                    b.ToTable("CalendarEvent");
                });

            modelBuilder.Entity("Calendar.Data.Entities.CalendarEventType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CalendarEventType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("35bcf96a-a7b8-4952-9596-7c9fbbb057f8"),
                            Color = "lightgreen",
                            Name = "F"
                        },
                        new
                        {
                            Id = new Guid("8e61e931-0ed3-4bcd-aff8-b46e1f6cc476"),
                            Color = "lightblue",
                            Name = "PS"
                        },
                        new
                        {
                            Id = new Guid("86e2c4f4-8149-4c10-8d34-09098a7c4dff"),
                            Color = "yellow",
                            Name = "SF"
                        },
                        new
                        {
                            Id = new Guid("3701d747-e546-4272-bc44-3e1c80bc2c71"),
                            Color = "pink",
                            Name = "BF"
                        },
                        new
                        {
                            Id = new Guid("54639082-9dff-428d-9fb0-28c528aa34bf"),
                            Color = "orange",
                            Name = "BSF"
                        },
                        new
                        {
                            Id = new Guid("29f82be0-5f48-4ac9-aa76-bc00dd4507fb"),
                            Color = "brown",
                            Name = "MF"
                        },
                        new
                        {
                            Id = new Guid("a592ee31-d662-45e9-bbcc-c46b8a48dff4"),
                            Color = "blue",
                            Name = "MSF"
                        },
                        new
                        {
                            Id = new Guid("a38cc313-bbef-4143-8915-b9242bc143e2"),
                            Color = "green",
                            Name = "TONER"
                        },
                        new
                        {
                            Id = new Guid("15780fe4-ef61-4415-bd1a-696133eb3c29"),
                            Color = "magenta",
                            Name = "AGÁVE"
                        },
                        new
                        {
                            Id = new Guid("8704d57e-38bf-45d4-bfe9-e34315adab54"),
                            Color = "red",
                            Name = "KONZULTACE"
                        },
                        new
                        {
                            Id = new Guid("ba55b21c-eac8-440d-be6f-8ea971ede553"),
                            Color = "cyan",
                            Name = "VÝČES"
                        },
                        new
                        {
                            Id = new Guid("89387522-843b-4aee-98b3-75ac1c80c1e8"),
                            Color = "lightbrown",
                            Name = "JINÉ"
                        });
                });

            modelBuilder.Entity("Calendar.Data.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SendEmails")
                        .HasColumnType("bit");

                    b.Property<bool>("SendSmss")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Calendar.Models.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71"),
                            ConcurrencyStamp = "3cbe5c50-ec8e-4fa5-9c11-83910c5d14b6",
                            Description = "Administrators role",
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"),
                            ConcurrencyStamp = "54702b6c-f334-4900-80ec-8fb5ed3a766a",
                            Description = "Stylists role",
                            Name = "Stylist",
                            NormalizedName = "STYLIST",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Calendar.Models.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefaultColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8efb102c-e1d6-47ce-96b5-88d0ac54f924",
                            Created = new DateTime(2020, 9, 30, 12, 26, 4, 442, DateTimeKind.Local).AddTicks(1494),
                            DefaultColor = "lightgreen",
                            Email = "xkalinam@email.cz",
                            EmailConfirmed = true,
                            FirstName = "Miroslav",
                            LastName = "Kalina",
                            LockoutEnabled = false,
                            NormalizedEmail = "XKALINAM@EMAIL.CZ",
                            NormalizedUserName = "RESCATORX",
                            PasswordHash = "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892",
                            PhoneNumber = "123456789",
                            PhoneNumberConfirmed = true,
                            Status = 2,
                            TwoFactorEnabled = false,
                            UserName = "RescatorX"
                        },
                        new
                        {
                            Id = new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8fbad38b-233f-4a23-bd86-5a01d9e08cc7",
                            Created = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(4117),
                            DefaultColor = "lightblue",
                            Email = "jiri.pragr@seznam.cz",
                            EmailConfirmed = true,
                            FirstName = "Jiří",
                            LastName = "Prágr",
                            LockoutEnabled = false,
                            NormalizedEmail = "JIRI.PRAGR@SEZNAM.CZ",
                            NormalizedUserName = "JPRAGR",
                            PasswordHash = "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892",
                            PhoneNumber = "987654321",
                            PhoneNumberConfirmed = true,
                            Status = 2,
                            TwoFactorEnabled = false,
                            UserName = "jpragr"
                        },
                        new
                        {
                            Id = new Guid("aac3a6a0-c971-4fea-aed2-790ed9b7a6de"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e0d9628-f18f-4f4b-bc85-1d57e41abf07",
                            Created = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(4293),
                            DefaultColor = "pink",
                            Email = "sandra.nisterova@seznam.cz",
                            EmailConfirmed = true,
                            FirstName = "Sandra",
                            LastName = "Nisterová",
                            LockoutEnabled = false,
                            NormalizedEmail = "SANDRA.NISTEROVA@SEZNAM.CZ",
                            NormalizedUserName = "SNISTEROVA",
                            PasswordHash = "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892",
                            PhoneNumber = "666555444",
                            PhoneNumberConfirmed = true,
                            Status = 2,
                            TwoFactorEnabled = false,
                            UserName = "snisterova"
                        },
                        new
                        {
                            Id = new Guid("3546d9ac-94bf-4bc0-95aa-c44b83e95a55"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "433e661a-d55d-491f-babf-ef19df6f6c84",
                            Created = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(4363),
                            DefaultColor = "yellow",
                            Email = "iveta.iveta@seznam.cz",
                            EmailConfirmed = true,
                            FirstName = "Iveta",
                            LastName = "Iveta",
                            LockoutEnabled = false,
                            NormalizedEmail = "IVETA.IVETA@SEZNAM.CZ",
                            NormalizedUserName = "IIVETA",
                            PasswordHash = "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892",
                            PhoneNumber = "777888999",
                            PhoneNumberConfirmed = true,
                            Status = 2,
                            TwoFactorEnabled = false,
                            UserName = "iiveta"
                        },
                        new
                        {
                            Id = new Guid("54a3bc4b-11f6-4bb4-b533-39ceac4dafb2"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c762a28b-6eeb-484d-9f2f-58ae64c47970",
                            Created = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(4422),
                            DefaultColor = "green",
                            Email = "michal.michal@seznam.cz",
                            EmailConfirmed = true,
                            FirstName = "Michal",
                            LastName = "Michal",
                            LockoutEnabled = false,
                            NormalizedEmail = "MICHAL.MICHAL@SEZNAM.CZ",
                            NormalizedUserName = "MMICHAL",
                            PasswordHash = "d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892",
                            PhoneNumber = "111222333",
                            PhoneNumberConfirmed = true,
                            Status = 2,
                            TwoFactorEnabled = false,
                            UserName = "mmichal"
                        });
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Added")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"),
                            RoleId = new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71"),
                            Added = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(6965)
                        },
                        new
                        {
                            UserId = new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"),
                            RoleId = new Guid("35e5d761-1ab6-4730-b68e-00f0430eec71"),
                            Added = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7627)
                        },
                        new
                        {
                            UserId = new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"),
                            RoleId = new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"),
                            Added = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7679)
                        },
                        new
                        {
                            UserId = new Guid("aac3a6a0-c971-4fea-aed2-790ed9b7a6de"),
                            RoleId = new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"),
                            Added = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7702)
                        },
                        new
                        {
                            UserId = new Guid("3546d9ac-94bf-4bc0-95aa-c44b83e95a55"),
                            RoleId = new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"),
                            Added = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7726)
                        },
                        new
                        {
                            UserId = new Guid("54a3bc4b-11f6-4bb4-b533-39ceac4dafb2"),
                            RoleId = new Guid("1c0818b6-bde5-484d-a424-200c2af2fda2"),
                            Added = new DateTime(2020, 9, 30, 12, 26, 4, 444, DateTimeKind.Local).AddTicks(7750)
                        });
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("88033fb6-de8d-46c9-a7c1-c9902e29b39b"),
                            LoginProvider = "CalendarLoginProvider",
                            Name = "Token1",
                            Value = "Token1"
                        },
                        new
                        {
                            UserId = new Guid("30fe9cb3-bfb7-4ecf-8e16-2e01e3ad92c5"),
                            LoginProvider = "CalendarLoginProvider",
                            Name = "Token2",
                            Value = "Token2"
                        });
                });

            modelBuilder.Entity("Calendar.Data.Entities.AuditTrail", b =>
                {
                    b.HasOne("Calendar.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Calendar.Data.Entities.CalendarEvent", b =>
                {
                    b.HasOne("Calendar.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("Calendar.Data.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Calendar.Data.Entities.CalendarEventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeId");

                    b.HasOne("Calendar.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("Calendar.Models.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("Calendar.Models.ApplicationRoleClaim", b =>
                {
                    b.HasOne("Calendar.Models.ApplicationRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUserClaim", b =>
                {
                    b.HasOne("Calendar.Models.ApplicationUser", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUserLogin", b =>
                {
                    b.HasOne("Calendar.Models.ApplicationUser", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUserRole", b =>
                {
                    b.HasOne("Calendar.Models.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Calendar.Models.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Calendar.Models.ApplicationUserToken", b =>
                {
                    b.HasOne("Calendar.Models.ApplicationUser", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
