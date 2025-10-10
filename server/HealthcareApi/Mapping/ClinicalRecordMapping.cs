﻿using HealthcareApi.DTOs.ClinicalRecord;
using HealthcareApi.DTOs.MedicalHistory;
using HealthcareApi.Helpers;
using HealthcareApi.Models;
using MachineLearningModel.DataEntities;

namespace HealthcareApi.Mapping;

public static class ClinicalRecordMapping
{
  public static ViewClinicalRecordDto ToDto(this ClinicalRecord entity)
  {
    return new ViewClinicalRecordDto
    {
      Id = entity.Id,
      Patient = entity.Patient?.ToDto(),
      RecordedByDoctor = entity.RecordedByDoctor?.ToDto(),
      RecordedDate = entity.RecordedDate,
      ChestPainType = entity.ChestPainType.GetDisplayName(),
      RestingBloodPressure = entity.RestingBloodPressure,
      CholesterolTotal = entity.CholesterolTotal,
      FastingBloodSugar =
        entity.FastingBloodSugar ? "Greater than or equal to 120mg/ml": "Lower than 120mg/ml",
      RestEcg = entity.RestEcg.GetDisplayName(),
      MaximumHeartRate = entity.MaximumHeartRate,
      ExerciseInducedAngina = entity.ExerciseInducedAngina,
      OldPeak = entity.OldPeak,
      Slope = entity.Slope.ToString(),
      MajorVesselsColored = entity.MajorVesselsColored,
      Thalassemia = entity.Thalassemia.GetDisplayName(),
    };
  }

  public static ClinicalRecord ToEntity(this AddClinicalRecordDto dto)
  {
    return new ClinicalRecord
    {
      PatientId = dto.PatientId,
      RecordedByDoctorId = dto.RecordedByDoctorId,
      ChestPainType = dto.ChestPainType,
      RestingBloodPressure = dto.RestingBloodPressure,
      CholesterolTotal = dto.Cholesterol_Total,
      FastingBloodSugar = dto.FastingBloodSugar >= 120,
      RestEcg = dto.RestECG,
      MaximumHeartRate = dto.MaximumHeartRate,
      ExerciseInducedAngina = dto.ExerciseInducedAngina,
      OldPeak = dto.OldPeak,
      Slope = dto.Slope,
      MajorVesselsColored = dto.MajorVesselsColored,
      Thalassemia = dto.Thalassemia,
    };
  }

  
  
}
