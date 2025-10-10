using HealthcareApi.DTOs.HeartDiseasePrediction;
using HealthcareApi.Models;

namespace HealthcareApi.Mapping;

public static class HeartDiseasePredictionMapping
{
  public static ViewHeartDiseasePredictionDto ToDto(this HeartDiseasePrediction entity)
  {
    return new ViewHeartDiseasePredictionDto
    {
      Id = entity.Id,
      Patient = entity.Patient?.ToDto(),
      Label = entity.Label,
      Probability = entity.Probability,
      Timestamp = entity.Timestamp
    };
  }

  public static HeartDiseasePrediction ToEntity(this AddHeartDiseasePredictionDto dto)
  {
    return new HeartDiseasePrediction
    {
      PatientId = dto.PatientId,
      Label = dto.Label,
      Probability = dto.Probability
    };
  }
}
