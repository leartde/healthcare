using System.ComponentModel.DataAnnotations;

namespace HealthcareApi.Enums;

public enum Sex
{
  [Display(Name = "Female")]
  Female = 0,
  [Display(Name = "Male")]
  Male = 1
}
