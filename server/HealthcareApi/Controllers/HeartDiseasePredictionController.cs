using HealthcareApi.Data;
using HealthcareApi.Mapping;
using MachineLearningModel;
using MachineLearningModel.DataEntities;
using MachineLearningModel.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeartDiseasePrediction = HealthcareApi.Models.HeartDiseasePrediction;

namespace HealthcareApi.Controllers;

[ApiController]
[Route("api/predictions")]
public class HeartDiseasePredictionController : ControllerBase
{
  private readonly TrainingResult _trainingResult;
  private readonly ApplicationDbContext _context;

  public HeartDiseasePredictionController(ApplicationDbContext context)
  {
    _context = context;
    _trainingResult = new MachineLearningBuilder()
      .WithData("heart.csv")
      .WithAlgorithm(TrainingAlgorithm.SdcaLogisticRegression)
      .WithTestSplit(0.2)
      .Build();
  }

  [HttpGet]
  public async Task<IActionResult> GetPredictions()
  {
    var predictions = await _context.HeartDiseasePredictions
      .ToListAsync();
    return Ok(predictions);
  }

  [HttpPost("record/{recordId}")]
  public async Task<IActionResult> AddPrediction(int recordId)
  {
    var clinicalRecord = await _context.ClinicalRecords
      .Where(cr => cr.Id.Equals(recordId))
      .Include(cr => cr.Patient)
      .SingleOrDefaultAsync();
    if (clinicalRecord is null) return BadRequest($"Clinical record with id:{recordId} not found.");
    var clinicalRecordDto = clinicalRecord.ToDto();
    if (clinicalRecordDto.Patient is null)
    {
      return BadRequest("Couldn't get patient data");
    }

    var heartDiseaseData = new HeartDiseaseData
    {
      Age = clinicalRecordDto.Patient.Age,
      Sex = (float)clinicalRecord.Patient!.Sex,
      Cp = (float)clinicalRecord.ChestPainType,
      Trestbps = (float)clinicalRecord.RestingBloodPressure,
      Chol = (float)clinicalRecord.CholesterolTotal,
      Fbs = clinicalRecord.FastingBloodSugar ? 1f : 0f,
      Restecg = (float)clinicalRecord.RestEcg,
      Thalach = (float)clinicalRecord.MaximumHeartRate,
      Exang = clinicalRecord.ExerciseInducedAngina ? 1f : 0f,
      Oldpeak = (float)clinicalRecord.OldPeak,
      Ca = (float)clinicalRecord.MajorVesselsColored,
      Thal = (float)clinicalRecord.Thalassemia
    };
    var prediction = Predictor
      .UseModelWithSingleItem(_trainingResult.Context, _trainingResult.Model, heartDiseaseData);

    var heartDiseasePrediction = new HeartDiseasePrediction
    {
      PatientId = clinicalRecord.PatientId,
      Label = prediction.Prediction,
      Probability = prediction.Probability
    };

    await _context.HeartDiseasePredictions.AddAsync(heartDiseasePrediction);
    await _context.SaveChangesAsync();
    return Ok(heartDiseasePrediction.ToDto());
  }
}
