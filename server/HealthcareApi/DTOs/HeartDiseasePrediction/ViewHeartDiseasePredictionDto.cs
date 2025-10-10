using HealthcareApi.DTOs.MedicalHistory;
using HealthcareApi.DTOs.Patient;

namespace HealthcareApi.DTOs.HeartDiseasePrediction;

public class ViewHeartDiseasePredictionDto
{
  public int Id { get; set; }
  public ViewClinicalRecordDto? ClinicalRecord { get; set; }
  public bool Label { get; set; }
  public double Probability { get; set; }
  public DateTime Timestamp { get; set; }
}
