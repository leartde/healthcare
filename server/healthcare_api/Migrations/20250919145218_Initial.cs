using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace healthcare_api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    BiologicalSex = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    RecordedByDoctorId = table.Column<int>(type: "int", nullable: true),
                    RecordedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloodPressureSystolic = table.Column<int>(type: "int", nullable: true),
                    BloodPressureDiastolic = table.Column<int>(type: "int", nullable: true),
                    Cholesterol_Total = table.Column<int>(type: "int", nullable: true),
                    Cholesterol_HDL = table.Column<int>(type: "int", nullable: true),
                    RestingHeartRate = table.Column<int>(type: "int", nullable: true),
                    FastingBloodSugar = table.Column<double>(type: "float", nullable: true),
                    BodyMassIndex = table.Column<double>(type: "float", nullable: true),
                    Smoker = table.Column<bool>(type: "bit", nullable: true),
                    Smoker_PackYears = table.Column<double>(type: "float", nullable: true),
                    Condition_CardiovascularDisease = table.Column<bool>(type: "bit", nullable: true),
                    Condition_DiabetesType1 = table.Column<bool>(type: "bit", nullable: true),
                    Condition_DiabetesType2 = table.Column<bool>(type: "bit", nullable: true),
                    Condition_Hypertension = table.Column<bool>(type: "bit", nullable: true),
                    Condition_Hyperlipidemia = table.Column<bool>(type: "bit", nullable: true),
                    Condition_FamilyHistoryHeartDisease = table.Column<bool>(type: "bit", nullable: true),
                    Symptom_ChestPainType = table.Column<int>(type: "int", nullable: true),
                    Symptom_ShortnessOfBreath = table.Column<int>(type: "int", nullable: true),
                    Symptom_ExerciseInducedAngina = table.Column<bool>(type: "bit", nullable: true),
                    ECG_Results = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MajorVesselsColored = table.Column<int>(type: "int", nullable: true),
                    DoctorNotes = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    PatientReportedDataJson = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalHistories_Doctors_RecordedByDoctorId",
                        column: x => x.RecordedByDoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalHistories_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistories_PatientId",
                table: "MedicalHistories",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistories_RecordedByDoctorId",
                table: "MedicalHistories",
                column: "RecordedByDoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalHistories");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
