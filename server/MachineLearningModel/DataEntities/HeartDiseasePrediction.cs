using Microsoft.ML.Data;

namespace MachineLearningModel.DataEntities;

public class HeartDiseasePrediction : HeartDiseaseData
{
  [ColumnName("PredictedLabel")]
  public bool Prediction { get; set; }

  public float Probability { get; set; }

  public float Score { get; set; }
}
