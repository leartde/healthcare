using Microsoft.ML;

namespace MachineLearningModel;

public class TrainingResult
{
  public ITransformer Model { get; set; } = null!;
  public MLContext Context { get; set; } = null!;
  public DataOperationsCatalog.TrainTestData SplitData { get; set; }
}
