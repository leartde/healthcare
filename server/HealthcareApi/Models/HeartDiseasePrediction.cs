namespace HealthcareApi.Models;

public class HeartDiseasePrediction
{
  public int Id { get; set; }
  public ClinicalRecord? ClinicalRecord { get; set; }
  public int ClinicalRecordId { get; set; }
  public bool Label { get; set; }
  public double Probability { get; set; }
  public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
