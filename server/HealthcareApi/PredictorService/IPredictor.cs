

using HealthcareApi.DTOs.ClinicalRecord;

namespace HealthcareApi.PredictorService;

public interface IPredictor
{
  public bool Predict(AddClinicalRecordDto clinicalRecordDto);
}
