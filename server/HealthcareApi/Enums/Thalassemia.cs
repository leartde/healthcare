using System.ComponentModel.DataAnnotations;

namespace HealthcareApi.Enums;

public enum Thalassemia
{
  [Display(Name = "Error")]
  Error = 0,
  [Display(Name = "Fixed Defect")]
  FixedDefect = 1,
  [Display(Name = "Normal")]
  Normal = 2,
  [Display(Name = "Reversible Defect")]
  ReversibleDefect  = 3
}
