namespace healthcare_api.Enums;

/// <summary>
/// Resting ECG results
/// </summary>
public enum RestECG
{
  /// <summary>
  /// Normal
  /// </summary>
  Normal = 0,

  /// <summary>
  /// Having ST-T wave abnormality
  /// </summary>
  STTWaveAbnormality = 1,

  /// <summary>
  /// Showing probable or definite left ventricular hypertrophy by Estes' criteria
  /// </summary>
  LeftVentricularHypertrophy = 2
}
