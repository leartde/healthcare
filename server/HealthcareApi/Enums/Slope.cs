
using System.ComponentModel.DataAnnotations;

namespace HealthcareApi.Enums;

public enum Slope
{
  [Display(Name = "Uplsoping")]
  Uplsoping = 0,
  [Display(Name = "Flat")]
  Flat = 1,
  [Display(Name ="Downsloping")]
  Downsloping = 2,
}
