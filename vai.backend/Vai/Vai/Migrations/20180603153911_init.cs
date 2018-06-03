using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vai.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Researches",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BallTrowing = table.Column<double>(nullable: false),
                    BloodPressureDiastolic = table.Column<double>(nullable: false),
                    BloodPressureSystolic = table.Column<double>(nullable: false),
                    Cholestirol = table.Column<double>(nullable: false),
                    CircumFenceArm = table.Column<double>(nullable: false),
                    CircumFenceChest = table.Column<double>(nullable: false),
                    CircumFenceCrus = table.Column<double>(nullable: false),
                    CircumFenceHead = table.Column<double>(nullable: false),
                    CircumFenceNeck = table.Column<double>(nullable: false),
                    CircumFenceThigh = table.Column<double>(nullable: false),
                    CircumFenceWaist = table.Column<double>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DynamometyLeftHand = table.Column<double>(nullable: false),
                    DynamometyRightHand = table.Column<double>(nullable: false),
                    DynamometySpine = table.Column<double>(nullable: false),
                    Glucose = table.Column<double>(nullable: false),
                    GrenadeTrowing = table.Column<double>(nullable: false),
                    HandsLength = table.Column<double>(nullable: false),
                    HeartRateRest = table.Column<double>(nullable: false),
                    HeartRateTotalRest = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Hemoglobin = table.Column<double>(nullable: false),
                    HypoxicTestExpiration = table.Column<double>(nullable: false),
                    HypoxicTestInspiration = table.Column<double>(nullable: false),
                    IsDrinkingAlco = table.Column<bool>(nullable: false),
                    IsSmoking = table.Column<bool>(nullable: false),
                    Jumping = table.Column<double>(nullable: false),
                    JumpingLong = table.Column<double>(nullable: false),
                    LungsCapacity = table.Column<double>(nullable: false),
                    PersonId = table.Column<Guid>(nullable: false),
                    Platelets = table.Column<double>(nullable: false),
                    Posture = table.Column<int>(nullable: false),
                    PullUpStandart = table.Column<double>(nullable: false),
                    Pushes = table.Column<double>(nullable: false),
                    RedBloodCells = table.Column<double>(nullable: false),
                    Shooting25 = table.Column<double>(nullable: false),
                    Shooting50 = table.Column<double>(nullable: false),
                    Skinfolds6Edge = table.Column<double>(nullable: false),
                    SkinfoldsAbdominal = table.Column<double>(nullable: false),
                    SkinfoldsBiceps = table.Column<double>(nullable: false),
                    SkinfoldsCrus = table.Column<double>(nullable: false),
                    SkinfoldsSubscapular = table.Column<double>(nullable: false),
                    SkinfoldsThigh = table.Column<double>(nullable: false),
                    SkinfoldsTriceps = table.Column<double>(nullable: false),
                    Somatype = table.Column<int>(nullable: false),
                    SpineFrontwisePitch = table.Column<double>(nullable: false),
                    SpineRewardPitch = table.Column<double>(nullable: false),
                    Swiming100 = table.Column<double>(nullable: false),
                    Swiming50 = table.Column<double>(nullable: false),
                    TestDataId = table.Column<Guid>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    WhiteBloodCells = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Researches_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SportResearch",
                columns: table => new
                {
                    SportId = table.Column<Guid>(nullable: false),
                    ResearchId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportResearch", x => new { x.SportId, x.ResearchId });
                    table.ForeignKey(
                        name: "FK_SportResearch_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportResearch_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InnerRunTests = table.Column<string>(nullable: true),
                    InnerRusalovTest = table.Column<string>(nullable: true),
                    InnerTestDataTappingChernikova = table.Column<string>(nullable: true),
                    InnerTestPassedFlash = table.Column<string>(nullable: true),
                    InnerTestPassedMotion = table.Column<string>(nullable: true),
                    InnerTestPassedSound = table.Column<string>(nullable: true),
                    InnerTestPassedTapping = table.Column<string>(nullable: true),
                    ResearchId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Researches_PersonId",
                table: "Researches",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SportResearch_ResearchId",
                table: "SportResearch",
                column: "ResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ResearchId",
                table: "Tests",
                column: "ResearchId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SportResearch");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "Researches");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
