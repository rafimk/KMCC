using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MMS.Infrastructure.EF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MMS");

            migrationBuilder.CreateTable(
                name: "Districts",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembershipPeriods",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Start = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    RegistrationUntil = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    MobileNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    AlternativeContactNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    VerifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mandalams",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DistrictId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mandalams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mandalams_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "MMS",
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StateId = table.Column<Guid>(type: "uuid", nullable: false),
                    Prefix = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Areas_States_StateId",
                        column: x => x.StateId,
                        principalSchema: "MMS",
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Panchayats",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    MandalamId = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panchayats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Panchayats_Mandalams_MandalamId",
                        column: x => x.MandalamId,
                        principalSchema: "MMS",
                        principalTable: "Mandalams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                schema: "MMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MembershipId = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    EmiratesIdNumber = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EmiratesIdExpiry = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EmiratesIdFrontPage = table.Column<Guid>(type: "uuid", nullable: true),
                    EmiratesIdLastPage = table.Column<Guid>(type: "uuid", nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    MobileNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    AlternativeContactNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PassportNumber = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    PassportExpiry = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    PassportFrontPage = table.Column<Guid>(type: "uuid", nullable: true),
                    PassportLastPage = table.Column<Guid>(type: "uuid", nullable: true),
                    ProfessionId = table.Column<Guid>(type: "uuid", nullable: false),
                    QualificationId = table.Column<Guid>(type: "uuid", nullable: false),
                    BloodGroup = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<Guid>(type: "uuid", nullable: true),
                    HouseName = table.Column<string>(type: "text", nullable: true),
                    AddressInIndia = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    AreaId = table.Column<Guid>(type: "uuid", nullable: false),
                    MandalamId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsMemberOfAnyIndianRegisteredOrganization = table.Column<bool>(type: "boolean", nullable: false),
                    IsKMCCWelfareScheme = table.Column<bool>(type: "boolean", nullable: false),
                    CollectedAmount = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    VerifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memberships_Areas_AreaId",
                        column: x => x.AreaId,
                        principalSchema: "MMS",
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Mandalams_MandalamId",
                        column: x => x.MandalamId,
                        principalSchema: "MMS",
                        principalTable: "Mandalams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalSchema: "MMS",
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalSchema: "MMS",
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_StateId",
                schema: "MMS",
                table: "Areas",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Mandalams_DistrictId",
                schema: "MMS",
                table: "Mandalams",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_AreaId",
                schema: "MMS",
                table: "Memberships",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_Email",
                schema: "MMS",
                table: "Memberships",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_MandalamId",
                schema: "MMS",
                table: "Memberships",
                column: "MandalamId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_ProfessionId",
                schema: "MMS",
                table: "Memberships",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_QualificationId",
                schema: "MMS",
                table: "Memberships",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Panchayats_MandalamId",
                schema: "MMS",
                table: "Panchayats",
                column: "MandalamId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                schema: "MMS",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MembershipPeriods",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "Memberships",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "Panchayats",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "Areas",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "Professions",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "Qualifications",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "Mandalams",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "States",
                schema: "MMS");

            migrationBuilder.DropTable(
                name: "Districts",
                schema: "MMS");
        }
    }
}
