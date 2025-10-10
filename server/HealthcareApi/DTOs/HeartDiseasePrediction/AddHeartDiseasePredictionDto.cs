namespace HealthcareApi.DTOs.HeartDiseasePrediction;

public class AddHeartDiseasePredictionDto
{
  public int RecordId { get; set; }
  public bool Label { get; set; }
  public double Probability { get; set; }
}
