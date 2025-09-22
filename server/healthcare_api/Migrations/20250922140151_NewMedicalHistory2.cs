using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace healthcare_api.Migrations
{
    /// <inheritdoc />
    public partial class NewMedicalHistory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestEcg",
                table: "MedicalHistories",
                newName: "RestECG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestECG",
                table: "MedicalHistories",
                newName: "RestEcg");
        }
    }
}
