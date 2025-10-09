namespace HealthcareApi.Models;

public class HeartDiseasePrediction
{
  public int Id { get; set; }
  public Patient? Patient { get; set; }
  public int PatientId { get; set; }
  public bool Label { get; set; }
  public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
