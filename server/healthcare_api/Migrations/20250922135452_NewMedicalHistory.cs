using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace healthcare_api.Migrations
{
    /// <inheritdoc />
    public partial class NewMedicalHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistories_Doctors_RecordedByDoctorId",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "BiologicalSex",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "BloodPressureDiastolic",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "BloodPressureSystolic",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "BodyMassIndex",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Cholesterol_HDL",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Condition_CardiovascularDisease",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Condition_DiabetesType1",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Condition_DiabetesType2",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Condition_FamilyHistoryHeartDisease",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Condition_Hyperlipidemia",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Condition_Hypertension",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "DoctorNotes",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "ECG_Results",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "PatientReportedDataJson",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "RestingHeartRate",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Smoker",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Smoker_PackYears",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Symptom_ChestPainType",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Symptom_ExerciseInducedAngina",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Symptom_ShortnessOfBreath",
                table: "MedicalHistories");

            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RecordedByDoctorId",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MajorVesselsColored",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FastingBloodSugar",
                table: "MedicalHistories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cholesterol_Total",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChestPainType",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ExerciseInducedAngina",
                table: "MedicalHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MaximumHeartRate",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "OldPeak",
                table: "MedicalHistories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "RestEcg",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RestingBloodPressure",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Slope",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Target",
                table: "MedicalHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Thalassemia",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistories_Doctors_RecordedByDoctorId",
                table: "MedicalHistories",
                column: "RecordedByDoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistories_Doctors_RecordedByDoctorId",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ChestPainType",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "ExerciseInducedAngina",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "MaximumHeartRate",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "OldPeak",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "RestEcg",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "RestingBloodPressure",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Slope",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Target",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "Thalassemia",
                table: "MedicalHistories");

            migrationBuilder.AddColumn<string>(
                name: "BiologicalSex",
                table: "Patients",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "RecordedByDoctorId",
                table: "MedicalHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MajorVesselsColored",
                table: "MedicalHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "FastingBloodSugar",
                table: "MedicalHistories",
                type: "float",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Cholesterol_Total",
                table: "MedicalHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BloodPressureDiastolic",
                table: "MedicalHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BloodPressureSystolic",
                table: "MedicalHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "BodyMassIndex",
                table: "MedicalHistories",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cholesterol_HDL",
                table: "MedicalHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Condition_CardiovascularDisease",
                table: "MedicalHistories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Condition_DiabetesType1",
                table: "MedicalHistories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Condition_DiabetesType2",
                table: "MedicalHistories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Condition_FamilyHistoryHeartDisease",
                table: "MedicalHistories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Condition_Hyperlipidemia",
                table: "MedicalHistories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Condition_Hypertension",
                table: "MedicalHistories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorNotes",
                table: "MedicalHistories",
                type: "NVARCHAR(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ECG_Results",
                table: "MedicalHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientReportedDataJson",
                table: "MedicalHistories",
                type: "NVARCHAR(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestingHeartRate",
                table: "MedicalHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Smoker",
                table: "MedicalHistories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Smoker_PackYears",
                table: "MedicalHistories",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Symptom_ChestPainType",
                table: "MedicalHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Symptom_ExerciseInducedAngina",
                table: "MedicalHistories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Symptom_ShortnessOfBreath",
                table: "MedicalHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistories_Doctors_RecordedByDoctorId",
                table: "MedicalHistories",
                column: "RecordedByDoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }
    }
}
