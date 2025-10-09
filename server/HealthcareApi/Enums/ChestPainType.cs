using System.ComponentModel.DataAnnotations;

namespace HealthcareApi.Enums;

public enum ChestPainType
{
  [Display(Name = "Typical Angina")]
  TypicalAngina = 0,
  [Display(Name = "Atypical Angina")]
  AtypicalAngina = 1,
  [Display(Name = "Non-anginal Pain")]
  NonAnginalPain = 2,
  [Display(Name = "Asymptomatic")]
  Asymptomatic = 3
}
