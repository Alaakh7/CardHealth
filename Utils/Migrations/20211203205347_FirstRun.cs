using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Utils.Migrations
{
    public partial class FirstRun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Analysiss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnalysisType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analysiss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChronicDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicDiseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElseMedicineId = table.Column<int>(type: "int", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicines_Medicines_ElseMedicineId",
                        column: x => x.ElseMedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sensitives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensitives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserBasicInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<int>(type: "int", nullable: false),
                    NationalNumbser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBasicInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealingPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealingPointType = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealingPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealingPoints_Accounts_Id",
                        column: x => x.Id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HealingPoints_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSecondaryInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userBasicInfoId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMaried = table.Column<bool>(type: "bit", nullable: false),
                    MariedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChiledNames = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecondaryInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecondaryInfos_UserBasicInfos_userBasicInfoId",
                        column: x => x.userBasicInfoId,
                        principalTable: "UserBasicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnalysisId = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealingPointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalysisInfos_Analysiss_AnalysisId",
                        column: x => x.AnalysisId,
                        principalTable: "Analysiss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnalysisInfos_HealingPoints_HealingPointId",
                        column: x => x.HealingPointId,
                        principalTable: "HealingPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealingPointId = table.Column<int>(type: "int", nullable: false),
                    UserBasicInfoId = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalysisResults_HealingPoints_HealingPointId",
                        column: x => x.HealingPointId,
                        principalTable: "HealingPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnalysisResults_UserBasicInfos_UserBasicInfoId",
                        column: x => x.UserBasicInfoId,
                        principalTable: "UserBasicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    HealingPointId = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneType = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_HealingPoints_HealingPointId",
                        column: x => x.HealingPointId,
                        principalTable: "HealingPoints",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_UserBasicInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserBasicInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TherapeuticStage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiseaseId = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealingPointId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TherapeuticStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TherapeuticStage_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TherapeuticStage_HealingPoints_HealingPointId",
                        column: x => x.HealingPointId,
                        principalTable: "HealingPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TherapeuticStage_UserBasicInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserBasicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserChronicDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ChronicDiseaseId = table.Column<int>(type: "int", nullable: false),
                    HealingPointId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChronicDiseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserChronicDiseases_ChronicDiseases_ChronicDiseaseId",
                        column: x => x.ChronicDiseaseId,
                        principalTable: "ChronicDiseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserChronicDiseases_HealingPoints_HealingPointId",
                        column: x => x.HealingPointId,
                        principalTable: "HealingPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserChronicDiseases_UserBasicInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserBasicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSensitives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SensitiveId = table.Column<int>(type: "int", nullable: false),
                    HealingPointId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSensitives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSensitives_HealingPoints_HealingPointId",
                        column: x => x.HealingPointId,
                        principalTable: "HealingPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSensitives_Sensitives_SensitiveId",
                        column: x => x.SensitiveId,
                        principalTable: "Sensitives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSensitives_UserBasicInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserBasicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisResultFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnalysisResultId = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisResultFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalysisResultFiles_AnalysisResults_AnalysisResultId",
                        column: x => x.AnalysisResultId,
                        principalTable: "AnalysisResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineId = table.Column<int>(type: "int", nullable: true),
                    AnalysisId = table.Column<int>(type: "int", nullable: true),
                    TherapeuticStageId = table.Column<int>(type: "int", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Analysiss_AnalysisId",
                        column: x => x.AnalysisId,
                        principalTable: "Analysiss",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prescriptions_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prescriptions_TherapeuticStage_TherapeuticStageId",
                        column: x => x.TherapeuticStageId,
                        principalTable: "TherapeuticStage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisInfos_AnalysisId",
                table: "AnalysisInfos",
                column: "AnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisInfos_HealingPointId",
                table: "AnalysisInfos",
                column: "HealingPointId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisResultFiles_AnalysisResultId",
                table: "AnalysisResultFiles",
                column: "AnalysisResultId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisResults_HealingPointId",
                table: "AnalysisResults",
                column: "HealingPointId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisResults_UserBasicInfoId",
                table: "AnalysisResults",
                column: "UserBasicInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_HealingPoints_CityId",
                table: "HealingPoints",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_ElseMedicineId",
                table: "Medicines",
                column: "ElseMedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_HealingPointId",
                table: "PhoneNumbers",
                column: "HealingPointId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_UserId",
                table: "PhoneNumbers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_AnalysisId",
                table: "Prescriptions",
                column: "AnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_MedicineId",
                table: "Prescriptions",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_TherapeuticStageId",
                table: "Prescriptions",
                column: "TherapeuticStageId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapeuticStage_DiseaseId",
                table: "TherapeuticStage",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapeuticStage_HealingPointId",
                table: "TherapeuticStage",
                column: "HealingPointId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapeuticStage_UserId",
                table: "TherapeuticStage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChronicDiseases_ChronicDiseaseId",
                table: "UserChronicDiseases",
                column: "ChronicDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChronicDiseases_HealingPointId",
                table: "UserChronicDiseases",
                column: "HealingPointId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChronicDiseases_UserId",
                table: "UserChronicDiseases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecondaryInfos_userBasicInfoId",
                table: "UserSecondaryInfos",
                column: "userBasicInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSensitives_HealingPointId",
                table: "UserSensitives",
                column: "HealingPointId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSensitives_SensitiveId",
                table: "UserSensitives",
                column: "SensitiveId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSensitives_UserId",
                table: "UserSensitives",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalysisInfos");

            migrationBuilder.DropTable(
                name: "AnalysisResultFiles");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "UserChronicDiseases");

            migrationBuilder.DropTable(
                name: "UserSecondaryInfos");

            migrationBuilder.DropTable(
                name: "UserSensitives");

            migrationBuilder.DropTable(
                name: "AnalysisResults");

            migrationBuilder.DropTable(
                name: "Analysiss");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "TherapeuticStage");

            migrationBuilder.DropTable(
                name: "ChronicDiseases");

            migrationBuilder.DropTable(
                name: "Sensitives");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "HealingPoints");

            migrationBuilder.DropTable(
                name: "UserBasicInfos");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
